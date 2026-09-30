Public Class Payment_method

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        With cashreceivedandcahnge
            cashreceivedandcahnge.TextBox1.Text = ordersystem.TextBox1.Text
            .TopLevel = False
            Panel4.Controls.Add(cashreceivedandcahnge)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        ordersystem.Show()


    End Sub
End Class