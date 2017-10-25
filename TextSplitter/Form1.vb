Imports System.IO
Imports System.Text

Public Class Form1
    Private Sub sourceButton_Click(sender As Object, e As EventArgs) Handles sourceButton.Click
        Dim OpenFileDialog1 As New OpenFileDialog

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            sourceTextBox.Text = OpenFileDialog1.FileName ' Writes path + filename to source textbox

            ' Is there no easy way to get the fckng path without the file name?
            Dim pathArray As Array = OpenFileDialog1.FileName.Split("\")
            Dim pathString As String = ""

            For i As Integer = 0 To pathArray.Length - 2
                pathString += pathArray(i) + "\"
            Next

            destinationTextBox.Text = pathString ' Writes path to destination textbox
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
            Using sr As New StreamReader(sourceTextBox.Text, Encoding.GetEncoding(1252))

                Dim line As String
                Dim firstline As String = ""
                Dim linecount As Integer = 0
                Dim filecount As Integer = 1
                Do ' Loop until there is no line in the file left
                    Dim folderstructure As Array = sourceTextBox.Text.Split("\") ' We need the filename and extension, so we split the path at all \
                    Dim filename As Array = folderstructure(folderstructure.Length - 1).Split(".") ' filename(0) -> name of the file; filename(1) -> extension
                    Dim filepath As String = destinationTextBox.Text + filename(0) + "_" + filecount.ToString + "." + filename(1) ' Build the names of the new generated files
                    Using sw As New StreamWriter(filepath, True) ' Write new text files

                        line = sr.ReadLine() ' Read from source file

                        If keepFirstLine.Checked Then ' Should the first line of the file be written to every new file?
                            If linecount = 0 Then
                                firstline = line
                            ElseIf (linecount Mod Convert.ToInt64(splitTextBox.Text) = 0) Then ' At the start of a new file, write the first line
                                sw.WriteLine(firstline)
                            End If
                        End If

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
