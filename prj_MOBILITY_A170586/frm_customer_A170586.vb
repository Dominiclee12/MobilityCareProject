Public Class frm_customer_A170586
    Dim current_code As String

    Private Sub frm_customer_A170586_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_list()
    End Sub

    Private Sub refresh_list()
        lst_customer.DataSource = run_sql_query("SELECT FLD_CUSTOMER_ID FROM TBL_CUSTOMERS_A170586 WHERE
FLD_CUSTOMER_ID like '%" & txt_search.Text & "%'")
        lst_customer.DisplayMember = "FLD_CUSTOMER_ID"
        refresh_text(lst_customer.Text)
    End Sub

    Private Sub refresh_text(customer As String)
        Dim mysql As String = "SELECT * FROM TBL_CUSTOMERS_A170586 WHERE FLD_CUSTOMER_ID='" &
customer & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        Try
            txt_customer.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_ID")
            txt_name.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_NAME")
            txt_address.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_ADDRESS")
            txt_phone.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_PHONE")
        Catch ex As Exception
        End Try

        current_code = txt_customer.Text

        Try
            pic_customer.BackgroundImage = Image.FromFile("pictures/" & txt_customer.Text & ".jpg")
        Catch ex As Exception
            pic_customer.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        frm_insertcustomer_A170586.Show()
        Me.Close()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        frm_updatecustomer_A170586.Show()
        Me.Close()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the customer """ _
                                         & current_code & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_CUSTOMERS_A170586 WHERE FLD_CUSTOMER_ID='" & current_code & "'")
            Beep()
            MsgBox("The customer """ & current_code & """ has been successfully deleted.")
            refresh_list()
        End If
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_A170586.Show()
        Me.Close()
    End Sub

    Private Sub lst_customer_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_customer.MouseClick
        refresh_text(lst_customer.Text)
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        refresh_list()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        refresh_list()
    End Sub
End Class