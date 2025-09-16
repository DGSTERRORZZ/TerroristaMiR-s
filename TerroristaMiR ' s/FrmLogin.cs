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
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private bool ValidarLogin(string prontuario, string senha)
        {
            string connStr = @"Server=SQLEXPRESS;Database=CJ3027678PR2;User Id=aluno;Password=aluno;";
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
            using (FrmCadastro cadastro = new FrmCadastro())
            {
                cadastro.ShowDialog();
            }
            this.Show();
        }
        private void BtnMos_Click(object sender, EventArgs e)
        {
            // Se a senha está oculta (com '*')
            if (TxbSenha.PasswordChar == '*')
            {
                TxbSenha.PasswordChar = '\0'; // Mostra o texto real
                BtnMos.Text = "🔓"; // Cadeado aberto
            }
            else
            {
                TxbSenha.PasswordChar = '*'; // Volta a esconder com asteriscos
                BtnMos.Text = "🔒"; // Cadeado fechado
            }
        }

        private void BtnEnt_Click_1(object sender, EventArgs e)
        {

            string prontuario = TxbPro.Text.Trim();
            string senha = TxbSenha.Text.Trim();

            if (ValidarLogin(prontuario, senha))
            {
                IsLoggedIn = true;
                FrmQuiz frmQuiz = new FrmQuiz();
                frmQuiz.ShowDialog();
            }
            else
            {
                MessageBox.Show("Prontuário ou senha inválidos.");
            }
        }

        private void TxbPro_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
 

