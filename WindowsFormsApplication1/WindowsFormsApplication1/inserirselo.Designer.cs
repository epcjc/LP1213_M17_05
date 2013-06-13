namespace WindowsFormsApplication1
{
    partial class inserirselo
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
            System.Windows.Forms.Label numeroserieLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label serieLabel;
            System.Windows.Forms.Label corLabel;
            System.Windows.Forms.Label anoLabel;
            System.Windows.Forms.Label paisLabel;
            System.Windows.Forms.Label valorfacialLabel;
            System.Windows.Forms.Label qtdstockLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inserirselo));
            this.database1DataSet = new WindowsFormsApplication1.Database1DataSet();
            this.seloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seloTableAdapter = new WindowsFormsApplication1.Database1DataSetTableAdapters.SeloTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.Database1DataSetTableAdapters.TableAdapterManager();
            this.seloBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.seloBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.numeroserieTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.serieTextBox = new System.Windows.Forms.TextBox();
            this.corTextBox = new System.Windows.Forms.TextBox();
            this.anoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.paisTextBox = new System.Windows.Forms.TextBox();
            this.valorfacialTextBox = new System.Windows.Forms.TextBox();
            this.qtdstockTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            numeroserieLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            serieLabel = new System.Windows.Forms.Label();
            corLabel = new System.Windows.Forms.Label();
            anoLabel = new System.Windows.Forms.Label();
            paisLabel = new System.Windows.Forms.Label();
            valorfacialLabel = new System.Windows.Forms.Label();
            qtdstockLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seloBindingNavigator)).BeginInit();
            this.seloBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // numeroserieLabel
            // 
            numeroserieLabel.AutoSize = true;
            numeroserieLabel.Location = new System.Drawing.Point(38, 56);
            numeroserieLabel.Name = "numeroserieLabel";
            numeroserieLabel.Size = new System.Drawing.Size(74, 13);
            numeroserieLabel.TabIndex = 1;
            numeroserieLabel.Text = "Numero Serie:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(74, 82);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // serieLabel
            // 
            serieLabel.AutoSize = true;
            serieLabel.Location = new System.Drawing.Point(79, 108);
            serieLabel.Name = "serieLabel";
            serieLabel.Size = new System.Drawing.Size(34, 13);
            serieLabel.TabIndex = 5;
            serieLabel.Text = "Serie:";
            // 
            // corLabel
            // 
            corLabel.AutoSize = true;
            corLabel.Location = new System.Drawing.Point(87, 134);
            corLabel.Name = "corLabel";
            corLabel.Size = new System.Drawing.Size(26, 13);
            corLabel.TabIndex = 7;
            corLabel.Text = "Cor:";
            // 
            // anoLabel
            // 
            anoLabel.AutoSize = true;
            anoLabel.Location = new System.Drawing.Point(84, 161);
            anoLabel.Name = "anoLabel";
            anoLabel.Size = new System.Drawing.Size(29, 13);
            anoLabel.TabIndex = 9;
            anoLabel.Text = "Ano:";
            // 
            // paisLabel
            // 
            paisLabel.AutoSize = true;
            paisLabel.Location = new System.Drawing.Point(84, 186);
            paisLabel.Name = "paisLabel";
            paisLabel.Size = new System.Drawing.Size(30, 13);
            paisLabel.TabIndex = 11;
            paisLabel.Text = "Pais:";
            // 
            // valorfacialLabel
            // 
            valorfacialLabel.AutoSize = true;
            valorfacialLabel.Location = new System.Drawing.Point(50, 212);
            valorfacialLabel.Name = "valorfacialLabel";
            valorfacialLabel.Size = new System.Drawing.Size(65, 13);
            valorfacialLabel.TabIndex = 13;
            valorfacialLabel.Text = "Valor Facial:";
            // 
            // qtdstockLabel
            // 
            qtdstockLabel.AutoSize = true;
            qtdstockLabel.Location = new System.Drawing.Point(11, 238);
            qtdstockLabel.Name = "qtdstockLabel";
            qtdstockLabel.Size = new System.Drawing.Size(105, 13);
            qtdstockLabel.TabIndex = 15;
            qtdstockLabel.Text = "Quantidae de Stock:";
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CorrespondenteTableAdapter = null;
            this.tableAdapterManager.ligaçãoTableAdapter = null;
            this.tableAdapterManager.loginTableAdapter = null;
            this.tableAdapterManager.SeloTableAdapter = this.seloTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // seloBindingNavigator
            // 
            this.seloBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.seloBindingNavigator.BindingSource = this.seloBindingSource;
            this.seloBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.seloBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.seloBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.seloBindingNavigatorSaveItem});
            this.seloBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.seloBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.seloBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.seloBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.seloBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.seloBindingNavigator.Name = "seloBindingNavigator";
            this.seloBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.seloBindingNavigator.Size = new System.Drawing.Size(411, 25);
            this.seloBindingNavigator.TabIndex = 0;
            this.seloBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // seloBindingNavigatorSaveItem
            // 
            this.seloBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.seloBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("seloBindingNavigatorSaveItem.Image")));
            this.seloBindingNavigatorSaveItem.Name = "seloBindingNavigatorSaveItem";
            this.seloBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.seloBindingNavigatorSaveItem.Text = "Save Data";
            this.seloBindingNavigatorSaveItem.Click += new System.EventHandler(this.seloBindingNavigatorSaveItem_Click);
            // 
            // numeroserieTextBox
            // 
            this.numeroserieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seloBindingSource, "numeroserie", true));
            this.numeroserieTextBox.Location = new System.Drawing.Point(116, 53);
            this.numeroserieTextBox.Name = "numeroserieTextBox";
            this.numeroserieTextBox.Size = new System.Drawing.Size(200, 20);
            this.numeroserieTextBox.TabIndex = 2;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seloBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(116, 79);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomeTextBox.TabIndex = 4;
            // 
            // serieTextBox
            // 
            this.serieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seloBindingSource, "serie", true));
            this.serieTextBox.Location = new System.Drawing.Point(116, 105);
            this.serieTextBox.Name = "serieTextBox";
            this.serieTextBox.Size = new System.Drawing.Size(200, 20);
            this.serieTextBox.TabIndex = 6;
            // 
            // corTextBox
            // 
            this.corTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seloBindingSource, "cor", true));
            this.corTextBox.Location = new System.Drawing.Point(116, 131);
            this.corTextBox.Name = "corTextBox";
            this.corTextBox.Size = new System.Drawing.Size(200, 20);
            this.corTextBox.TabIndex = 8;
            // 
            // anoDateTimePicker
            // 
            this.anoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.seloBindingSource, "ano", true));
            this.anoDateTimePicker.Location = new System.Drawing.Point(116, 157);
            this.anoDateTimePicker.Name = "anoDateTimePicker";
            this.anoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.anoDateTimePicker.TabIndex = 10;
            // 
            // paisTextBox
            // 
            this.paisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seloBindingSource, "pais", true));
            this.paisTextBox.Location = new System.Drawing.Point(116, 183);
            this.paisTextBox.Name = "paisTextBox";
            this.paisTextBox.Size = new System.Drawing.Size(200, 20);
            this.paisTextBox.TabIndex = 12;
            // 
            // valorfacialTextBox
            // 
            this.valorfacialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seloBindingSource, "valorfacial", true));
            this.valorfacialTextBox.Location = new System.Drawing.Point(116, 209);
            this.valorfacialTextBox.Name = "valorfacialTextBox";
            this.valorfacialTextBox.Size = new System.Drawing.Size(200, 20);
            this.valorfacialTextBox.TabIndex = 14;
            // 
            // qtdstockTextBox
            // 
            this.qtdstockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seloBindingSource, "qtdstock", true));
            this.qtdstockTextBox.Location = new System.Drawing.Point(116, 235);
            this.qtdstockTextBox.Name = "qtdstockTextBox";
            this.qtdstockTextBox.Size = new System.Drawing.Size(200, 20);
            this.qtdstockTextBox.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // inserirselo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 304);
            this.Controls.Add(this.button2);
            this.Controls.Add(numeroserieLabel);
            this.Controls.Add(this.numeroserieTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(serieLabel);
            this.Controls.Add(this.serieTextBox);
            this.Controls.Add(corLabel);
            this.Controls.Add(this.corTextBox);
            this.Controls.Add(anoLabel);
            this.Controls.Add(this.anoDateTimePicker);
            this.Controls.Add(paisLabel);
            this.Controls.Add(this.paisTextBox);
            this.Controls.Add(valorfacialLabel);
            this.Controls.Add(this.valorfacialTextBox);
            this.Controls.Add(qtdstockLabel);
            this.Controls.Add(this.qtdstockTextBox);
            this.Controls.Add(this.seloBindingNavigator);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "inserirselo";
            this.Text = "Inserir Selo";
            this.Load += new System.EventHandler(this.inserirselo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seloBindingNavigator)).EndInit();
            this.seloBindingNavigator.ResumeLayout(false);
            this.seloBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource seloBindingSource;
        private Database1DataSetTableAdapters.SeloTableAdapter seloTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator seloBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton seloBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox numeroserieTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox serieTextBox;
        private System.Windows.Forms.TextBox corTextBox;
        private System.Windows.Forms.DateTimePicker anoDateTimePicker;
        private System.Windows.Forms.TextBox paisTextBox;
        private System.Windows.Forms.TextBox valorfacialTextBox;
        private System.Windows.Forms.TextBox qtdstockTextBox;
        private System.Windows.Forms.Button button2;
    }
}