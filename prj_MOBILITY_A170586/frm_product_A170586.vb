Public Class frm_product_A170586
    Dim current_code As String
    Private Sub frm_product_A170586_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_list()
    End Sub

    Private Sub refresh_list()
        lst_product.DataSource = run_sql_query("SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A170586 WHERE
FLD_PRODUCT_ID like '%" & txt_search.Text & "%'")
        lst_product.DisplayMember = "FLD_PRODUCT_ID"
        refresh_text(lst_product.Text)
    End Sub

    Private Sub refresh_text(product As String)
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A170586 WHERE FLD_PRODUCT_ID='" &
product & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        Try
            txt_product.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
            txt_name.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
            txt_price.Text = mydatatable.Rows(0).Item("FLD_PRICE")
            txt_brand.Text = mydatatable.Rows(0).Item("FLD_BRAND")
            txt_type.Text = mydatatable.Rows(0).Item("FLD_TYPE")
            txt_quantity.Text = mydatatable.Rows(0).Item("FLD_QUANTITY")
            txt_warranty.Text = mydatatable.Rows(0).Item("FLD_WARRANTY")
        Catch ex As Exception
        End Try

        current_code = txt_product.Text

        Try
            pic_product.BackgroundImage = Image.FromFile("pictures/" & txt_product.Text & ".jpg")
        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try

    End Sub

    Private Sub lst_product_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_product.MouseClick
        refresh_text(lst_product.Text)
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        frm_insertproduct_A170586.Show()
        Me.Close()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        frm_updateproduct_A170586.Show()
        Me.Close()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the product """ _
                                         & current_code & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_PRODUCTS_A170586 WHERE FLD_PRODUCT_ID='" & current_code & "'")
            Beep()
            MsgBox("The product """ & current_code & """ has been successfully deleted.")
            refresh_list()
        End If
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        refresh_list()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        refresh_list()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_A170586.Show()
        Me.Close()
    End Sub
End Class