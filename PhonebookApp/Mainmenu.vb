Class mainMenu
	Implements IMenu
	Sub Initial() Implements Imenu.Start

	Console.WriteLine("Hello Hello World!")
		dim repeat as Boolean = True 
		Do While repeat
	Console.writeLine("What would you like to do")
	Console.writeLine("[0] Say hello")
	Console.writeLine("[x] Exit")
	Dim input as String = Console.Readline()
	Select Case input
		Case "0"
			Console.WriteLine("Hello there user ")
		Case "x"
			Console.WriteLine("Goodbye")
			repeat = False 	
		End Select
	Loop
			 
End Sub	

End Class