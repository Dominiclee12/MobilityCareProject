<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_invoice_A170586
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_invoice_A170586))
        Me.grd_order = New System.Windows.Forms.DataGridView()
        Me.grd_invoice = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.txt_subtotal = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_invoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_order
        '
        Me.grd_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_order.Location = New System.Drawing.Point(41, 116)
        Me.grd_order.Name = "grd_order"
        Me.grd_order.ReadOnly = True
        Me.grd_order.RowTemplate.Height = 24
        Me.grd_order.Size = New System.Drawing.Size(614, 176)
        Me.grd_order.TabIndex = 0
        '
        'grd_invoice
        '
        Me.grd_invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_invoice.Location = New System.Drawing.Point(41, 309)
        Me.grd_invoice.Name = "grd_invoice"
        Me.grd_invoice.ReadOnly = True
        Me.grd_invoice.RowTemplate.Height = 24
        Me.grd_invoice.Size = New System.Drawing.Size(614, 164)
        Me.grd_invoice.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Castellar", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(34, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 41)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Invoice"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiBold", 20.0!)
        Me.Label2.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label2.Location = New System.Drawing.Point(39, 476)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 41)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Total:"
        '
        'txt_total
        '
        Me.txt_total.AutoSize = True
        Me.txt_total.BackColor = System.Drawing.Color.Transparent
        Me.txt_total.Font = New System.Drawing.Font("Bahnschrift SemiBold", 20.0!)
        Me.txt_total.ForeColor = System.Drawing.Color.LawnGreen
        Me.txt_total.Location = New System.Drawing.Point(111, 517)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(80, 41)
        Me.txt_total.TabIndex = 4
        Me.txt_total.Text = "0.00"
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(699, 555)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 23)
        Me.btn_back.TabIndex = 5
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'txt_subtotal
        '
        Me.txt_subtotal.AutoSize = True
        Me.txt_subtotal.BackColor = System.Drawing.Color.Transparent
        Me.txt_subtotal.Font = New System.Drawing.Font("Bahnschrift SemiBold", 20.0!)
        Me.txt_subtotal.ForeColor = System.Drawing.Color.LawnGreen
        Me.txt_subtotal.Location = New System.Drawing.Point(288, 517)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.Size = New System.Drawing.Size(80, 41)
        Me.txt_subtotal.TabIndex = 7
        Me.txt_subtotal.Text = "0.00"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.BackColor = System.Drawing.Color.Transparent
        Me.lbl.Font = New System.Drawing.Font("Bahnschrift SemiBold", 20.0!)
        Me.lbl.ForeColor = System.Drawing.Color.LawnGreen
        Me.lbl.Location = New System.Drawing.Point(216, 476)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(145, 41)
        Me.lbl.TabIndex = 6
        Me.lbl.Text = "Subtotal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiBold", 20.0!)
        Me.Label3.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label3.Location = New System.Drawing.Point(39, 517)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 41)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "RM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiBold", 20.0!)
        Me.Label4.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label4.Location = New System.Drawing.Point(216, 517)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 41)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "RM"
        '
        'frm_invoice_A170586
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(786, 590)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_subtotal)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grd_invoice)
        Me.Controls.Add(Me.grd_order)
        Me.Name = "frm_invoice_A170586"
        Me.Text = "frm_invoice_A170586"
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_invoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grd_order As DataGridView
    Friend WithEvents grd_invoice As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_total As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents txt_subtotal As Label
    Friend WithEvents lbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
