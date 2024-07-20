namespace Ex05_UserInterface
{
    using System;
    using System.Text;
    using System.Windows.Forms;
    using Ex05_Engine;

    // $G$ SFN-004 (-5) The form's size should be determined by the board's size.
    public class GameRunner
    {
        private readonly GameSettingsForm r_GameSettingsForm;
        private readonly TicTacToeForm r_TicTacToeForm;
        private readonly Engine r_GameEngine;
        private const string k_FontName = "Microsoft Sans Serif";
        private const string k_Tie = "Tie!";

        public GameRunner()
        {
            r_GameSettingsForm = new GameSettingsForm();
            r_TicTacToeForm = new TicTacToeForm();
            r_GameEngine = new Engine();
        }

        public void Run()
        {
            r_GameSettingsForm.GameSettingsCloses += onGameSettingClose;
            r_GameSettingsForm.ShowDialog();
        }

        private void intializeGameSettings()
        {
            string secondPlayerName = !r_GameSettingsForm.IsAgainstComputer ? r_GameSettingsForm.SecondPlayerName :
                                          r_GameSettingsForm.SecondPlayerName.Substring
                                              (1, r_GameSettingsForm.SecondPlayerName.Length - 2);


            // $G$ CSS-999 (-3) Unnecessary blank lines
            r_GameEngine.InitializeEngine(r_GameSettingsForm.BoardSize, !r_GameSettingsForm.IsAgainstComputer,
            r_GameSettingsForm.FirstPlayerName, secondPlayerName);
        }

        private void onGameSettingClose()
        {
            if(r_GameSettingsForm.ButtonStartClicked)
            {
                intializeGameSettings();
                gameSetUpSession();
            }
            else
            {
                r_GameSettingsForm.Close();
            }
        }

        private void gameSetUpSession()
        {
            linkEngineEvents();
            linkGuiEvents();
            r_TicTacToeForm.InitilaizeSettings(r_GameEngine.FirstPlayer.Name,
                r_GameEngine.SecondPlayer.Name, r_GameSettingsForm.BoardSize);
            r_TicTacToeForm.ShowDialog();
        }

        // $G$ CSS-011 (-3) Bad private method name. Should be pascalCased.
        private void TicTacToeForm_ButtonClicked(object sender, ButtonLocationEventArgs e)
        {
            int rowIndex, columnIndex;
            Button button = (Button)sender;

            rowIndex = e.RowIndex;
            columnIndex = e.ColumnIndex;
            if(button.Enabled)
            {
                r_GameEngine.SetBoardValue(rowIndex, columnIndex);
            }

            endTurnProcess();
        }

        private void endTurnProcess()
        {
            r_GameEngine.EndOfTurn();
            if(r_GameEngine.PlayerTurn == ePlayerType.Computer)
            {
                r_GameEngine.MakeAiMove();
                r_GameEngine.EndOfTurn();
            }
        }

        private void engine_BoardUpdated(object sender, EventArgs e)
        {
            int[] pos = (int[])sender;
            Button button = r_TicTacToeForm.GetButtonFromLocation(pos[0], pos[1]);
            button.Text = getPlayerSymbol(r_GameEngine.PlayerTurn);
            button.Font = new System.Drawing.Font(k_FontName, 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)177);
            button.Enabled = !button.Enabled;
        }

        private void linkEngineEvents()
        {
            r_GameEngine.GameOver += engine_GameOverEvent;
            r_GameEngine.BoardUpdated += engine_BoardUpdated;
        }

        private void linkGuiEvents()
        {
            r_TicTacToeForm.ButtonClicked += TicTacToeForm_ButtonClicked;
        }

        private void engine_GameOverEvent()
        {
            bool isAnotherRound;
            string endGameMessageTitle = string.IsNullOrEmpty(r_GameEngine.TheNameOfTheWinner) ? k_Tie : "A Win!";

            isAnotherRound = r_TicTacToeForm.GetUserRestartGameResponse(GameOverMsg(r_GameEngine.TheNameOfTheWinner), endGameMessageTitle);
            if(isAnotherRound)
            {
                r_TicTacToeForm.UpdateScore(r_GameEngine.FirstPlayer.Score, r_GameEngine.FirstPlayer.Name, r_GameEngine.FirstPlayer);
                r_TicTacToeForm.UpdateScore(r_GameEngine.SecondPlayer.Score, r_GameEngine.SecondPlayer.Name, r_GameEngine.SecondPlayer);
                r_GameEngine.RestartGame();
                r_TicTacToeForm.InitDynamicButtonClick();
            }
            else
            {
                r_TicTacToeForm.Close();
            }
        }

        public string GameOverMsg(string i_NameOfTheWinner)
        {
            StringBuilder endGameMessage = new StringBuilder();

            if(string.IsNullOrEmpty(i_NameOfTheWinner))
            {
                endGameMessage.Append(k_Tie);
            }
            else
            {
                endGameMessage.Append(string.Format($"The winner is {i_NameOfTheWinner}!"));
            }

            endGameMessage.Append(string.Format($"{Environment.NewLine}Would you like to play another round?"));

            return endGameMessage.ToString();
        }

        private string getPlayerSymbol(ePlayerType playerType)
        {
            return playerType == ePlayerType.FirstPlayer ? "X" : "O";
        }
    }
}
