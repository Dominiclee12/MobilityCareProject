Public Class frm_insertproduct_A170586
    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"
    Private Sub frm_insertproduct_A170586_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        txt_product.Text = generate_product()

        txt_picture.Text = defaultpicture
        pic_product.BackgroundImage = Image.FromFile(defaultpicture)
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

    Private Function generate_product() As String
        Dim lastproduct As String = run_sql_query("SELECT MAX(FLD_PRODUCT_ID) AS LASTPRODUCT
FROM TBL_PRODUCTS_A170586").Rows(0).Item("LASTPRODUCT")

        Dim newproduct As String = "P" & Mid(lastproduct, 2) + 1
        Return newproduct
    End Function

    Private Sub clear_fields()
        txt_product.Text = ""
        txt_name.Text = ""
        txt_price.Text = ""
        txt_brand.Text = ""
        txt_type.Text = ""
        txt_quantity.Text = ""
        txt_warranty.Text = ""
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim mysql As String = "INSERT INTO TBL_PRODUCTS_A170586 VALUES ('" & txt_product.Text _
            & "', '" & txt_name.Text & "', " & txt_price.Text & ", '" & txt_brand.Text & "', '" & txt_type.Text & "', " &
            txt_quantity.Text & ", '" & txt_warranty.Text & "')"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)
        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            My.Computer.FileSystem.CopyFile(txt_picture.Text, "pictures\" & txt_product.Text & ".jpg")

            grd_products.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A170586")

            txt_product.Text = generate_product()
            txt_name.Text = ""
            txt_price.Text = ""
            txt_brand.Text = ""
            txt_type.Text = ""
            txt_quantity.Text = ""
            txt_warranty.Text = ""
            txt_picture.Text = defaultpicture
            pic_product.BackgroundImage = Image.FromFile(defaultpicture)
            refresh_grid()
        Catch ex As Exception
            Beep()
            MsgBox(“There is a mistake in the data you entered, as shown below” & vbCrLf &
                   vbCrLf & ex.Message)
            mywriter.Connection.Close()
            refresh_grid()
        End Try
    End Sub

    Private Sub btn_picture_Click(sender As Object, e As EventArgs) Handles btn_picture.Click
        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()
        Try
            pic_product.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            txt_picture.Text = OpenFileDialog1.FileName
        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile(defaultpicture)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_product_A170586.Show()
        Me.Close()
    End Sub
End Class