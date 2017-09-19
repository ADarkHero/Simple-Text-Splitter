Imports System.IO

Public Class Form1
    Private Sub sourceButton_Click(sender As Object, e As EventArgs) Handles sourceButton.Click
        Dim OpenFileDialog1 As New OpenFileDialog

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            sourceTextBox.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub destinationButton_Click(sender As Object, e As EventArgs) Handles destinationButton.Click
        Dim FolderBrowserDialog1 As New FolderBrowserDialog

        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            destinationTextBox.Text = FolderBrowserDialog1.SelectedPath + "\"
        End If
    End Sub

    Private Sub splitButton_Click(sender As Object, e As EventArgs) Handles splitButton.Click
        Try
            ' Open the file using a stream reader.
            Using sr As New StreamReader(sourceTextBox.Text)

                Dim line As String
                Dim linecount As Integer = 0
                Dim filecount As Integer = 1
                Do ' Loop until there is no line in the file left
                    Dim folderstructure As Array = sourceTextBox.Text.Split("\") ' We need the filename and extension, so we split the path at all \
                    Dim filename As Array = folderstructure(folderstructure.Length - 1).Split(".") ' filename(0) -> name of the file; filename(1) -> extension
                    Dim filepath As String = destinationTextBox.Text + filename(0) + "_" + filecount.ToString + "." + filename(1) ' Build the names of the new generated files
                    Using sw As New StreamWriter(filepath, True) ' Write new text files

                        line = sr.ReadLine() ' Read from source file
                        linecount += 1

                        If (linecount Mod Convert.ToInt64(splitTextBox.Text) = 0) Then ' Go to next file, when the division rest is zero
                            filecount += 1 ' Next file
                        End If

                        sw.WriteLine(line)
                    End Using
                Loop Until line Is Nothing

            End Using

            MessageBox.Show("The file was successfully split!", "Victory!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Notice me!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
