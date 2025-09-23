using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TerroristaMiR___s
{
    public partial class FrmQuiz1 : Form
    {
        public FrmQuiz1()
        {
            InitializeComponent();
        }
        
        private List<Pergunta> perguntasDoDia = new List<Pergunta>();

     
        private int perguntaAtual = 0;

        private void CarregarQuestoesDoDia()
        {
            string connStr = "Server=.SQLEXPRESS;Database=CJ3027678PR2;User Id=aluno;Password=aluno;";
            DateTime hoje = DateTime.Today;

            perguntasDoDia.Clear();

            try
            {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar perguntas: " + ex.Message);
            }
        }

        private void VerificarOuGerarQuestoesDoDia()
        {
            string connStr = "Server=.SQLEXPRESS;Database=CJ3027678PR2;User Id=aluno;Password=aluno;";
            DateTime hoje = DateTime.Today;

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    // Verificar se já existem perguntas sorteadas hoje
                    string verificaQuery = "SELECT COUNT(*) FROM QuestoesDoDia WHERE DataSelecionada = @hoje";
                    using (SqlCommand cmdVerifica = new SqlCommand(verificaQuery, conn))
                    {
                        cmdVerifica.Parameters.AddWithValue("@hoje", hoje);
                        int count = (int)cmdVerifica.ExecuteScalar();

                        if (count == 0)
                        {
                            // Sortear 15 perguntas aleatórias
                            string sorteiaQuery = "SELECT TOP 15 ID FROM Perguntas ORDER BY NEWID()";
                            List<int> perguntasSorteadas = new List<int>();

                            using (SqlCommand cmdSorteia = new SqlCommand(sorteiaQuery, conn))
                            using (SqlDataReader reader = cmdSorteia.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    perguntasSorteadas.Add((int)reader["ID"]);
                                }
                            }

                            // Inserir no banco
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

                            MessageBox.Show("15 perguntas foram sorteadas para o dia de hoje!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar perguntas do dia: " + ex.Message);
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

        private List<Pergunta> perguntasDoDia = new List<Pergunta>();
        private int perguntaAtual = 0;
    }
}
