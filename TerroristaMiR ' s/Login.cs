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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void BtnSlv_Click(object sender, EventArgs e)
        {

            string connectionString = @"Server=SQLEXPRESS;Database=CJ3027678PR2;User Id=aluno;Password=aluno;";


            string nome = TxbNom.Text.Trim();
            string idadeText = TxbIda.Text.Trim();
            string prontuario = TxbPro.Text.Trim();
            string email = TxbEml.Text.Trim();


            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(idadeText) ||
                string.IsNullOrEmpty(prontuario) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            int idade;
            if (!int.TryParse(idadeText, out idade))
            {
                MessageBox.Show("Digite uma idade válida (número inteiro).");
                return;
            }

            string query = "INSERT INTO usuarios (prontuario, nome, idade, email) VALUES (@prontuario, @nome, @idade, @email)";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@prontuario", prontuario);
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@idade", idade);
                        cmd.Parameters.AddWithValue("@email", email);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                MessageBox.Show("Usuário cadastrado com sucesso!");
                TxbNom.Clear();
                TxbIda.Clear();
                TxbPro.Clear();
                TxbEml.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}