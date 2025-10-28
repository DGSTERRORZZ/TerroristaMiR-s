using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TerroristaMiR___s
{
    public partial class FrmQuiz1 : Form
    {
        private List<Pergunta> perguntasDoDia = new List<Pergunta>();
        private int perguntaAtual = 0;
        private int acertos = 0;

        public FrmQuiz1()
        {
            InitializeComponent();
        }

        private void FrmQuiz1_Load(object sender, EventArgs e)
        {
            SortearQuestoesDoDia(15); // Sorteia 15 perguntas aleatórias
            CarregarQuestoesDoDia();   // Carrega perguntas do banco para a lista
            MostrarPerguntaAtual();    // Exibe a primeira pergunta
        }

        // ✅ Sorteio automático das perguntas do dia
        private void SortearQuestoesDoDia(int quantidade)
        {
            string connStr = @"Server=.SQLEXPRESS;Database=CJ3027678PR2;User Id=aluno;Password=aluno;";
            DateTime hoje = DateTime.Today;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                // Verificar se já existem perguntas do dia
                string verificaQuery = "SELECT COUNT(*) FROM QuestoesDoDia WHERE DataSelecionada = @hoje";
                using (SqlCommand cmdVerifica = new SqlCommand(verificaQuery, conn))
                {
                    cmdVerifica.Parameters.AddWithValue("@hoje", hoje);
                    int count = (int)cmdVerifica.ExecuteScalar();

                    if (count > 0)
                        return; // Já existe, não precisa sortear
                }

                // Sortear IDs aleatórios da tabela Perguntas
                List<int> perguntasSorteadas = new List<int>();
                string sorteiaQuery = $"SELECT TOP {quantidade} ID FROM Perguntas ORDER BY NEWID()";

                using (SqlCommand cmdSorteia = new SqlCommand(sorteiaQuery, conn))
                using (SqlDataReader reader = cmdSorteia.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        perguntasSorteadas.Add((int)reader["ID"]);
                    }
                }

                // Inserir no banco na tabela QuestoesDoDia
                foreach (int idPergunta in perguntasSorteadas)
                {
                    string insertQuery = "INSERT INTO QuestoesDoDia (IdPergunta, DataSelecionada) VALUES (@id, @data)";
                    using (SqlCommand cmdInsert = new SqlCommand(insertQuery, conn))
                    {
                        cmdInsert.Parameters.AddWithValue("@id", idPergunta);
                        cmdInsert.Parameters.AddWithValue("@data", hoje);
                        cmdInsert.ExecuteNonQuery();
                    }
                }
            }
        }

        // ✅ Carrega as perguntas do dia para a lista
        private void CarregarQuestoesDoDia()
        {
            perguntasDoDia.Clear();
            string connStr = @"Server=.SQLEXPRESS;Database=CJ3027678PR2;User Id=aluno;Password=aluno;";
            DateTime hoje = DateTime.Today;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = @"
                    SELECT P.ID, TextoPergunta, AlternativaA, AlternativaB, AlternativaC, AlternativaD, RespostaCorreta
                    FROM QuestoesDoDia QD
                    JOIN Perguntas P ON QD.IdPergunta = P.ID
                    WHERE QD.DataSelecionada = @hoje";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@hoje", hoje);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pergunta p = new Pergunta
                            {
                                Id = (int)reader["ID"],
                                Texto = reader["TextoPergunta"].ToString(),
                                A = reader["AlternativaA"].ToString(),
                                B = reader["AlternativaB"].ToString(),
                                C = reader["AlternativaC"].ToString(),
                                D = reader["AlternativaD"].ToString(),
                                Correta = reader["RespostaCorreta"].ToString()
                            };
                            perguntasDoDia.Add(p);
                        }
                    }
                }
            }
        }

        // ✅ Mostra pergunta atual
        private void MostrarPerguntaAtual()
        {
            if (perguntaAtual >= perguntasDoDia.Count)
            {
                MessageBox.Show($"Fim das perguntas! Acertos: {acertos}/{perguntasDoDia.Count}");
                this.Close();
                return;
            }

            Pergunta p = perguntasDoDia[perguntaAtual];
            LblPergunta.Text = p.Texto;
            RbA.Text = p.A;
            RbB.Text = p.B;
            RbC.Text = p.C;
            RbD.Text = p.D;

            RbA.Checked = false;
            RbB.Checked = false;
            RbC.Checked = false;
            RbD.Checked = false;
        }

        // ✅ Botão Próxima pergunta
        private void BtnProxima_Click(object sender, EventArgs e)
        {
            Pergunta p = perguntasDoDia[perguntaAtual];
            string selecionada = "";

            if (RbA.Checked) selecionada = "A";
            else if (RbB.Checked) selecionada = "B";
            else if (RbC.Checked) selecionada = "C";
            else if (RbD.Checked) selecionada = "D";

            if (!string.IsNullOrEmpty(selecionada))
            {
                if (selecionada == p.Correta) acertos++;
                perguntaAtual++;
                MostrarPerguntaAtual();
            }
            else
            {
                MessageBox.Show("Selecione uma alternativa antes de continuar.");
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
}
