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
            this.BtnEnt = new System.Windows.Forms.Button();
            this.TxbSenha = new System.Windows.Forms.TextBox();
            this.TxbPro = new System.Windows.Forms.TextBox();
            this.BtnCad = new System.Windows.Forms.Button();
            this.BtnMos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnEnt
            // 
            this.BtnEnt.BackColor = System.Drawing.Color.Transparent;
            this.BtnEnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEnt.FlatAppearance.BorderSize = 0;
            this.BtnEnt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnEnt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnEnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnt.ForeColor = System.Drawing.Color.Transparent;
            this.BtnEnt.Location = new System.Drawing.Point(759, 641);
            this.BtnEnt.Name = "BtnEnt";
            this.BtnEnt.Size = new System.Drawing.Size(463, 89);
            this.BtnEnt.TabIndex = 0;
            this.BtnEnt.UseMnemonic = false;
            this.BtnEnt.UseVisualStyleBackColor = false;
            this.BtnEnt.Click += new System.EventHandler(this.BtnEnt_Click_1);
            // 
            // TxbSenha
            // 
            this.TxbSenha.BackColor = System.Drawing.SystemColors.Window;
            this.TxbSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbSenha.Location = new System.Drawing.Point(740, 433);
            this.TxbSenha.Name = "TxbSenha";
            this.TxbSenha.PasswordChar = '*';
            this.TxbSenha.Size = new System.Drawing.Size(490, 55);
            this.TxbSenha.TabIndex = 2;
            // 
            // TxbPro
            // 
            this.TxbPro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbPro.Location = new System.Drawing.Point(740, 259);
            this.TxbPro.Name = "TxbPro";
            this.TxbPro.Size = new System.Drawing.Size(490, 55);
            this.TxbPro.TabIndex = 1;
            this.TxbPro.TextChanged += new System.EventHandler(this.TxbPro_TextChanged);
            // 
            // BtnCad
            // 
            this.BtnCad.BackColor = System.Drawing.Color.Transparent;
            this.BtnCad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCad.FlatAppearance.BorderSize = 0;
            this.BtnCad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnCad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCad.Location = new System.Drawing.Point(863, 565);
            this.BtnCad.Name = "BtnCad";
            this.BtnCad.Size = new System.Drawing.Size(253, 58);
            this.BtnCad.TabIndex = 3;
            this.BtnCad.Text = " To Register";
            this.BtnCad.UseVisualStyleBackColor = false;
            this.BtnCad.Click += new System.EventHandler(this.BtnCad_Click);
            // 
            // BtnMos
            // 
            this.BtnMos.BackColor = System.Drawing.Color.Transparent;
            this.BtnMos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnMos.FlatAppearance.BorderSize = 0;
            this.BtnMos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnMos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnMos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMos.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMos.Location = new System.Drawing.Point(1251, 443);
            this.BtnMos.Name = "BtnMos";
            this.BtnMos.Size = new System.Drawing.Size(75, 49);
            this.BtnMos.TabIndex = 4;
            this.BtnMos.Text = "🔒";
            this.BtnMos.UseVisualStyleBackColor = false;
            this.BtnMos.Click += new System.EventHandler(this.BtnMos_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TerroristaMiR___s.Properties.Resources.Captura_de_tela_2025_09_18_160736;
            this.ClientSize = new System.Drawing.Size(1872, 1061);
            this.Controls.Add(this.BtnMos);
            this.Controls.Add(this.BtnCad);
            this.Controls.Add(this.TxbSenha);
            this.Controls.Add(this.TxbPro);
            this.Controls.Add(this.BtnEnt);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEnt;
        private System.Windows.Forms.TextBox TxbPro;
        private System.Windows.Forms.TextBox TxbSenha;
        private System.Windows.Forms.Button BtnCad;
        private System.Windows.Forms.Button BtnMos;
    }
}