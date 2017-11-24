Imports MySql.Data.MySqlClient

Public Class Supplier
    Dim cn As MySqlConnection
    Dim command As New MySqlCommand
    Dim productAppter As New MySqlDataAdapter
    Dim ContactsData As New DataTable
    Dim SQL As String

    Private Sub Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New MySqlConnection()



        SQL = "SELECT suplier_name AS Supplier , contact_person AS ContactPerson , suplier_address AS Address, suplier_contact AS ContactNo ,note AS Note FROM  supliers ORDER BY suplier_id DESC"

        'Connection String
        cn.ConnectionString = "server=localhost;" _
        & "user id=root;" _
        & "password=;" _
        & "database=pos2"

        ' Try, Catch, Finally
        Try
            cn.Open()

            command.Connection = cn
            command.CommandText = SQL

            productAppter.SelectCommand = command
            productAppter.Fill(ContactsData)

            DataGridView12.DataSource = ContactsData

        Catch myerror As MySqlException
            MessageBox.Show("Cannot connect to database: " & myerror.Message)
        Finally
            cn.Close()
            cn.Dispose()
        End Try
    End Sub

    Private Sub addsupplierbtn_Click(sender As Object, e As EventArgs) Handles addsupplierbtn.Click
        AddSupplier.MdiParent = mainpos
        AddSupplier.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        reload("SELECT * FROM products WHERE product_code LIKE '" & TextBox1.Text & "%' ", Me.DataGridView12)
    End Sub
End Class