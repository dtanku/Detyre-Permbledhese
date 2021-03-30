Imports System

Module Program
    Sub Main()
        For Numri As Integer = 1 To 20
            If Numri Mod 3 = 0 Then
                Console.WriteLine(Numri & "*")
            Else
                Console.WriteLine(Numri)
            End If
        Next
    End Sub
End Module

