Public Class UpdateSupplier
    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        updates("UPDATE supliers SET `suplier_name` = '" & suppliername.Text & "' ,`suplier_address` = '" & address.Text & "', `suplier_address` = '" & cperson.Text & "' , `suplier_contact` = '" & contact.Text & "' ,`note` = '" & note.Text & "'  WHERE suplier_id ='" & SuplierID.Text & "'")
        reload("SELECT * FROM supliers", Supplier.DataGridView12)
    End Sub
End Class