Public Class Form1
    Dim speed As Integer
    Dim road(7) As PictureBox
    Dim score As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        speed = 3
        road(0) = PictureBox1
        road(1) = PictureBox2
        road(2) = PictureBox3
        road(3) = PictureBox4
        road(4) = PictureBox5
        road(5) = PictureBox6
        road(6) = PictureBox7
        road(7) = PictureBox8

    End Sub

    Private Sub RoadMover_Tick(sender As Object, e As EventArgs) Handles RoadMover.Tick

        For x As Integer = 0 To 7
            road(x).Top += speed
            If road(x).Top >= Me.Height Then
                road(x).Top = -road(x).Height
            End If
        Next

        If score >= 10 And score <= 20 Then
            speed = 4
        End If
        If score > 20 And score <= 30 Then
            speed = 5
        End If
        If score > 30 And score <= 50 Then
            speed = 6
        End If
        If score > 50 Then
            speed = 7
        End If
        Speedb.Text = "Speed " & speed
        If (MainCar.Bounds.IntersectsWith(EnemyCar1.Bounds)) Then
            gameOver()
        End If
        If (MainCar.Bounds.IntersectsWith(EnemyCar2.Bounds)) Then
            gameOver()
        End If
        If (MainCar.Bounds.IntersectsWith(EnemyCar3.Bounds)) Then
            gameOver()
        End If


    End Sub

    Private Sub gameOver()
        Restartb.Visible = True
        Game_Over.Visible = True
        RoadMover.Stop()
        Left_Mover.Stop()
        Right_Mover.Stop()
        Enemy1_Mover.Stop()
        Enemy2_Mover.Stop()
        Enemy3_Mover.Stop()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Right Then
            Right_Mover.Start()
        End If
        If e.KeyCode = Keys.Left Then
            Left_Mover.Start()
        End If
    End Sub

    Private Sub Left_Mover_Tick(sender As Object, e As EventArgs) Handles Left_Mover.Tick
        If (MainCar.Location.X > 1) Then
            MainCar.Left -= 5
        End If
    End Sub

    Private Sub Right_Mover_Tick(sender As Object, e As EventArgs) Handles Right_Mover.Tick
        If (MainCar.Location.X <= 195) Then
            MainCar.Left += 5
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        Right_Mover.Stop()
        Left_Mover.Stop()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles EnemyCar3.Click

    End Sub

    Private Sub EnemyCar1_Click(sender As Object, e As EventArgs) Handles EnemyCar1.Click

    End Sub

    Private Sub EnemyCar2_Click(sender As Object, e As EventArgs) Handles EnemyCar2.Click

    End Sub

    Private Sub Enemy1_Mover_Tick(sender As Object, e As EventArgs) Handles Enemy1_Mover.Tick
        EnemyCar1.Top += speed / 2
        If EnemyCar1.Top >= Me.Height Then
            score += 1
            Score_.Text = "Score " & score
            EnemyCar1.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + EnemyCar1.Height)
            EnemyCar1.Left = CInt(Math.Ceiling(Rnd() * 50)) + 0
        End If
    End Sub

    Private Sub Enemy2_Mover_Tick(sender As Object, e As EventArgs) Handles Enemy2_Mover.Tick
        EnemyCar2.Top += speed
        If EnemyCar2.Top >= Me.Height Then
            score += 1
            Score_.Text = "Score " & score
            EnemyCar2.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + EnemyCar2.Height)
            EnemyCar2.Left = CInt(Math.Ceiling(Rnd() * 33)) + 70

        End If
    End Sub

    Private Sub Enemy3_Mover_Tick(sender As Object, e As EventArgs) Handles Enemy3_Mover.Tick
        EnemyCar3.Top += speed * 3 / 2
        If EnemyCar3.Top >= Me.Height Then
            score += 1
            Score_.Text = "Score " & score
            EnemyCar3.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + EnemyCar3.Height)
            EnemyCar3.Left = CInt(Math.Ceiling(Rnd() * 40)) + 150
        End If
    End Sub

    Private Sub Restartb_Click(sender As Object, e As EventArgs) Handles Restartb.Click
        score = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form1_Load(e, e)
    End Sub
End Class
