Public Class DashBoard


    Public Shared userdashform


    Shared Property admindashform As String


    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub btnAddOrder_Click_1(sender As System.Object, e As System.EventArgs) Handles btnAddOrder.Click
        Add_Order.Show()
        Me.Hide()
    End Sub

    Private Sub btnNewProduct_Click_1(sender As System.Object, e As System.EventArgs) Handles btnNewProduct.Click
        Products.Show()
        Me.Hide()
    End Sub
End Class