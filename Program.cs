using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Tic-Tac-Toe!");

        // Create a new instance of the game
        TicTacToeGame game = new TicTacToeGame();

        // Game loop
        while (!game.IsGameOver)
        {
            Console.Clear(); // Clear console for a clean display
            game.PrintBoard();

            // Get the current player's move
            int currentPlayer = game.GetCurrentPlayer();
            Console.WriteLine($"Player {currentPlayer}, enter your move (1-9): ");
            int move = int.Parse(Console.ReadLine());

            // Make the move and check for a winner
            game.MakeMove(move);
            if (game.CheckForWinner())
            {
                Console.Clear();
                game.PrintBoard();
                Console.WriteLine($"Player {currentPlayer} wins!");
                break;
            }

            // Switch to the next player
            game.SwitchPlayer();
        }

        Console.WriteLine("Game over!");
    }
}

class TicTacToeGame
{
    private char[] board;
    private int currentPlayer;

    public TicTacToeGame()
    {
        board = new char[9] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        currentPlayer = 1;
    }

    public bool IsGameOver { get; private set; }

    public void PrintBoard()
    {
        Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
        Console.WriteLine("-----------");
        Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
        Console.WriteLine("-----------");
        Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
    }

    public int GetCurrentPlayer()
    {
        return currentPlayer;
    }

    public void MakeMove(int position)
    {
        char symbol = (currentPlayer == 1) ? 'X' : 'O';

        if (position >= 1 && position <= 9 && board[position - 1] == (position + '0'))
        {
            board[position - 1] = symbol;
        }
        else
        {
            Console.WriteLine("Invalid move. Try again.");
            Console.ReadLine(); // Pause to let the user read the message
        }
    }

    public bool CheckForWinner()
    {
        // Check rows, columns, and diagonals for a winner
        // Implement your logic here

        // For simplicity, let's assume no winner for now
        return false;
    }

    public void SwitchPlayer()
    {
        currentPlayer = (currentPlayer == 1) ? 2 : 1;
    }
}



/* The “Driver” class (the Program.cs class with the main method where the program begins) 
will:
• Welcome the user to the game
• Create a game board array to store the players’ choices
• Ask each player in turn for their choice and update the game board array
• Print the board by calling the method in the supporting class
• Check for a winner by calling the method in the supporting class, and notify the players 
when a win has occurred and which player won the game */
