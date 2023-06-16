Imports System

Module Program
    Sub Main()
        'Delcaring Variables 
        Dim choice As Char
        'Setting an Array
        Dim numbers() As String = {"1", "2", "3", "4", "5", "6", "7", "8", "9"}
        Console.WriteLine("These are all of the avaliable notes:")
        'Looping 
        For counter = 0 To 8
            'Output the element
            Console.WriteLine(numbers(counter))
        Next



        'Iteration Loop
        Do
            'Declaring variables and asking for user input which are stored
            Dim changeNote As Integer
            Console.WriteLine("Enter a number for a note to change")
            changeNote = Console.ReadLine
            Console.WriteLine("Enter a new note")
            numbers(changeNote) = Console.ReadLine


            Console.WriteLine("Do you wish to continue?")
            choice = Console.ReadLine
            'Statment to show the new list 
            Console.WriteLine("The new list is: ")
            'For loop until the amount of numbers entered is equal to 10
            For counter = 0 To 8
                'Output the element

                Console.WriteLine(numbers(counter))
            Next

            'Conditions 
        Loop While choice <> "y" And choice <> "n"
        Console.ReadLine()



    End Sub
End Module



