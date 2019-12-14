Public Class frm_insertstaff_A170586
    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"
    Private Sub frm_insertstaff_A170586_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        txt_staff.Text = generate_staff()

        txt_picture.Text = defaultpicture
        pic_staff.BackgroundImage = Image.FromFile(defaultpicture)
    End Sub

    Private Sub refresh_grid()
        grd_staffs.DataSource = run_sql_query("SELECT * FROM TBL_STAFFS_A170586")

        grd_staffs.Columns(0).HeaderText = "Staff ID"
        grd_staffs.Columns(1).HeaderText = "Name"
        grd_staffs.Columns(2).HeaderText = "Address"
        grd_staffs.Columns(3).HeaderText = "Phone"
    End Sub

    Private Function generate_staff() As String
        Dim laststaff As String = run_sql_query("SELECT MAX(FLD_STAFF_ID) AS LASTSTAFF
FROM TBL_STAFFS_A170586").Rows(0).Item("LASTSTAFF")
        'MsgBox(lastproduct)
        Dim newstaff As String = "S" & Mid(laststaff, 2) + 1
        Return newstaff
    End Function

    Private Sub btn_insert_Click_1(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim mysql As String = "INSERT INTO TBL_STAFFS_A170586 VALUES ('" & txt_staff.Text _
            & "', '" & txt_name.Text & "', '" & txt_address.Text & "', '" & txt_phone.Text & "')"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)
        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            grd_staffs.DataSource = run_sql_query("SELECT * FROM TBL_STAFFS_A170586")

            txt_staff.Text = generate_staff()
            txt_name.Text = ""
            txt_address.Text = ""
            txt_phone.Text = ""
            txt_picture.Text = defaultpicture
            pic_staff.BackgroundImage = Image.FromFile(defaultpicture)
            refresh_grid()
        Catch ex As Exception
            Beep()
            MsgBox(“There is a mistake in the data you entered, as shown below” & vbCrLf &
                   vbCrLf & ex.Message)
            mywriter.Connection.Close()
            refresh_grid()
        End Try
    End Sub

    Private Sub clear_fields()
        txt_staff.Text = ""
        txt_name.Text = ""
        txt_address.Text = ""
        txt_phone.Text = ""
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_staff_A170586.Show()
        Me.Close()
    End Sub

    Private Sub btn_picture_Click(sender As Object, e As EventArgs) Handles btn_picture.Click
        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()

        Try
            pic_staff.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            txt_picture.Text = OpenFileDialog1.FileName
        Catch ex As Exception
            pic_staff.BackgroundImage = Image.FromFile(defaultpicture)
        End Try
    End Sub
End Class