Public Class Form2
    Dim Number As Integer
    Dim Counter As Integer
    Dim time As Integer = 10
    Dim Num1 As Integer
    Dim Num2 As Integer
    Dim Op1 As Integer
    Dim AnswerFinal As Integer
    Dim counter1 As Integer
    Dim Tries As Integer
    Dim Percentage As Double

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Num1 = Int((15 - 1 + 1) * Rnd() + 1)
        Num2 = Int((15 - 1 + 1) * Rnd() + 1)
        Op1 = Int((2 - 1 + 1) * Rnd() + 1)
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Randomize()
        Num1 = Int((15 - 1 + 1) * Rnd() + 1)
        Num2 = Int((15 - 1 + 1) * Rnd() + 1)
        Op1 = Int((2 - 1 + 1) * Rnd() + 1)

        Label1.Text = Num1
        Label2.Text = Num2

        If Op1 = 2 Then
            Label3.Text = "+"
            AnswerFinal = Num1 + Num2
        Else
            Label3.Text = "-"
            AnswerFinal = Num1 - Num2
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = AnswerFinal Then
            Label4.Text = "Good job"
        Else : Label4.Text = "Try again"
        End If

        If TextBox1.Text = AnswerFinal Then
            MsgBox("Good job")
        Else
            MsgBox("You're bad")
        End If

        If TextBox1.Text = AnswerFinal Then
            counter = counter + 1
            Label5.Text = "Correct: " & counter
        End If

        Tries = Tries + 1

        Randomize()
        Num1 = Int((15 - 1 + 1) * Rnd() + 1)
        Num2 = Int((15 - 1 + 1) * Rnd() + 1)
        Op1 = Int((2 - 1 + 1) * Rnd() + 1)

        Label1.Text = Num1
        Label2.Text = Num2

        If Op1 = 2 Then
            Label3.Text = "+"
            AnswerFinal = Num1 + Num2
        Else
            Label3.Text = "-"
            AnswerFinal = Num1 - Num2
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1.MouseClick
        TextBox1.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Percentage = counter / Tries * 100
        MsgBox("GoodBye, Here is your percentage: " & Percentage & "% Correct")
        End
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Num1 = Int((15 - 1 + 1) * Rnd() + 1)
        Num2 = Int((15 - 1 + 1) * Rnd() + 1)
        Op1 = Int((2 - 1 + 1) * Rnd() + 1)
    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.D Then
            PictureBox4.Left = PictureBox4.Left + 10
        End If
        If e.KeyCode = Keys.A Then
            PictureBox4.Left = PictureBox4.Left - 10
        End If
        If e.KeyCode = Keys.W Then
            PictureBox4.Top = PictureBox4.Top - 10
        End If
        If e.KeyCode = Keys.S Then
            PictureBox4.Top = PictureBox4.Top + 10
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Number = Int((10 - 1 + 1) * Rnd() + 1)
        Timer1.Enabled = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = time
        time = time - 1
        If time < 0 Then
            Timer1.Enabled = False
            time = 10
            PictureBox2.Visible = True
            PictureBox2.Width = 185
            PictureBox2.Height = 181
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Randomize()
        Num1 = Int((15 - 1 + 1) * Rnd() + 1)
        Num2 = Int((15 - 1 + 1) * Rnd() + 1)
        Op1 = Int((2 - 1 + 1) * Rnd() + 1)

        Label1.Text = Num1
        Label2.Text = Num2

        If Op1 = 2 Then
            Label3.Text = "+"
            AnswerFinal = Num1 + Num2
        Else
            Label3.Text = "-"
            AnswerFinal = Num1 - Num2
        End If
    End Sub
End Class
