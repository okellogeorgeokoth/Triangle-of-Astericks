'Name
'Details
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For counterVar As Integer = 1 To 10 Step 1      ' Printing the asterisks in inner loop

            For innerCounter As Integer = 1 To counterVar Step 1

                ' Statement to print the asterisk

                outputTextBox.AppendText("*")

            Next

            ' Adding new line statements

            outputTextBox.AppendText(vbCrLf)

        Next

        ' Adding Space between patterns

        outputTextBox.AppendText(vbCrLf)

        ' Loop used to display the second pattern

        For counterVar As Integer = 1 To 10 Step 1

            For innerCounter As Integer = 10 To counterVar Step -1
                ' Printing asterick statement
                outputTextBox.AppendText("*")

            Next

            ' Adding new line statements

            outputTextBox.AppendText(vbCrLf)

        Next

        ' Adding Space between patterns

        outputTextBox.AppendText(vbCrLf)

        ' Loop displaying the third pattern

        For counterVar As Integer = 1 To 10 Step 1

            ' Loop printing the leading spaces

            For innerSpaceCounter As Integer = 1 To (counterVar - 1) Step 1

                ' Statement  printing the leading spaces

                outputTextBox.AppendText(" ")

            Next

            ' Loop for printing the asterisks

            For innerCounter As Integer = 10 To counterVar Step -1

                ' Statement for printing the asterisk

                outputTextBox.AppendText("*")

            Next

            ' Statement to add a new line

            outputTextBox.AppendText(vbCrLf)

        Next

        ' leave a line space between patterns

        outputTextBox.AppendText(vbCrLf)

        ' Loop  displaying the fourth pattern

        For counterVar As Integer = 1 To 10 Step 1

            ' loop for printing the leading spaces

            For innerSpaceCounter As Integer = 10 To (counterVar + 1) Step -1

                ' statement to print the leading spaces

                outputTextBox.AppendText(" ")

            Next

            ' loop for printing the asterisks

            For innerCounter As Integer = 1 To counterVar Step 1

                '  print the asterisk statement

                outputTextBox.AppendText("*")

            Next

            ' add a new line statement

            outputTextBox.AppendText(vbCrLf)

        Next

    End Sub ' MyForm_Load procedure ends here
End Class  'end of Class MyForm 
