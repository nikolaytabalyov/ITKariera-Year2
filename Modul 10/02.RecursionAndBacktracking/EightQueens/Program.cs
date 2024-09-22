namespace EightQueens {
    internal class Program {
        bool[,] board = new bool[8, 8];
        bool[] attackedRows = new bool[8];
        bool[] attackedColumns = new bool[8];
        // top right -> top left -> bottom left    ld[i] = (n - 1) - col + row
        bool[] attackedLeftDiagonals = new bool[8];
        // top left -> top right -> bottom right   rd[i] = col + row
        bool[] attackedRightDiagonals = new bool[8];

        static void Main(string[] args) {

        }
        private bool CanPlaceQueen(int row, int col) {
            if (attackedRows[row]
                || attackedColumns[col]
                || attackedLeftDiagonals[(attackedRows.Length - 1) - col + row]
                || attackedRightDiagonals[col + row])
                return false;
            return true;
        }

        private void PlaceQueen(int row, int col) {
            attackedRows[row] = true;
            attackedColumns[col] = true;
            attackedLeftDiagonals[(attackedRows.Length - 1) - col + row] = true;
            attackedRightDiagonals[col + row] = true;
        }
    }
}
