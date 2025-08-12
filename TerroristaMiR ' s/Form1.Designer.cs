namespace TerroristaMiR___s
{
    partial class FrmBtt
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEntrar = new System.Windows.Forms.Button();
            this.LblTrig = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEntrar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnEntrar.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnEntrar.Location = new System.Drawing.Point(320, 391);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(130, 36);
            this.btnEntrar.TabIndex = 0;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LblTrig
            // 
            this.LblTrig.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblTrig.AutoSize = true;
            this.LblTrig.BackColor = System.Drawing.Color.RoyalBlue;
            this.LblTrig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblTrig.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTrig.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.LblTrig.Image = global::TerroristaMiR___s.Properties.Resources.Captura_de_tela_5_8_2025_10023_wallpaperaccess1;
            this.LblTrig.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LblTrig.Location = new System.Drawing.Point(249, 9);
            this.LblTrig.Name = "LblTrig";
            this.LblTrig.Size = new System.Drawing.Size(302, 31);
            this.LblTrig.TabIndex = 1;
            this.LblTrig.Text = "Batata Trigonometrica";
            // 
            // FrmBtt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = global::TerroristaMiR___s.Properties.Resources.Captura_de_tela_5_8_2025_10023_wallpaperaccess_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(771, 450);
            this.Controls.Add(this.LblTrig);
            this.Controls.Add(this.btnEntrar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "FrmBtt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batata Trigonométrica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label LblTrig;
    }
}

