using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerroristaMiR___s
{
    public partial class FrmQuiz1 : Form
    {

        private int acertos = 0;
        string respostaSelecionada = "";
        private int tempoDecorrido = 0;
        private List<Pergunta> perguntasDoDia = new List<Pergunta>();
        private int perguntaAtual = 0;
        private DateTime inicioPergunta;
        // variáveis de pontuação
        int pontuacaoAtual = 0;

        // prontuário do usuário logado (vou explicar no final como enviar do login)
        public string prontuarioLogado;

        private void AtualizarPontuacaoNaTela(int pontos)
        {
            pontuacaoAtual += pontos;
            LblPontuacao.Text = "Pontuação: " + pontuacaoAtual;
        }
        private async void AnimarPontos(string texto)
        {
            Label anim = new Label();
            anim.Text = texto;
            anim.Font = new Font("Press Start 2P", 14);
            anim.ForeColor = Color.Yellow;
            anim.BackColor = Color.Transparent;
            anim.AutoSize = true;

            anim.Location = new Point(450, 300); // ajuste se quiser
            this.Controls.Add(anim);
            anim.BringToFront();

            for (int i = 0; i < 20; i++)
            {
                anim.Top -= 2;
                await Task.Delay(15);
            }

            this.Controls.Remove(anim);
            anim.Dispose();
        }


        public FrmQuiz1()
        {
            InitializeComponent();
        }

        private void CarregarQuestoesDoDia()
        {
            string connStr = "Server=SQLEXPRESS;Database=CJ3027678PR2;User Id=aluno;Password=aluno;";
            DateTime hoje = DateTime.Today;

            perguntasDoDia.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    string query = @"
                SELECT P.ID, P.TextoPergunta, P.AlternativaA, P.AlternativaB, 
                       P.AlternativaC, P.AlternativaD, P.RespostaCorreta
                FROM QuestoesDoDia QD
                INNER JOIN Perguntas P ON QD.IdPergunta = P.ID
                WHERE QD.DataSelecionada = @hoje";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@hoje", hoje);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                Pergunta pergunta = new Pergunta
                                {
                                    Id = (int)reader["ID"],
                                    Texto = reader["TextoPergunta"].ToString(),
                                    A = reader["AlternativaA"].ToString(),
                                    B = reader["AlternativaB"].ToString(),
                                    C = reader["AlternativaC"].ToString(),
                                    D = reader["AlternativaD"].ToString(),
                                    Correta = reader["RespostaCorreta"].ToString()
                                };

                                perguntasDoDia.Add(pergunta);
                            }
                        }
                    }
                }
                Console.WriteLine(perguntasDoDia.Count);
                if (perguntasDoDia.Count == 0)
                {
                    MessageBox.Show("Nenhuma pergunta disponível para o dia de hoje!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar perguntas: " + ex.Message);
            }
        }


        private void MostrarProximaPergunta()
        {

            if (perguntaAtual >= perguntasDoDia.Count)
            {
                MessageBox.Show("Você terminou o quiz de hoje!");
                FrmRanking rank = new FrmRanking();
                rank.Show();
                this.Close();
            }
            else
            {

                Pergunta pergunta = perguntasDoDia[perguntaAtual];

                // Atualiza os textos na tela
                LblPergunta.Text = pergunta.Texto;
                RbA.Text = pergunta.A;
                RbB.Text = pergunta.B;
                RbC.Text = pergunta.C;
                RbD.Text = pergunta.D;

                // Limpa seleção anterior
                RbA.Checked = false;
                RbB.Checked = false;
                RbC.Checked = false;
                RbD.Checked = false;

                // Reseta o tempo de resposta
                inicioPergunta = DateTime.Now;
                tempoDecorrido = 0;
                LblTempo.Text = "Tempo: 00:00";
                timerPergunta.Start();
                //perguntaAtual++;
            }
        }


        private void BtnProxima_Click(object sender, EventArgs e)
        {


            timerPergunta.Stop();
            // calcula tempo
            TimeSpan tempo = DateTime.Now - inicioPergunta;
            int tempoSegundos = (int)tempo.TotalSeconds;
            // determina a alternativa selecionada como string "A"/"B"/"C"/"D"
            string respostaSelecionada = "";

            if (RbA.Checked) respostaSelecionada = "A";
            else if (RbB.Checked) respostaSelecionada = "B";
            else if (RbC.Checked) respostaSelecionada = "C";
            else if (RbD.Checked) respostaSelecionada = "D";
            else
            {
                MessageBox.Show("Selecione uma alternativa antes de continuar!");
                return;
            }

            // pega a pergunta atual
            Pergunta p = perguntasDoDia[perguntaAtual++];
            // chama o método com os tipos corretos: (string, Pergunta, string, int)
            RegistrarResposta(UsuarioLogado.IdUsuario, p, respostaSelecionada, tempoSegundos);
            // avança
            //perguntaAtual++;
            MostrarProximaPergunta();
        }

        private void RegistrarResposta(string prontuario, Pergunta p, string respostaSelecionada, int tempo)
        {
            string connStr = @"Server=SQLEXPRESS;Database=CJ3027678PR2;User Id=aluno;Password=aluno;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    // 1️⃣ Inserir resposta
                    string insertQuery = @"
                INSERT INTO Respostas (IdUsuario, IdPergunta, RespostaDada, Correta, TempoRespostaSegundos, DataResposta)
                VALUES (@IdUsuario, @IdPergunta, @RespostaDada, @Correta, @TempoRespostaSegundos, GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        if (respostaSelecionada == p.Correta)
                        {
                            MessageBox.Show("Correto!");
                            AtualizarPontuacaoNoBanco(100);
                            AtualizarPontuacaoNaTela(100);
                            AnimarPontos("+100");
                        }
                        else
                        {
                            MessageBox.Show("Errado!");
                        }

                        bool acertou = (respostaSelecionada == p.Correta);

                        cmd.Parameters.AddWithValue("@IdUsuario", prontuario);
                        cmd.Parameters.AddWithValue("@IdPergunta", p.Id);
                        cmd.Parameters.AddWithValue("@RespostaDada", respostaSelecionada);
                        cmd.Parameters.AddWithValue("@Correta", acertou ? 1 : 0);
                        cmd.Parameters.AddWithValue("@TempoRespostaSegundos", tempo);
                        cmd.ExecuteNonQuery();

                        // 2️⃣ Se acertou, soma 100 pontos
                        if (acertou)
                        {

                            MessageBox.Show("Parabéns você acertou a alternativa correta ");
                            string updatePontuacao = @"
                               UPDATE Usuarios
                               SET Pontuacao = ISNULL(Pontuacao, 0) + 100
                               WHERE prontuario = @IdUsuario";

                            using (SqlCommand cmdPontuacao = new SqlCommand(updatePontuacao, conn))
                            {
                                cmdPontuacao.Parameters.AddWithValue("@IdUsuario", prontuario);
                                cmdPontuacao.ExecuteNonQuery();

                            }

                        }
                        else
                        {
                            MessageBox.Show("A resposta correta era a alternativa " + p.Correta);
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar resposta: " + ex.Message);
            }
        }





        private void LblPergunta_Click(object sender, EventArgs e)
        {

        }

        private void FrmQuiz1_Load_1(object sender, EventArgs e)
        {

            CarregarQuestoesDoDia();
            perguntaAtual = 0; // começa na primeira
            MostrarProximaPergunta();
        }

        private void timerPergunta_Tick(object sender, EventArgs e)
        {

            {
                tempoDecorrido++;
                TimeSpan ts = TimeSpan.FromSeconds(tempoDecorrido);
                LblTempo.Text = $"Tempo: {ts:mm\\:ss}";
            }

        }


        private void RbA_CheckedChanged(object sender, EventArgs e)
        {
            if (RbA.BackColor == Color.White && RbA.Checked == true)
                RbA.BackColor = Color.Yellow;
            else
            {
                RbA.BackColor = Color.White;
            }
        }

        private void RbB_CheckedChanged(object sender, EventArgs e)
        {
            if (RbB.BackColor == Color.White && RbB.Checked == true)
                RbB.BackColor = Color.Yellow;
            else
            {
                RbB.BackColor = Color.White;
            }
        }

        private void RbC_CheckedChanged(object sender, EventArgs e)
        {
            if (RbC.BackColor == Color.White && RbC.Checked == true)
                RbC.BackColor = Color.Yellow;
            else
            {
                RbC.BackColor = Color.White;
            }
        }

        private void RbD_CheckedChanged(object sender, EventArgs e)
        {
            if (RbD.BackColor == Color.White && RbD.Checked == true)
                RbD.BackColor = Color.Yellow;
            else
            {
                RbD.BackColor = Color.White;
            }
        }
    
    private void AtualizarPontuacaoNoBanco(int pontos)
        {
            string connStr = @"Server=SQLEXPRESS;Database=CJ3027678PR2;User Id=aluno;Password=aluno;";
            string query = "UPDATE Usuarios SET pontuacao = pontuacao + @pontos WHERE prontuario = @prontuario";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@pontos", pontos);
                    cmd.Parameters.AddWithValue("@prontuario", prontuarioLogado);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar pontuação: " + ex.Message);
            }
        }
    }
}


    public class Pergunta
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public string Correta { get; set; }
    }

    public static class UsuarioLogado
    {
        public static string IdUsuario { get; set; }
    }


