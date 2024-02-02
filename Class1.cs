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
        public string PrintBoard(char[] board)
        {
            string boardOutput = "";
            boardOutput = " " + board[1] + " | " + board[2] + " | " + board[3] + "  \n" +
                        "---|---|--- \n" +
                        " " + board[4] + " | " + board[5] + " | " + board[6] + " \n" +
                        "---|---|--- \n" + 
                        " " + board[7] + " | " + board[8] + " | " + board[9] + " ";

            return boardOutput;
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
                int index1 = Convert.ToInt32(combination[0].ToString());
                int index2 = Convert.ToInt32(combination[1].ToString());
                int index3 = Convert.ToInt32(combination[2].ToString());

                char first = board[index1];
                char second = board[index2];
                char third = board[index3];

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
