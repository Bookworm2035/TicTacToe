using System;
using TicTacToe;

/* The “Driver” class (the Program.cs class with the main method where the program begins) 
will:
• Welcome the user to the game
• Create a game board array to store the players’ choices
• Ask each player in turn for their choice and update the game board array
• Print the board by calling the method in the supporting class
• Check for a winner by calling the method in the supporting class, and notify the players 
when a win has occurred and which player won the game */
char[] board = new char[9];
char moveChoice;

// Create an instance of Class1
Class1 c = new Class1();

// Call PrintBoard method
c.PrintBoard(board);

// Ask for choice and update array
Console.Write("Player X will start. Select your move, insert a number 1-9: ");
moveChoice = Convert.ToChar(Console.ReadLine());

