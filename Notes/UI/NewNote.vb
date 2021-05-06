Public Class NewNote
    Private Sub btnSaveToNotes_Click(sender As Object, e As EventArgs) Handles btnSaveToNotes.Click

    End Sub

    Private Sub btnDiscardDraft_Click(sender As Object, e As EventArgs) Handles btnDiscardDraft.Click
        If txtBody.Text.Length = 0 And txtHeader.Text.Length = 0 Then
            GoTo quit
        End If

        Dim ask As DialogResult = MessageBox.Show(
            "All the made changes will be lost forever." + Environment.NewLine + Environment.NewLine +
            "Are you sure you want to discard this draft?",
            "Discard Confirmation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If ask = DialogResult.No Then
            Return
        End If

quit:
        Dispose()
        Close()
    End Sub

    Private Sub btnPreferences_Click(sender As Object, e As EventArgs) Handles btnPreferences.Click

    End Sub

    Private Sub txtHeader_TextChanged(sender As Object, e As EventArgs) Handles txtHeader.TextChanged
        txtBody.Enabled = Not String.IsNullOrWhiteSpace(txtHeader.Text)
        labelCaption.Visible = txtBody.Text.Length = 0 And txtHeader.Text.Length > 0
    End Sub

    Private Sub txtBody_TextChanged(sender As Object, e As EventArgs) Handles txtBody.TextChanged
        Dim txtLength As Integer = txtBody.Text.Length

        labelCaption.Visible = txtLength = 0
        txtStatistics.Visible = txtLength > 0

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