Public Class frm_updateproduct_A170586
    Dim current_code As String
    Private Sub frm_updateproduct_A170586_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()

    End Sub

    Private Sub refresh_grid()
        grd_products.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A170586")

        grd_products.Columns(0).HeaderText = "Product ID"
        grd_products.Columns(1).HeaderText = "Product Name"
        grd_products.Columns(2).HeaderText = "Price"
        grd_products.Columns(3).HeaderText = "Brand"
        grd_products.Columns(4).HeaderText = "Type"
        grd_products.Columns(5).HeaderText = "Quantity"
        grd_products.Columns(6).HeaderText = "Warranty"
    End Sub

    Private Sub clear_fields()
        txt_product.Text = ""
        txt_name.Text = ""
        txt_price.Text = ""
        txt_brand.Text = ""
        txt_type.Text = ""
        txt_quantity.Text = ""
        txt_warranty.Text = ""
    End Sub

    Private Sub get_current_code()

        Dim current_row As Integer = grd_products.CurrentRow.Index
        current_code = grd_products(0, current_row).Value

        txt_product.Text = current_code
        txt_name.Text = grd_products(1, current_row).Value
        txt_price.Text = grd_products(2, current_row).Value
        txt_brand.Text = grd_products(3, current_row).Value
        txt_type.Text = grd_products(4, current_row).Value
        txt_quantity.Text = grd_products(5, current_row).Value
        txt_warranty.Text = grd_products(6, current_row).Value

    End Sub

    Private Sub grd_products_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_products.CellClick

        get_current_code()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        run_sql_command("UPDATE TBL_PRODUCTS_A170586 SET FLD_PRODUCT_NAME='" & txt_name.Text & "', FLD_PRICE=" & txt_price.Text &
                        ", FLD_BRAND='" & txt_brand.Text & "', FLD_TYPE='" & txt_type.Text & "', FLD_QUANTITY=" & txt_quantity.Text &
                        ", FLD_WARRANTY='" & txt_warranty.Text & "' WHERE FLD_PRODUCT_ID='" & current_code & "'")

        If data_update = True Then
            Beep()
            MsgBox("You have successfully updated the product """ & current_code & """.")
        End If

        refresh_grid()
            clear_fields()
            get_current_code()

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_product_A170586.Show()
        Me.Close()
    End Sub
End Class