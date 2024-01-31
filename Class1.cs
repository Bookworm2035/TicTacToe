using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{

     /*) The supporting class (with whichever name you choose) will:
        • Receive the “board” array from the driver class
        • Contain a method that prints the board based on the information passed to it
        • Contain a method that receives the game board array as input and returns if there is a
        winner and who it was
         */
    internal class Class1
    {
        public void PrintBoard(char[] board)
        {

            Console.WriteLine(" " + board[0] + " | " + board[1] + " | " + board[2] + " ");
            Console.WriteLine("---|---|---");
            Console.WriteLine(" " + board[3] + " | " + board[4] + " | " + board[5] + " ");
            Console.WriteLine("---|---|---");
            Console.WriteLine(" " + board[6] + " | " + board[7] + " | " + board[8] + " ");

            Console.ReadLine();
        }

        public string WhoWon(char[] board)
        {
            string result = "";

            string[] winningCombinations = {
                "012", "345", "678",  // Horizontal
                "036", "147", "258",  // Vertical
                "048", "246"          // Diagonal
            };

            foreach (string combination in winningCombinations)
            {
                char first = board[combination[0]];
                char second = board[combination[1]];
                char third = board[combination[2]];

                if (first == 'X' && second == 'X' && third == 'X')
                {
                    result = "Player X won!";
                }
                else if (first == 'O' && second == 'O' && third == 'O')
                {
                    result = "Player O won!";
                }
                else
                {
                    result = "Next player's turn!";
                }
            }

            return result;
        }

    }
}
