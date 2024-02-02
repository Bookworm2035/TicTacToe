using System;
using System.Runtime.InteropServices;
using TicTacToe;


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
        int turnCount = 0;

        while (GameWon == false)
        {
            //turn counter for ties
            turnCount++;

            //turn prompt
            Console.Write($"Player {(PlayerX ? 'X' : 'O')}'s turn. Select your move, insert a number 1-9: ");
            moveChoice = Convert.ToInt32(Console.ReadLine());

            // Update the game board
            board[moveChoice] = (PlayerX ? 'X' : 'O');

            // Print the updated board
            Console.WriteLine(c.PrintBoard(board));

            // Check for a winner
            string result = c.WhoWon(board, turnCount);
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

