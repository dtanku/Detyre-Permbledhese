Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Fusni nj� num�r t� plot�:")
        Dim Numri As Integer = Console.ReadLine()
        If Numri > 0 Then
            Console.WriteLine("Numri " & Numri & " �sht� pozitiv")
        ElseIf Numri < 0 Then
            Console.WriteLine("Numri " & Numri & " �sht� negativ")
        ElseIf Numri = 0 Then
            Console.WriteLine("Numri " & Numri & " �sht� zero")
        Else
            Console.WriteLine("Numri q� keni futur nuk �sht� i vlefsh�m!")
        End If
    End Sub
End Module
