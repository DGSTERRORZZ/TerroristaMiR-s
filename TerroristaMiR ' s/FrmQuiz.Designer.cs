namespace TerroristaMiR___s
{
    partial class FrmQuiz
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnYes = new System.Windows.Forms.Button();
            this.BtnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // BtnYes
            // 
            this.BtnYes.BackColor = System.Drawing.Color.Transparent;
            this.BtnYes.FlatAppearance.BorderSize = 0;
            this.BtnYes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnYes.Location = new System.Drawing.Point(629, 761);
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.Size = new System.Drawing.Size(305, 59);
            this.BtnYes.TabIndex = 1;
            this.BtnYes.UseVisualStyleBackColor = false;
            this.BtnYes.Click += new System.EventHandler(this.BtnYes_Click);
            // 
            // BtnNo
            // 
            this.BtnNo.BackColor = System.Drawing.Color.Transparent;
            this.BtnNo.FlatAppearance.BorderSize = 0;
            this.BtnNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNo.Location = new System.Drawing.Point(1000, 761);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.Size = new System.Drawing.Size(318, 59);
            this.BtnNo.TabIndex = 2;
            this.BtnNo.UseVisualStyleBackColor = false;
            this.BtnNo.Click += new System.EventHandler(this.BtnNo_Click);
            // 
            // FrmQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TerroristaMiR___s.Properties.Resources.Captura_de_tela_2025_09_16_123942;
            this.ClientSize = new System.Drawing.Size(1725, 989);
            this.Controls.Add(this.BtnNo);
            this.Controls.Add(this.BtnYes);
            this.Controls.Add(this.label1);
            this.Name = "FrmQuiz";
            this.Text = "FrmQuiz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnYes;
        private System.Windows.Forms.Button BtnNo;
    }
}