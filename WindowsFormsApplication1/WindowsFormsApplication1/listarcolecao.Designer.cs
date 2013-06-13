namespace WindowsFormsApplication1
{
    partial class listarcolecao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listarcolecao));
            this.database1DataSet = new WindowsFormsApplication1.Database1DataSet();
            this.seloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seloTableAdapter = new WindowsFormsApplication1.Database1DataSetTableAdapters.SeloTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numeroserieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorfacialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdstockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seloBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.seloBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.correspondenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.correspondenteTableAdapter = new WindowsFormsApplication1.Database1DataSetTableAdapters.CorrespondenteTableAdapter();
            this.fKligaçãoCorrespondenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ligaçãoTableAdapter = new WindowsFormsApplication1.Database1DataSetTableAdapters.ligaçãoTableAdapter();
            this.fKligaçãoSeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seloBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seloBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correspondenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKligaçãoCorrespondenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKligaçãoSeloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seloBindingSource
            // 
            this.seloBindingSource.DataMember = "Selo";
            this.seloBindingSource.DataSource = this.database1DataSet;
            // 
            // seloTableAdapter
            // 
            this.seloTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroserieDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.serieDataGridViewTextBoxColumn,
            this.corDataGridViewTextBoxColumn,
            this.anoDataGridViewTextBoxColumn,
            this.paisDataGridViewTextBoxColumn,
            this.valorfacialDataGridViewTextBoxColumn,
            this.qtdstockDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.seloBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(602, 378);
            this.dataGridView1.TabIndex = 3;
            // 
            // numeroserieDataGridViewTextBoxColumn
            // 
            this.numeroserieDataGridViewTextBoxColumn.DataPropertyName = "numeroserie";
            this.numeroserieDataGridViewTextBoxColumn.HeaderText = "numeroserie";
            this.numeroserieDataGridViewTextBoxColumn.Name = "numeroserieDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // serieDataGridViewTextBoxColumn
            // 
            this.serieDataGridViewTextBoxColumn.DataPropertyName = "serie";
            this.serieDataGridViewTextBoxColumn.HeaderText = "serie";
            this.serieDataGridViewTextBoxColumn.Name = "serieDataGridViewTextBoxColumn";
            // 
            // corDataGridViewTextBoxColumn
            // 
            this.corDataGridViewTextBoxColumn.DataPropertyName = "cor";
            this.corDataGridViewTextBoxColumn.HeaderText = "cor";
            this.corDataGridViewTextBoxColumn.Name = "corDataGridViewTextBoxColumn";
            // 
            // anoDataGridViewTextBoxColumn
            // 
            this.anoDataGridViewTextBoxColumn.DataPropertyName = "ano";
            this.anoDataGridViewTextBoxColumn.HeaderText = "ano";
            this.anoDataGridViewTextBoxColumn.Name = "anoDataGridViewTextBoxColumn";
            // 
            // paisDataGridViewTextBoxColumn
            // 
            this.paisDataGridViewTextBoxColumn.DataPropertyName = "pais";
            this.paisDataGridViewTextBoxColumn.HeaderText = "pais";
            this.paisDataGridViewTextBoxColumn.Name = "paisDataGridViewTextBoxColumn";
            // 
            // valorfacialDataGridViewTextBoxColumn
            // 
            this.valorfacialDataGridViewTextBoxColumn.DataPropertyName = "valorfacial";
            this.valorfacialDataGridViewTextBoxColumn.HeaderText = "valorfacial";
            this.valorfacialDataGridViewTextBoxColumn.Name = "valorfacialDataGridViewTextBoxColumn";
            // 
            // qtdstockDataGridViewTextBoxColumn
            // 
            this.qtdstockDataGridViewTextBoxColumn.DataPropertyName = "qtdstock";
            this.qtdstockDataGridViewTextBoxColumn.HeaderText = "qtdstock";
            this.qtdstockDataGridViewTextBoxColumn.Name = "qtdstockDataGridViewTextBoxColumn";
            // 
            // seloBindingSource2
            // 
            this.seloBindingSource2.DataMember = "Selo";
            this.seloBindingSource2.DataSource = this.database1DataSet;
            // 
            // seloBindingSource1
            // 
            this.seloBindingSource1.DataMember = "Selo";
            this.seloBindingSource1.DataSource = this.database1DataSetBindingSource;
            // 
            // correspondenteBindingSource
            // 
            this.correspondenteBindingSource.DataMember = "Correspondente";
            this.correspondenteBindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // correspondenteTableAdapter
            // 
            this.correspondenteTableAdapter.ClearBeforeFill = true;
            // 
            // fKligaçãoCorrespondenteBindingSource
            // 
            this.fKligaçãoCorrespondenteBindingSource.DataMember = "FK_ligação_Correspondente";
            this.fKligaçãoCorrespondenteBindingSource.DataSource = this.correspondenteBindingSource;
            // 
            // ligaçãoTableAdapter
            // 
            this.ligaçãoTableAdapter.ClearBeforeFill = true;
            // 
            // fKligaçãoSeloBindingSource
            // 
            this.fKligaçãoSeloBindingSource.DataMember = "FK_ligação_Selo";
            this.fKligaçãoSeloBindingSource.DataSource = this.seloBindingSource1;
            // 
            // listarcolecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(626, 431);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "listarcolecao";
            this.Text = "Listagem da Coleção";
            this.Load += new System.EventHandler(this.listarcolecao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seloBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seloBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correspondenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKligaçãoCorrespondenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKligaçãoSeloBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource seloBindingSource;
        private Database1DataSetTableAdapters.SeloTableAdapter seloTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource seloBindingSource1;
        private System.Windows.Forms.BindingSource correspondenteBindingSource;
        private Database1DataSetTableAdapters.CorrespondenteTableAdapter correspondenteTableAdapter;
        private System.Windows.Forms.BindingSource fKligaçãoCorrespondenteBindingSource;
        private Database1DataSetTableAdapters.ligaçãoTableAdapter ligaçãoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroserieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorfacialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdstockDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource seloBindingSource2;
        private System.Windows.Forms.BindingSource fKligaçãoSeloBindingSource;
    }
}