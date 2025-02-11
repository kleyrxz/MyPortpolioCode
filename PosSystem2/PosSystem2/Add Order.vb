Imports System.Data.SqlClient
Imports MessagingToolkit.Barcode


Public Class Add_Order

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub



    Private Sub txtSerialNum_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuan.KeyPress, txtUnitPrice.KeyPress, txtDiscount.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click

        Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder
        Generator.BackColor = Color.White
        Generator.LabelFont = New Font("Arial", 10, FontStyle.Regular)
        Generator.IncludeLabel = True
        Generator.CustomLabel = txtSerialNum.Text
        Try
            PictureBarcode.Image = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code93, txtSerialNum.Text))
        Catch ex As Exception
        End Try

        Dim SerialNum As String = txtSerialNum.Text
        Dim ItemName As String = txtItemName.Text
        Dim ProductCat As String = txtCategory.Text
        Dim Quan As String = txtQuan.Text
        Dim UnitPrice As String = txtUnitPrice.Text
        Dim Discount As String = txtDiscount.Text
        Dim Price As String = txtPrice.Text
        Dim Barcode As String = PictureBarcode.Text


        Dim query As String = "Insert into AddOrder values (@SerialNumber, @ItemName, @ProductCategory, @Quantity, @UnitPrice, @Discount, @Price, @Barcode)"
        Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-O91ELP8\SQLEXPRESS;Initial Catalog=PosSystem;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@SerialNumber", txtSerialNum.Text)
                cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text)
                cmd.Parameters.AddWithValue("@ProductCategory", txtCategory.Text)
                cmd.Parameters.AddWithValue("@Quantity", txtQuan.Text)
                cmd.Parameters.AddWithValue("@UnitPrice", txtUnitPrice.Text)
                cmd.Parameters.AddWithValue("@Discount", txtDiscount.Text)
                cmd.Parameters.AddWithValue("@Price", txtPrice.Text)
                cmd.Parameters.AddWithValue("@Barcode", PictureBarcode.Text)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Succesfully Added")
                BindData()


            End Using
        End Using

        Clear()


    End Sub

    Private Sub BindData()


        Dim query As String = " select * from AddOrder "
        Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-O91ELP8\SQLEXPRESS;Initial Catalog=PosSystem;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        DataGridView1().DataSource() = dt
                    End Using


                End Using
            End Using
        End Using
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click

        Dim SerialNum As String = txtSerialNum.Text
        Dim ItemName As String = txtItemName.Text
        Dim ProductCat As String = txtCategory.Text
        Dim Quan As String = txtQuan.Text
        Dim UnitPrice As String = txtUnitPrice.Text
        Dim Discount As String = txtDiscount.Text
        Dim Price As String = txtPrice.Text
        Dim Barcode As String = PictureBarcode.Text

        Dim query As String = "Update AddOrder Set SerialNumber = @SerialNumber, ItemName = @ItemName, ProductCategory = @ProductCategory, Quantity = @Quantity, UnitPrice = @UnitPrice, Discount = @Discount, Price = @Price, Barcode = @Barcode Where SerialNumber = @SerialNumber"
        Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-O91ELP8\SQLEXPRESS;Initial Catalog=PosSystem;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@SerialNumber", txtSerialNum.Text)
                cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text)
                cmd.Parameters.AddWithValue("@ProductCategory", txtCategory.Text)
                cmd.Parameters.AddWithValue("@Quantity", txtQuan.Text)
                cmd.Parameters.AddWithValue("@UnitPrice", txtUnitPrice.Text)
                cmd.Parameters.AddWithValue("@Discount", txtDiscount.Text)
                cmd.Parameters.AddWithValue("@Price", txtPrice.Text)
                cmd.Parameters.AddWithValue("@Barcode", PictureBarcode.Text)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Succesfully Added")
                BindData()


            End Using
        End Using

        Clear()
    End Sub

    
   

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click

        Dim ID As String = txtID.Text

        Dim query As String = "delete AddOrder where ID = @ID"
        Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-O91ELP8\SQLEXPRESS;Initial Catalog=PosSystem;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@ID", txtID.Text)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Succesfully Deleted")
                BindData()

            End Using
        End Using

        Clear()

    End Sub

    Private Sub Clear()

        txtSerialNum.Text = ""
        txtItemName.Text = ""
        txtCategory.Text = ""
        txtQuan.Text = ""
        txtUnitPrice.Text = ""
        txtDiscount.Text = ""
        txtPrice.Text = ""
        PictureBarcode.Text = ""
        
    End Sub

    Private Sub Add_Order_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        BindData()

    End Sub

    Private Sub BtnSave_Click(sender As System.Object, e As System.EventArgs) Handles BtnSave.Click

        Dim SD As New SaveFileDialog
        SD.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        SD.FileName = txtSerialNum.Text
        SD.SupportMultiDottedExtensions = True
        SD.AddExtension = True
        SD.Filter = "PNG File|*.png"
        If SD.ShowDialog() = DialogResult.OK Then
            Try
                PictureBarcode.Image.Save(SD.FileName, Imaging.ImageFormat.Png)

            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub txtQuan_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtUnitPrice.TextChanged, txtQuan.TextChanged

        Compute()

    End Sub

    Private Sub txtDiscount_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDiscount.TextChanged

        Compute()
      
    End Sub

    Private Sub Compute()
        Try

            Dim Quan As String = txtQuan.Text
            Dim UnitPrice As String = txtUnitPrice.Text

            txtprice.Text = (UnitPrice * Quan)
        Catch ex As Exception

        End Try

        Try
            Dim Discount As Double = txtDiscount.Text
            Dim Price As Double = txtprice.Text
            txtprice.Text = Price - (Price * (Discount / 100))
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Dim ID As String = txtID.Text

        Dim query As String = "SELECT * FROM AddOrder WHERE ID = @ID"
        Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-O91ELP8\SQLEXPRESS;Initial Catalog=PosSystem;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@ID", txtID.Text)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd

                    Using dt As New DataTable()
                        da.Fill(dt)

                        If dt.Rows.Count > 0 Then

                            txtSerialNum.Text = dt.Rows(0)(1).ToString
                            txtItemName.Text = dt.Rows(0)(2).ToString
                            txtCategory.Text = dt.Rows(0)(3).ToString
                            txtQuan.Text = dt.Rows(0)(4).ToString
                            txtUnitPrice.Text = dt.Rows(0)(5).ToString
                            txtDiscount.Text = dt.Rows(0)(6).ToString
                            txtprice.Text = dt.Rows(0)(7).ToString
                            PictureBarcode.Text = dt.Rows(0)(8).ToString

                        Else
                            MsgBox("No Data Found")

                        End If
                        BindData()
                    End Using
                End Using
            End Using
        End Using


    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        DashBoard.Show()
        Me.Hide()
    End Sub
End Class