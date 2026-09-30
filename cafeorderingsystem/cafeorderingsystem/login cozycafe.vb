Imports System.Data.OleDb

Public Class login_cozycafe
    Dim con As New OleDbConnection
    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbsource As String = "Data Source=E:\Cafe Ordering System (4.0)\Cafe Ordering System (1.0.0)\Cafe Ordering System (1.0.0)\cafeorderingsystem\cafeorderingsystem\login_database.accdb;"

    Private Shared Property AdminMain As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        passtxt.Clear()
        usernametxt.Clear()
    End Sub

    Private Sub login_cozycafe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        passtxt.UseSystemPasswordChar = True
        con.ConnectionString = dbProvider & dbsource
    End Sub

    Private Sub loginbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loginbutton.Click
        If usernametxt.Text = Nothing Or passtxt.Text = Nothing Then
            MessageBox.Show("Please enter your credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
        End If
        Try
            con.Open()
            Using Command As New OleDbCommand("SELECT COUNT(*) FROM USERS WHERE [USERNAME] = @USERNAME AND [PASSWORD] = @PASSWORD", con)
                Command.Parameters.AddWithValue("@USERNAME", OleDbType.VarChar).Value = usernametxt.Text.Trim
                Command.Parameters.AddWithValue("@PASSWORD", OleDbType.VarChar).Value = passtxt.Text.Trim
                Dim ds As New OleDbDataAdapter(cmd)
                Dim mytable As New DataTable
                ds.Fill(mytable)
                If mytable.Rows(0)("USERTYPE") = "admin" Then
                    Dim message As String = "you have successfully login!. please click to ok to proceed"
                    Dim caption As String = "Success"
                    Dim result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim AdminMain As New ordersystem
                    ordersystem.AdminMain = usernametxt.Text
                    ordersystem.Show()
                ElseIf mytable.Rows(0)("USERTYPE") = "staff" Then
                    Dim message As String = "you have successfully login!. please click to ok to proceed"
                    Dim caption As String = "Success"
                    Dim result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim UserMain As New ordersystem
                    ordersystem.UserMain = usernametxt.Text
                    ordersystem.Show()
                Else
                    MessageBox.Show("Wrong password or username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Wrong password or username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If passtxt.UseSystemPasswordChar = True Then
            passtxt.UseSystemPasswordChar = False
        Else
            passtxt.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioAdmin.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioStaff.CheckedChanged

    End Sub

End Class