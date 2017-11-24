Public Class Dashboard
    Private Sub Productbtn_Click(sender As Object, e As EventArgs) Handles Productbtn.Click
        Product.MdiParent = mainpos
        Product.Show()
    End Sub

    Private Sub SuppliersBtn_Click(sender As Object, e As EventArgs) Handles SuppliersBtn.Click
        Supplier.MdiParent = mainpos
        Supplier.Show()


    End Sub

    Private Sub Salesbtn_Click(sender As Object, e As EventArgs) Handles Salesbtn.Click
        Sales.MdiParent = mainpos
        Sales.Show()

    End Sub
End Class