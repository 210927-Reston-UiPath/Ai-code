Imports System.IO
Imports System.Text.Json

Class mainMenu
	Implements IMenu
	dim friends as List(of Contact) = new List(of Contact)
	dim filename as string = "friends.json"
	dim jsonstring as string = ""
	Sub Initial() Implements Imenu.Start

		dim repeat as Boolean = True 
		Do While repeat
			Console.writeLine("What would you like to do")
			Console.writeLine("[0] Add a friend")
			AddFriend()
			Console.WriteLine("[1] Show all friends")
			Console.writeLine("[x] Exit")

	dim input as string = Console.Readline()
	Select Case input
		Case "0"
			Console.WriteLine("Hello")
			Console.WriteLine()
		Case "1"
			Console.WriteLine("So many friends")
			Console.WriteLine()
		Case "x"
			Console.WriteLine("Goodbye")
			repeat = False 	
		End Select
	Loop
			 
End Sub	

Sub AddFriend()
	Console.WriteLine("Name: ")
	dim name as string = Console.ReadLine()
	Console.WriteLine("Phone Number:")
	dim number as string = Console.ReadLine()
	dim newfriend as Contact = new Contact(name, Int32.Parse(number))
	AddFriend2File(newfriend)
	Console.WriteLine("New Friend" + newfriend.ToString())
End Sub

Sub ShowFriends()
	Console.WriteLine("Friend list plus contact info")
	For Each person As Contact In GetContactsFromFile()
		Console.WriteLine(person.ToString())
	Next
End Sub

Sub AddFriend2File(ByVal person as Contact)
	dim existingContacts as List(of Contact) = GetContactsFromFile()
	existingContacts.Add(person)
	jsonstring = jsonSerializer.Serialize(existingContacts)
	File.WriteAllText(filename, jsonstring)
End Sub

	Function GetContactsFromFile() As List(of Contact)
		Try
			jsonString = File.ReadAllText(filename)
			return JsonSerializer.Deserialize(of List(of Contact))(jsonstring)
		Catch ex As Exception
			return new List(of Contact)
		End Try
		End Function

  
End Class