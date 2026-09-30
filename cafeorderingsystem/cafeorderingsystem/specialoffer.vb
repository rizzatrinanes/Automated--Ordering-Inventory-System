Public Class specialoffer

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        itemshop.Show()
        ordersystem.Hide()
        itemshop.TextBox4.Text = "Vanilla"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        itemshop.Show()
        ordersystem.Hide()
        itemshop.TextBox4.Text = "Strawberry"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        itemshop.Show()
        ordersystem.Hide()
        itemshop.TextBox4.Text = "Coconut"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        itemshop.Show()
        ordersystem.Hide()
        itemshop.TextBox4.Text = "Mocha"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        dessertform.Show()
        ordersystem.Hide()
        dessertform.TextBox4.Text = "Red Velvet"
        dessertform.TextBox8.Text = "120"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        dessertform.Show()
        ordersystem.Hide()
        dessertform.TextBox4.Text = "Blue Berry"
        dessertform.TextBox8.Text = "120"
    End Sub
End Class