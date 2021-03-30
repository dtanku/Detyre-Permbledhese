Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Fusni një numër të plotë:")
        Dim Numri As Integer = Console.ReadLine()
        If Numri > 0 Then
            Console.WriteLine("Numri " & Numri & " është pozitiv")
        ElseIf Numri < 0 Then
            Console.WriteLine("Numri " & Numri & " është negativ")
        ElseIf Numri = 0 Then
            Console.WriteLine("Numri " & Numri & " është zero")
        Else
            Console.WriteLine("Numri që keni futur nuk është i vlefshëm!")
        End If
    End Sub
End Module
