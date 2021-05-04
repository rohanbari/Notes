Option Strict On
Option Explicit On

''' <summary>
''' This class contains all the custom-defined common Windows components.
''' </summary>
Public Class Common
    ''' <summary>
    ''' Displays a message prompt on the screen.
    ''' </summary>
    ''' <param name="body">Message Body</param>
    ''' <param name="head">Message Header</param>
    ''' <param name="type">Message Type</param>
    Public Shared Sub ShowMessage(body As String, head As String, type As Short)
        Dim messageType As MsgBoxStyle

        Select Case type
            Case 1
                messageType = MsgBoxStyle.Information
            Case 2
                messageType = MsgBoxStyle.Exclamation
            Case 3
                messageType = MsgBoxStyle.Critical
            Case Else
                messageType = MsgBoxStyle.Information
        End Select

        MsgBox(body, messageType, head)
    End Sub
End Class
