using System;
using System.Runtime.InteropServices;
using TicTacToe;

/* The “Driver” class (the Program.cs class with the main method where the program begins) 
will:
• Welcome the user to the game
• Create a game board array to store the players’ choices
• Ask each player in turn for their choice and update the game board array
• Print the board by calling the method in the supporting class
• Check for a winner by calling the method in the supporting class, and notify the players 
when a win has occurred and which player won the game */
//change this to 10 so we can use 1-9 positions and 0 will not be used 

class Program
{

    static void Main()
    {
        // Initialize the game board
        char[] board = new char[10];
        for (int i = 0; i < board.Length; i++)
        {
            board[i] = (char)(i + '0');// Convert the integer value to its character representation
        }

        // Create an instance of Class1
        Class1 c = new Class1();

        // Print the initial board
        Console.WriteLine(c.PrintBoard(board));

        int moveChoice;
        bool GameWon = false;
        bool PlayerX = true;

        while (GameWon == false)
        {
            Console.Write($"Player {(PlayerX ? 'X' : 'O')}'s turn. Select your move, insert a number 1-9: ");
            moveChoice = Convert.ToInt32(Console.ReadLine());

            // Update the game board
            board[moveChoice] = (PlayerX ? 'X' : 'O');

            // Print the updated board
            Console.WriteLine(c.PrintBoard(board));

            // Check for a winner
            string result = c.WhoWon(board);
            Console.WriteLine(result);

            // If there is a winner, end the game
            if (result.StartsWith("Player"))
            {
                GameWon = true;
            }

            // Switch to the other player's turn
            PlayerX = !PlayerX;
        }
    }
}

