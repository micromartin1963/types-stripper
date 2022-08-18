


Imports System.IO

Public Class Form1


    Dim NumberOfTypes As Integer
    Dim PresentType As Integer = 0
    Dim PresentTypeText As String = ""
    Dim EndText As String
    Dim AllText As String
    Dim fileReader As String
    Dim counter As Integer = 0





    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Do_Stuff()
    End Sub

    Private Sub Do_Stuff()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Using O As New OpenFileDialog With {.Filter = "Text Files|*.txt;*.xml"}
            If O.ShowDialog = 1 Then
                TextBox1.Text = O.FileName
            End If
        End Using

        '  Dim objReader As New System.IO.StreamReader(FILE_NAME)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        fileReader = My.Computer.FileSystem.ReadAllText(TextBox1.Text)
        TextBox2.Text = fileReader
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GetNumberOfTypes()
        Pass001()
        Pass002()



    End Sub

    Private Sub Pass001()



        Dim reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(TextBox1.Text)
        Dim a As String

        Do
            a = reader.ReadLine
            If a.Contains("type name") = True Then
                TextBox3.Text = TextBox3.Text + vbCrLf + a
                counter = counter + 1
            Else

            End If

        Loop Until counter = NumberOfTypes

    End Sub


    Private Sub Pass002()
        Dim str As String
        str = TextBox3.Text
        Dim repStr As String = str.Replace("<type name=", "")
        repStr = repStr.Replace("""", "")
        repStr = repStr.Replace(">", "")
        repStr = repStr.Replace(" ", "")
        repStr = repStr.Replace(vbTab, "")
        TextBox5.Text = repStr
    End Sub





    Private Sub WriteALine(str As String, sw As StreamWriter)


        Using sw
            sw.WriteLine(str)
        End Using


    End Sub





    Private Sub GetNumberOfTypes()
        Dim mysplit As Array
        mysplit = Split(fileReader, "type name")
        '  MsgBox(mysplit.Length - 1)
        NumberOfTypes = mysplit.Length - 1
        TextBox4.Text = "Number of types   " + (mysplit.Length - 1).ToString


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK _
         Then
            My.Computer.FileSystem.WriteAllText _
            (SaveFileDialog1.FileName, TextBox5.Text, True)
        End If
    End Sub
End Class
