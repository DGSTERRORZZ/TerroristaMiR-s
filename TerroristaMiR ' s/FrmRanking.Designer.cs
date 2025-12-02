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
            this.components = new System.ComponentModel.Container();
            this.DgvRanking = new System.Windows.Forms.DataGridView();
            this.cJ3027678PR2DataSet1 = new TerroristaMiR___s.CJ3027678PR2DataSet1();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new TerroristaMiR___s.CJ3027678PR2DataSet1TableAdapters.usuariosTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prontuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pontuacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataregistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRanking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3027678PR2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvRanking
            // 
            this.DgvRanking.AllowUserToAddRows = false;
            this.DgvRanking.AutoGenerateColumns = false;
            this.DgvRanking.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DgvRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRanking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.prontuarioDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.idadeDataGridViewTextBoxColumn,
            this.pontuacaoDataGridViewTextBoxColumn,
            this.dataregistroDataGridViewTextBoxColumn,
            this.senhaDataGridViewTextBoxColumn});
            this.DgvRanking.DataSource = this.usuariosBindingSource;
            this.DgvRanking.Location = new System.Drawing.Point(525, 314);
            this.DgvRanking.Name = "DgvRanking";
            this.DgvRanking.ReadOnly = true;
            this.DgvRanking.Size = new System.Drawing.Size(871, 453);
            this.DgvRanking.TabIndex = 0;
            this.DgvRanking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRanking_CellContentClick);
            // 
            // cJ3027678PR2DataSet1
            // 
            this.cJ3027678PR2DataSet1.DataSetName = "CJ3027678PR2DataSet1";
            this.cJ3027678PR2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.cJ3027678PR2DataSet1;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prontuarioDataGridViewTextBoxColumn
            // 
            this.prontuarioDataGridViewTextBoxColumn.DataPropertyName = "prontuario";
            this.prontuarioDataGridViewTextBoxColumn.HeaderText = "prontuario";
            this.prontuarioDataGridViewTextBoxColumn.Name = "prontuarioDataGridViewTextBoxColumn";
            this.prontuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idadeDataGridViewTextBoxColumn
            // 
            this.idadeDataGridViewTextBoxColumn.DataPropertyName = "idade";
            this.idadeDataGridViewTextBoxColumn.HeaderText = "idade";
            this.idadeDataGridViewTextBoxColumn.Name = "idadeDataGridViewTextBoxColumn";
            this.idadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pontuacaoDataGridViewTextBoxColumn
            // 
            this.pontuacaoDataGridViewTextBoxColumn.DataPropertyName = "pontuacao";
            this.pontuacaoDataGridViewTextBoxColumn.HeaderText = "pontuacao";
            this.pontuacaoDataGridViewTextBoxColumn.Name = "pontuacaoDataGridViewTextBoxColumn";
            this.pontuacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataregistroDataGridViewTextBoxColumn
            // 
            this.dataregistroDataGridViewTextBoxColumn.DataPropertyName = "dataregistro";
            this.dataregistroDataGridViewTextBoxColumn.HeaderText = "dataregistro";
            this.dataregistroDataGridViewTextBoxColumn.Name = "dataregistroDataGridViewTextBoxColumn";
            this.dataregistroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // senhaDataGridViewTextBoxColumn
            // 
            this.senhaDataGridViewTextBoxColumn.DataPropertyName = "senha";
            this.senhaDataGridViewTextBoxColumn.HeaderText = "senha";
            this.senhaDataGridViewTextBoxColumn.Name = "senhaDataGridViewTextBoxColumn";
            this.senhaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TerroristaMiR___s.Properties.Resources.Captura_de_tela_2025_12_02_1020271;
            this.ClientSize = new System.Drawing.Size(1584, 821);
            this.Controls.Add(this.DgvRanking);
            this.Name = "FrmRanking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRanking";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRanking_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRanking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3027678PR2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvRanking;
        private CJ3027678PR2DataSet1 cJ3027678PR2DataSet1;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private CJ3027678PR2DataSet1TableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prontuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pontuacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataregistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
    }
}