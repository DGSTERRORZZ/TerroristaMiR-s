using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerroristaMiR___s
{
    public partial class FrmMat : Form
    {
        public FrmMat()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                // Ignora ESC
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

            private void BtnPlay_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            //frmLogin.FormClosed += (s, args) => this.Show(); // Mostra a tela principal de novo
            this.Hide(); // Esconde tela inicial
            login.ShowDialog(); // Mostra a tela de login
            this.Show();
        }

        private void LblMat_Click(object sender, EventArgs e)
        {
            
        }


        private void BtnSair_Click(object sender, EventArgs e)
        {


            DialogResult resultado = MessageBox.Show(
                "Tem certeza que deseja sair?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }



    }
}



   