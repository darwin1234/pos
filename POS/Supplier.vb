Imports MySql.Data.MySqlClient

Public Class Supplier
    Dim cn As MySqlConnection
    Dim command As New MySqlCommand
    Dim productAppter As New MySqlDataAdapter
    Dim ContactsData As New DataTable
    Dim SQL As String

    Private Sub Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload("SELECT * FROM supliers", Me.DataGridView12)
    End Sub

    Private Sub addsupplierbtn_Click(sender As Object, e As EventArgs) Handles addsupplierbtn.Click
        AddSupplier.MdiParent = mainpos
        AddSupplier.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        reload("SELECT * FROM supliers WHERE suplier_name LIKE '" & TextBox1.Text & "%' ", Me.DataGridView12)
    End Sub

    Private Sub DataGridView12_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView12.DoubleClick
        UpdateSupplier.suppliername.Text = DataGridView12.CurrentRow.Cells(0).Value
        UpdateSupplier.address.Text = DataGridView12.CurrentRow.Cells(1).Value
        UpdateSupplier.cperson.Text = DataGridView12.CurrentRow.Cells(2).Value
        UpdateSupplier.contact.Text = DataGridView12.CurrentRow.Cells(3).Value
        UpdateSupplier.note.Text = DataGridView12.CurrentRow.Cells(4).Value
    End Sub

    Private Sub editbtn_Click(sender As Object, e As EventArgs) Handles editbtn.Click
        UpdateSupplier.MdiParent = mainpos
        UpdateSupplier.Show()
    End Sub
End Class