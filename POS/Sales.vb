Public Class Sales
    Dim ProducTDInfo As Integer
    Dim invoice_ As Integer
    Dim product_ As String
    Dim qty_ As Integer
    Dim amount_ As Integer
    Dim profit_ As Integer
    Dim productcode_ As String
    Dim genname_ As String
    Dim name_ As String
    Dim price_ As Integer
    Dim discount_ As Integer
    Dim date_ As Date


    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload("SELECT  product_id AS ID ,  product_code AS BrandName,  gen_name AS GenericName , product_name AS Category,  supplier AS Supplier,date_arrival AS DateRecieved, expiry_date AS ExpiryDate,  o_price AS OriginalPrice, price AS SellingPrice, qty_sold AS QTY, qty AS QuantityLeft,(price* qty) AS Total FROM products", Me.prodlist)
    End Sub

    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click

        create("INSERT INTO sales_order (`transaction_id`,`invoice`,`product`,`qty`, `amount`, `profit`, `product_code`, `gen_name`,`name`, `price`, `discount`, `date`) " _
                               & "VALUES('','" & invoice_ & "','" & product_ & "','" & qty_ & "', '" & amount_ & "', '" & profit_ & "', '" & productcode_ & "', '" & genname_ & "','" & name_ & "', '" & price_ & "', '" & discount_ & "', '7/3/1990')")
        ' reload("SELECT  product_id AS ID ,  product_code AS BrandName,  gen_name AS GenericName , product_name AS Category,  supplier AS Supplier,date_arrival AS DateRecieved, expiry_date AS ExpiryDate,  o_price AS OriginalPrice, price AS SellingPrice, qty_sold AS QTY, qty AS QuantityLeft,(price* qty) AS Total FROM sales_order", Product.DTGLIST)

    End Sub

    Private Sub Searchtext1_TextChanged(sender As Object, e As EventArgs) Handles Searchtext1.TextChanged
        reload("SELECT * FROM products WHERE product_code LIKE '" & Searchtext1.Text & "%' ", Me.prodlist)
    End Sub

    Private Sub prodlist_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles prodlist.DoubleClick
        ProducTDInfo = prodlist.CurrentRow.Cells(0).Value

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        cash.MdiParent = mainpos
        cash.Show()
    End Sub
End Class