Public Class frm_invoice_A170586
    Dim current_code As String
    Dim product_code As String
    Private Sub frm_invoice_A170586_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
    End Sub

    Private Sub refresh_grid()
        grd_order.DataSource = run_sql_query("SELECT * FROM TBL_ORDERS_A170586")

        grd_order.Columns(0).HeaderText = "Order ID"
        grd_order.Columns(1).HeaderText = "Customer ID"
        grd_order.Columns(2).HeaderText = "Staff ID"
        grd_order.Columns(3).HeaderText = "Total"
    End Sub

    Private Sub get_current_code()
        Dim current_row As Integer = grd_order.CurrentRow.Index
        current_code = grd_order(0, current_row).Value
    End Sub

    Private Sub get_product_code()
        Dim product_row As Integer = grd_invoice.CurrentRow.Index
        product_code = grd_invoice(0, product_row).Value
    End Sub

    Private Sub grd_order_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_order.CellClick
        get_current_code()
        refresh_grdinvoice()
        refresh_total()
    End Sub

    Private Sub refresh_total()
        Dim mysql As String = ("SELECT * FROM TBL_ORDERS_A170586 WHERE FLD_ORDER_ID ='" & current_code & "'")
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        txt_total.Text = mydatatable.Rows(0).Item("FLD_TOTAL")
    End Sub

    Private Sub refresh_subtotal()
        Dim mysql2 As String = ("SELECT * FROM TBL_ORDERS_DETAIL_A170586 WHERE FLD_ORDER_ID ='" & current_code & "' AND FLD_PRODUCT_ID='" & product_code & "'")
        Dim mydatatable2 As New DataTable
        Dim myreader2 As New OleDb.OleDbDataAdapter(mysql2, myconnection)
        myreader2.Fill(mydatatable2)

        txt_subtotal.Text = mydatatable2.Rows(0).Item("FLD_SUBTOTAL")
    End Sub

    Private Sub refresh_grdinvoice()
        grd_invoice.DataSource = run_sql_query("SELECT * FROM TBL_ORDERS_DETAIL_A170586 WHERE FLD_ORDER_ID='" & current_code & "'")

        grd_invoice.Columns(0).HeaderText = "Product ID"
        grd_invoice.Columns(1).HeaderText = "Order ID"
        grd_invoice.Columns(2).HeaderText = "Quantity"
        grd_invoice.Columns(3).HeaderText = "Subtotal"
    End Sub

    Private Sub grd_invoice_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_invoice.CellClick
        get_product_code()
        get_current_code()
        refresh_subtotal()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_order_A170586.Show()
        Me.Close()
    End Sub
End Class