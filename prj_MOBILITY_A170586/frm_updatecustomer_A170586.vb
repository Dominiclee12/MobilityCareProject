Public Class frm_updatecustomer_A170586
    Dim current_code As String
    Private Sub frm_updatecustomer_A170586_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()

    End Sub

    Private Sub refresh_grid()
        grd_customers.DataSource = run_sql_query("SELECT * FROM TBL_CUSTOMERS_A170586")

        grd_customers.Columns(0).HeaderText = "Customer ID"
        grd_customers.Columns(1).HeaderText = "Name"
        grd_customers.Columns(2).HeaderText = "Address"
        grd_customers.Columns(3).HeaderText = "Phone"
    End Sub

    Private Sub clear_fields()
        txt_customer.Text = ""
        txt_name.Text = ""
        txt_address.Text = ""
        txt_phone.Text = ""
    End Sub

    Private Sub get_current_code()

        Dim current_row As Integer = grd_customers.CurrentRow.Index
        current_code = grd_customers(0, current_row).Value

        txt_customer.Text = current_code
        txt_name.Text = grd_customers(1, current_row).Value
        txt_address.Text = grd_customers(2, current_row).Value
        txt_phone.Text = grd_customers(3, current_row).Value

    End Sub

    Private Sub grd_customers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_customers.CellClick

        get_current_code()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        run_sql_command("UPDATE TBL_CUSTOMERS_A170586 SET FLD_CUSTOMER_NAME='" & txt_name.Text & "', FLD_CUSTOMER_ADDRESS='" _
                        & txt_address.Text & "', FLD_CUSTOMER_PHONE='" & txt_phone.Text & "' WHERE FLD_CUSTOMER_ID='" _
                        & current_code & "'")

        If data_update = True Then
            Beep()
            MsgBox("You have successfully updated the customer """ & current_code & """.")
        End If

        refresh_grid()
        clear_fields()
        get_current_code()

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_customer_A170586.Show()
        Me.Close()
    End Sub
End Class