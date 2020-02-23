using System;

namespace Morpion
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] board = new string[3,3] {{" ", " ", " " }, { " ", " ", " " }, { " ", " ", " " }};
            int row = 0;
            int line = 0;
            int player_turn = 1;
            bool is_coord_ok = false;

            Console.WriteLine("  == TIC TAC TOE ==\n");

            while (!IsGameOver(board))
            {
                Console.WriteLine("  -- PLAYER " + player_turn + " TURN --\n");
                DrawBoard(board);

                is_coord_ok = false;

                while (!is_coord_ok)
                {
                    row = AskCorrectValue("row");
                    line = AskCorrectValue("line");

                    //bool v = board[row, line] == " ";
                    is_coord_ok = board[row, line] == " ";

                    if (!is_coord_ok)
                    {
                        Console.WriteLine("This case is filled, please select an empty one.\n");
                    }
                }


                if (player_turn == 1)
                {
                    board[row, line] = "X";
                    player_turn = 2;
                }
                else
                {
                    board[row, line] = "O";
                    player_turn = 1;
                }
            }
            
        }

        static int AskCorrectValue(string to_ask)
        {
            int input = -1;

            while (input < 1 || input > 3)
            {
                Console.Write("Choose your " + to_ask + " between 1 and 3 >> ");
                input = Convert.ToInt32(Console.ReadLine());

            }

            return input - 1;
        }

        static void DrawBoard(string[,] board)
        {
            string separator = "|";
            string start = "       ";

            Console.WriteLine(start + board[0, 0] + separator + board[1, 0] + separator + board[2, 0]);
            DrawHLine(start);
            Console.WriteLine(start + board[0, 1] + separator + board[1, 1] + separator + board[2, 1]);
            DrawHLine(start);
            Console.WriteLine(start + board[0, 2] + separator + board[1, 2] + separator + board[2, 2]);

            Console.WriteLine("\n");
        }

        static void DrawHLine(string start)
        {
            Console.Write(start);

            for (int i=0; i<5; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine();
        }

        static bool IsGameOver(string[,] board)
        {
            return false;
        }
    }
}
