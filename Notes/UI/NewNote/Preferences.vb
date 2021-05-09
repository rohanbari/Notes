Option Strict On
Option Explicit On

Public Class Preferences

    Private Sub Preferences_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnApplyChanges_Click(sender As Object, e As EventArgs) Handles BtnApplyChanges.Click

    End Sub

    Private Sub BtnDiscard_Click(sender As Object, e As EventArgs) Handles BtnDiscard.Click
        Dispose()
        Close()
    End Sub
End Class