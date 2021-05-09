Option Strict On
Option Explicit On

Public Class AboutNotes

    Private Sub AboutNotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkX_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkX.LinkClicked
        Dispose()
        Close()
    End Sub

    Private Sub LabelPowered_Click(sender As Object, e As EventArgs) Handles LabelPowered.Click
        Const link As String = "http://technosoftlabs.com/"
        Process.Start(link)
    End Sub
End Class