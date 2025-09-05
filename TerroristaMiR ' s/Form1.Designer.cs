namespace TerroristaMiR___s
{
    partial class FrmMat
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
            this.BtnEnt = new System.Windows.Forms.Button();
            this.LblMat = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnEnt
            // 
            this.BtnEnt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnEnt.BackColor = System.Drawing.Color.Transparent;
            this.BtnEnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnEnt.FlatAppearance.BorderSize = 0;
            this.BtnEnt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnEnt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnEnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnt.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnt.ForeColor = System.Drawing.SystemColors.InfoText;
            this.BtnEnt.Image = global::TerroristaMiR___s.Properties.Resources._414144141411;
            this.BtnEnt.Location = new System.Drawing.Point(586, 400);
            this.BtnEnt.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEnt.Name = "BtnEnt";
            this.BtnEnt.Size = new System.Drawing.Size(349, 68);
            this.BtnEnt.TabIndex = 0;
            this.BtnEnt.UseVisualStyleBackColor = false;
            this.BtnEnt.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LblMat
            // 
            this.LblMat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblMat.AutoSize = true;
            this.LblMat.BackColor = System.Drawing.Color.Transparent;
            this.LblMat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMat.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblMat.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LblMat.Location = new System.Drawing.Point(1095, -13);
            this.LblMat.Name = "LblMat";
            this.LblMat.Size = new System.Drawing.Size(23, 31);
            this.LblMat.TabIndex = 1;
            this.LblMat.Text = ".";
            this.LblMat.Click += new System.EventHandler(this.LblMat_Click);
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
            this.BtnSair.Location = new System.Drawing.Point(1272, 733);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(261, 116);
            this.BtnSair.TabIndex = 4;
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // FrmMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = global::TerroristaMiR___s.Properties.Resources._8888888888888888881;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.LblMat);
            this.Controls.Add(this.BtnEnt);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Name = "FrmMat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Matemático";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEnt;
        private System.Windows.Forms.Label LblMat;
        private System.Windows.Forms.Button BtnSair;
    }
}

