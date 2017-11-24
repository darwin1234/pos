Imports MySql.Data.MySqlClient

Public Class Product
    Dim cn As MySqlConnection
    Dim command As New MySqlCommand
    Dim productAppter As New MySqlDataAdapter
    Dim ContactsData As New DataTable
    Dim SQL As String

    Private Sub Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New MySqlConnection()

        ' Define the SQL to grab data from table.
        SQL = "SELECT  product_id AS ID ,  product_code AS BrandName,  gen_name AS GenericName , product_name AS Category,  supplier AS Supplier,date_arrival AS DateRecieved, expiry_date AS ExpiryDate,  o_price AS OriginalPrice, price AS SellingPrice, qty_sold AS QTY, qty AS QuantityLeft,(price* qty) AS Total FROM products"

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

            DTGLIST.DataSource = ContactsData

        Catch myerror As MySqlException
            MessageBox.Show("Cannot connect to database: " & myerror.Message)
        Finally
            cn.Close()
            cn.Dispose()
        End Try


    End Sub

    Private Sub AddProductBtn_Click(sender As Object, e As EventArgs) Handles AddProductBtn.Click
        AddProduct.MdiParent = mainpos
        AddProduct.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        UpdateProduct.MdiParent = mainpos
        UpdateProduct.Show()
    End Sub



    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DTGLIST.DoubleClick
        UpdateProduct.productID.Text = DTGLIST.CurrentRow.Cells(0).Value
        UpdateProduct.code.Text = DTGLIST.CurrentRow.Cells(1).Value
        UpdateProduct.gen.Text = DTGLIST.CurrentRow.Cells(2).Value
        UpdateProduct.nameCat.Text = DTGLIST.CurrentRow.Cells(3).Value
        UpdateProduct.date_arrival.Text = DTGLIST.CurrentRow.Cells(4).Value
        UpdateProduct.exdate.Text = DTGLIST.CurrentRow.Cells(5).Value
        UpdateProduct.price.Text = DTGLIST.CurrentRow.Cells(6).Value
        UpdateProduct.o_price.Text = DTGLIST.CurrentRow.Cells(7).Value
        UpdateProduct.profit.Text = DTGLIST.CurrentRow.Cells(8).Value
        UpdateProduct.supplier.Text = DTGLIST.CurrentRow.Cells(9).Value
        UpdateProduct.qty.Text = DTGLIST.CurrentRow.Cells(10).Value
        UpdateProduct.sold.Text = DTGLIST.CurrentRow.Cells(11).Value
    End Sub

    Private Sub DTGLIST_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTGLIST.CellContentClick


    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim ID As Integer
        ID = DTGLIST.CurrentRow.Cells(0).Value
        delete(" delete From products Where product_id = '" & ID & "'")
        reload("SELECT  product_id AS ID ,  product_code AS BrandName,  gen_name AS GenericName , product_name AS Category,  supplier AS Supplier,date_arrival AS DateRecieved, expiry_date AS ExpiryDate,  o_price AS OriginalPrice, price AS SellingPrice, qty_sold AS QTY, qty AS QuantityLeft,(price* qty) AS Total FROM products", Me.DTGLIST)

    End Sub

    Private Sub Searchtext_TextChanged(sender As Object, e As EventArgs) Handles Searchtext.TextChanged
        reload("SELECT * FROM products WHERE product_code LIKE '" & Searchtext.Text & "%' ", Me.DTGLIST)

    End Sub
End Class