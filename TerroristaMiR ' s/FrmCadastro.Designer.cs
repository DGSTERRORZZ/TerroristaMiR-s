using System.Windows.Forms;

namespace TerroristaMiR___s
{
    partial class FrmCadastro
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
            this.BtnSair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxbPro = new System.Windows.Forms.TextBox();
            this.BtnSlv = new System.Windows.Forms.Button();
            this.TxbNom = new System.Windows.Forms.TextBox();
            this.TxbIda = new System.Windows.Forms.TextBox();
            this.TxbEml = new System.Windows.Forms.TextBox();
            this.TxbSenha = new System.Windows.Forms.TextBox();
       
            // 
            // BtnSair
            // 
            this.BtnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSair.BackColor = System.Drawing.Color.Transparent;
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(1604, 933);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(246, 116);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // TxbPro
            // 
            this.TxbPro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbPro.Font = new System.Drawing.Font("Press Start 2P", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbPro.Location = new System.Drawing.Point(478, 303);
            this.TxbPro.Multiline = true;
            this.TxbPro.Name = "TxbPro";
            this.TxbPro.Size = new System.Drawing.Size(487, 94);
            this.TxbPro.TabIndex = 7;
            // 
            // BtnSlv
            // 
            this.BtnSlv.BackColor = System.Drawing.Color.Transparent;
            this.BtnSlv.FlatAppearance.BorderSize = 0;
            this.BtnSlv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnSlv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnSlv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSlv.ForeColor = System.Drawing.Color.Transparent;
            this.BtnSlv.Location = new System.Drawing.Point(729, 551);
            this.BtnSlv.Name = "BtnSlv";
            this.BtnSlv.Size = new System.Drawing.Size(551, 120);
            this.BtnSlv.TabIndex = 17;
            this.BtnSlv.UseVisualStyleBackColor = false;
            // 
            // TxbNom
            // 
            this.TxbNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbNom.Font = new System.Drawing.Font("Press Start 2P", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbNom.Location = new System.Drawing.Point(478, 104);
            this.TxbNom.Multiline = true;
            this.TxbNom.Name = "TxbNom";
            this.TxbNom.Size = new System.Drawing.Size(487, 94);
            this.TxbNom.TabIndex = 18;
            // 
            // TxbIda
            // 
            this.TxbIda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbIda.Font = new System.Drawing.Font("Press Start 2P", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbIda.Location = new System.Drawing.Point(1140, 104);
            this.TxbIda.Multiline = true;
            this.TxbIda.Name = "TxbIda";
            this.TxbIda.Size = new System.Drawing.Size(487, 94);
            this.TxbIda.TabIndex = 19;
            // 
            // TxbEml
            // 
            this.TxbEml.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbEml.Font = new System.Drawing.Font("Press Start 2P", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbEml.Location = new System.Drawing.Point(1140, 303);
            this.TxbEml.Multiline = true;
            this.TxbEml.Name = "TxbEml";
            this.TxbEml.Size = new System.Drawing.Size(487, 94);
            this.TxbEml.TabIndex = 20;
            // 
            // TxbSenha
            // 
            this.TxbSenha.Font = new System.Drawing.Font("Press Start 2P", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbSenha.Location = new System.Drawing.Point(761, 464);
            this.TxbSenha.Name = "TxbSenha";
            this.TxbSenha.Size = new System.Drawing.Size(583, 103);
            this.TxbSenha.TabIndex = 21;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::TerroristaMiR___s.Properties.Resources.Captura_de_tela_2025_09_09_113708;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.TxbSenha);
            this.Controls.Add(this.TxbEml);
            this.Controls.Add(this.TxbIda);
            this.Controls.Add(this.TxbNom);
            this.Controls.Add(this.BtnSlv);
            this.Controls.Add(this.TxbPro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSair);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxbPro;
        private System.Windows.Forms.Button BtnSlv;
        private System.Windows.Forms.TextBox TxbNom;
        private System.Windows.Forms.TextBox TxbIda;
        private System.Windows.Forms.TextBox TxbEml;
        private System.Windows.Forms.TextBox TxbSenha;
    }
}