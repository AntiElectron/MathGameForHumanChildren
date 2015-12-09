Public Class Form1
    Dim strUser As String
    Dim Fontt As New System.Drawing.Font("Times New Roman", 12)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Btn_Launch_Click(sender As Object, e As EventArgs) Handles Btn_Launch.Click
        If txt_launch.Text = "" Then
            MsgBox("Enter Your Username")
            End
        End If


        strUser = txt_launch.Text
        Pnl_Launch.Visible = False
        Me.Width = 704
        Me.Height = 687
        MsgBox("Welcome " & strUser)
        Label2.Text = "Welcome " & strUser
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub


    Private Sub txt_launch_TextChanged(sender As Object, e As EventArgs) Handles txt_launch.MouseClick
        txt_launch.Text = ""
        txt_launch.Font = New System.Drawing.Font(txt_launch.Font)
    End Sub

    Private Sub txt_launch_TextChanged_1(sender As Object, e As EventArgs) Handles txt_launch.TextChanged

    End Sub
End Class
