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

        Dim query As String = "Insert into Inventory1 values (@Milktea, @Flavor, @Prize, @Quantity, @Size)"
        Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-O91ELP8\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;Pooling=False")
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

            End Using
        End Using


    End Sub

    Private Sub txtPrize_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrize.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class