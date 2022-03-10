using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practive
{
    internal class problem1275
    {
        public void Main1725()
        {
            int[][] grid = new int[3][];
            grid[0] = new int[] { 1, 0 };
            grid[1] = new int[] { 2, 0 };
            grid[2] = new int[] { 0, 1 };
            Console.WriteLine(Tictactoe(grid));
            Console.ReadKey();
        }
        public static string Tictactoe(int[][] moves)
        {
            int totalMoves = moves.GetLength(0);
            //2d array to hold moves
            string[,] array2D = new string[,] {
              { "E", "E", "E" }, //0,0 | 0,1 | 0,2
              { "E", "E", "E" }, //1,0 | 1,1 | 1,2
              { "E", "E", "E" }  //2,0 | 2,1 | 2,2
            };
            //print array for debug 
            printBoard(array2D);
            for (int i = 0; i < moves.GetLength(0); i++)
            {
                //determine who turn it is
                string move = "";
                if (i % 2 == 0)
                    move = "X";
                else
                    move = "O";
                //assign move to 2d board
                array2D[moves[i][0], moves[i][1]] = move;
                //print updated board to console for debug
                Console.WriteLine($"Index : {i}");
                printBoard(array2D);
            }
            return checkOutcome(array2D, totalMoves);
        }
        public static string checkOutcome(string[,] board, int totalMoves)
        {
            //check horizontal
            for (int i = 0; i < board.GetLength(0); i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    if (board[i, 0] == "X")
                        return "A";
                    else if (board[i, 0] == "O")
                        return "B";
                }
            }
            //check vertical
            for (int i = 0; i < board.GetLength(0); i++)
            {
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                {
                    if (board[0, i] == "X")
                        return "A";
                    else if (board[0, i] == "O")
                        return "B";
                }
            }
            //top left to bottom right diagnal
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                if (board[0, 0] == "X")
                    return "A";
                else if (board[0, 0] == "O")
                    return "B";
            }
            //top right to bottom left diagnal
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                if (board[0, 2] == "X")
                    return "A";
                else if (board[0, 2] == "O")
                    return "B";
            }
            //we know there is no winners, if there were 9 moves its draw, else pending
            if (totalMoves == 9)
                return "Draw";
            else
                return "Pending";
        }
        public static void printBoard(string[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                string line = "";
                line += (" | ");
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    line += ($" {board[i, j]} ");
                }
                line += (" | ");
                Console.WriteLine(line);
            }
        }
    }
}
