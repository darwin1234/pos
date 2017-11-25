<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales
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
        Me.prodlist = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.productname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.genericname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categorydescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.profit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Searchtext1 = New System.Windows.Forms.TextBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.addbtn = New System.Windows.Forms.Button()
        Me.prodname = New System.Windows.Forms.TextBox()
        Me.genname = New System.Windows.Forms.TextBox()
        Me.catdesc = New System.Windows.Forms.TextBox()
        Me.priceinfo = New System.Windows.Forms.TextBox()
        Me.qtyinfo = New System.Windows.Forms.TextBox()
        Me.amountinfo = New System.Windows.Forms.TextBox()
        Me.profitinfo = New System.Windows.Forms.TextBox()
        CType(Me.prodlist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'prodlist
        '
        Me.prodlist.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.prodlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.prodlist.Location = New System.Drawing.Point(12, 66)
        Me.prodlist.Name = "prodlist"
        Me.prodlist.Size = New System.Drawing.Size(858, 80)
        Me.prodlist.TabIndex = 19
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.productname, Me.genericname, Me.categorydescription, Me.price, Me.qty, Me.amount, Me.profit})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 166)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(858, 161)
        Me.DataGridView1.TabIndex = 20
        '
        'productname
        '
        Me.productname.HeaderText = "Product Name "
        Me.productname.Name = "productname"
        '
        'genericname
        '
        Me.genericname.HeaderText = "Generic Name"
        Me.genericname.Name = "genericname"
        '
        'categorydescription
        '
        Me.categorydescription.HeaderText = "Category Description"
        Me.categorydescription.Name = "categorydescription"
        '
        'price
        '
        Me.price.HeaderText = "Price"
        Me.price.Name = "price"
        '
        'qty
        '
        Me.qty.HeaderText = "Qty"
        Me.qty.Name = "qty"
        '
        'amount
        '
        Me.amount.HeaderText = "Amount"
        Me.amount.Name = "amount"
        '
        'profit
        '
        Me.profit.HeaderText = "Profit"
        Me.profit.Name = "profit"
        '
        'Searchtext1
        '
        Me.Searchtext1.Location = New System.Drawing.Point(12, 23)
        Me.Searchtext1.Name = "Searchtext1"
        Me.Searchtext1.Size = New System.Drawing.Size(718, 20)
        Me.Searchtext1.TabIndex = 21
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(495, 333)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(169, 44)
        Me.btnsave.TabIndex = 22
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'addbtn
        '
        Me.addbtn.Location = New System.Drawing.Point(746, 23)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(122, 23)
        Me.addbtn.TabIndex = 23
        Me.addbtn.Text = "Add"
        Me.addbtn.UseVisualStyleBackColor = True
        '
        'prodname
        '
        Me.prodname.Location = New System.Drawing.Point(34, 420)
        Me.prodname.Name = "prodname"
        Me.prodname.Size = New System.Drawing.Size(180, 20)
        Me.prodname.TabIndex = 24
        '
        'genname
        '
        Me.genname.Location = New System.Drawing.Point(34, 447)
        Me.genname.Name = "genname"
        Me.genname.Size = New System.Drawing.Size(180, 20)
        Me.genname.TabIndex = 25
        '
        'catdesc
        '
        Me.catdesc.Location = New System.Drawing.Point(34, 474)
        Me.catdesc.Name = "catdesc"
        Me.catdesc.Size = New System.Drawing.Size(180, 20)
        Me.catdesc.TabIndex = 26
        '
        'priceinfo
        '
        Me.priceinfo.Location = New System.Drawing.Point(34, 501)
        Me.priceinfo.Name = "priceinfo"
        Me.priceinfo.Size = New System.Drawing.Size(180, 20)
        Me.priceinfo.TabIndex = 27
        '
        'qtyinfo
        '
        Me.qtyinfo.Location = New System.Drawing.Point(271, 420)
        Me.qtyinfo.Name = "qtyinfo"
        Me.qtyinfo.Size = New System.Drawing.Size(164, 20)
        Me.qtyinfo.TabIndex = 28
        '
        'amountinfo
        '
        Me.amountinfo.Location = New System.Drawing.Point(271, 447)
        Me.amountinfo.Name = "amountinfo"
        Me.amountinfo.Size = New System.Drawing.Size(164, 20)
        Me.amountinfo.TabIndex = 29
        '
        'profitinfo
        '
        Me.profitinfo.Location = New System.Drawing.Point(271, 473)
        Me.profitinfo.Name = "profitinfo"
        Me.profitinfo.Size = New System.Drawing.Size(164, 20)
        Me.profitinfo.TabIndex = 30
        '
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 551)
        Me.Controls.Add(Me.profitinfo)
        Me.Controls.Add(Me.amountinfo)
        Me.Controls.Add(Me.qtyinfo)
        Me.Controls.Add(Me.priceinfo)
        Me.Controls.Add(Me.catdesc)
        Me.Controls.Add(Me.genname)
        Me.Controls.Add(Me.prodname)
        Me.Controls.Add(Me.addbtn)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Searchtext1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.prodlist)
        Me.Name = "Sales"
        Me.Text = "Sales"
        CType(Me.prodlist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents prodlist As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Searchtext1 As TextBox
    Friend WithEvents btnsave As Button
    Friend WithEvents productname As DataGridViewTextBoxColumn
    Friend WithEvents genericname As DataGridViewTextBoxColumn
    Friend WithEvents categorydescription As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents amount As DataGridViewTextBoxColumn
    Friend WithEvents profit As DataGridViewTextBoxColumn
    Friend WithEvents addbtn As Button
    Friend WithEvents prodname As TextBox
    Friend WithEvents genname As TextBox
    Friend WithEvents catdesc As TextBox
    Friend WithEvents priceinfo As TextBox
    Friend WithEvents qtyinfo As TextBox
    Friend WithEvents amountinfo As TextBox
    Friend WithEvents profitinfo As TextBox
End Class
