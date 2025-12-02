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
            this.components = new System.ComponentModel.Container();
            this.RbA = new System.Windows.Forms.RadioButton();
            this.RbB = new System.Windows.Forms.RadioButton();
            this.RbC = new System.Windows.Forms.RadioButton();
            this.RbD = new System.Windows.Forms.RadioButton();
            this.LblTempo = new System.Windows.Forms.Label();
            this.LblPergunta = new System.Windows.Forms.Label();
            this.BtnProxima = new System.Windows.Forms.Button();
            this.timerPergunta = new System.Windows.Forms.Timer(this.components);
            this.LblPontuacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RbA
            // 
            this.RbA.Appearance = System.Windows.Forms.Appearance.Button;
            this.RbA.AutoSize = true;
            this.RbA.BackColor = System.Drawing.Color.White;
            this.RbA.FlatAppearance.BorderSize = 0;
            this.RbA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RbA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbA.Location = new System.Drawing.Point(626, 478);
            this.RbA.Name = "RbA";
            this.RbA.Size = new System.Drawing.Size(124, 34);
            this.RbA.TabIndex = 1;
            this.RbA.Text = "Alternativa A";
            this.RbA.UseVisualStyleBackColor = false;
            this.RbA.CheckedChanged += new System.EventHandler(this.RbA_CheckedChanged);
            // 
            // RbB
            // 
            this.RbB.Appearance = System.Windows.Forms.Appearance.Button;
            this.RbB.AutoSize = true;
            this.RbB.BackColor = System.Drawing.Color.White;
            this.RbB.FlatAppearance.BorderSize = 0;
            this.RbB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RbB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbB.Location = new System.Drawing.Point(1163, 478);
            this.RbB.Name = "RbB";
            this.RbB.Size = new System.Drawing.Size(123, 34);
            this.RbB.TabIndex = 3;
            this.RbB.Text = "Alternativa B";
            this.RbB.UseVisualStyleBackColor = false;
            this.RbB.CheckedChanged += new System.EventHandler(this.RbB_CheckedChanged);
            // 
            // RbC
            // 
            this.RbC.Appearance = System.Windows.Forms.Appearance.Button;
            this.RbC.AutoSize = true;
            this.RbC.BackColor = System.Drawing.Color.White;
            this.RbC.FlatAppearance.BorderSize = 0;
            this.RbC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RbC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbC.Location = new System.Drawing.Point(626, 578);
            this.RbC.Name = "RbC";
            this.RbC.Size = new System.Drawing.Size(124, 34);
            this.RbC.TabIndex = 2;
            this.RbC.Text = "Alternativa C";
            this.RbC.UseVisualStyleBackColor = false;
            this.RbC.CheckedChanged += new System.EventHandler(this.RbC_CheckedChanged);
            // 
            // RbD
            // 
            this.RbD.Appearance = System.Windows.Forms.Appearance.Button;
            this.RbD.AutoSize = true;
            this.RbD.BackColor = System.Drawing.Color.White;
            this.RbD.Checked = true;
            this.RbD.FlatAppearance.BorderSize = 0;
            this.RbD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RbD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RbD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbD.Location = new System.Drawing.Point(1163, 578);
            this.RbD.Name = "RbD";
            this.RbD.Size = new System.Drawing.Size(124, 34);
            this.RbD.TabIndex = 4;
            this.RbD.TabStop = true;
            this.RbD.Text = "Alternativa D";
            this.RbD.UseVisualStyleBackColor = false;
            this.RbD.CheckedChanged += new System.EventHandler(this.RbD_CheckedChanged);
            // 
            // LblTempo
            // 
            this.LblTempo.AutoSize = true;
            this.LblTempo.BackColor = System.Drawing.Color.Transparent;
            this.LblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTempo.ForeColor = System.Drawing.Color.White;
            this.LblTempo.Location = new System.Drawing.Point(1403, 213);
            this.LblTempo.Name = "LblTempo";
            this.LblTempo.Size = new System.Drawing.Size(110, 24);
            this.LblTempo.TabIndex = 5;
            this.LblTempo.Text = "TIME: 00:00";
            // 
            // LblPergunta
            // 
            this.LblPergunta.AutoSize = true;
            this.LblPergunta.BackColor = System.Drawing.Color.Transparent;
            this.LblPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPergunta.ForeColor = System.Drawing.Color.White;
            this.LblPergunta.Location = new System.Drawing.Point(907, 316);
            this.LblPergunta.Name = "LblPergunta";
            this.LblPergunta.Size = new System.Drawing.Size(122, 24);
            this.LblPergunta.TabIndex = 0;
            this.LblPergunta.Text = "PERGUNTA";
            this.LblPergunta.Click += new System.EventHandler(this.LblPergunta_Click);
            // 
            // BtnProxima
            // 
            this.BtnProxima.BackColor = System.Drawing.Color.Black;
            this.BtnProxima.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnProxima.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProxima.FlatAppearance.BorderSize = 0;
            this.BtnProxima.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnProxima.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnProxima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProxima.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProxima.ForeColor = System.Drawing.Color.Transparent;
            this.BtnProxima.Location = new System.Drawing.Point(1634, 843);
            this.BtnProxima.Name = "BtnProxima";
            this.BtnProxima.Size = new System.Drawing.Size(141, 40);
            this.BtnProxima.TabIndex = 6;
            this.BtnProxima.Text = "NEXT";
            this.BtnProxima.UseVisualStyleBackColor = false;
            this.BtnProxima.Click += new System.EventHandler(this.BtnProxima_Click);
            // 
            // timerPergunta
            // 
            this.timerPergunta.Interval = 1000;
            this.timerPergunta.Tick += new System.EventHandler(this.timerPergunta_Tick);
            // 
            // LblPontuacao
            // 
            this.LblPontuacao.AutoSize = true;
            this.LblPontuacao.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblPontuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPontuacao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblPontuacao.Location = new System.Drawing.Point(1403, 278);
            this.LblPontuacao.Name = "LblPontuacao";
            this.LblPontuacao.Size = new System.Drawing.Size(120, 24);
            this.LblPontuacao.TabIndex = 8;
            this.LblPontuacao.Text = "Pontuação: 0";
            // 
            // FrmQuiz1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TerroristaMiR___s.Properties.Resources.Captura_de_tela_2025_09_23_101028;
            this.ClientSize = new System.Drawing.Size(1858, 932);
            this.Controls.Add(this.LblPontuacao);
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

       
        

        

        #endregion

        private System.Windows.Forms.RadioButton RbA;
        private System.Windows.Forms.RadioButton RbB;
        private System.Windows.Forms.RadioButton RbC;
        private System.Windows.Forms.RadioButton RbD;
        private System.Windows.Forms.Label LblTempo;
        private System.Windows.Forms.Label LblPergunta;
        private System.Windows.Forms.Button BtnProxima;
        private Timer timerPergunta;
        private Label LblPontuacao;
    }
}