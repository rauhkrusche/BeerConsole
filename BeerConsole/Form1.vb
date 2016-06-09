Imports DerAtrox.BeerNET.BeerEx
Public Class BeerConsoleForm
    Public Const year As String = "2016"
    Public Jahr As Integer
    Public Const beer_origin As String = "2014"
    Dim beer As New DerAtrox.BeerNET.BeerEx
    Private Sub BeerButton_Click(sender As Object, e As EventArgs) Handles BeerButton.Click

        Dim input As String = NoBeerBox.Text
        Dim output As String
        output = beer.Encode(input)
        BeerBox.Text = output

    End Sub

    Private Sub NoBeerButton_Click(sender As Object, e As EventArgs) Handles NoBeerButton.Click

        Dim input As String = BeerBox.Text
        Dim output As String
        output = beer.Decode(input)
        NoBeerBox.Text = output

    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        MessageBox.Show("Version 1.0" & vbCrLf & "© " & beer_origin & "-" & year & " rauhkrusche, a venture of Möller IT-Consulting" & vbCrLf & "Released under the MIT License (https://opensource.org/licenses/MIT)" & vbCrLf & "GitHub:  https://github.com/rauhkrusche/BeerConsole" & vbCrLf & "               https://github.com/rauhkrusche/", "Beer2Beer - The BEER-Console", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub
End Class
