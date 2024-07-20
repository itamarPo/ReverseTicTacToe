namespace Ex05_Engine
{
    using System;
    using System.Collections.Generic;

    public class Engine
    {
        private Board m_Board;
        private ePlayer m_FirstPlayer;
        private ePlayer m_SecondPlayer;
        private string m_TheNameOfTheWinner;
        private ePlayerType m_PlayerTurn;
        public event EventHandler BoardUpdated;
        public event Action GameOver;

        public Engine() { }

        public ePlayer FirstPlayer
        {
            get => m_FirstPlayer;
        }

        public ePlayer SecondPlayer
        {
            get => m_SecondPlayer;
        }

        public ePlayerType PlayerTurn
        {
            get => m_PlayerTurn;
            set => m_PlayerTurn = value;
        }

        public string TheNameOfTheWinner
        {
            get => m_TheNameOfTheWinner;
        }
        
        public void SetBoardValue(int i_RowPostion, int i_ColPosition)
        {
            m_Board.SetCellValue(i_RowPostion, i_ColPosition, getPlayerPieceFromPlayerType(m_PlayerTurn));
            int[] pos = {i_RowPostion, i_ColPosition};
            BoardUpdated.Invoke(pos, EventArgs.Empty);
        }

        public void RestartGame()
        {
            m_Board.RestartBoard();
            m_PlayerTurn = ePlayerType.FirstPlayer;
            m_TheNameOfTheWinner = null;
        }

        private bool isBoardFull()
        {
            return m_Board.IsBoardFull();
        }

        private bool isThereVictory()
        {
            bool isThereVictory = false;
            ePlayer playerChecking, opponentPlayer;
           
            if (m_FirstPlayer.GetPlayerPiece() == getPlayerPieceFromPlayerType(m_PlayerTurn))
            {
                playerChecking = m_FirstPlayer;
                opponentPlayer = m_SecondPlayer;
            }
            else
            {
                playerChecking = m_SecondPlayer;
                opponentPlayer = m_FirstPlayer;
            }

            if(diagonalWinningCheck(playerChecking) || rowOrColumnWinningCheck(playerChecking))
            {
                opponentPlayer.Score++;
                m_TheNameOfTheWinner = opponentPlayer.Name;
                isThereVictory = true;
            }

            return isThereVictory;
        }

        public void EndOfTurn()
        {
            if (isThereVictory() || isBoardFull())
            {
                GameOver.Invoke();
            }
            else
            {
                if (m_PlayerTurn == ePlayerType.FirstPlayer)
                {
                    PlayerTurn = m_SecondPlayer.GetPlayerType == ePlayerType.SecondPlayer ? ePlayerType.SecondPlayer : ePlayerType.Computer;
                }
                else
                {
                    PlayerTurn = ePlayerType.FirstPlayer;
                }
            }
        }

        private bool diagonalWinningCheck(ePlayer i_Player)
        {
            bool diagonalSequenceOfSameShape = false;
            ePieceType[] primaryDiagonal, secondaryDiagonal;

            primaryDiagonal = m_Board.GetPrimaryDiagonal();
            secondaryDiagonal = m_Board.GetSecondaryDiagonal();
            if (checkIfIsASequenceOfSameShapes(primaryDiagonal, i_Player.GetPlayerPiece()) || 
                checkIfIsASequenceOfSameShapes(secondaryDiagonal, i_Player.GetPlayerPiece()))
            {
                diagonalSequenceOfSameShape = true;
            }

            return diagonalSequenceOfSameShape;
        }

        private bool rowOrColumnWinningCheck(ePlayer i_Player)
        {
            ePieceType[] row, col;
            bool rowOrColumnAreSequencial = false;

            for (int i = 0; i < m_Board.BoardSize; i++)
            {
                row = m_Board.GetEntireRow(i);
                col = m_Board.GetEntireColumn(i);
                if (checkIfIsASequenceOfSameShapes(row, i_Player.GetPlayerPiece()) ||
                    checkIfIsASequenceOfSameShapes(col, i_Player.GetPlayerPiece()))
                {
                    rowOrColumnAreSequencial = true;
                    break;
                }
            }

            return rowOrColumnAreSequencial;
        }

        private bool checkIfIsASequenceOfSameShapes(ePieceType[] i_SequenceShapes, ePieceType i_PlayerSymbol) 
        {
            bool areTheShapeInTheSequenceAreTheSame = true;

            foreach (ePieceType shape in i_SequenceShapes)
            {
                if(shape != i_PlayerSymbol)
                {
                    areTheShapeInTheSequenceAreTheSame = false;
                    break;
                }
            }

            return areTheShapeInTheSequenceAreTheSame;
        }

        public void MakeAiMove()
        {
            Random rand = new Random();
            List<int[]> availableCellsInBoard = new List<int[]>();
            List<int[]> optimazedAvailableCellsInBoard = new List<int[]>();
            int availableCount = 0, aviilableGoodLocationCount = 0, randomIndex;

            findValidAiMoves(ref availableCount,
                ref aviilableGoodLocationCount,
                ref availableCellsInBoard,
                ref optimazedAvailableCellsInBoard);
            if (aviilableGoodLocationCount > 0)
            {
                randomIndex = rand.Next(0, aviilableGoodLocationCount);
                SetBoardValue(optimazedAvailableCellsInBoard[randomIndex][0], 
                    optimazedAvailableCellsInBoard[randomIndex][1]);
            }
            else
            {
                randomIndex = rand.Next(0, availableCount);
                SetBoardValue(availableCellsInBoard[randomIndex][0], availableCellsInBoard[randomIndex][1]);
            }
        }

        private void findValidAiMoves(ref int io_AvailableCount, ref int io_AvailableGoodLocationCount,
            ref List<int[]> io_AvailableCellsInBoard, ref List<int[]> io_OptimazedAvailableCellsInBoard)
        {
            for (int i = 0; i < m_Board.BoardSize; i++)
            {
                for (int j = 0; j < m_Board.BoardSize; j++)
                {
                    if (m_Board.GetCellValue(i, j) == ePieceType.Empty)
                    {
                        io_AvailableCellsInBoard.Add(new int[2] {i, j});
                        io_AvailableCount++;

                        if (isAGoodPositionForAI(i, j))
                        {
                            io_OptimazedAvailableCellsInBoard.Add(new int[2] {i, j});
                            io_AvailableGoodLocationCount++;
                        }
                    }
                }
            }
        }

        private bool isAGoodPositionForAI(int i_Row, int i_Colum)    
        {
            ePieceType[] entireColumn = m_Board.GetEntireColumn(i_Colum);
            ePieceType[] entireRow = m_Board.GetEntireRow(i_Row);
            ePieceType[] primaryDiagonal = m_Board.GetPrimaryDiagonal();
            ePieceType[] scondaryDiagonal = m_Board.GetSecondaryDiagonal();

            return (!isLineContainsInputLocationOfAi(entireRow)
                && !isLineContainsInputLocationOfAi(entireColumn)
                && !isLineContainsInputLocationOfAi(primaryDiagonal) 
                && !isLineContainsInputLocationOfAi(scondaryDiagonal));
        }

        private bool isLineContainsInputLocationOfAi(ePieceType[] i_Line)
        {
            bool isValueInline = false;

            foreach (ePieceType symbol in i_Line)
            {
                if(symbol == ePieceType.PlayerO)
                {
                    isValueInline = true;
                    break;
                }
            }
            
            return isValueInline;
        }

        private ePieceType getPlayerPieceFromPlayerType(ePlayerType i_Player)
        {
            ePieceType pieceType;

            pieceType = i_Player == ePlayerType.FirstPlayer ? ePieceType.PlayerX : ePieceType.PlayerO;

            return pieceType;
        }

        public void InitializeEngine(int o_BoardSize, bool o_IsTwoHumanPlaying, string o_PlayerOneName, string o_PlayerTwoName)
        {
            const bool v_BoolIsPlayerHuman = true;

            m_Board = new Board(o_BoardSize);
            m_FirstPlayer = new ePlayer(ePieceType.PlayerX, v_BoolIsPlayerHuman, o_PlayerOneName);
            m_SecondPlayer = new ePlayer(ePieceType.PlayerO, o_IsTwoHumanPlaying, o_PlayerTwoName);
            m_PlayerTurn = ePlayerType.FirstPlayer;
            m_TheNameOfTheWinner = null;
        }
    }
}
