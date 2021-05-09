Option Strict On
Option Explicit On

Public Class MainMenu

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnNewNote_Click(sender As Object, e As EventArgs) Handles BtnNewNote.Click
        NewNote.ShowDialog()
    End Sub

    Private Sub BtnManageNotes_Click(sender As Object, e As EventArgs) Handles BtnManageNotes.Click

    End Sub

    Private Sub BtnStatistics_Click(sender As Object, e As EventArgs) Handles BtnStatistics.Click

    End Sub

    Private Sub BtnAboutNotes_Click(sender As Object, e As EventArgs) Handles BtnAboutNotes.Click
        AboutNotes.ShowDialog()
    End Sub
End Class
