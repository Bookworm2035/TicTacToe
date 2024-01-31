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

            if ((board[0] == 'X' && board[1] == 'X' && board[2] == 'X') || 
                (board[3] == 'X' && board[4] == 'X' && board[5] == 'X') ||
                (board[6] == 'X' && board[7] == 'X' && board[8] == 'X') ||
                (board[0] == 'X' && board[3] == 'X' && board[6] == 'X') ||
                (board[1] == 'X' && board[4] == 'X' && board[7] == 'X') ||
                (board[2] == 'X' && board[5] == 'X' && board[8] == 'X') ||
                (board[0] == 'X' && board[4] == 'X' && board[8] == 'X') ||
                (board[2] == 'X' && board[4] == 'X' && board[6] == 'X'))
            {
                result = "Player X won!";
            }
            else if ((board[0] == 'O' && board[1] == 'O' && board[2] == 'O') ||
                    (board[3] == 'O' && board[4] == 'O' && board[5] == 'O') ||
                    (board[6] == 'O' && board[7] == 'O' && board[8] == 'O') ||
                    (board[0] == 'O' && board[3] == 'O' && board[6] == 'O') ||
                    (board[1] == 'O' && board[4] == 'O' && board[7] == 'O') ||
                    (board[2] == 'O' && board[5] == 'O' && board[8] == 'O') ||
                    (board[0] == 'O' && board[4] == 'O' && board[8] == 'O') ||
                    (board[2] == 'O' && board[4] == 'O' && board[6] == 'O'))
            {
                result = "Player O won!";
            }

            return result;
        }

    }
}
