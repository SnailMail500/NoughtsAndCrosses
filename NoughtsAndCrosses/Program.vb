Imports System
Imports System.Security.Cryptography.X509Certificates

Module Program
    Dim oneName As String
    Dim twoName As String
    Dim oneSymbol As String
    Dim twoSymbol As String
    Dim theBoard(5, 5) As String
    Sub Main(args As String()) 'this is ugly, maybe a for loop?
        Console.WriteLine("Noughts and Crosses v0.1")

        Console.WriteLine("PLAYER 1, Please enter your name below: ")
        oneName = Console.ReadLine()

        Console.WriteLine("PLAYER 2, Please enter your name below: ")
        twoName = Console.ReadLine()

        Console.WriteLine("Hello, " & oneName & " and " & twoName & ", welcome to the Noughts And Crosses Game.")
        Console.WriteLine("Please wait while the board is being loaded...")
        Call createBoard()
        Call menu()
    End Sub
    Sub createBoard() 'make this more efficient in future version(s)!
        theBoard(1, 0) = " 1 " 'begin xCoord numbering
        theBoard(2, 0) = "   "
        theBoard(3, 0) = " 2 "
        theBoard(4, 0) = "   "
        theBoard(5, 0) = " 3 " 'end xCoord numbering

        theBoard(0, 1) = " 1 " 'begin yCoord numbering
        theBoard(0, 2) = "   "
        theBoard(0, 3) = " 2 "
        theBoard(0, 4) = "   "
        theBoard(0, 5) = " 3 " 'end yCoord numbering

        theBoard(1, 1) = "   " 'first row begin draw
        theBoard(2, 1) = " | "
        theBoard(3, 1) = "   "
        theBoard(4, 1) = " | "
        theBoard(5, 1) = "   " 'first row end draw

        theBoard(1, 2) = "---" 'second row begin draw
        theBoard(2, 2) = "-+-"
        theBoard(3, 2) = "---"
        theBoard(4, 2) = "-+-"
        theBoard(5, 2) = "---" 'second row end draw

        theBoard(1, 3) = "   " 'third row begin draw
        theBoard(2, 3) = " | "
        theBoard(3, 3) = "   "
        theBoard(4, 3) = " | "
        theBoard(5, 3) = "   " 'third row end draw

        theBoard(1, 4) = "---" 'fourth row begin draw
        theBoard(2, 4) = "-+-"
        theBoard(3, 4) = "---"
        theBoard(4, 4) = "-+-"
        theBoard(5, 4) = "---" 'fourth row end draw

        theBoard(1, 5) = "   " 'fifth row begin draw
        theBoard(2, 5) = " | "
        theBoard(3, 5) = "   "
        theBoard(4, 5) = " | "
        theBoard(5, 5) = "   " 'fifth row end draw
    End Sub
    Sub drawBoard()
        For i = 1 To 5
            For j = 1 To 5
                Console.Write(theBoard(j, i)) 'prints the row and column
            Next
            Console.WriteLine()
        Next
    End Sub
    Sub menu()
        Dim menuInput As Integer
        Dim validInput As Boolean = False
        Console.WriteLine("Main Menu")
        Console.WriteLine(" 1. New Game")
        Console.WriteLine(" 2. Load a previous game ")
        Console.WriteLine(" 3. Save last game played")
        Console.WriteLine("Please enter your choice below: ")
        menuInput = Console.ReadLine()
        While validInput = False
            Select Case menuInput
                Case 1
                    Console.WriteLine("New Game Selected")
                    validInput = True
                    Call newGame()
                Case 2
                    Console.WriteLine("Load Game Selected")
                    validInput = True
                    Call loadGame()
                Case 3
                    Console.WriteLine("Save Last Game Selected")
                    validInput = True
                    Call saveGame()
                Case Else
                    Console.WriteLine("Oops, that didn't seem to work. Please try again: ")
                    Console.WriteLine(" 1. New Game")
                    Console.WriteLine(" 2. Load a previous game ")
                    Console.WriteLine(" 3. Save last game played")
                    Console.WriteLine("Please enter your choice below: ")
                    validInput = False
                    menuInput = Console.ReadLine()
            End Select
        End While
    End Sub
    Sub newGame()
        Dim gameWon As Boolean = False
        Console.WriteLine("Starting New Game...")
        Call pickSymbol(oneName, twoName)
        Call drawBoard()
        While gameWon = False

        End While

    End Sub
    Sub loadGame()
        Console.WriteLine("Preparing to load a previous game...")
    End Sub
    Sub saveGame()
        Console.WriteLine("Preparing to save the last game played...")
    End Sub
    Sub pickSymbol(ByVal pOne As String, ByVal pTwo As String)
        Dim symbolChoice As Integer
        Dim validInput As Boolean = False
        Console.WriteLine(pOne & ", please choose 1 for symbol 'X' or 2 for symbol 'O': ")
        While validInput = False
            symbolChoice = Console.ReadLine()
            Select Case symbolChoice
                Case 1
                    Console.WriteLine(pOne & "you have chosen 'X' as your symbol for this game. ")
                    oneSymbol = " X "
                    validInput = True
                Case 2
                    Console.WriteLine(pOne & "you have chosen 'O' as your symbol for this game. ")
                    oneSymbol = " O "
                    validInput = True
                Case Else
                    Console.WriteLine("Oops, that didn't seem to work. Please try again: ")
                    Console.WriteLine(pOne & ", please choose 1 for symbol 'X' or 2 for symbol 'O': ")
                    symbolChoice = Console.ReadLine()
            End Select
        End While
        validInput = False
        symbolChoice = 0
        Console.WriteLine(pTwo & ", please choose 1 for symbol 'X' or 2 for symbol 'O': ")
        While validInput = False
            symbolChoice = Console.ReadLine()
            Select Case symbolChoice
                Case 1
                    Console.WriteLine(pTwo & "you have chosen 'X' as your symbol for this game. ")
                    twoSymbol = " X "
                    validInput = True
                Case 2
                    Console.WriteLine(pTwo & "you have chosen 'O' as your symbol for this game. ")
                    twoSymbol = " O "
                    validInput = True
                Case Else
                    Console.WriteLine("Oops, that didn't seem to work. Please try again: ")
                    Console.WriteLine(pTwo & ", please choose 1 for symbol 'X' or 2 for symbol 'O': ")
                    symbolChoice = Console.ReadLine()
            End Select
        End While
    End Sub
    Sub updateBoard(ByVal xCoord, ByVal yCoord, ByVal symbol)
        theBoard(xCoord, yCoord) = symbol
    End Sub
End Module
