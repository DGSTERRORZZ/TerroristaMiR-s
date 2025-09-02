namespace TerroristaMiR___s
{
    partial class FrmLogin
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
            this.LblNom = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.LblIda = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblPro = new System.Windows.Forms.Label();
            this.TxbNom = new System.Windows.Forms.TextBox();
            this.TxbIda = new System.Windows.Forms.TextBox();
            this.TxbPro = new System.Windows.Forms.TextBox();
            this.TxbEml = new System.Windows.Forms.TextBox();
            this.LblDados = new System.Windows.Forms.Label();
            this.LblEml = new System.Windows.Forms.Label();
            this.BtnSlv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNom.Location = new System.Drawing.Point(32, 93);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(55, 20);
            this.LblNom.TabIndex = 2;
            this.LblNom.Text = "Nome";
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.Snow;
            this.BtnSair.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(866, 504);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(102, 34);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // LblIda
            // 
            this.LblIda.AutoSize = true;
            this.LblIda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIda.Location = new System.Drawing.Point(295, 91);
            this.LblIda.Name = "LblIda";
            this.LblIda.Size = new System.Drawing.Size(55, 20);
            this.LblIda.TabIndex = 4;
            this.LblIda.Text = "Idade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // LblPro
            // 
            this.LblPro.AutoSize = true;
            this.LblPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPro.Location = new System.Drawing.Point(32, 131);
            this.LblPro.Name = "LblPro";
            this.LblPro.Size = new System.Drawing.Size(92, 20);
            this.LblPro.TabIndex = 6;
            this.LblPro.Text = "Prontuario";
            this.LblPro.Click += new System.EventHandler(this.label3_Click);
            // 
            // TxbNom
            // 
            this.TxbNom.Location = new System.Drawing.Point(107, 91);
            this.TxbNom.Name = "TxbNom";
            this.TxbNom.Size = new System.Drawing.Size(182, 20);
            this.TxbNom.TabIndex = 7;
            // 
            // TxbIda
            // 
            this.TxbIda.Location = new System.Drawing.Point(356, 93);
            this.TxbIda.Name = "TxbIda";
            this.TxbIda.Size = new System.Drawing.Size(31, 20);
            this.TxbIda.TabIndex = 8;
            // 
            // TxbPro
            // 
            this.TxbPro.Location = new System.Drawing.Point(130, 131);
            this.TxbPro.Name = "TxbPro";
            this.TxbPro.Size = new System.Drawing.Size(179, 20);
            this.TxbPro.TabIndex = 9;
            // 
            // TxbEml
            // 
            this.TxbEml.Location = new System.Drawing.Point(404, 131);
            this.TxbEml.Name = "TxbEml";
            this.TxbEml.Size = new System.Drawing.Size(176, 20);
            this.TxbEml.TabIndex = 10;
            // 
            // LblDados
            // 
            this.LblDados.AutoSize = true;
            this.LblDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDados.Location = new System.Drawing.Point(31, 22);
            this.LblDados.Name = "LblDados";
            this.LblDados.Size = new System.Drawing.Size(182, 25);
            this.LblDados.TabIndex = 11;
            this.LblDados.Text = "Dados Pessoais";
            // 
            // LblEml
            // 
            this.LblEml.AutoSize = true;
            this.LblEml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEml.Location = new System.Drawing.Point(334, 131);
            this.LblEml.Name = "LblEml";
            this.LblEml.Size = new System.Drawing.Size(53, 20);
            this.LblEml.TabIndex = 12;
            this.LblEml.Text = "Email";
            // 
            // BtnSlv
            // 
            this.BtnSlv.Location = new System.Drawing.Point(56, 460);
            this.BtnSlv.Name = "BtnSlv";
            this.BtnSlv.Size = new System.Drawing.Size(210, 55);
            this.BtnSlv.TabIndex = 17;
            this.BtnSlv.Text = "Salvar";
            this.BtnSlv.UseVisualStyleBackColor = true;
            this.BtnSlv.Click += new System.EventHandler(this.BtnSlv_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.BtnSlv);
            this.Controls.Add(this.LblEml);
            this.Controls.Add(this.LblDados);
            this.Controls.Add(this.TxbEml);
            this.Controls.Add(this.TxbPro);
            this.Controls.Add(this.TxbIda);
            this.Controls.Add(this.TxbNom);
            this.Controls.Add(this.LblPro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblIda);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.LblNom);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label LblIda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblPro;
        private System.Windows.Forms.TextBox TxbNom;
        private System.Windows.Forms.TextBox TxbIda;
        private System.Windows.Forms.TextBox TxbPro;
        private System.Windows.Forms.TextBox TxbEml;
        private System.Windows.Forms.Label LblDados;
        private System.Windows.Forms.Label LblEml;
        private System.Windows.Forms.Button BtnSlv;
    }
}