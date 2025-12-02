namespace TerroristaMiR___s
{
    partial class FrmRanking
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
            this.DgvRanking = new System.Windows.Forms.DataGridView();
            this.Atualizar = new System.Windows.Forms.Button();
            this.Fechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRanking)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvRanking
            // 
            this.DgvRanking.AllowUserToAddRows = false;
            this.DgvRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRanking.Location = new System.Drawing.Point(352, 157);
            this.DgvRanking.Name = "DgvRanking";
            this.DgvRanking.ReadOnly = true;
            this.DgvRanking.Size = new System.Drawing.Size(240, 150);
            this.DgvRanking.TabIndex = 0;
            this.DgvRanking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRanking_CellContentClick);
            // 
            // Atualizar
            // 
            this.Atualizar.Location = new System.Drawing.Point(352, 48);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(75, 23);
            this.Atualizar.TabIndex = 1;
            this.Atualizar.Text = "button1";
            this.Atualizar.UseVisualStyleBackColor = true;
            // 
            // Fechar
            // 
            this.Fechar.Location = new System.Drawing.Point(352, 78);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(75, 23);
            this.Fechar.TabIndex = 2;
            this.Fechar.Text = "button2";
            this.Fechar.UseVisualStyleBackColor = true;
            // 
            // FrmRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.Atualizar);
            this.Controls.Add(this.DgvRanking);
            this.Name = "FrmRanking";
            this.Text = "FrmRanking";
            ((System.ComponentModel.ISupportInitialize)(this.DgvRanking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvRanking;
        private System.Windows.Forms.Button Atualizar;
        private System.Windows.Forms.Button Fechar;
    }
}