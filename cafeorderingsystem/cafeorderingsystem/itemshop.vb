Public Class itemshop
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Hide()
        ordersystem.Show()
        Reset()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim a As Char
        Dim p As Integer

        a = ""
        If (RadioButton1.Checked) Then
            a = "SMALL"
            p = 39
        End If
        If (RadioButton2.Checked) Then
            a = "MEDIUM"
            p = 49
        End If
        If (RadioButton3.Checked) Then
            a = "LARGE"
            p = 69
        End If
        TextBox8.Text = a
        TextBox2.Text = p

    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        Dim a As String
        a = ""

        If (RadioButton1.Checked) Then
            a = "SMALL"

        End If
        If (RadioButton2.Checked) Then
            a = "MEDIUM"

        End If
        If (RadioButton3.Checked) Then
            a = "LARGE"
        End If
        TextBox8.Text = a
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox3.Text += 1
        Dim p As Integer
        If (RadioButton1.Checked) Then
            p = 39
        End If
        If (RadioButton2.Checked) Then
            p = 49
        End If
        If (RadioButton3.Checked) Then
            p = 69
        End If
        TextBox2.Text = p
        TextBox1.Text = TextBox3.Text * p
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox3.Text -= 1
        TextBox1.Text = TextBox3.Text * TextBox2.Text

        If TextBox3.Text <= 0 Then
            TextBox3.Text = 0
        End If

        If TextBox1.Text <= 0 Then
            TextBox1.Text = 0

        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim p As Integer
        If (RadioButton1.Checked) Then
            p = 39
        End If
        If (RadioButton2.Checked) Then
            p = 49
        End If
        If (RadioButton3.Checked) Then
            p = 69
        End If
        TextBox2.Text = p
        TextBox1.Text = TextBox3.Text * p
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n As Integer = ordersystem.DataGridView1.Rows.Add()
        ordersystem.DataGridView1.Rows.Item(n).Cells("column1").Value = TextBox4.Text()
        ordersystem.DataGridView1.Rows.Item(n).Cells("column2").Value = TextBox9.Text()
        ordersystem.DataGridView1.Rows.Item(n).Cells("column3").Value = TextBox8.Text()
        ordersystem.DataGridView1.Rows.Item(n).Cells("column4").Value = TextBox3.Text()
        ordersystem.DataGridView1.Rows.Item(n).Cells("column5").Value = TextBox1.Text()
        ordersystem.DataGridView1.CurrentCell = ordersystem.DataGridView1(0, ordersystem.DataGridView1.Rows.Count - 1)
        Dim total As Decimal = 0
        For Each row As DataGridViewRow In ordersystem.DataGridView1.Rows
        Next

        Me.Hide()
        ordersystem.Show()

        Dim m As Integer = 0
        Dim s As Integer = 0

        m = ordersystem.TextBox1.Text
        s = TextBox1.Text

        total = m + s

        ordersystem.TextBox1.Text = total

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        TextBox8.Text = "SMALL"
        TextBox2.Text = "39"
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        TextBox8.Text = "MEDIUM"
        TextBox2.Text = "49"
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        TextBox8.Text = "LARGE"
        TextBox2.Text = "69"
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox9.Text += 25


        If TextBox9.Text >= 100 Then
            TextBox9.Text = 100
        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox9.Text -= 25
        If TextBox9.Text <= 0 Then
            TextBox9.Text = 0
        End If
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub
End Class