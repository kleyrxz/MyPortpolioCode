Imports System.Data.SqlClient

Public Class Form4

    Private Sub btnSelect_Click(sender As System.Object, e As System.EventArgs) Handles btnSelect.Click

        Dim Name As String = txtname.Text
        Dim Age As Integer = txtAge.Text
        Dim Gender As String = txtGender.Text
        Dim DoB As String = txtDoB.Text
        Dim Add As String = txtAdd.Text
        Dim PhoneNum As String = txtPn.Text
        Dim Course As String = txtCourse.Text

        Dim query As String = "Insert into TB_Four values (@Name, @Age, @Gender, @DateofBirth, @Address, @PhoneNumber, @Course)"
        Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-O91ELP8\SQLEXPRESS;Initial Catalog=Enrollmentsystem;Integrated Security=True;Pooling=False")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Name", Name)
                cmd.Parameters.AddWithValue("@Age", Age)
                cmd.Parameters.AddWithValue("@Gender", Gender)
                cmd.Parameters.AddWithValue("@DateofBirth", DoB)
                cmd.Parameters.AddWithValue("@Address", Add)
                cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNum)
                cmd.Parameters.AddWithValue("@Course", Course)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Succesfully Add")
                BindData()

            End Using
        End Using
    End Sub

    Private Sub txtPn_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPn.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BindData()

        Dim query As String = " select * from TB_Four"
        Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-O91ELP8\SQLEXPRESS;Initial Catalog=Enrollmentsystem;Integrated Security=True;Pooling=False")
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

    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        BindData()
    End Sub
End Class