Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim xd As System.IO.StreamWriter
        xd = My.Computer.FileSystem.OpenTextFileWriter("cnt.txt", True)
        xd.WriteLine("name:" + txtname.Text)
        xd.WriteLine("age" + txtage.Text)
        xd.WriteLine("gender" + txtgender.Text)
        xd.WriteLine("address" + txtaddress.Text)
        xd.WriteLine("contact" + txtcontact.Text)
        xd.Close()
        MessageBox.Show("datas has been added")

        txtaddress.Text = ""
        txtage.Text = ""
        txtcontact.Text = ""
        txtgender.Text = ""
        txtname.Text = ""
        txtname.Cursor = True


    End Sub
End Class
