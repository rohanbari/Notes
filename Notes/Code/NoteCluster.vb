''' <summary>
''' This class contains the definitions of required functions and sub-procedures for Notes.
''' </summary>
Public Class NoteCluster
    ''' <summary>
    ''' Counts the number of words containing in a string.
    ''' </summary>
    ''' <param name="str">String to be tested</param>
    ''' <returns>Integer</returns>
    Public Shared Function WordCount(str As String) As Integer
        If String.IsNullOrEmpty(str) Then
            Debug.WriteLine("String " + NameOf(str) + " has been detected null or empty // Skipping count")
            Return 0
        End If

        Dim expr As Integer = UBound(Split(Trim(Replace(str, Space(2), Space(1))))) + 1

        Return expr
    End Function
End Class
