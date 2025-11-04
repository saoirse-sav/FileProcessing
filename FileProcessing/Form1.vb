Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim filePath As String = "sample.txt"

            Using writer As New StreamWriter(filePath, True) 'True to append
                writer.WriteLine("Hello, this is a test file!")
                writer.WriteLine("Second line of text.")
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try


        MessageBox.Show("Data written successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ButtonRead_Click(sender As Object, e As EventArgs) Handles ButtonRead.Click
        Dim filePath As String = "sample.txt"

        Using Reader As New StreamReader(filePath)
            Dim content As String = Reader.ReadToEnd()
            MessageBox.Show(content, "File Content: ")
        End Using
    End Sub
End Class
