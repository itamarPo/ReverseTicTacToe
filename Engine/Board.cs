namespace Ex05_Engine
{
    // $G$ CSS-012 (-3) This class is only referenced in the GameLogic, as it should, that is why it should be internal
    // And the other classes as well.
    public class Board
    {
        private readonly int r_BoardSize;
        private readonly ePieceType[,] r_BoardGame;
        private int m_NumOfEmptyCells;

        public Board(int i_BoardSize)
        {
            r_BoardSize = i_BoardSize;
            m_NumOfEmptyCells = i_BoardSize * i_BoardSize;
            r_BoardGame = new ePieceType[r_BoardSize, r_BoardSize];
            initializeBoard();
        }

        public int BoardSize
        {
            get => r_BoardSize;
        }

        public int NumOfEmptyCells
        {
            get => m_NumOfEmptyCells;
            set => m_NumOfEmptyCells = value;
        }

        public ePieceType GetCellValue(int i_Row, int i_Column)
        {
            return r_BoardGame[i_Row, i_Column];
        }

        public ePieceType[] GetEntireRow(int i_Row)
        {
            ePieceType[] entireRow = new ePieceType[r_BoardSize];

            for (int column = 0; column < r_BoardSize; column++)
            {
                entireRow.SetValue(GetCellValue(i_Row, column), column);
            }

            return entireRow; 
        }

        public ePieceType[] GetEntireColumn(int i_Column)
        {
            ePieceType[] entireColumn = new ePieceType[r_BoardSize];

            for (int row = 0; row < r_BoardSize; row++)
            {
                entireColumn.SetValue(GetCellValue(row, i_Column), row);
            }

            return entireColumn; 
        }

        public ePieceType[] GetPrimaryDiagonal()
        {
            ePieceType[] diagonal = new ePieceType[r_BoardSize];

            for(int i = 0; i < r_BoardSize; i++)
            {
                diagonal.SetValue(GetCellValue(i, i), i);
            }

            return diagonal; 
        }

        public ePieceType[] GetSecondaryDiagonal()
        {
            ePieceType[] diagonal = new ePieceType[r_BoardSize];

            for (int i = 0; i < r_BoardSize ; i++)
            {
                diagonal.SetValue(GetCellValue(i, r_BoardSize - (i+1)), i);
            }

            return diagonal; 
        }

        public void SetCellValue(int i_Row, int i_Column, ePieceType i_PlayerSymbol)
        {
            r_BoardGame[i_Row, i_Column] = i_PlayerSymbol;
            NumOfEmptyCells--;
        }

        private void initializeBoard()
        {
            for (int i = 0; i < r_BoardSize; i++)
            {
                for (int j = 0; j < r_BoardSize; j++)
                {
                    r_BoardGame[i, j] = ePieceType.Empty;
                }
            }
        }

        public void RestartBoard()
        {
            initializeBoard();
            m_NumOfEmptyCells = r_BoardSize * r_BoardSize;
        }

        public bool IsBoardFull()
        {
            return NumOfEmptyCells == 0;
        }
    }
}
