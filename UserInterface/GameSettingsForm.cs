namespace Ex05_UserInterface
{
    using System;
    using System.Windows.Forms;

    public partial class GameSettingsForm : Form
    {
        private const string k_ComputerStringText  ="[Computer]";
        private bool m_ButtonStartClicked = false;
        public event Action GameSettingsCloses;

        public string FirstPlayerName
        {
            get => textBoxPlayerOneName.Text;
        }

        public string SecondPlayerName
        {
            get => textBoxPlayerTwoName.Text;
        }

        public bool IsAgainstComputer
        {
            get => !textBoxPlayerTwoName.Enabled;
        }

        public int BoardSize
        {
            get => (int)nUDCols.Value;
        }

        public bool ButtonStartClicked
        {
            get => m_ButtonStartClicked;
        }

        public GameSettingsForm()
        {
            InitializeComponent();
            this.MaximizeBox = false; 
            this.MinimizeBox = false; 
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            nUDCols.ReadOnly = true;
            nUDRows.ReadOnly = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void nUDCols_ValueChanged(object sender, EventArgs e)
        {
            nUDCols.Text = nUDCols.Value.ToString();
            nUDRows.Value = nUDCols.Value;
            nUDRows.Text = nUDCols.Text;
        }

        private void checkBoxPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPlayerTwo.Checked)
            {
                textBoxPlayerTwoName.Text = string.Empty;
                textBoxPlayerTwoName.Enabled = true;             
            }
            else
            {
                textBoxPlayerTwoName.Text = k_ComputerStringText;
                textBoxPlayerTwoName.Enabled = false;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxPlayerOneName.Text) || string.IsNullOrEmpty(textBoxPlayerTwoName.Text))
            {
                MessageBox.Show("Please enter names for both players");
            }
            else
            {
                m_ButtonStartClicked = true;
                this.Close();
            } 
        }

        private void nUDRows_ValueChanged(object sender, EventArgs e)
        {
            nUDRows.Text = nUDRows.Value.ToString();
            nUDCols.Value = nUDRows.Value;
            nUDCols.Text = nUDRows.Text;
        }

        private void onGameSettingsCloses(object sender, FormClosedEventArgs e)
        {
            GameSettingsCloses.Invoke();
        }
    }
}
