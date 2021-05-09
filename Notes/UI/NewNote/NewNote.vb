Option Strict On
Option Explicit On

Public Class NewNote

    Private Sub NewNote_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnSaveToNotes_Click(sender As Object, e As EventArgs) Handles BtnSaveToNotes.Click

    End Sub

    Private Sub BtnDiscardDraft_Click(sender As Object, e As EventArgs) Handles BtnDiscardDraft.Click
        If String.IsNullOrWhiteSpace(TextHeader.Text) Then
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

    Private Sub BtnPreferences_Click(sender As Object, e As EventArgs) Handles BtnPreferences.Click
        Preferences.ShowDialog()
    End Sub

    Private Sub TextHeader_TextChanged(sender As Object, e As EventArgs) Handles TextHeader.TextChanged
        TextBody.Enabled = Not String.IsNullOrWhiteSpace(TextHeader.Text)
        LabelHeaderCaption.Visible = Not TextBody.Enabled
        LabelCaption.Visible = TextBody.Text.Length = 0 And TextHeader.Text.Length > 0

        Text = If(TextHeader.Text.Length <> 0, "New Note — " + TextHeader.Text, "New Note")
    End Sub

    Private Sub TextBody_TextChanged(sender As Object, e As EventArgs) Handles TextBody.TextChanged
        Dim txtLength As Integer = TextBody.Text.Length

        LabelCaption.Visible = txtLength = 0
        LabelStatistics.Visible = txtLength > 0

        BtnSaveToNotes.Enabled = txtLength > 0

        Dim cleanString As String = System.Text.RegularExpressions.Regex.Replace(TextBody.Text, "\s+", " ")
        TextBody.Text = cleanString

        Dim words As Integer = NoteCluster.WordCount(TextBody.Text)

        TextBody.SelectionStart = txtLength
        TextBody.SelectionLength = 0

        Dim expr = words.ToString + " word" + If(words <> 1, "s", "") + " (" + txtLength.ToString +
            " character" + If(txtLength <> 1, "s", "") + ")"

        LabelStatistics.Text = expr
    End Sub
End Class