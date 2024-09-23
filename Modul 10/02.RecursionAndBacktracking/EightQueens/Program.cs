using System.Runtime.ExceptionServices;

namespace EightQueens {
    internal class Program {
        static bool[,] board = new bool[8, 8];
        static bool[] attackedRows = new bool[8];
        static bool[] attackedColumns = new bool[8];
        // top right -> top left -> bottom left    ld[i] = (n - 1) - col + row
        static bool[] attackedLeftDiagonals = new bool[15];
        // top left -> top right -> bottom right   rd[i] = col + row
        static bool[] attackedRightDiagonals = new bool[15];
        static Stack<(int, int)> queenPositions = new();
        static void Main(string[] args) {
            try {
                FindSolutionToEightQueens();
            }
            catch (Exception) {
            }
                PutAllQueensOnBoard(queenPositions);
                PrintBoard(board);
            //PrintBoard(board);
        }
        static private bool CanPlaceQueen(int row, int col) {
            if (attackedRows[row]
                || attackedColumns[col]
                || attackedLeftDiagonals[(attackedRows.Length - 1) - col + row]
                || attackedRightDiagonals[col + row])
                return false;
            return true;
        }

        static private void PlaceQueen(int row, int col) {
            attackedRows[row] = true;
            attackedColumns[col] = true;
            attackedLeftDiagonals[(attackedRows.Length - 1) - col + row] = true;
            attackedRightDiagonals[col + row] = true;
            queenPositions.Push((row, col));
        }

        static private (int, int) RemoveQueen() {
            (int row, int col) = queenPositions.Pop();
            attackedRows[row] = false;
            attackedColumns[col] = false;
            attackedLeftDiagonals[(attackedRows.Length - 1) - col + row] = false;
            attackedRightDiagonals[col + row] = false;
            return (row, col);
        }

        static private void PutAllQueensOnBoard(Stack<(int, int)> queens) {
            for (int i = 0; i < board.GetLength(0); i++) {
                (int row, int col) = queens.Pop();
                board[row, col] = true;
            }
        }

        static private void PrintBoard(bool[,] board) {
            int rowLength = board.GetLength(0);
            for (int i = 0; i < rowLength; i++) {
                for (int j = 0; j < rowLength; j++) {
                    Console.Write(board[i, j].GetHashCode() + " ");
                }
                Console.WriteLine();
            }
        }
        
        static private (int, int) FindSolutionToEightQueens(int col = 0, int row = 0) {
            int boardLength = board.GetLength(0);
            if (col >= boardLength)
                return queenPositions.Peek();

            if (row >= boardLength) {
                (int lastRow, int lastCol) = RemoveQueen();
                FindSolutionToEightQueens(lastCol, lastRow + 1);
            }

            if (!CanPlaceQueen(row, col)) 
                return FindSolutionToEightQueens(col, row + 1);

            PlaceQueen(row, col);
            return FindSolutionToEightQueens(col + 1);
        }
    }
}
