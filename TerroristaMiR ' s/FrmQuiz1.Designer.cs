using System;
using System.Windows.Forms;

namespace TerroristaMiR___s
{
    partial class FrmQuiz1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RbA = new System.Windows.Forms.RadioButton();
            this.RbB = new System.Windows.Forms.RadioButton();
            this.RbC = new System.Windows.Forms.RadioButton();
            this.RbD = new System.Windows.Forms.RadioButton();
            this.LblTempo = new System.Windows.Forms.Label();
            this.LblPergunta = new System.Windows.Forms.Label();
            this.BtnProxima = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RbA
            // 
            this.RbA.AutoSize = true;
            this.RbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbA.Location = new System.Drawing.Point(569, 478);
            this.RbA.Name = "RbA";
            this.RbA.Size = new System.Drawing.Size(132, 28);
            this.RbA.TabIndex = 0;
            this.RbA.TabStop = true;
            this.RbA.Text = "Alternativa A";
            this.RbA.UseVisualStyleBackColor = true;
            // 
            // RbB
            // 
            this.RbB.AutoSize = true;
            this.RbB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbB.Location = new System.Drawing.Point(1090, 478);
            this.RbB.Name = "RbB";
            this.RbB.Size = new System.Drawing.Size(131, 28);
            this.RbB.TabIndex = 1;
            this.RbB.TabStop = true;
            this.RbB.Text = "Alternativa B";
            this.RbB.UseVisualStyleBackColor = false;
            // 
            // RbC
            // 
            this.RbC.AutoSize = true;
            this.RbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbC.Location = new System.Drawing.Point(569, 591);
            this.RbC.Name = "RbC";
            this.RbC.Size = new System.Drawing.Size(132, 28);
            this.RbC.TabIndex = 2;
            this.RbC.TabStop = true;
            this.RbC.Text = "Alternativa C";
            this.RbC.UseVisualStyleBackColor = true;
            // 
            // RbD
            // 
            this.RbD.AutoSize = true;
            this.RbD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbD.Location = new System.Drawing.Point(1090, 578);
            this.RbD.Name = "RbD";
            this.RbD.Size = new System.Drawing.Size(132, 28);
            this.RbD.TabIndex = 3;
            this.RbD.TabStop = true;
            this.RbD.Text = "Alternativa D";
            this.RbD.UseVisualStyleBackColor = true;
            this.RbD.CheckedChanged += new System.EventHandler(this.RbD_CheckedChanged);
            // 
            // LblTempo
            // 
            this.LblTempo.AutoSize = true;
            this.LblTempo.Location = new System.Drawing.Point(655, 235);
            this.LblTempo.Name = "LblTempo";
            this.LblTempo.Size = new System.Drawing.Size(45, 13);
            this.LblTempo.TabIndex = 4;
            this.LblTempo.Text = "TEMPO";
            // 
            // LblPergunta
            // 
            this.LblPergunta.AutoSize = true;
            this.LblPergunta.Location = new System.Drawing.Point(872, 310);
            this.LblPergunta.Name = "LblPergunta";
            this.LblPergunta.Size = new System.Drawing.Size(67, 13);
            this.LblPergunta.TabIndex = 5;
            this.LblPergunta.Text = "PERGUNTA";
            this.LblPergunta.Click += new System.EventHandler(this.LblPergunta_Click);
            // 
            // BtnProxima
            // 
            this.BtnProxima.Location = new System.Drawing.Point(1609, 859);
            this.BtnProxima.Name = "BtnProxima";
            this.BtnProxima.Size = new System.Drawing.Size(75, 23);
            this.BtnProxima.TabIndex = 6;
            this.BtnProxima.UseVisualStyleBackColor = true;
            this.BtnProxima.Click += new System.EventHandler(this.BtnProxima_Click);
            // 
            // FrmQuiz1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TerroristaMiR___s.Properties.Resources.Captura_de_tela_2025_09_23_101028;
            this.ClientSize = new System.Drawing.Size(1858, 932);
            this.Controls.Add(this.BtnProxima);
            this.Controls.Add(this.LblPergunta);
            this.Controls.Add(this.LblTempo);
            this.Controls.Add(this.RbD);
            this.Controls.Add(this.RbC);
            this.Controls.Add(this.RbB);
            this.Controls.Add(this.RbA);
            this.Name = "FrmQuiz1";
            this.Text = "FrmQuiz1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmQuiz1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
            private void BtnProxima_Click_(object sender, EventArgs e)
        {
            string respostaSelecionada = "";

            if (RbA.Checked) respostaSelecionada = "A";
            else if (RbB.Checked) respostaSelecionada = "B";
            else if (RbC.Checked) respostaSelecionada = "C";
            else if (RbD.Checked) respostaSelecionada = "D";
            else
            {
                MessageBox.Show("Selecione uma alternativa antes de continuar!");
                return;
            }

            Pergunta p = perguntasDoDia[perguntaAtual];
            bool acertou = respostaSelecionada == p.Correta;
            TimeSpan tempo = DateTime.Now - inicioPergunta;

            RegistrarResposta(UsuarioLogado.IdUsuario, p, acertou, (int)tempo.TotalSeconds);

            if (acertou) acertos++;

            perguntaAtual++;
            MostrarProximaPergunta();
        }

        

        #endregion

        private System.Windows.Forms.RadioButton RbA;
        private System.Windows.Forms.RadioButton RbB;
        private System.Windows.Forms.RadioButton RbC;
        private System.Windows.Forms.RadioButton RbD;
        private System.Windows.Forms.Label LblTempo;
        private System.Windows.Forms.Label LblPergunta;
        private System.Windows.Forms.Button BtnProxima;
    }
}