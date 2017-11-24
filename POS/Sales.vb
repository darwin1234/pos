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

    Private Sub prodlist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles prodlist.CellContentClick
        UpdateProduct.productID.Text = prodlist.CurrentRow.Cells(0).Value
        UpdateProduct.code.Text = prodlist.CurrentRow.Cells(1).Value
        UpdateProduct.gen.Text = prodlist.CurrentRow.Cells(2).Value
        UpdateProduct.nameCat.Text = prodlist.CurrentRow.Cells(3).Value
        UpdateProduct.date_arrival.Text = prodlist.CurrentRow.Cells(4).Value
        UpdateProduct.exdate.Text = prodlist.CurrentRow.Cells(5).Value
        UpdateProduct.price.Text = prodlist.CurrentRow.Cells(6).Value
        UpdateProduct.o_price.Text = prodlist.CurrentRow.Cells(7).Value
        UpdateProduct.profit.Text = prodlist.CurrentRow.Cells(8).Value
        UpdateProduct.supplier.Text = prodlist.CurrentRow.Cells(9).Value
        UpdateProduct.qty.Text = prodlist.CurrentRow.Cells(10).Value
        UpdateProduct.sold.Text = prodlist.CurrentRow.Cells(11).Value
    End Sub
End Class