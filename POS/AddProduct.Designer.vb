﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddProduct
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.qty = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.profit = New System.Windows.Forms.TextBox()
        Me.o_price = New System.Windows.Forms.TextBox()
        Me.price = New System.Windows.Forms.TextBox()
        Me.exdate = New System.Windows.Forms.TextBox()
        Me.nameCat = New System.Windows.Forms.RichTextBox()
        Me.date_arrival = New System.Windows.Forms.TextBox()
        Me.gen = New System.Windows.Forms.TextBox()
        Me.code = New System.Windows.Forms.TextBox()
        Me.qty_sold = New System.Windows.Forms.TextBox()
        Me.supplier = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 359)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Quantity :"
        '
        'qty
        '
        Me.qty.Location = New System.Drawing.Point(116, 356)
        Me.qty.Name = "qty"
        Me.qty.Size = New System.Drawing.Size(258, 20)
        Me.qty.TabIndex = 42
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 333)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Supplier :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 308)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Profit :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 277)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Original Price :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Selling Price :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Expiry Date :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Date Arrival:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 26)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Category /" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Description :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Generic Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Brand Name :"
        '
        'savebtn
        '
        Me.savebtn.Location = New System.Drawing.Point(204, 397)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(174, 34)
        Me.savebtn.TabIndex = 32
        Me.savebtn.Text = "Save"
        Me.savebtn.UseVisualStyleBackColor = True
        '
        'profit
        '
        Me.profit.Location = New System.Drawing.Point(115, 301)
        Me.profit.Name = "profit"
        Me.profit.Size = New System.Drawing.Size(259, 20)
        Me.profit.TabIndex = 30
        '
        'o_price
        '
        Me.o_price.Location = New System.Drawing.Point(115, 274)
        Me.o_price.Name = "o_price"
        Me.o_price.Size = New System.Drawing.Size(259, 20)
        Me.o_price.TabIndex = 29
        '
        'price
        '
        Me.price.Location = New System.Drawing.Point(115, 248)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(259, 20)
        Me.price.TabIndex = 28
        '
        'exdate
        '
        Me.exdate.Location = New System.Drawing.Point(115, 221)
        Me.exdate.Name = "exdate"
        Me.exdate.Size = New System.Drawing.Size(259, 20)
        Me.exdate.TabIndex = 27
        '
        'nameCat
        '
        Me.nameCat.Location = New System.Drawing.Point(114, 81)
        Me.nameCat.Name = "nameCat"
        Me.nameCat.Size = New System.Drawing.Size(257, 66)
        Me.nameCat.TabIndex = 26
        Me.nameCat.Text = ""
        '
        'date_arrival
        '
        Me.date_arrival.Location = New System.Drawing.Point(115, 188)
        Me.date_arrival.Name = "date_arrival"
        Me.date_arrival.Size = New System.Drawing.Size(259, 20)
        Me.date_arrival.TabIndex = 25
        '
        'gen
        '
        Me.gen.Location = New System.Drawing.Point(115, 55)
        Me.gen.Name = "gen"
        Me.gen.Size = New System.Drawing.Size(257, 20)
        Me.gen.TabIndex = 24
        '
        'code
        '
        Me.code.Location = New System.Drawing.Point(115, 23)
        Me.code.Name = "code"
        Me.code.Size = New System.Drawing.Size(257, 20)
        Me.code.TabIndex = 23
        '
        'qty_sold
        '
        Me.qty_sold.Location = New System.Drawing.Point(399, 39)
        Me.qty_sold.Name = "qty_sold"
        Me.qty_sold.Size = New System.Drawing.Size(21, 20)
        Me.qty_sold.TabIndex = 45
        '
        'supplier
        '
        Me.supplier.FormattingEnabled = True
        Me.supplier.Location = New System.Drawing.Point(116, 327)
        Me.supplier.Name = "supplier"
        Me.supplier.Size = New System.Drawing.Size(258, 21)
        Me.supplier.TabIndex = 46
        '
        'AddProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 433)
        Me.Controls.Add(Me.supplier)
        Me.Controls.Add(Me.qty_sold)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.qty)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.profit)
        Me.Controls.Add(Me.o_price)
        Me.Controls.Add(Me.price)
        Me.Controls.Add(Me.exdate)
        Me.Controls.Add(Me.nameCat)
        Me.Controls.Add(Me.date_arrival)
        Me.Controls.Add(Me.gen)
        Me.Controls.Add(Me.code)
        Me.Name = "AddProduct"
        Me.Text = "AddProduct"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents qty As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents savebtn As Button
    Friend WithEvents profit As TextBox
    Friend WithEvents o_price As TextBox
    Friend WithEvents price As TextBox
    Friend WithEvents exdate As TextBox
    Friend WithEvents nameCat As RichTextBox
    Friend WithEvents date_arrival As TextBox
    Friend WithEvents gen As TextBox
    Friend WithEvents code As TextBox
    Friend WithEvents qty_sold As TextBox
    Friend WithEvents supplier As ComboBox
End Class
