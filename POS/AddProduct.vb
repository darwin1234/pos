Imports MySql.Data.MySqlClient

Public Class AddProduct





    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click

        create("INSERT INTO products (product_code,product_name,expiry_date,price,supplier,qty,o_price,profit,gen_name,date_arrival,qty_sold) VALUES('" & code.Text & "','" & nameCat.Text & "','" & exdate.Text & "','" & price.Text & "','" & supplier.Text & "','" & qty.Text & "','" & o_price.Text & "','" & profit.Text & "','" & gen.Text & "','" & date_arrival.Text & "','" & qty_sold.Text & "')")
        reload("SELECT  product_id AS ID ,  product_code AS BrandName,  gen_name AS GenericName , product_name AS Category,  supplier AS Supplier,date_arrival AS DateRecieved, expiry_date AS ExpiryDate,  o_price AS OriginalPrice, price AS SellingPrice, qty_sold AS QTY, qty AS QuantityLeft,(price* qty) AS Total FROM products", Product.DTGLIST)


    End Sub

    Private Sub AddProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strcon.Open()
        With cmd
            .Connection = strcon
            .CommandText = "SELECT suplier_name AS Supplier FROM  supliers ORDER BY suplier_id DESC"
            reader = cmd.ExecuteReader
            While reader.Read()
                supplier.Items.Add(reader.GetString("Supplier"))
            End While

        End With

    End Sub


End Class