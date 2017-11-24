<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.LogoutBtn = New System.Windows.Forms.Button()
        Me.SalesReportbtn = New System.Windows.Forms.Button()
        Me.SuppliersBtn = New System.Windows.Forms.Button()
        Me.customersbtn = New System.Windows.Forms.Button()
        Me.Productbtn = New System.Windows.Forms.Button()
        Me.Salesbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LogoutBtn
        '
        Me.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogoutBtn.Location = New System.Drawing.Point(495, 216)
        Me.LogoutBtn.Name = "LogoutBtn"
        Me.LogoutBtn.Size = New System.Drawing.Size(192, 84)
        Me.LogoutBtn.TabIndex = 11
        Me.LogoutBtn.Text = "Logout"
        Me.LogoutBtn.UseVisualStyleBackColor = True
        '
        'SalesReportbtn
        '
        Me.SalesReportbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SalesReportbtn.Location = New System.Drawing.Point(252, 216)
        Me.SalesReportbtn.Name = "SalesReportbtn"
        Me.SalesReportbtn.Size = New System.Drawing.Size(194, 84)
        Me.SalesReportbtn.TabIndex = 10
        Me.SalesReportbtn.Text = "Sales Report"
        Me.SalesReportbtn.UseVisualStyleBackColor = True
        '
        'SuppliersBtn
        '
        Me.SuppliersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SuppliersBtn.Location = New System.Drawing.Point(16, 216)
        Me.SuppliersBtn.Name = "SuppliersBtn"
        Me.SuppliersBtn.Size = New System.Drawing.Size(186, 84)
        Me.SuppliersBtn.TabIndex = 9
        Me.SuppliersBtn.Text = "Suppliers"
        Me.SuppliersBtn.UseVisualStyleBackColor = True
        '
        'customersbtn
        '
        Me.customersbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.customersbtn.Location = New System.Drawing.Point(495, 96)
        Me.customersbtn.Name = "customersbtn"
        Me.customersbtn.Size = New System.Drawing.Size(192, 88)
        Me.customersbtn.TabIndex = 8
        Me.customersbtn.Text = "Customers"
        Me.customersbtn.UseVisualStyleBackColor = True
        '
        'Productbtn
        '
        Me.Productbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Productbtn.Location = New System.Drawing.Point(252, 96)
        Me.Productbtn.Name = "Productbtn"
        Me.Productbtn.Size = New System.Drawing.Size(194, 88)
        Me.Productbtn.TabIndex = 7
        Me.Productbtn.Text = "Product"
        Me.Productbtn.UseVisualStyleBackColor = True
        '
        'Salesbtn
        '
        Me.Salesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Salesbtn.Location = New System.Drawing.Point(16, 96)
        Me.Salesbtn.Name = "Salesbtn"
        Me.Salesbtn.Size = New System.Drawing.Size(186, 88)
        Me.Salesbtn.TabIndex = 6
        Me.Salesbtn.Text = "Sales"
        Me.Salesbtn.UseVisualStyleBackColor = True
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 396)
        Me.Controls.Add(Me.LogoutBtn)
        Me.Controls.Add(Me.SalesReportbtn)
        Me.Controls.Add(Me.SuppliersBtn)
        Me.Controls.Add(Me.customersbtn)
        Me.Controls.Add(Me.Productbtn)
        Me.Controls.Add(Me.Salesbtn)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LogoutBtn As Button
    Friend WithEvents SalesReportbtn As Button
    Friend WithEvents SuppliersBtn As Button
    Friend WithEvents customersbtn As Button
    Friend WithEvents Productbtn As Button
    Friend WithEvents Salesbtn As Button
End Class
