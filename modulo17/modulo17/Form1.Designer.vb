<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Database1DataSet = New modulo17.Database1DataSet()
        Me.SeloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeloTableAdapter = New modulo17.Database1DataSetTableAdapters.SeloTableAdapter()
        Me.NumeroserieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SerieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorfacialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtdstockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroserieDataGridViewTextBoxColumn, Me.NomeDataGridViewTextBoxColumn, Me.SerieDataGridViewTextBoxColumn, Me.CorDataGridViewTextBoxColumn, Me.AnoDataGridViewTextBoxColumn, Me.PaisDataGridViewTextBoxColumn, Me.ValorfacialDataGridViewTextBoxColumn, Me.QtdstockDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SeloBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(853, 278)
        Me.DataGridView1.TabIndex = 0
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SeloBindingSource
        '
        Me.SeloBindingSource.DataMember = "Selo"
        Me.SeloBindingSource.DataSource = Me.Database1DataSet
        '
        'SeloTableAdapter
        '
        Me.SeloTableAdapter.ClearBeforeFill = True
        '
        'NumeroserieDataGridViewTextBoxColumn
        '
        Me.NumeroserieDataGridViewTextBoxColumn.DataPropertyName = "numeroserie"
        Me.NumeroserieDataGridViewTextBoxColumn.HeaderText = "numeroserie"
        Me.NumeroserieDataGridViewTextBoxColumn.Name = "NumeroserieDataGridViewTextBoxColumn"
        '
        'NomeDataGridViewTextBoxColumn
        '
        Me.NomeDataGridViewTextBoxColumn.DataPropertyName = "nome"
        Me.NomeDataGridViewTextBoxColumn.HeaderText = "nome"
        Me.NomeDataGridViewTextBoxColumn.Name = "NomeDataGridViewTextBoxColumn"
        '
        'SerieDataGridViewTextBoxColumn
        '
        Me.SerieDataGridViewTextBoxColumn.DataPropertyName = "serie"
        Me.SerieDataGridViewTextBoxColumn.HeaderText = "serie"
        Me.SerieDataGridViewTextBoxColumn.Name = "SerieDataGridViewTextBoxColumn"
        '
        'CorDataGridViewTextBoxColumn
        '
        Me.CorDataGridViewTextBoxColumn.DataPropertyName = "cor"
        Me.CorDataGridViewTextBoxColumn.HeaderText = "cor"
        Me.CorDataGridViewTextBoxColumn.Name = "CorDataGridViewTextBoxColumn"
        '
        'AnoDataGridViewTextBoxColumn
        '
        Me.AnoDataGridViewTextBoxColumn.DataPropertyName = "ano"
        Me.AnoDataGridViewTextBoxColumn.HeaderText = "ano"
        Me.AnoDataGridViewTextBoxColumn.Name = "AnoDataGridViewTextBoxColumn"
        '
        'PaisDataGridViewTextBoxColumn
        '
        Me.PaisDataGridViewTextBoxColumn.DataPropertyName = "pais"
        Me.PaisDataGridViewTextBoxColumn.HeaderText = "pais"
        Me.PaisDataGridViewTextBoxColumn.Name = "PaisDataGridViewTextBoxColumn"
        '
        'ValorfacialDataGridViewTextBoxColumn
        '
        Me.ValorfacialDataGridViewTextBoxColumn.DataPropertyName = "valorfacial"
        Me.ValorfacialDataGridViewTextBoxColumn.HeaderText = "valorfacial"
        Me.ValorfacialDataGridViewTextBoxColumn.Name = "ValorfacialDataGridViewTextBoxColumn"
        '
        'QtdstockDataGridViewTextBoxColumn
        '
        Me.QtdstockDataGridViewTextBoxColumn.DataPropertyName = "qtdstock"
        Me.QtdstockDataGridViewTextBoxColumn.HeaderText = "qtdstock"
        Me.QtdstockDataGridViewTextBoxColumn.Name = "QtdstockDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 278)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Database1DataSet As modulo17.Database1DataSet
    Friend WithEvents SeloBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SeloTableAdapter As modulo17.Database1DataSetTableAdapters.SeloTableAdapter
    Friend WithEvents NumeroserieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SerieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorfacialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtdstockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
