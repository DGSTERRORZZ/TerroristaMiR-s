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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void CarregarPerguntas()
        {
            string connectionString = @"Server=SQLEXPRESS;Database=CJ3027678PR2;User Id=aluno;Password=aluno;";
            string query = "SELECT ID, TextoPergunta, AlternativaA, AlternativaB, AlternativaC, AlternativaD, RespostaCorreta, Nivel FROM Perguntas";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DgvPerguntas.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar perguntas: " + ex.Message);
            }
        }

        private void CmbNivel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            CmbCorreta.Items.Clear();
            CmbNivel.Items.Clear();

            CmbCorreta.Items.AddRange(new string[] { "A", "B", "C", "D" });
            CmbNivel.Items.AddRange(new string[] { "1 - Fácil", "2 - Médio", "3 - Difícil" });
            CarregarPerguntas();
        }

 

        private void BtnSlvAdmin_Click(object sender, EventArgs e)
        {
            // Validação dos campos
            if (string.IsNullOrWhiteSpace(TxbPergunta.Text) ||
                string.IsNullOrWhiteSpace(TxbA.Text) ||
                string.IsNullOrWhiteSpace(TxbB.Text) ||
                string.IsNullOrWhiteSpace(TxbC.Text) ||
                string.IsNullOrWhiteSpace(TxbD.Text) ||
                CmbCorreta.SelectedIndex == -1 ||
                CmbNivel.SelectedIndex == -1)
            {
                MessageBox.Show("⚠️ Preencha todos os campos antes de salvar!");
                return;
            }

            string connStr = @"Server=SQLEXPRESS;Database=CJ3027678PR2;User Id=aluno;Password=aluno;";
            string query = @"INSERT INTO Perguntas 
                             (TextoPergunta, AlternativaA, AlternativaB, AlternativaC, AlternativaD, RespostaCorreta, NivelDificuldade)
                             VALUES (@texto, @a, @b, @c, @d, @correta, @nivel)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@texto", TxbPergunta.Text.Trim());
                    cmd.Parameters.AddWithValue("@a", TxbA.Text.Trim());
                    cmd.Parameters.AddWithValue("@b", TxbB.Text.Trim());
                    cmd.Parameters.AddWithValue("@c", TxbC.Text.Trim());
                    cmd.Parameters.AddWithValue("@d", TxbD.Text.Trim());
                    cmd.Parameters.AddWithValue("@correta", CmbCorreta.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@nivel", CmbNivel.SelectedIndex + 1);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("✅ Pergunta cadastrada com sucesso!");

                // Limpa os campos após salvar
                TxbPergunta.Clear();
                TxbA.Clear();
                TxbB.Clear();
                TxbC.Clear();
                TxbD.Clear();
                CmbCorreta.SelectedIndex = -1;
                CmbNivel.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar pergunta: " + ex.Message);

                BtnSlvAdmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 255, 100);
                BtnSlvAdmin.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 200, 50);

            }
            CarregarPerguntas();

        }

        private void TxbB_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxbD_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgvPerguntas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

  