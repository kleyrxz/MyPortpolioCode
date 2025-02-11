Imports System.Data.SqlClient

Public Class Login1





    Private Sub btnlogin_Click(sender As System.Object, e As System.EventArgs) Handles btnlogin.Click
        Dim username As String = txtuser.Text
        Dim Pass As String = txtPass.Text

        Dim query As String = " select * from Login where UserName = '" & txtuser.Text & "' And Password = '" & txtPass.Text & "' "
        Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-O91ELP8\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;Pooling=False")
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




    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()

    End Sub

   
End Class