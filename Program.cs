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

        int moveChoice= -1;
        bool GameWon = false;
        bool PlayerX = true;
        int turnCount = 0;
        string input;
        Console.WriteLine("Welcome to the best ever game of Tic-Tac-Toe");


        while (!GameWon)
        {
            //turn counter for ties
            turnCount++;

            // Turn prompt with input validation
            bool validInput = false;

            while (!validInput)
            {
                Console.Write($"Player {(PlayerX ? 'X' : 'O')}'s turn. Select your move, insert a number 1-9: ");
                input = Console.ReadLine();

                if (int.TryParse(input, out moveChoice) && moveChoice >= 1 && moveChoice <= 9)
                {
                    // Check if the selected position is available
                    if ( Class1.IsMoveValid(board, moveChoice))
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid move. The selected position is already taken. Please choose another position.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a single number between 1 and 9.");
                }

            }

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

                // If there is a tie, end the game
                if (result == "Tie, play again!")
                {
                    break;
                }
            // Switch to the other player's turn
            PlayerX = !PlayerX;

            
          
           
   
        }
    }
}

