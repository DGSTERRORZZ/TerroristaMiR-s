using System;
using System.Windows.Forms;

namespace TerroristaMiR___s
{
    public partial class FrmQuiz : Form
    {
        public FrmQuiz()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            FrmQuiz1 frmQuiz1 = new FrmQuiz1();
            frmQuiz1.ShowDialog();
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
        }
    }
}

