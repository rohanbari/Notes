Option Strict On
Option Explicit On

Public Class NewNote

    Private Sub NewNote_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSaveToNotes_Click(sender As Object, e As EventArgs) Handles btnSaveToNotes.Click

    End Sub

    Private Sub btnDiscardDraft_Click(sender As Object, e As EventArgs) Handles btnDiscardDraft.Click
        If String.IsNullOrWhiteSpace(txtHeader.Text) Then
            GoTo quit
        End If

        Dim ask As DialogResult = MessageBox.Show(
            "All the changes you have made will be permanently lost." + Environment.NewLine +
            Environment.NewLine + "Are you sure you want to discard this draft?",
            "Discard Confirmation",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If ask = DialogResult.No Then
            Return
        End If

quit:
        Dispose()
        Close()
    End Sub

    Private Sub btnPreferences_Click(sender As Object, e As EventArgs) Handles btnPreferences.Click
        Preferences.ShowDialog()
    End Sub

    Private Sub txtHeader_TextChanged(sender As Object, e As EventArgs) Handles txtHeader.TextChanged
        txtBody.Enabled = Not String.IsNullOrWhiteSpace(txtHeader.Text)
        txtHeaderCaption.Visible = Not txtBody.Enabled
        labelCaption.Visible = txtBody.Text.Length = 0 And txtHeader.Text.Length > 0

        Text = If(txtHeader.Text.Length <> 0, "New Note — " + txtHeader.Text, "New Note")
    End Sub

    Private Sub txtBody_TextChanged(sender As Object, e As EventArgs) Handles txtBody.TextChanged
        Dim txtLength As Integer = txtBody.Text.Length

        labelCaption.Visible = txtLength = 0
        txtStatistics.Visible = txtLength > 0

        btnSaveToNotes.Enabled = txtLength > 0

        Dim cleanString As String = System.Text.RegularExpressions.Regex.Replace(txtBody.Text, "\s+", " ")
        txtBody.Text = cleanString

        Dim words As Integer = NoteCluster.WordCount(txtBody.Text)

        txtBody.SelectionStart = txtLength
        txtBody.SelectionLength = 0

        Dim expr = words.ToString + " word" + If(words <> 1, "s", "") + " (" + txtLength.ToString +
            " character" + If(txtLength <> 1, "s", "") + ")"

        txtStatistics.Text = expr
    End Sub
End Class