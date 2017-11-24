<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddSupplier
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.suppliername = New System.Windows.Forms.TextBox()
        Me.address = New System.Windows.Forms.TextBox()
        Me.contact = New System.Windows.Forms.TextBox()
        Me.cperson = New System.Windows.Forms.TextBox()
        Me.note = New System.Windows.Forms.RichTextBox()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'suppliername
        '
        Me.suppliername.Location = New System.Drawing.Point(100, 23)
        Me.suppliername.Name = "suppliername"
        Me.suppliername.Size = New System.Drawing.Size(205, 20)
        Me.suppliername.TabIndex = 0
        '
        'address
        '
        Me.address.Location = New System.Drawing.Point(100, 69)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(205, 20)
        Me.address.TabIndex = 1
        '
        'contact
        '
        Me.contact.Location = New System.Drawing.Point(100, 164)
        Me.contact.Name = "contact"
        Me.contact.Size = New System.Drawing.Size(205, 20)
        Me.contact.TabIndex = 2
        '
        'cperson
        '
        Me.cperson.Location = New System.Drawing.Point(100, 111)
        Me.cperson.Name = "cperson"
        Me.cperson.Size = New System.Drawing.Size(205, 20)
        Me.cperson.TabIndex = 3
        '
        'note
        '
        Me.note.Location = New System.Drawing.Point(100, 213)
        Me.note.Name = "note"
        Me.note.Size = New System.Drawing.Size(205, 96)
        Me.note.TabIndex = 4
        Me.note.Text = ""
        '
        'savebtn
        '
        Me.savebtn.Location = New System.Drawing.Point(100, 340)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(205, 48)
        Me.savebtn.TabIndex = 5
        Me.savebtn.Text = "Save"
        Me.savebtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Supplier Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Address :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Address :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Contact Person :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Contact No. :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Note :"
        '
        'AddSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 402)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.note)
        Me.Controls.Add(Me.cperson)
        Me.Controls.Add(Me.contact)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.suppliername)
        Me.Name = "AddSupplier"
        Me.Text = "AddSupplier"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents suppliername As TextBox
    Friend WithEvents address As TextBox
    Friend WithEvents contact As TextBox
    Friend WithEvents cperson As TextBox
    Friend WithEvents note As RichTextBox
    Friend WithEvents savebtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
