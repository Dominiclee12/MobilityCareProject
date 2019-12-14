Public Class frm_updatestaff_A170586
    Dim current_code As String
    Private Sub frm_updatestaff_A170586_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()

        get_current_code()

    End Sub

    Private Sub refresh_grid()
        grd_staffs.DataSource = run_sql_query("SELECT * FROM TBL_STAFFS_A170586")

        grd_staffs.Columns(0).HeaderText = "Staff ID"
        grd_staffs.Columns(1).HeaderText = "Name"
        grd_staffs.Columns(2).HeaderText = "Address"
        grd_staffs.Columns(3).HeaderText = "Phone"
    End Sub

    Private Sub clear_fields()
        txt_staff.Text = ""
        txt_name.Text = ""
        txt_address.Text = ""
        txt_phone.Text = ""
    End Sub

    Private Sub get_current_code()

        Dim current_row As Integer = grd_staffs.CurrentRow.Index
        current_code = grd_staffs(0, current_row).Value

        txt_staff.Text = current_code
        txt_name.Text = grd_staffs(1, current_row).Value
        txt_address.Text = grd_staffs(2, current_row).Value
        txt_phone.Text = grd_staffs(3, current_row).Value

    End Sub

    Private Sub grd_staffs_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_staffs.CellClick

        get_current_code()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        run_sql_command("UPDATE TBL_STAFFS_A170586 SET FLD_STAFF_NAME='" & txt_name.Text & "', FLD_STAFF_ADDRESS='" _
                        & txt_address.Text & "', FLD_STAFF_PHONE='" & txt_phone.Text & "' WHERE FLD_STAFF_ID='" _
                        & current_code & "'")

        If data_update = True Then
            Beep()
            MsgBox("You have successfully updated the staff """ & current_code & """.")
        End If

        refresh_grid()
        clear_fields()
        get_current_code()

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_staff_A170586.Show()
        Me.Close()
    End Sub
End Class