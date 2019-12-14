Public Class frm_staff_A170586
    Dim current_code As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_mainmenu_A170586.Show()
        Me.Close()
    End Sub

    Private Sub frm_staff_A170586_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_list()
    End Sub

    Private Sub refresh_list()
        lst_staff.DataSource = run_sql_query("SELECT FLD_STAFF_ID FROM TBL_STAFFS_A170586 WHERE
FLD_STAFF_ID like '%" & txt_search.Text & "%'")
        lst_staff.DisplayMember = "FLD_STAFF_ID"
        refresh_text(lst_staff.Text)
    End Sub

    Private Sub refresh_text(staff As String)
        Dim mysql As String = "SELECT * FROM TBL_STAFFS_A170586 WHERE FLD_STAFF_ID='" &
staff & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        Try
            txt_staff.Text = mydatatable.Rows(0).Item("FLD_STAFF_ID")
            txt_name.Text = mydatatable.Rows(0).Item("FLD_STAFF_NAME")
            txt_address.Text = mydatatable.Rows(0).Item("FLD_STAFF_ADDRESS")
            txt_phone.Text = mydatatable.Rows(0).Item("FLD_STAFF_PHONE")
        Catch ex As Exception
        End Try

        current_code = txt_staff.Text

        Try
            pic_staff.BackgroundImage = Image.FromFile("pictures/" & txt_staff.Text & ".jpg")
        Catch ex As Exception
            pic_staff.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        frm_insertstaff_A170586.Show()
        Me.Close()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        frm_updatestaff_A170586.Show()
        Me.Close()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the staff """ _
                                         & current_code & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_STAFFS_A170586 WHERE FLD_STAFF_ID='" & current_code & "'")
            Beep()
            MsgBox("The staff """ & current_code & """ has been successfully deleted.")
            refresh_list()
        End If
    End Sub

    Private Sub lst_staff_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_staff.MouseClick
        refresh_text(lst_staff.Text)
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        refresh_list()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        refresh_list()
    End Sub
End Class