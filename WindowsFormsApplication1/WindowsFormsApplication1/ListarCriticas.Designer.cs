namespace WindowsFormsApplication1
{
    partial class ListarCriticas
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.restaurantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WindowsFormsApplication1.Database1DataSet();
            this.restaurantesTableAdapter = new WindowsFormsApplication1.Database1DataSetTableAdapters.RestaurantesTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.criticaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classificacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKAvaliacaoRestaurantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avaliacaoTableAdapter = new WindowsFormsApplication1.Database1DataSetTableAdapters.AvaliacaoTableAdapter();
            this.fKAvaliacaoRestaurantesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKAvaliacaoRestaurantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKAvaliacaoRestaurantesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.restaurantesBindingSource;
            this.listBox1.DisplayMember = "Nome";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(136, 121);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "ID";
            // 
            // restaurantesBindingSource
            // 
            this.restaurantesBindingSource.DataMember = "Restaurantes";
            this.restaurantesBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restaurantesTableAdapter
            // 
            this.restaurantesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataDataGridViewTextBoxColumn,
            this.criticaDataGridViewTextBoxColumn,
            this.classificacaoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fKAvaliacaoRestaurantesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(194, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // criticaDataGridViewTextBoxColumn
            // 
            this.criticaDataGridViewTextBoxColumn.DataPropertyName = "Critica";
            this.criticaDataGridViewTextBoxColumn.HeaderText = "Critica";
            this.criticaDataGridViewTextBoxColumn.Name = "criticaDataGridViewTextBoxColumn";
            // 
            // classificacaoDataGridViewTextBoxColumn
            // 
            this.classificacaoDataGridViewTextBoxColumn.DataPropertyName = "Classificacao";
            this.classificacaoDataGridViewTextBoxColumn.HeaderText = "Classificacao";
            this.classificacaoDataGridViewTextBoxColumn.Name = "classificacaoDataGridViewTextBoxColumn";
            // 
            // fKAvaliacaoRestaurantesBindingSource
            // 
            this.fKAvaliacaoRestaurantesBindingSource.DataMember = "FK_Avaliacao_Restaurantes";
            this.fKAvaliacaoRestaurantesBindingSource.DataSource = this.restaurantesBindingSource;
            // 
            // avaliacaoTableAdapter
            // 
            this.avaliacaoTableAdapter.ClearBeforeFill = true;
            // 
            // fKAvaliacaoRestaurantesBindingSource1
            // 
            this.fKAvaliacaoRestaurantesBindingSource1.DataMember = "FK_Avaliacao_Restaurantes";
            this.fKAvaliacaoRestaurantesBindingSource1.DataSource = this.restaurantesBindingSource;
            // 
            // ListarCriticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 261);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Name = "ListarCriticas";
            this.Text = "ListarCriticas";
            this.Load += new System.EventHandler(this.ListarCriticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKAvaliacaoRestaurantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKAvaliacaoRestaurantesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource restaurantesBindingSource;
        private Database1DataSetTableAdapters.RestaurantesTableAdapter restaurantesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fKAvaliacaoRestaurantesBindingSource;
        private Database1DataSetTableAdapters.AvaliacaoTableAdapter avaliacaoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crticoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn criticaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classificacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKAvaliacaoRestaurantesBindingSource1;
    }
}