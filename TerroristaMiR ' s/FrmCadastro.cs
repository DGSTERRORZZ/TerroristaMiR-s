using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerroristaMiR___s
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
            TxbCfs.PasswordChar = '*';
            TxbSenha.PasswordChar = '*';
            TxbNom.Font = new Font("Press Start 2P", 20, FontStyle.Regular);
            TxbIda.Font = new Font("Press Start 2P", 20, FontStyle.Regular);
            TxbPro.Font = new Font("Press Start 2P", 20, FontStyle.Regular);
            TxbEml.Font = new Font("Press Start 2P", 20, FontStyle.Regular);
            TxbSenha.Font = new Font("Press Start 2P", 20, FontStyle.Regular);
            TxbCfs.Font = new Font("Press Start 2P", 20, FontStyle.Regular);
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string nome = TxbNom.Text.Trim();
            string idadeTxt = TxbIda.Text.Trim();
            string email = TxbEml.Text.Trim();
            string prontuario = TxbPro.Text.Trim();
            string senha = TxbSenha.Text.Trim();

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(idadeTxt) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(prontuario) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            if (!int.TryParse(idadeTxt, out int idade))
            {
                MessageBox.Show("Idade inválida.");
                return;
            }
            if ((senha != TxbCfs.Text))
            {
                MessageBox.Show("As senhas não coincidem");
                return;
            }

            string connStr = @"Server=SQLEXPRESS;Database=CJ3027678PR2;User Id=aluno;Password=aluno;";
            string query = "INSERT INTO usuarios (prontuario, nome, idade, email, senha) VALUES (@prontuario, @nome, @idade, @email, @senha)";

            try
            {
               
                using (SqlConnection conn = new SqlConnection(connStr))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    
                    cmd.Parameters.AddWithValue("@prontuario", prontuario);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@idade", idade);
                   
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    
                    conn.Open();
                  
                    cmd.ExecuteNonQuery();
                    

                    MessageBox.Show("Usuário cadastrado com sucesso!");
                    this.Close();
                }


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
         


        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            TxbNom.Font = new Font("Press Start 2P", 20, FontStyle.Regular);
            TxbIda.Font = new Font("Press Start 2P", 20, FontStyle.Regular);
            TxbPro.Font = new Font("Press Start 2P", 20, FontStyle.Regular);
            TxbEml.Font = new Font("Press Start 2P", 20, FontStyle.Regular);
            TxbSenha.Font = new Font("Press Start 2P", 20, FontStyle.Regular);
            TxbCfs.Font = new Font("Press Start 2P", 20, FontStyle.Regular);
        }

        private void TxbSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxbEml_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxbCfs_TextChanged(object sender, EventArgs e)
        {
            if (TxbCfs.Text != TxbSenha.Text)
            {
            }
        }

        private void BtnMos1_Click(object sender, EventArgs e)
        {
            // Se a senha está oculta (com '*')
            if (TxbSenha.PasswordChar == '*')
            {
                TxbSenha.PasswordChar = '\0'; // Mostra o texto real
                BtnMos1.Text = "🔓"; // Cadeado aberto
            }
            else
            {
                TxbSenha.PasswordChar = '*'; // Volta a esconder com asteriscos
                BtnMos1.Text = "🔒"; // Cadeado fechado
            }
        }

        private void BtnMos2_Click(object sender, EventArgs e)
        {
            // Se a senha está oculta (com '*')
            if (TxbCfs.PasswordChar == '*')
            {
                TxbCfs.PasswordChar = '\0'; // Mostra o texto real
                BtnMos2.Text = "🔓"; // Cadeado aberto
            }
            else
            {
                TxbCfs.PasswordChar = '*'; // Volta a esconder com asteriscos
                BtnMos2.Text = "🔒"; // Cadeado fechado
            }
        }
    }
}
    


