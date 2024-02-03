using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Class1
    {

        public static bool IsMoveValid(char[] board, int position)
        {
            return position >= 1 && position <= 9 && board[position] != 'X' && board[position] != 'O';
        }



        public string PrintBoard(char[] board)
        {
            //create board
            string boardOutput = "";
            boardOutput = " " + board[1] + " | " + board[2] + " | " + board[3] + "  \n" +
                        "---|---|--- \n" +
                        " " + board[4] + " | " + board[5] + " | " + board[6] + " \n" +
                        "---|---|--- \n" + 
                        " " + board[7] + " | " + board[8] + " | " + board[9] + " ";
            //return board
            return boardOutput;
        }
        public string WhoWon(char[] board, int turnCount)
        {
            string result = "";
            //winning combos
            string[] winningCombinations = {
                    "123", "456", "789",  // Horizontal
                    "147", "258", "369",  // Vertical
                    "159", "357"          // Diagonal
                };
            //check for winning combo
            foreach (string combination in winningCombinations)
            {
                int index1 = Convert.ToInt32(combination[0].ToString());
                int index2 = Convert.ToInt32(combination[1].ToString());
                int index3 = Convert.ToInt32(combination[2].ToString());

                char first = board[index1];
                char second = board[index2];
                char third = board[index3];

                // display winner 
                if (first == 'X' && second == 'X' && third == 'X')
                {
                    result = "Player X won!";
                    break; // Exit the loop when a winner is found
                }
                else if (first == 'O' && second == 'O' && third == 'O')
                {
                    result = "Player O won!";
                    break; // Exit the loop when a winner is found
                }
                // display tie
                else if (turnCount >= 9) 
                {
                    result = "Tie, play again!";
                    break;
                }
            }

            // If result is still empty, no winner was found in any combo
            if (result == "")
            {
                result = "Next player's turn!";
            }

            return result;
        }

    }
}
