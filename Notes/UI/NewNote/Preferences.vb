Option Strict On
Option Explicit On

Public Class Preferences

    Private Sub Preferences_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnApplyChanges_Click(sender As Object, e As EventArgs) Handles btnApplyChanges.Click

    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Dispose()
        Close()
    End Sub
End Class