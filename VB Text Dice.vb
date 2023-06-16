Imports System

Module Program
    Sub Main()
        'Delcaring variables
        Dim randomNumber As String = ((1 * Rnd() + 1))
        'Outputs the number based on the number inside the brackets 
        Console.WriteLine(randomNumber(0))
        Console.WriteLine(randomNumber(2))
        Console.WriteLine(randomNumber(3))
        Console.WriteLine(randomNumber(4))
        Console.ReadLine()
    End Sub
End Module
