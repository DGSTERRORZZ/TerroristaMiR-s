using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TerroristaMiR___s
{
    public partial class FrmRanking : Form
    {
        public FrmRanking()
        {
            InitializeComponent();
        }

        private void FrmRanking_Load(object sender, EventArgs e)
        {
            CarregarRanking();
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarRanking();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregarRanking()
        {
            string connStr = @"Server=.\SQLEXPRESS;Database=CJ3027678PR2;User Id=aluno;Password=aluno;";
            string query = @"
                SELECT 
                    prontuario AS [Prontuário],
                    nome AS [Nome],
                    pontuacao AS [Pontuação]
                FROM Usuarios
                ORDER BY pontuacao DESC";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DgvRanking.DataSource = dt;
                }

                // Ajusta colunas
                DgvRanking.Columns["Pontuação"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DgvRanking.Columns["Pontuação"].DefaultCellStyle.Font = new Font("Press Start 2P", 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar ranking: " + ex.Message);
            }
        }
    }
}
