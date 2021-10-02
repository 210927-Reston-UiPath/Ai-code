 Class MainMenu
     Implements IMenu  
     Sub Initial() Implements IMenu.Start
        Console.WriteLine("What is your name?")
        Dim answer1 = Console.ReadLine()
        Console.WriteLine("What is your last name?")
        Dim answer2 = Console.ReadLine()
        Console.WriteLine("How old are you?")
        Dim answer3 = Console.ReadLine()

        Console.WriteLine(answer1)
        Console.WriteLine(answer2)
        Console.WriteLine(answer3)

    End Sub
End Class