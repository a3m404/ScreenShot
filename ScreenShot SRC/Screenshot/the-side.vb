Public Class Form2

    Private Sub Form2_Click(sender As Object, e As EventArgs) Handles Me.Click
        Main.BackColor = Color.FromArgb(224, 224, 224)
        Main.TransparencyKey = Color.FromArgb(224, 224, 224)
        Main.BackgroundImage = Nothing
        Main.BackgroundImageLayout = ImageLayout.Tile
        Main.Panel1.Visible = False
        Main.Label1.Visible = False

        Me.Opacity = 0.85
        Main.Opacity = 0.85
    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Main.Close()
            Me.Close()
        End If
        If e.KeyCode = Keys.Enter Then
            Main.Timer1.Start()
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "0"
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        TextBox1.Text += 1
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Main.Timer1.Start()
        End If
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Main.Timer2.Start()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
        Main.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Main.Panel1.Visible = True
        Main.Label1.Visible = True
    End Sub
End Class