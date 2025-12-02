
using System.Collections.Generic;
using System.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace TerroristaMiR___s
{
    public partial class FrmQuiz : Form
    {
        private bool perguntasGeradas = false;
        private bool Aceite = false;
        public FrmQuiz()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }


        public bool BuscaAceite() {  return Aceite; }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            GerarQuestoesDoDia();
            Aceite = true;
            this.Close();
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmQuiz_Load(object sender, EventArgs e)
        {

        }
        private void GerarQuestoesDoDia()
        {
            string connStr = "Server=SQLEXPRESS;Database=CJ3027678PR2;User Id=aluno;Password=aluno;";
            DateTime hoje = DateTime.Today;

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    // 1️⃣ Remove registros antigos de hoje (caso já existam)
                    string deleteQuery = "DELETE FROM QuestoesDoDia WHERE DataSelecionada = @hoje";
                    using (SqlCommand delCmd = new SqlCommand(deleteQuery, conn))
                    {
                        delCmd.Parameters.AddWithValue("@hoje", hoje);
                        delCmd.ExecuteNonQuery();
                    }

                    // 2️⃣ Busca 10 perguntas aleatórias da tabela Perguntas
                    // NEWID() garante ordem completamente aleatória a cada execução
                    string selectQuery = "SELECT TOP 10 ID FROM Perguntas ORDER BY NEWID()";
                    List<int> perguntasSelecionadas = new List<int>();

                    using (SqlCommand selCmd = new SqlCommand(selectQuery, conn))
                    using (SqlDataReader reader = selCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            perguntasSelecionadas.Add((int)reader["ID"]);
                        }
                    }

                    // 3️⃣ Insere as 10 perguntas sorteadas em QuestoesDoDia com a data de hoje
                    string insertQuery = "INSERT INTO QuestoesDoDia (IdPergunta, DataSelecionada) VALUES (@idPergunta, @hoje)";
                    foreach (int idPergunta in perguntasSelecionadas)
                    {
                        using (SqlCommand insCmd = new SqlCommand(insertQuery, conn))
                        {
                            insCmd.Parameters.AddWithValue("@idPergunta", idPergunta);
                            insCmd.Parameters.AddWithValue("@hoje", hoje);
                            insCmd.ExecuteNonQuery();
                        }
                    }
                    perguntasGeradas = true;
                    MessageBox.Show("✅ 10 perguntas foram sorteadas e registradas para o dia de hoje!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Erro ao gerar questões do dia: " + ex.Message);
            }
        }

    }
}

