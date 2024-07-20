namespace Ex05_Engine
{
    public class ePlayer
    {
        private readonly ePlayerType r_PlayerType;
        private readonly ePieceType r_PieceType;
        private readonly string r_Name;
        private int m_Score;

        public ePlayer(ePieceType i_PlayerPiece, bool i_IsHuman, string i_Name)
        {
            r_PlayerType = determinePlayerType(i_IsHuman, i_PlayerPiece);
            r_PieceType = i_PlayerPiece;
            r_Name = i_Name;
            m_Score = 0;
        }

        public ePieceType GetPlayerPiece()
        {
            return r_PieceType;
        }

        public ePlayerType GetPlayerType
        {
            get => r_PlayerType;
        }

        public int Score
        {
           get => m_Score;
           set => m_Score = value;
        }

        public string Name
        {
            get => r_Name;
        }

        private ePlayerType determinePlayerType(bool i_IsHuman, ePieceType i_PlayerPiece)
        {
            ePlayerType playerType;

            if (i_PlayerPiece == ePieceType.PlayerX)
            {
                playerType = ePlayerType.FirstPlayer;
            }
            else if (i_IsHuman)
            {
                playerType = ePlayerType.SecondPlayer;
            }
            else
            {
                playerType = ePlayerType.Computer;
            }

            return playerType;
        }
    }
}
