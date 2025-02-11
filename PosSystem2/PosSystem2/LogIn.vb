Imports System.Data.SqlClient

Public Class LogIn



    Private Sub CheckShowpass_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckShowpass.CheckedChanged
        If CheckShowpass.Checked Then
            txtPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub LogIn_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtPass.UseSystemPasswordChar = True
    End Sub

    Private Sub btnLogIn_Click(sender As System.Object, e As System.EventArgs) Handles btnLogIn.Click
        login()
    End Sub

    Private Sub login()
        Try
            Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-O91ELP8\SQLEXPRESS;Initial Catalog=PosSystem;Integrated Security=True")
                con.Open()

                Using cmd As SqlCommand = New SqlCommand("SELECT * FROM LogIn WHERE UserName=@UserName AND Password=@Password", con)
                    cmd.Parameters.AddWithValue("@UserName", txtUserId.Text)
                    cmd.Parameters.AddWithValue("@Password", txtPass.Text)

                    Using sda As SqlDataAdapter = New SqlDataAdapter(cmd)
                        Dim dt As DataTable = New DataTable()
                        sda.Fill(dt)

                        If dt.Rows.Count > 0 Then

                            Dim UserRole As String

                            UserRole = dt.Rows(0)(3).ToString()


                            If UserRole = "Admin" Then
                                Dim admindashform As New DashBoard
                                DashBoard.admindashform = txtUserId.Text



                                MessageBox.Show("Admin Login Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                DashBoard.Show()
                                Me.Hide()

                            ElseIf UserRole = "Staff" Then
                                Dim userdashform As New DashBoard
                                DashBoard.userdashform = txtUserId.Text




                                MessageBox.Show("Staff Login Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                DashBoard.Show()
                                Me.Hide()
                            Else
                                MessageBox.Show("Invalid!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error)

                                txtUserId.Text = ""
                                txtPass.Text = ""

                            End If
                            Return
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            txtUserId.Text = ""
            txtPass.Text = ""
            Return
        End Try

    End Sub
End Class