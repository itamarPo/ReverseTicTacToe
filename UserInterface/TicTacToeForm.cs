namespace Ex05_UserInterface
{
    using System;
    using System.Windows.Forms;
    using Ex05_Engine;

    public partial class TicTacToeForm : Form
    {
        private int m_BoardSize;
        private TableLayoutPanel m_DynamicButtonTable;
        public event EventHandler<ButtonLocationEventArgs> ButtonClicked;

        public TicTacToeForm()
        {
            InitializeComponent();
        }

        private void createDynamicTable()
        {
            m_DynamicButtonTable = new TableLayoutPanel();
            m_DynamicButtonTable.Dock = DockStyle.Fill;
            m_DynamicButtonTable.RowCount = m_BoardSize;
            m_DynamicButtonTable.ColumnCount = m_BoardSize;

            for (int i = 0; i < m_BoardSize; i++)
            {
                m_DynamicButtonTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / m_BoardSize));
            }

            for (int j = 0; j < m_BoardSize; j++)
            {
                m_DynamicButtonTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / m_BoardSize));
            }

            for (int i = 0; i < m_BoardSize; i++)
            {
                for (int j = 0; j < m_BoardSize; j++)
                {
                    Button button = new Button();
                    button.Dock = DockStyle.Fill;
                    button.Click += button_Click; 
                    m_DynamicButtonTable.Controls.Add(button, j, i);
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int rowIndex = m_DynamicButtonTable.GetRow(button);
            int columnIndex = m_DynamicButtonTable.GetColumn(button);
            ButtonLocationEventArgs locationEventArgs = new ButtonLocationEventArgs(rowIndex, columnIndex);
     
            ButtonClicked?.Invoke(button, locationEventArgs);
        }

        private bool createEndGameMessage(string i_EndGameMessage, string i_Title)
        {
            DialogResult dialogResult = MessageBox.Show(i_EndGameMessage, i_Title, MessageBoxButtons.YesNo);

            return dialogResult == DialogResult.Yes;
        }

        public bool GetUserRestartGameResponse(string i_GameOverMsg, string i_EndGameMessageTitle)
        {
            return createEndGameMessage(i_GameOverMsg, i_EndGameMessageTitle);
        }

        public void InitilaizeSettings(string i_PlayerOneName, string i_PlayerTwoName, int i_BoardSize)
        {
            m_BoardSize = i_BoardSize;
            createDynamicTable();
            playerOneScoreLabel.Text = string.Format($"{i_PlayerOneName}: 0");
            playerTwoScoreLabel.Text = string.Format($"{i_PlayerTwoName}: 0");
            mainTablePanel.Controls.Add(m_DynamicButtonTable,0,0);
        }

        public void UpdateScore(int i_Score, string i_PlayerName, ePlayer i_Player)
        {
            if (i_Player.GetPlayerType == ePlayerType.FirstPlayer)
            {
                playerOneScoreLabel.Text = string.Format($"{i_Player.Name}: {i_Player.Score}");
            }
            else
            {
                playerTwoScoreLabel.Text = string.Format($"{i_Player.Name}: {i_Player.Score}");
            }
        }

        public Button GetButtonFromLocation(int i_RowIndex, int i_ColumnIndex)
        {
            Button button = null;

            foreach (Control control in m_DynamicButtonTable.Controls)
            {
                if (control is Button buttonControl && m_DynamicButtonTable.GetRow(buttonControl) == i_RowIndex && 
                    m_DynamicButtonTable.GetColumn(buttonControl) == i_ColumnIndex)
                {
                    button = buttonControl;
                    break;
                }
            }

            return button;
        }

        public void InitDynamicButtonClick()
        {
            foreach (Control control in m_DynamicButtonTable.Controls)
            {
                if (control is Button button)
                {
                    button.Enabled = true;
                    button.Text = string.Empty;
                }
            }
        }
    }
}

