Imports System.Data.SqlClient

Public Class Project_Details

    Private Sub Project_Details_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ComboMilktea.Items.Add("")

        ComboMilktea.Items.Add("Coffee")
        ComboMilktea.Items.Add("Milktea")
        ComboMilktea.Items.Add("Fruittea")
        ComboMilktea.Items.Add("Javachips")


        ComboQuan.Items.Add("")

        ComboQuan.Items.Add("1")
        ComboQuan.Items.Add("2")
        ComboQuan.Items.Add("3")
        ComboQuan.Items.Add("4")
        ComboQuan.Items.Add("5")
        ComboQuan.Items.Add("6")
        ComboQuan.Items.Add("7")
        ComboQuan.Items.Add("8")
        ComboQuan.Items.Add("9")
        ComboQuan.Items.Add("10")

        ComboSize.Items.Add("")

        ComboSize.Items.Add("16oz")
        ComboSize.Items.Add("22oz")
        
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click

        Dim Milktea As String = ComboMilktea.Text
        Dim Flav As String = txtflavor.Text
        Dim Prize As String = txtPrize.Text
        Dim Quan As String = ComboQuan.Text
        Dim Size As String = ComboSize.Text

        Dim query As String = "Insert into Inventory3 values (@Milktea, @Flavor, @Prize, @Quantity, @Size)"
        Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-O91ELP8\SQLEXPRESS;Initial Catalog=Inventory3;Integrated Security=True;Pooling=False")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Milktea", Milktea)
                cmd.Parameters.AddWithValue("@Flavor", Flav)
                cmd.Parameters.AddWithValue("@Prize", Prize)
                cmd.Parameters.AddWithValue("@Quantity", Quan)
                cmd.Parameters.AddWithValue("@Size", Size)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Succesfully Added")
                BindData()

            End Using
        End Using



    End Sub

    Private Sub txtPrize_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrize.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub PicturesSearch_Click(sender As System.Object, e As System.EventArgs) Handles PicturesSearch.Click
        Dim Code As String = txtCode.Text
        Dim query As String = "SELECT * FROM Inventory3 WHERE Code = @Code"
        Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-O91ELP8\SQLEXPRESS;Initial Catalog=Inventory3;Integrated Security=True;Pooling=False")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Code", Code)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd

                    Using dt As New DataTable()
                        da.Fill(dt)

                        If dt.Rows.Count > 0 Then

                            ComboMilktea.Text = dt.Rows(0)(1).ToString
                            txtflavor.Text = dt.Rows(0)(2).ToString
                            txtPrize.Text = dt.Rows(0)(3).ToString
                            ComboQuan.Text = dt.Rows(0)(4).ToString
                            ComboSize.Text = dt.Rows(0)(5).ToString

                        Else
                            MsgBox("No Data Found")

                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub BindData()
        Dim query As String = " select * from Inventory3 "
        Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-O91ELP8\SQLEXPRESS;Initial Catalog=Inventory3;Integrated Security=True;Pooling=False")
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

    Private Sub btnupdate_Click(sender As System.Object, e As System.EventArgs) Handles btnupdate.Click

        Dim Code As String = txtCode.Text
        Dim Milktea As String = ComboMilktea.Text
        Dim Flavor As String = txtflavor.Text
        Dim Prize As String = txtPrize.Text
        Dim Quantity As String = ComboQuan.Text
        Dim Size As String = ComboSize.Text

        Dim query As String = "Update Inventory3 Set Milktea = @Milktea, Flavor = @Flavor, Prize = @Prize, Quantity = @Quantity, Size = @Size Where Code = @Code"
        Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-O91ELP8\SQLEXPRESS;Initial Catalog=Inventory3;Integrated Security=True;Pooling=False")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Milktea", Milktea)
                cmd.Parameters.AddWithValue("@Flavor", Flavor)
                cmd.Parameters.AddWithValue("@Prize", Prize)
                cmd.Parameters.AddWithValue("@Quantity", Quantity)
                cmd.Parameters.AddWithValue("@Size", Size)
                cmd.Parameters.AddWithValue("@Code", Code)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Succesfully Updated")
                BindData()

                ComboMilktea.Text = ""
                txtflavor.Text = ""
                txtPrize.Text = ""
                ComboQuan.Text = ""
                ComboSize.Text = ""


            End Using
        End Using





    End Sub

    Private Sub btndel_Click(sender As System.Object, e As System.EventArgs) Handles btndel.Click

        Dim Code As String = txtCode.Text

        Dim query As String = "delete Inventory3 where Code = @Code"
        Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-O91ELP8\SQLEXPRESS;Initial Catalog=Inventory3;Integrated Security=True;Pooling=False")
            Using cmd As SqlCommand = New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@Code", Code)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Succesfully Deleted")
                BindData()

            End Using
        End Using
    End Sub

    Private Sub Project_Details_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        e.Handled = True
    End Sub
End Class



