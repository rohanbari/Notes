Option Strict On
Option Explicit On

Public Class MainMenu

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNewNote_Click(sender As Object, e As EventArgs) Handles btnNewNote.Click
        NewNote.ShowDialog()
    End Sub

    Private Sub btnManageNotes_Click(sender As Object, e As EventArgs) Handles btnManageNotes.Click

    End Sub

    Private Sub btnStatistics_Click(sender As Object, e As EventArgs) Handles btnStatistics.Click

    End Sub

    Private Sub btnAboutNotes_Click(sender As Object, e As EventArgs) Handles btnAboutNotes.Click

    End Sub
End Class
