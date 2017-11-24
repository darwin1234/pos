<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product
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
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.AddProductBtn = New System.Windows.Forms.Button()
        Me.Searchtext = New System.Windows.Forms.TextBox()
        Me.DTGLIST = New System.Windows.Forms.DataGridView()
        CType(Me.DTGLIST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnDelete
        '
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Location = New System.Drawing.Point(726, 540)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(128, 34)
        Me.BtnDelete.TabIndex = 12
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Location = New System.Drawing.Point(559, 540)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(135, 34)
        Me.btnEdit.TabIndex = 11
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'AddProductBtn
        '
        Me.AddProductBtn.Location = New System.Drawing.Point(666, 30)
        Me.AddProductBtn.Name = "AddProductBtn"
        Me.AddProductBtn.Size = New System.Drawing.Size(188, 44)
        Me.AddProductBtn.TabIndex = 10
        Me.AddProductBtn.Text = "Add Product"
        Me.AddProductBtn.UseVisualStyleBackColor = True
        '
        'Searchtext
        '
        Me.Searchtext.Location = New System.Drawing.Point(12, 30)
        Me.Searchtext.Name = "Searchtext"
        Me.Searchtext.Size = New System.Drawing.Size(640, 20)
        Me.Searchtext.TabIndex = 7
        '
        'DTGLIST
        '
        Me.DTGLIST.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DTGLIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGLIST.Location = New System.Drawing.Point(6, 103)
        Me.DTGLIST.Name = "DTGLIST"
        Me.DTGLIST.Size = New System.Drawing.Size(848, 349)
        Me.DTGLIST.TabIndex = 18
        '
        'Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 586)
        Me.Controls.Add(Me.DTGLIST)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.AddProductBtn)
        Me.Controls.Add(Me.Searchtext)
        Me.Name = "Product"
        Me.Text = "Product"
        CType(Me.DTGLIST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents AddProductBtn As Button
    Friend WithEvents Searchtext As TextBox
    Friend WithEvents DTGLIST As DataGridView
End Class
