Public Class dessertform

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Hide()
        ordersystem.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox3.Text -= 1
        TextBox1.Text = TextBox3.Text * TextBox8.Text
        If TextBox3.Text <= 0 Then
            TextBox3.Text = 0
        End If
        If TextBox1.Text <= 0 Then
            TextBox1.Text = 0
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox3.Text += 1
        TextBox1.Text = TextBox3.Text * TextBox8.Text
    End Sub
   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n As Integer = ordersystem.DataGridView1.Rows.Add()
        ordersystem.DataGridView1.Rows.Item(n).Cells("column1").Value = TextBox4.Text()
        ordersystem.DataGridView1.Rows.Item(n).Cells("column4").Value = TextBox3.Text()
        ordersystem.DataGridView1.Rows.Item(n).Cells("column5").Value = TextBox1.Text()
        ordersystem.DataGridView1.CurrentCell = ordersystem.DataGridView1(0, ordersystem.DataGridView1.Rows.Count - 1)
        Dim total As Decimal = 0
        For Each row As DataGridViewRow In ordersystem.DataGridView1.Rows
        Next

        Dim m As Integer = 0
        Dim s As Integer = 0

        m = ordersystem.TextBox1.Text
        s = TextBox1.Text

        total = m + s

        ordersystem.TextBox1.Text = total

        Me.Hide()
        ordersystem.Show()
    End Sub
End Class