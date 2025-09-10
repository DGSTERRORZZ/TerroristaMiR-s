using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
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

            string connStr = @"Server=.\SQLEXPRESS;Database=CJ3027678PR2;User Id=aluno;Password=aluno;";
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

                   
                
            
           

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // Exemplo para diminuir a fonte dos TextBox
            TxbNom.Font = new Font("Press Start 2P", 30, FontStyle.Regular); 
            TxbIda.Font = new Font("Press Start 2P", 30, FontStyle.Regular);
            TxbPro.Font = new Font("Press Start 2P", 30, FontStyle.Regular);
            TxbEml.Font = new Font("Press Start 2P", 30, FontStyle.Regular);
            TxbSenha.Font = new Font("Press Start 2P", 30, FontStyle.Regular);
        }
    }
}

