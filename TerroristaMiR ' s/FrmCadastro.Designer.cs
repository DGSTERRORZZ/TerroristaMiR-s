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
            this.TxbNom = new System.Windows.Forms.TextBox();
            this.TxbIda = new System.Windows.Forms.TextBox();
            this.TxbEml = new System.Windows.Forms.TextBox();
            this.TxbSenha = new System.Windows.Forms.TextBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.TxbCfs = new System.Windows.Forms.TextBox();
            this.BtnMos1 = new System.Windows.Forms.Button();
            this.BtnMos2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.TxbPro.Location = new System.Drawing.Point(476, 323);
            this.TxbPro.Multiline = true;
            this.TxbPro.Name = "TxbPro";
            this.TxbPro.Size = new System.Drawing.Size(364, 74);
            this.TxbPro.TabIndex = 7;
            // 
            // TxbNom
            // 
            this.TxbNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbNom.Font = new System.Drawing.Font("Press Start 2P", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbNom.Location = new System.Drawing.Point(466, 159);
            this.TxbNom.Multiline = true;
            this.TxbNom.Name = "TxbNom";
            this.TxbNom.Size = new System.Drawing.Size(364, 74);
            this.TxbNom.TabIndex = 18;
            // 
            // TxbIda
            // 
            this.TxbIda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbIda.Font = new System.Drawing.Font("Press Start 2P", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbIda.Location = new System.Drawing.Point(1140, 159);
            this.TxbIda.Multiline = true;
            this.TxbIda.Name = "TxbIda";
            this.TxbIda.Size = new System.Drawing.Size(373, 82);
            this.TxbIda.TabIndex = 19;
            // 
            // TxbEml
            // 
            this.TxbEml.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbEml.Font = new System.Drawing.Font("Press Start 2P", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbEml.Location = new System.Drawing.Point(1140, 323);
            this.TxbEml.Multiline = true;
            this.TxbEml.Name = "TxbEml";
            this.TxbEml.Size = new System.Drawing.Size(364, 74);
            this.TxbEml.TabIndex = 20;
            this.TxbEml.TextChanged += new System.EventHandler(this.TxbEml_TextChanged);
            // 
            // TxbSenha
            // 
            this.TxbSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbSenha.Font = new System.Drawing.Font("Press Start 2P", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbSenha.Location = new System.Drawing.Point(476, 471);
            this.TxbSenha.Multiline = true;
            this.TxbSenha.Name = "TxbSenha";
            this.TxbSenha.Size = new System.Drawing.Size(364, 74);
            this.TxbSenha.TabIndex = 20;
            this.TxbSenha.TextChanged += new System.EventHandler(this.TxbSenha_TextChanged);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalvar.FlatAppearance.BorderSize = 0;
            this.BtnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvar.Location = new System.Drawing.Point(695, 633);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(591, 123);
            this.BtnSalvar.TabIndex = 21;
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // TxbCfs
            // 
            this.TxbCfs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbCfs.Font = new System.Drawing.Font("Press Start 2P", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbCfs.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxbCfs.Location = new System.Drawing.Point(1140, 471);
            this.TxbCfs.Multiline = true;
            this.TxbCfs.Name = "TxbCfs";
            this.TxbCfs.Size = new System.Drawing.Size(364, 74);
            this.TxbCfs.TabIndex = 22;
            this.TxbCfs.TextChanged += new System.EventHandler(this.TxbCfs_TextChanged);
            // 
            // BtnMos1
            // 
            this.BtnMos1.Location = new System.Drawing.Point(659, 569);
            this.BtnMos1.Name = "BtnMos1";
            this.BtnMos1.Size = new System.Drawing.Size(75, 23);
            this.BtnMos1.TabIndex = 23;
            this.BtnMos1.Text = "🔒";
            this.BtnMos1.UseVisualStyleBackColor = true;
            this.BtnMos1.Click += new System.EventHandler(this.BtnMos1_Click);
            // 
            // BtnMos2
            // 
            this.BtnMos2.Location = new System.Drawing.Point(1314, 568);
            this.BtnMos2.Name = "BtnMos2";
            this.BtnMos2.Size = new System.Drawing.Size(75, 23);
            this.BtnMos2.TabIndex = 24;
            this.BtnMos2.Text = "🔒";
            this.BtnMos2.UseVisualStyleBackColor = true;
            this.BtnMos2.Click += new System.EventHandler(this.BtnMos2_Click);
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::TerroristaMiR___s.Properties.Resources.Captura_de_tela_2025_09_16_095128;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.BtnMos2);
            this.Controls.Add(this.BtnMos1);
            this.Controls.Add(this.TxbCfs);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.TxbSenha);
            this.Controls.Add(this.TxbEml);
            this.Controls.Add(this.TxbIda);
            this.Controls.Add(this.TxbNom);
            this.Controls.Add(this.TxbPro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSair);
            this.Name = "FrmCadastro";
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
        private System.Windows.Forms.TextBox TxbNom;
        private System.Windows.Forms.TextBox TxbIda;
        private System.Windows.Forms.TextBox TxbEml;
        private System.Windows.Forms.TextBox TxbSenha;
        private Button BtnSalvar;
        private TextBox TxbCfs;
        private Button BtnMos1;
        private Button BtnMos2;
    }
}