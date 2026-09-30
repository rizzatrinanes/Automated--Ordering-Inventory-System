Public Class ordersystem
    Public Shared AdminMain
    Public Shared UserMain
    Private Sub bestsellers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bestsellersbutton.Click
        With specialoffer
            .TopLevel = False
            showpanel.Controls.Add(specialoffer)
            .BringToFront()
            .Show()
        End With
        Panel5.Visible = True
        Panel6.Visible = False
        Panel7.Visible = False
        Panel8.Visible = False
        Panel9.Visible = False
    End Sub

    Private Sub coffeebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles coffeebutton.Click
        With coffee
            .TopLevel = False
            showpanel.Controls.Add(coffee)
            .BringToFront()
            .Show()
        End With
        Panel5.Visible = False
        Panel6.Visible = True
        Panel7.Visible = False
        Panel8.Visible = False
        Panel9.Visible = False
    End Sub

    Private Sub icelattebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles icelattebutton.Click
        With icelatte
            .TopLevel = False
            showpanel.Controls.Add(icelatte)
            .BringToFront()
            .Show()
        End With
        Panel5.Visible = False
        Panel6.Visible = False
        Panel7.Visible = True
        Panel8.Visible = False
        Panel9.Visible = False
    End Sub

    Private Sub dessertbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dessertbutton.Click
        With dessert
            .TopLevel = False
            showpanel.Controls.Add(dessert)
            .BringToFront()
            .Show()
        End With
        Panel5.Visible = False
        Panel6.Visible = False
        Panel7.Visible = False
        Panel8.Visible = True
        Panel9.Visible = False
    End Sub

    Private Sub frappebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frappebutton.Click
        With frappe
            .TopLevel = False
            showpanel.Controls.Add(frappe)
            .BringToFront()
            .Show()
        End With
        Panel5.Visible = False
        Panel6.Visible = False
        Panel7.Visible = False
        Panel8.Visible = False
        Panel9.Visible = True

    End Sub

    Private Sub dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bestsellers_Click(sender, e)
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Payment_method.Show()


    End Sub
End Class


