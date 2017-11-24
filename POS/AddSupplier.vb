Imports MySql.Data.MySqlClient
Public Class AddSupplier
    Dim cn As New MySqlConnection
    Dim Command As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim SQL As String
    Dim result As Integer
    Dim tableData As New DataTable
    Dim productAppter As New MySqlDataAdapter
    Dim SupplierData As New DataTable
    Dim result1 As Integer

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click


        With Command
            .Connection = cn
            .CommandText = "INSERT INTO supliers (suplier_name,suplier_address,suplier_contact, contact_person,note) VALUES(@suplier_name,@suplier_address,@suplier_contact, @contact_person,@note)"
            .Parameters.AddWithValue("@suplier_name", suppliername.Text)
            .Parameters.AddWithValue("@suplier_address", address.Text)
            .Parameters.AddWithValue("@suplier_contact", cperson.Text)
            .Parameters.AddWithValue("@contact_person", contact.Text)
            .Parameters.AddWithValue("@note", note.Text)

            result1 = Command.ExecuteNonQuery
            If result1 = 0 Then
                MsgBox("Data has been Inserted!")

            Else
                .CommandText = "SELECT  suplier_name AS Supplier , contact_person AS ContactPerson , suplier_address AS Address, suplier_contact AS ContactNo ,note AS Note  FROM  supliers ORDER BY suplier_id DESC"
                productAppter.SelectCommand = Command
                productAppter.Fill(tableData)
                Supplier.DataGridView12.DataSource = tableData
                MsgBox("Successfully saved!")

            End If
        End With

    End Sub

    Private Sub AddSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Server=localhost;Database=pos2;Uid=root;Pwd=;"
        Command.Connection = cn
        cn.Open()
    End Sub
End Class