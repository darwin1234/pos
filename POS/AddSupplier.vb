Imports MySql.Data.MySqlClient
Public Class AddSupplier

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        create("INSERT INTO supliers (suplier_name,suplier_address,suplier_contact, contact_person,note) VALUES('" & suppliername.Text & "','" & address.Text & "','" & cperson.Text & "','" & contact.Text & "','" & note.Text & "')")
        reload("SELECT suplier_name,suplier_address,suplier_contact, contact_person,note  FROM supliers", Supplier.DataGridView12)
    End Sub


End Class