Imports ZXing.Common
Imports ZXing
Imports ZXing.QrCode
Imports System.Net.Mime.MediaTypeNames

Public Class Form1
    Dim pic As Bitmap = New Bitmap(190, 190)
    Dim gfx As Graphics = Graphics.FromImage(pic)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim xd As System.IO.StreamWriter
        xd = My.Computer.FileSystem.OpenTextFileWriter("cnt.txt", True)
        xd.WriteLine("name:" + txtname.Text)
        xd.WriteLine("age: " + txtage.Text)
        xd.WriteLine("gender: " + txtgender.Text)
        xd.WriteLine("address: " + txtaddress.Text)
        xd.WriteLine("contact: " + txtcontact.Text)
        xd.Close()
        MessageBox.Show("datas has been added")

        txtaddress.Text = ""
        txtage.Text = ""
        txtcontact.Text = ""
        txtgender.Text = ""
        txtname.Text = ""



    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        gfx.CopyFromScreen(New Point(Me.Location.X + PictureBox1.Location.X + 4, Me.Location.Y + PictureBox1.Location.Y + 30), New Point(0, 0), pic.Size)
        PictureBox1.Image = pic
        PictureBox1.Image = Nothing

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        PictureBox2.Image = pic

        Dim result As Result = Reader.decode(pic)
        Try
            Dim decoded As String = result.ToString().Trim()
            txtsamp.Text = decoded
        Catch ex As Exception

        End Try

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class
