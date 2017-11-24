<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Supplier
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView12 = New System.Windows.Forms.DataGridView()
        Me.addsupplierbtn = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.deletebtn = New System.Windows.Forms.Button()
        Me.editbtn = New System.Windows.Forms.Button()
        CType(Me.DataGridView12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView12
        '
        Me.DataGridView12.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView12.Location = New System.Drawing.Point(12, 95)
        Me.DataGridView12.Name = "DataGridView12"
        Me.DataGridView12.Size = New System.Drawing.Size(578, 236)
        Me.DataGridView12.TabIndex = 1
        '
        'addsupplierbtn
        '
        Me.addsupplierbtn.Location = New System.Drawing.Point(460, 31)
        Me.addsupplierbtn.Name = "addsupplierbtn"
        Me.addsupplierbtn.Size = New System.Drawing.Size(128, 33)
        Me.addsupplierbtn.TabIndex = 2
        Me.addsupplierbtn.Text = "Add Supplier"
        Me.addsupplierbtn.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(442, 20)
        Me.TextBox1.TabIndex = 3
        '
        'deletebtn
        '
        Me.deletebtn.Location = New System.Drawing.Point(396, 361)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(92, 38)
        Me.deletebtn.TabIndex = 4
        Me.deletebtn.Text = "Delete"
        Me.deletebtn.UseVisualStyleBackColor = True
        '
        'editbtn
        '
        Me.editbtn.Location = New System.Drawing.Point(494, 361)
        Me.editbtn.Name = "editbtn"
        Me.editbtn.Size = New System.Drawing.Size(94, 38)
        Me.editbtn.TabIndex = 5
        Me.editbtn.Text = "EDIT"
        Me.editbtn.UseVisualStyleBackColor = True
        '
        'Supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 406)
        Me.Controls.Add(Me.editbtn)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.addsupplierbtn)
        Me.Controls.Add(Me.DataGridView12)
        Me.Name = "Supplier"
        Me.Text = "Supplier"
        CType(Me.DataGridView12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView12 As DataGridView
    Friend WithEvents addsupplierbtn As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents deletebtn As Button
    Friend WithEvents editbtn As Button
End Class
