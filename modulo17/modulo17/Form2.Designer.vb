﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InserirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColeçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InserirSeloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InserirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(586, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InserirToolStripMenuItem
        '
        Me.InserirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColeçãoToolStripMenuItem, Me.InserirSeloToolStripMenuItem})
        Me.InserirToolStripMenuItem.Name = "InserirToolStripMenuItem"
        Me.InserirToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.InserirToolStripMenuItem.Text = "Inserir"
        '
        'ColeçãoToolStripMenuItem
        '
        Me.ColeçãoToolStripMenuItem.Name = "ColeçãoToolStripMenuItem"
        Me.ColeçãoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ColeçãoToolStripMenuItem.Text = "Coleção"
        '
        'InserirSeloToolStripMenuItem
        '
        Me.InserirSeloToolStripMenuItem.Name = "InserirSeloToolStripMenuItem"
        Me.InserirSeloToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.InserirSeloToolStripMenuItem.Text = "Inserir Selo"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 384)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InserirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColeçãoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InserirSeloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
