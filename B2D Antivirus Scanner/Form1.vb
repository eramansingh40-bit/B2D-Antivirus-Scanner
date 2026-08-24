Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Computer.FileSystem.FileExists("D:\C Drive\Virus.txt") Then ListBox1.Items.Add("Trojan Horse Virus Found")


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim targetfile As String
        Try
            Kill("D:\C Drive\Virus.txt")
            targetfile = "C:\Windows\System32\cmd.exe"
            Label1.Text = "Delecting Selecting File(s), Please Wait..."
            Timer1.Start()
        Catch ex As Exception
            MsgBox("No Virus Found. You are Safe...")
        End Try



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim therandom As New Random
        Timer1.Interval = therandom.Next(100, 1000)
        On Error Resume Next
        If ProgressBar1.Value >= ProgressBar1.Maximum Then
            Label2.Text = "Virus Has Been Deleted"
        Else
            ProgressBar1.Value += therandom.Next(1, 3)
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub
End Class
