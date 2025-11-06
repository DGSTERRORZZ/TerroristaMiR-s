using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace TerroristaMiR___s
{
    public partial class FrmQuiz1 : Form
    {
        private List<Pergunta> perguntasDoDia = new List<Pergunta>();
        private int perguntaAtual = 0;
        private DateTime inicioPergunta;
        private int acertos = 0;
        string respostaSelecionada = "";
        public FrmQuiz1()
        {
            InitializeComponent();
        }

        private void FrmQuiz1_Load(object sender, EventArgs e)
        {
            
            
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
            perguntaAtual++;
            if (perguntaAtual >= perguntasDoDia.Count)
            {
                MessageBox.Show("Você terminou o quiz de hoje!");
                return;
            }

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
        }


        private void BtnProxima_Click(object sender, EventArgs e)
        {
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
            Pergunta p = perguntasDoDia[perguntaAtual];

            // calcula tempo
            TimeSpan tempo = DateTime.Now - inicioPergunta;
            int tempoSegundos = (int)tempo.TotalSeconds;

            // chama o método com os tipos corretos: (string, Pergunta, string, int)
            RegistrarResposta(UsuarioLogado.IdUsuario, p, respostaSelecionada, tempoSegundos);

            // avança
            perguntaAtual++;
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

                    // determina se acertou (true/false)
                    bool acertou = (respostaSelecionada == p.Correta);

                    string insertQuery = @"
                INSERT INTO Respostas 
                    (IdUsuario, IdPergunta, RespostaDada, Correta, TempoRespostaSegundos, DataResposta)
                VALUES 
                    (@IdUsuario, @IdPergunta, @RespostaDada, @Correta, @TempoRespostaSegundos, GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdUsuario", prontuario);               // NVARCHAR
                        cmd.Parameters.AddWithValue("@IdPergunta", p.Id);                    // INT
                        cmd.Parameters.AddWithValue("@RespostaDada", respostaSelecionada);   // NVARCHAR ("A","B",...)
                        cmd.Parameters.AddWithValue("@Correta", acertou ? 1 : 0);            // BIT -> envia 1 ou 0
                        cmd.Parameters.AddWithValue("@TempoRespostaSegundos", tempo);        // INT

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar resposta: " + ex.Message);
            }
        }



        private void RbD_CheckedChanged(object sender, EventArgs e)
        {

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
}

