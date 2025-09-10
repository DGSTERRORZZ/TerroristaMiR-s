using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TerroristaMiR___s
{
    public partial class FrmLogin : Form
    {
        public bool IsLoggedIn { get; private set; } = false;

        public FrmLogin()
        {
            InitializeComponent();
            TxbSenha.PasswordChar = '*';
            TxbPro.Font = new Font("Press Start 2P", 30, FontStyle.Regular);
            TxbSenha.Font = new Font("Press Start 2P", 30, FontStyle.Regular);
        }

        private void BtnEnt_Click(object sender, EventArgs e)
        {
            string prontuario = TxbPro.Text.Trim();
            string senha = TxbSenha.Text.Trim();

            if (ValidarLogin(prontuario, senha))
            {
                IsLoggedIn = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Prontuário ou senha inválidos.");
            }
        }

        private bool ValidarLogin(string prontuario, string senha)
        {
            string connStr = @"Server=.\SQLEXPRESS;Database=CJ3027678PR2;User Id=aluno;Password=aluno;";
            string query = "SELECT COUNT(*) FROM usuarios WHERE prontuario = @prontuario AND senha = @senha";

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@prontuario", prontuario);
                cmd.Parameters.AddWithValue("@senha", senha);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }

        private void BtnCad_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FrmLogin cadastro = new FrmLogin())
            {
                cadastro.ShowDialog();
            }
            this.Show();
        }

    }
}


