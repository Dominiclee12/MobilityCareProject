<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_order_A170586
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_order_A170586))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grd_invoice = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.txt_warranty = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_staff = New System.Windows.Forms.ComboBox()
        Me.cmb_customer = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lst_product = New System.Windows.Forms.ListBox()
        Me.txt_quantity1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.btn_checkout = New System.Windows.Forms.Button()
        Me.btn_invoice = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.grd_invoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Californian FB", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.PapayaWhip
        Me.Label1.Location = New System.Drawing.Point(39, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Order"
        '
        'grd_invoice
        '
        Me.grd_invoice.AllowUserToAddRows = False
        Me.grd_invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grd_invoice.Location = New System.Drawing.Point(45, 402)
        Me.grd_invoice.Name = "grd_invoice"
        Me.grd_invoice.ReadOnly = True
        Me.grd_invoice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grd_invoice.RowTemplate.Height = 24
        Me.grd_invoice.Size = New System.Drawing.Size(609, 191)
        Me.grd_invoice.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(850, 626)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_add.Location = New System.Drawing.Point(796, 292)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(112, 33)
        Me.btn_add.TabIndex = 5
        Me.btn_add.Text = "Add Cart"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(389, 152)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.ReadOnly = True
        Me.txt_name.Size = New System.Drawing.Size(166, 22)
        Me.txt_name.TabIndex = 6
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(389, 180)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.ReadOnly = True
        Me.txt_price.Size = New System.Drawing.Size(166, 22)
        Me.txt_price.TabIndex = 7
        '
        'txt_brand
        '
        Me.txt_brand.Location = New System.Drawing.Point(389, 208)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.ReadOnly = True
        Me.txt_brand.Size = New System.Drawing.Size(166, 22)
        Me.txt_brand.TabIndex = 8
        '
        'txt_type
        '
        Me.txt_type.Location = New System.Drawing.Point(389, 236)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.ReadOnly = True
        Me.txt_type.Size = New System.Drawing.Size(166, 22)
        Me.txt_type.TabIndex = 9
        '
        'txt_warranty
        '
        Me.txt_warranty.Location = New System.Drawing.Point(389, 292)
        Me.txt_warranty.Name = "txt_warranty"
        Me.txt_warranty.ReadOnly = True
        Me.txt_warranty.Size = New System.Drawing.Size(166, 22)
        Me.txt_warranty.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Info
        Me.Label2.Location = New System.Drawing.Point(274, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 18)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Info
        Me.Label3.Location = New System.Drawing.Point(274, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 18)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Info
        Me.Label4.Location = New System.Drawing.Point(274, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 18)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Brand"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.Info
        Me.Label5.Location = New System.Drawing.Point(274, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 18)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Type"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.Info
        Me.Label7.Location = New System.Drawing.Point(274, 295)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 18)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Warranty"
        '
        'cmb_staff
        '
        Me.cmb_staff.FormattingEnabled = True
        Me.cmb_staff.Location = New System.Drawing.Point(389, 84)
        Me.cmb_staff.Name = "cmb_staff"
        Me.cmb_staff.Size = New System.Drawing.Size(166, 24)
        Me.cmb_staff.TabIndex = 19
        '
        'cmb_customer
        '
        Me.cmb_customer.FormattingEnabled = True
        Me.cmb_customer.Location = New System.Drawing.Point(389, 114)
        Me.cmb_customer.Name = "cmb_customer"
        Me.cmb_customer.Size = New System.Drawing.Size(166, 24)
        Me.cmb_customer.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.Info
        Me.Label8.Location = New System.Drawing.Point(274, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 18)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Staff"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.Info
        Me.Label9.Location = New System.Drawing.Point(274, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 18)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Customer"
        '
        'lst_product
        '
        Me.lst_product.FormattingEnabled = True
        Me.lst_product.ItemHeight = 16
        Me.lst_product.Location = New System.Drawing.Point(45, 87)
        Me.lst_product.Name = "lst_product"
        Me.lst_product.Size = New System.Drawing.Size(150, 228)
        Me.lst_product.TabIndex = 23
        '
        'txt_quantity1
        '
        Me.txt_quantity1.Location = New System.Drawing.Point(604, 298)
        Me.txt_quantity1.Name = "txt_quantity1"
        Me.txt_quantity1.Size = New System.Drawing.Size(100, 22)
        Me.txt_quantity1.TabIndex = 24
        Me.txt_quantity1.Text = "1"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.Info
        Me.Label10.Location = New System.Drawing.Point(604, 269)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 18)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Quantity to purchase"
        '
        'txt_total
        '
        Me.txt_total.AutoSize = True
        Me.txt_total.BackColor = System.Drawing.Color.Transparent
        Me.txt_total.Font = New System.Drawing.Font("Bahnschrift SemiBold", 20.0!)
        Me.txt_total.ForeColor = System.Drawing.Color.LawnGreen
        Me.txt_total.Location = New System.Drawing.Point(748, 506)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(80, 41)
        Me.txt_total.TabIndex = 26
        Me.txt_total.Text = "0.00"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Bahnschrift SemiBold", 20.0!)
        Me.Label11.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label11.Location = New System.Drawing.Point(672, 457)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 41)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Total:"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_product.Location = New System.Drawing.Point(604, 84)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(170, 175)
        Me.pic_product.TabIndex = 28
        Me.pic_product.TabStop = False
        '
        'btn_remove
        '
        Me.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_remove.Location = New System.Drawing.Point(45, 363)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(118, 33)
        Me.btn_remove.TabIndex = 29
        Me.btn_remove.Text = "Remove Cart"
        Me.btn_remove.UseVisualStyleBackColor = True
        '
        'btn_checkout
        '
        Me.btn_checkout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_checkout.Location = New System.Drawing.Point(675, 560)
        Me.btn_checkout.Name = "btn_checkout"
        Me.btn_checkout.Size = New System.Drawing.Size(118, 33)
        Me.btn_checkout.TabIndex = 30
        Me.btn_checkout.Text = "Checkout"
        Me.btn_checkout.UseVisualStyleBackColor = True
        '
        'btn_invoice
        '
        Me.btn_invoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_invoice.Location = New System.Drawing.Point(536, 363)
        Me.btn_invoice.Name = "btn_invoice"
        Me.btn_invoice.Size = New System.Drawing.Size(118, 33)
        Me.btn_invoice.TabIndex = 31
        Me.btn_invoice.Text = "Invoice"
        Me.btn_invoice.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Bahnschrift SemiBold", 20.0!)
        Me.Label12.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label12.Location = New System.Drawing.Point(672, 506)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 41)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "RM"
        '
        'txt_quantity
        '
        Me.txt_quantity.Location = New System.Drawing.Point(389, 264)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.ReadOnly = True
        Me.txt_quantity.Size = New System.Drawing.Size(166, 22)
        Me.txt_quantity.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.Info
        Me.Label6.Location = New System.Drawing.Point(274, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 18)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Quantity"
        '
        'frm_order_A170586
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(937, 661)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btn_invoice)
        Me.Controls.Add(Me.btn_checkout)
        Me.Controls.Add(Me.btn_remove)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_quantity1)
        Me.Controls.Add(Me.lst_product)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmb_customer)
        Me.Controls.Add(Me.cmb_staff)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_warranty)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.txt_brand)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grd_invoice)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_order_A170586"
        Me.Text = "frm_order_A170586"
        CType(Me.grd_invoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents grd_invoice As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents txt_type As TextBox
    Friend WithEvents txt_warranty As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmb_staff As ComboBox
    Friend WithEvents cmb_customer As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lst_product As ListBox
    Friend WithEvents txt_quantity1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_total As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents btn_remove As Button
    Friend WithEvents btn_checkout As Button
    Friend WithEvents btn_invoice As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents Label6 As Label
End Class
