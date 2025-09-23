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
            this.RbA = new System.Windows.Forms.RadioButton();
            this.RbB = new System.Windows.Forms.RadioButton();
            this.RbC = new System.Windows.Forms.RadioButton();
            this.RbD = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // RbA
            // 
            this.RbA.AutoSize = true;
            this.RbA.Font = new System.Drawing.Font("Press Start 2P", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbA.Location = new System.Drawing.Point(569, 478);
            this.RbA.Name = "RbA";
            this.RbA.Size = new System.Drawing.Size(277, 30);
            this.RbA.TabIndex = 0;
            this.RbA.TabStop = true;
            this.RbA.Text = "Alternativa A";
            this.RbA.UseVisualStyleBackColor = true;
            // 
            // RbB
            // 
            this.RbB.AutoSize = true;
            this.RbB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RbB.Font = new System.Drawing.Font("Press Start 2P", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbB.Location = new System.Drawing.Point(1090, 478);
            this.RbB.Name = "RbB";
            this.RbB.Size = new System.Drawing.Size(277, 30);
            this.RbB.TabIndex = 1;
            this.RbB.TabStop = true;
            this.RbB.Text = "Alternativa B";
            this.RbB.UseVisualStyleBackColor = false;
            // 
            // RbC
            // 
            this.RbC.AutoSize = true;
            this.RbC.Font = new System.Drawing.Font("Press Start 2P", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbC.Location = new System.Drawing.Point(569, 591);
            this.RbC.Name = "RbC";
            this.RbC.Size = new System.Drawing.Size(277, 30);
            this.RbC.TabIndex = 2;
            this.RbC.TabStop = true;
            this.RbC.Text = "Alternativa C";
            this.RbC.UseVisualStyleBackColor = true;
            // 
            // RbD
            // 
            this.RbD.AutoSize = true;
            this.RbD.Font = new System.Drawing.Font("Press Start 2P", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbD.Location = new System.Drawing.Point(1090, 578);
            this.RbD.Name = "RbD";
            this.RbD.Size = new System.Drawing.Size(277, 30);
            this.RbD.TabIndex = 3;
            this.RbD.TabStop = true;
            this.RbD.Text = "Alternativa D";
            this.RbD.UseVisualStyleBackColor = true;
            // 
            // FrmQuiz1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TerroristaMiR___s.Properties.Resources.Captura_de_tela_2025_09_23_101028;
            this.ClientSize = new System.Drawing.Size(1909, 976);
            this.Controls.Add(this.RbD);
            this.Controls.Add(this.RbC);
            this.Controls.Add(this.RbB);
            this.Controls.Add(this.RbA);
            this.Name = "FrmQuiz1";
            this.Text = "FrmQuiz1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RbA;
        private System.Windows.Forms.RadioButton RbB;
        private System.Windows.Forms.RadioButton RbC;
        private System.Windows.Forms.RadioButton RbD;
    }
}