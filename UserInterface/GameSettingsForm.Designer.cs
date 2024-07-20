 namespace Ex05_UserInterface
{
    partial class GameSettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPlayerOneName = new System.Windows.Forms.TextBox();
            this.textBoxPlayerTwoName = new System.Windows.Forms.TextBox();
            this.checkBoxPlayerTwo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nUDRows = new System.Windows.Forms.NumericUpDown();
            this.nUDCols = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUDRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCols)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(88, 191);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(206, 35);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start!";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Players:";
            // 
            // textBoxPlayerOneName
            // 
            this.textBoxPlayerOneName.Location = new System.Drawing.Point(85, 38);
            this.textBoxPlayerOneName.Name = "textBoxPlayerOneName";
            this.textBoxPlayerOneName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlayerOneName.TabIndex = 4;
            // 
            // textBoxPlayerTwoName
            // 
            this.textBoxPlayerTwoName.Enabled = false;
            this.textBoxPlayerTwoName.Location = new System.Drawing.Point(85, 69);
            this.textBoxPlayerTwoName.Name = "textBoxPlayerTwoName";
            this.textBoxPlayerTwoName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlayerTwoName.TabIndex = 5;
            this.textBoxPlayerTwoName.Text = "[Computer]";
            // 
            // checkBoxPlayerTwo
            // 
            this.checkBoxPlayerTwo.AutoSize = true;
            this.checkBoxPlayerTwo.Location = new System.Drawing.Point(14, 71);
            this.checkBoxPlayerTwo.Name = "checkBoxPlayerTwo";
            this.checkBoxPlayerTwo.Size = new System.Drawing.Size(64, 17);
            this.checkBoxPlayerTwo.TabIndex = 6;
            this.checkBoxPlayerTwo.Text = "Player 2";
            this.checkBoxPlayerTwo.UseVisualStyleBackColor = true;
            this.checkBoxPlayerTwo.CheckedChanged += new System.EventHandler(this.checkBoxPlayer2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Board Size:";
            // 
            // nUDRows
            // 
            this.nUDRows.Location = new System.Drawing.Point(88, 145);
            this.nUDRows.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDRows.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nUDRows.Name = "nUDRows";
            this.nUDRows.Size = new System.Drawing.Size(42, 20);
            this.nUDRows.TabIndex = 8;
            this.nUDRows.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nUDRows.ValueChanged += new System.EventHandler(this.nUDRows_ValueChanged);
            // 
            // nUDCols
            // 
            this.nUDCols.Location = new System.Drawing.Point(235, 145);
            this.nUDCols.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDCols.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nUDCols.Name = "nUDCols";
            this.nUDCols.Size = new System.Drawing.Size(43, 20);
            this.nUDCols.TabIndex = 9;
            this.nUDCols.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nUDCols.ValueChanged += new System.EventHandler(this.nUDCols_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Columns";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Rows";
            // 
            // GameSettingsForm
            // 
            this.AcceptButton = this.buttonStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 254);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nUDCols);
            this.Controls.Add(this.nUDRows);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxPlayerTwo);
            this.Controls.Add(this.textBoxPlayerTwoName);
            this.Controls.Add(this.textBoxPlayerOneName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStart);
            this.MaximizeBox = false;
            this.Name = "GameSettingsForm";
            this.Text = "GameSettingsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onGameSettingsCloses);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUDRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPlayerOneName;
        private System.Windows.Forms.TextBox textBoxPlayerTwoName;
        private System.Windows.Forms.CheckBox checkBoxPlayerTwo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nUDRows;
        private System.Windows.Forms.NumericUpDown nUDCols;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

