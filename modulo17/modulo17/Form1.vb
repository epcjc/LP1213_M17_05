Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Selo' table. You can move, or remove it, as needed.
        Me.SeloTableAdapter.Fill(Me.Database1DataSet.Selo)

    End Sub
End Class
