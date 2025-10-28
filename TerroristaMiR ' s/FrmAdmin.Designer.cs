namespace TerroristaMiR___s
{
    partial class FrmAdmin
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
            this.TxbB = new System.Windows.Forms.TextBox();
            this.TxbA = new System.Windows.Forms.TextBox();
            this.TxbC = new System.Windows.Forms.TextBox();
            this.TxbD = new System.Windows.Forms.TextBox();
            this.TxbPergunta = new System.Windows.Forms.TextBox();
            this.CmbCorreta = new System.Windows.Forms.ComboBox();
            this.CmbNivel = new System.Windows.Forms.ComboBox();
            this.BtnSlvAdmin = new System.Windows.Forms.Button();
            this.DgvPerguntas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPerguntas)).BeginInit();
            this.SuspendLayout();
            // 
            // TxbB
            // 
            this.TxbB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbB.Location = new System.Drawing.Point(1113, 418);
            this.TxbB.Multiline = true;
            this.TxbB.Name = "TxbB";
            this.TxbB.Size = new System.Drawing.Size(273, 63);
            this.TxbB.TabIndex = 0;
            this.TxbB.TextChanged += new System.EventHandler(this.TxbB_TextChanged);
            // 
            // TxbA
            // 
            this.TxbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbA.Location = new System.Drawing.Point(541, 418);
            this.TxbA.Multiline = true;
            this.TxbA.Name = "TxbA";
            this.TxbA.Size = new System.Drawing.Size(273, 63);
            this.TxbA.TabIndex = 1;
            // 
            // TxbC
            // 
            this.TxbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbC.Location = new System.Drawing.Point(541, 626);
            this.TxbC.Multiline = true;
            this.TxbC.Name = "TxbC";
            this.TxbC.Size = new System.Drawing.Size(273, 63);
            this.TxbC.TabIndex = 2;
            // 
            // TxbD
            // 
            this.TxbD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxbD.Location = new System.Drawing.Point(1113, 626);
            this.TxbD.Multiline = true;
            this.TxbD.Name = "TxbD";
            this.TxbD.Size = new System.Drawing.Size(273, 63);
            this.TxbD.TabIndex = 3;
            this.TxbD.TextChanged += new System.EventHandler(this.TxbD_TextChanged);
            // 
            // TxbPergunta
            // 
            this.TxbPergunta.BackColor = System.Drawing.Color.Gold;
            this.TxbPergunta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbPergunta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxbPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbPergunta.Location = new System.Drawing.Point(822, 287);
            this.TxbPergunta.Multiline = true;
            this.TxbPergunta.Name = "TxbPergunta";
            this.TxbPergunta.Size = new System.Drawing.Size(265, 64);
            this.TxbPergunta.TabIndex = 4;
            // 
            // CmbCorreta
            // 
            this.CmbCorreta.BackColor = System.Drawing.Color.SpringGreen;
            this.CmbCorreta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbCorreta.FormattingEnabled = true;
            this.CmbCorreta.Items.AddRange(new object[] {
            "A",
            "B",
            "C ",
            "D"});
            this.CmbCorreta.Location = new System.Drawing.Point(873, 503);
            this.CmbCorreta.Name = "CmbCorreta";
            this.CmbCorreta.Size = new System.Drawing.Size(177, 21);
            this.CmbCorreta.TabIndex = 5;
            // 
            // CmbNivel
            // 
            this.CmbNivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CmbNivel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbNivel.ForeColor = System.Drawing.SystemColors.Info;
            this.CmbNivel.FormattingEnabled = true;
            this.CmbNivel.Items.AddRange(new object[] {
            "1 - Fácil",
            " 2 - Médio",
            " 3 - Difícil"});
            this.CmbNivel.Location = new System.Drawing.Point(873, 561);
            this.CmbNivel.Name = "CmbNivel";
            this.CmbNivel.Size = new System.Drawing.Size(177, 21);
            this.CmbNivel.TabIndex = 6;
            this.CmbNivel.SelectedIndexChanged += new System.EventHandler(this.CmbNivel_SelectedIndexChanged);
            // 
            // BtnSlvAdmin
            // 
            this.BtnSlvAdmin.BackColor = System.Drawing.Color.Transparent;
            this.BtnSlvAdmin.FlatAppearance.BorderSize = 0;
            this.BtnSlvAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnSlvAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnSlvAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSlvAdmin.Location = new System.Drawing.Point(862, 751);
            this.BtnSlvAdmin.Name = "BtnSlvAdmin";
            this.BtnSlvAdmin.Size = new System.Drawing.Size(199, 39);
            this.BtnSlvAdmin.TabIndex = 7;
            this.BtnSlvAdmin.UseVisualStyleBackColor = false;
            this.BtnSlvAdmin.Click += new System.EventHandler(this.BtnSlvAdmin_Click);
            // 
            // DgvPerguntas
            // 
            this.DgvPerguntas.AllowUserToAddRows = false;
            this.DgvPerguntas.AllowUserToDeleteRows = false;
            this.DgvPerguntas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPerguntas.BackgroundColor = System.Drawing.Color.Black;
            this.DgvPerguntas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvPerguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPerguntas.Location = new System.Drawing.Point(1131, 248);
            this.DgvPerguntas.Name = "DgvPerguntas";
            this.DgvPerguntas.Size = new System.Drawing.Size(240, 150);
            this.DgvPerguntas.TabIndex = 8;
            this.DgvPerguntas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPerguntas_CellContentClick);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::TerroristaMiR___s.Properties.Resources.Captura_de_tela_2025_10_16_085514;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.DgvPerguntas);
            this.Controls.Add(this.BtnSlvAdmin);
            this.Controls.Add(this.CmbNivel);
            this.Controls.Add(this.CmbCorreta);
            this.Controls.Add(this.TxbPergunta);
            this.Controls.Add(this.TxbD);
            this.Controls.Add(this.TxbC);
            this.Controls.Add(this.TxbA);
            this.Controls.Add(this.TxbB);
            this.Name = "FrmAdmin";
            this.Text = "FrmAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPerguntas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxbB;
        private System.Windows.Forms.TextBox TxbA;
        private System.Windows.Forms.TextBox TxbC;
        private System.Windows.Forms.TextBox TxbD;
        private System.Windows.Forms.TextBox TxbPergunta;
        private System.Windows.Forms.ComboBox CmbCorreta;
        private System.Windows.Forms.ComboBox CmbNivel;
        private System.Windows.Forms.Button BtnSlvAdmin;
        private System.Windows.Forms.DataGridView DgvPerguntas;
    }
}