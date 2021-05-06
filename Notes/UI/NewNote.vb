Public Class NewNote
    Private Sub btnSaveToNotes_Click(sender As Object, e As EventArgs) Handles btnSaveToNotes.Click

    End Sub

    Private Sub btnDiscardDraft_Click(sender As Object, e As EventArgs) Handles btnDiscardDraft.Click
        If txtBody.Text.Length = 0 And txtHeader.Text.Length = 0 Then
            GoTo quit
        End If

        Dim ask As DialogResult = MessageBox.Show(
            "All the made changes will be lost forever." +
            " Are you sure you want to discard the draft?",
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
        txtBody.Enabled = txtHeader.Text.Length > 0
        labelCaption.Visible = txtBody.Text.Length = 0 And txtHeader.Text.Length > 0
    End Sub

    Private Sub txtBody_TextChanged(sender As Object, e As EventArgs) Handles txtBody.TextChanged
        labelCaption.Visible = txtBody.Text.Length = 0
    End Sub
End Class