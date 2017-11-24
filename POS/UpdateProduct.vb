Public Class UpdateProduct

    Private Sub UpdateProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cn.ConnectionString = "Server=localhost;Database=pos2;Uid=root;Pwd=;"
        'cn.Open()
        ' With Command
        '.Connection = cn
        '.CommandText = "SELECT product_code,product_name,expiry_date,price,supplier,qty,o_price,profit,gen_name,date_arrival,qty_sold FROM products WHERE product_id ='" & productID.Text & "'"
        'reader = Command.ExecuteReader
        'While reader.Read()
        'code.Text = reader.GetString("product_code")
        'gen.Text = reader.GetString("gen_name")
        'nameCat.Text = reader.GetString("product_name")
        'date_arrival.Text = reader.GetString("date_arrival")
        'exdate.Text = reader.GetString("expiry_date")
        'price.Text = reader.GetString("price")
        'o_price.Text = reader.GetString("o_price")
        'profit.Text = reader.GetString("profit")
        'supplier.Text = reader.GetString("supplier")
        'qty.Text = reader.GetString("qty")
        'sold.Text = reader.GetString("qty_sold")
        'End While
        'End With

    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        Try
            'CALL THE METHOD THAT YOU HAVE CREATED 
            'AND PUT YOUR QUERY IN THE PARAMETER FOR UPDATING THE DATA IN THE DATABASE

            updates("UPDATE products SET `product_code` = '" & code.Text & "', `gen_name` = '" & gen.Text & "' WHERE product_id ='" & productID.Text & "'")
            reload("SELECT  product_id AS ID ,  product_code AS BrandName,  gen_name AS GenericName , product_name AS Category,  supplier AS Supplier,date_arrival AS DateRecieved, expiry_date AS ExpiryDate,  o_price AS OriginalPrice, price AS SellingPrice, qty_sold AS QTY, qty AS QuantityLeft,(price* qty) AS Total FROM products", Product.DTGLIST)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class