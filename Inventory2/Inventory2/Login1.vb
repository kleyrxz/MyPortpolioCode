Imports System.Data.SqlClient

Public Class Login1


    Private Sub btnlogin_Click(sender As System.Object, e As System.EventArgs) Handles btnlogin.Click
        Dim username As String = txtuser.Text
        Dim Pass As String = txtPassword.Text

        Dim query As String = " select * from Login where UserName = '" & txtuser.Text & "' And Password = '" & txtPassword.Text & "' "
        Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-O91ELP8\SQLEXPRESS;Initial Catalog=Inventory3;Integrated Security=True;Pooling=False")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)

                        If dt.Rows.Count > 0 Then
                            MsgBox("Successfully Login")
                            Project_Details.Show()
                            Me.Hide()
                        Else
                            MsgBox("Wrong User or Password")

                        End If



                    End Using


                End Using
            End Using
        End Using


    End Sub

    Private Sub Login1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        txtPassword.UseSystemPasswordChar = True
    End Sub


    Private Sub Checkshowpass_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Checkshowpass.CheckedChanged
        If Checkshowpass.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub
End Class