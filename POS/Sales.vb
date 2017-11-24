Public Class Sales
    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload("SELECT  product_id AS ID ,  product_code AS BrandName,  gen_name AS GenericName , product_name AS Category,  supplier AS Supplier,date_arrival AS DateRecieved, expiry_date AS ExpiryDate,  o_price AS OriginalPrice, price AS SellingPrice, qty_sold AS QTY, qty AS QuantityLeft,(price* qty) AS Total FROM products", Me.prodlist)
    End Sub

    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        cash.MdiParent = mainpos
        cash.Show()
    End Sub

    Private Sub Searchtext1_TextChanged(sender As Object, e As EventArgs) Handles Searchtext1.TextChanged
        reload("SELECT * FROM products WHERE product_code LIKE '" & Searchtext1.Text & "%' ", Me.prodlist)
    End Sub
End Class