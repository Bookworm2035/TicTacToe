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

char[] board = new char[10];

for (int i = 0; i < board.Length; i++)
{
    board[i] = (char)(i + '0');  // Convert the integer value to its character representation
}

//debug statements can be deleted
Console.WriteLine(board[1]);
Console.WriteLine(board[2]);

int moveChoice2;
int moveChoice;
bool GameWon = false;
// Create an instance of Class1
Class1 c = new Class1();

// Call PrintBoard method
Console.WriteLine(c.PrintBoard(board));


while (GameWon == false) {
    //PUT THE LOOP ALL

    // Ask for choice and update array
    bool PlayerX = true;

    Console.Write("Player X will start. Select your move, insert a number 1-9: ");
    moveChoice = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(c.PrintBoard(board));
    //debug check variable value
    Console.WriteLine(moveChoice);

    //add X or O to array spot based on player name
    //numbers[positionToAdd] = valueToAdd;
    if (PlayerX == true) {
       board[moveChoice] = 'X';
    }
    else {
        board[moveChoice] = 'O';
    }
    //
    c.WhoWon();

    //other players turn 
    PlayerX = false;
    Console.Write("Player O's turn. Select your move, insert a number 1-9: ");
    moveChoice2 = Convert.ToInt32(Console.ReadLine());

    if (PlayerX == true)
    {
        board[moveChoice2] = 'X';
    }
    else
    {
        board[moveChoice2] = 'O';
    }
    Console.WriteLine(board);
}

//after there is a winner
//display stuff here :) 
