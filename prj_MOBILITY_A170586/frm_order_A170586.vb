Public Class frm_order_A170586
    Dim current_code As String
    Dim orderID As String
    Dim total As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_mainmenu_A170586.Show()
        Me.Close()
    End Sub

    Private Sub frm_order_A170586_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmb_staff.DataSource = run_sql_query("SELECT FLD_STAFF_ID FROM TBL_STAFFS_A170586")
        cmb_staff.DisplayMember = "FLD_STAFF_ID"
        cmb_customer.DataSource = run_sql_query("SELECT FLD_CUSTOMER_ID FROM TBL_CUSTOMERS_A170586")
        cmb_customer.DisplayMember = "FLD_CUSTOMER_ID"
        orderID = generate_oid()

        refresh_grid()
        refresh_list()
        refresh_text(lst_product.Text)

    End Sub

    Private Sub refresh_list()
        lst_product.DataSource = run_sql_query("SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A170586")
        lst_product.DisplayMember = "FLD_PRODUCT_ID"
    End Sub

    Private Sub refresh_text(product As String)
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A170586 WHERE FLD_PRODUCT_ID='" &
product & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        Try
            txt_name.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
            txt_price.Text = mydatatable.Rows(0).Item("FLD_PRICE")
            txt_brand.Text = mydatatable.Rows(0).Item("FLD_BRAND")
            txt_type.Text = mydatatable.Rows(0).Item("FLD_TYPE")
            txt_quantity.Text = mydatatable.Rows(0).Item("FLD_QUANTITY")
            txt_warranty.Text = mydatatable.Rows(0).Item("FLD_WARRANTY")
        Catch ex As Exception
        End Try

        Try
            pic_product.BackgroundImage = Image.FromFile("pictures/" & lst_product.Text & ".jpg")
        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try
    End Sub

    Private Sub refresh_grid()
        'empty grid
        grd_invoice.ColumnCount = 4

        grd_invoice.Columns(0).HeaderText = "Product ID"
        grd_invoice.Columns(1).HeaderText = "Order ID"
        grd_invoice.Columns(2).HeaderText = "Quantity"
        grd_invoice.Columns(3).HeaderText = "Subtotal"
    End Sub

    Private Sub lst_product_Click(sender As Object, e As EventArgs) Handles lst_product.Click
        refresh_text(lst_product.Text)
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        If txt_quantity.Text - txt_quantity1.Text >= 0 Then
            Try
                Dim productID As String

                productID = lst_product.Text
                ' MsgBox(productID)
                Dim subtotal As Double

                subtotal = txt_quantity1.Text * txt_price.Text

                total += subtotal

                txt_total.Text = total

                grd_invoice.Rows.Add(New String() {productID, orderID, txt_quantity1.Text, subtotal})
            Catch ex As Exception

                Beep()
                MsgBox("Please fill in the quantity you wish to order " & vbCrLf & vbCrLf & ex.Message)

            End Try
        Else
            Beep()
            MsgBox("The product do not have enough stock")
        End If

    End Sub

    Private Function generate_oid() As String
        Try
            Dim lastID As String = run_sql_query("SELECT MAX(FLD_ORDER_ID) AS LASTID FROM TBL_ORDERS_A170586").Rows(0).Item("LASTID")
            Dim newId As String = "O" & Mid(lastID, 2) + 1
            Return newId
        Catch ex As Exception
            Dim lastID As String = "O101"
            'Dim newId As String = "O" & Mid(lastID, 2) + 1
            Return lastID
        End Try
    End Function

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        Try
            Dim subtotal = grd_invoice.CurrentRow.Cells(3).Value.ToString()

            total -= subtotal

            txt_total.Text = total

            grd_invoice.Rows.Remove(grd_invoice.CurrentRow)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_checkout_Click(sender As Object, e As EventArgs) Handles btn_checkout.Click
        Dim mytransaction As OleDb.OleDbTransaction

        myconnection2.Open()
        mytransaction = myconnection2.BeginTransaction

        Try

            Dim mysql2 As String = "INSERT INTO TBL_ORDERS_A170586 VALUES ('" & orderID & "','" & cmb_customer.Text & "',
                                    '" & cmb_staff.Text & "', " & txt_total.Text & ")"

            Dim mywriter2 As New OleDb.OleDbCommand(mysql2, myconnection2, mytransaction)
            mywriter2.ExecuteNonQuery()

            For i As Integer = 0 To grd_invoice.RowCount - 1

                Dim pid As String = grd_invoice(0, i).Value
                Dim oid As String = grd_invoice(1, i).Value
                Dim quantity As Integer = grd_invoice(2, i).Value
                Dim subtotal As Double = grd_invoice(3, i).Value

                Dim mysql As String = "INSERT INTO TBL_ORDERS_DETAIL_A170586 VALUES ('" & pid & "', '" & oid & "'," & quantity & ", " & subtotal & ")"
                ' MsgBox("H")

                Dim mywritter As New OleDb.OleDbCommand(mysql, myconnection2, mytransaction)

                mywritter.ExecuteNonQuery()



            Next

            mytransaction.Commit()
            myconnection2.Close()

            For i As Integer = 0 To grd_invoice.RowCount - 1

                Dim pid As String = grd_invoice(0, i).Value
                Dim oid As String = grd_invoice(1, i).Value
                Dim quantity As Integer = grd_invoice(2, i).Value
                Dim subtotal As Double = grd_invoice(3, i).Value

                Dim mysql3 As String = "SELECT * FROM TBL_PRODUCTS_A170586 WHERE FLD_PRODUCT_ID='" &
pid & "'"
                Dim mydatatable As New DataTable
                Dim myreader As New OleDb.OleDbDataAdapter(mysql3, myconnection)
                myreader.Fill(mydatatable)

                Try
                    txt_quantity.Text = mydatatable.Rows(0).Item("FLD_QUANTITY")
                Catch ex As Exception
                End Try

                run_sql_command("UPDATE TBL_PRODUCTS_A170586 SET FLD_QUANTITY=" & (txt_quantity.Text - quantity) & " WHERE FLD_PRODUCT_ID='" _
                                & pid & "'")

            Next

            Beep()
            MsgBox("Transaction successful")

            grd_invoice.Rows.Clear()
            orderID = generate_oid()

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below " & vbCrLf & vbCrLf & ex.Message)

            mytransaction.Rollback()
            myconnection2.Close()

        End Try
        txt_total.Text = "0.00"
    End Sub

    Private Sub btn_invoice_Click(sender As Object, e As EventArgs) Handles btn_invoice.Click
        frm_invoice_A170586.Show()
        Me.Hide()
    End Sub
End Class