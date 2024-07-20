namespace Ex05_UserInterface
{
    partial class TicTacToeForm
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
            this.playerOneScoreLabel = new System.Windows.Forms.Label();
            this.mainTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.playerTwoScoreLabel = new System.Windows.Forms.Label();
            this.mainTablePanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerOneScoreLabel
            // 
            this.playerOneScoreLabel.AutoSize = true;
            this.playerOneScoreLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.playerOneScoreLabel.Location = new System.Drawing.Point(288, 0);
            this.playerOneScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerOneScoreLabel.Name = "playerOneScoreLabel";
            this.playerOneScoreLabel.Size = new System.Drawing.Size(69, 48);
            this.playerOneScoreLabel.TabIndex = 0;
            this.playerOneScoreLabel.Text = "ePlayer 1:";
            // 
            // mainTablePanel
            // 
            this.mainTablePanel.ColumnCount = 1;
            this.mainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTablePanel.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.mainTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTablePanel.Location = new System.Drawing.Point(0, 0);
            this.mainTablePanel.Name = "mainTablePanel";
            this.mainTablePanel.RowCount = 2;
            this.mainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.22801F));
            this.mainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.771987F));
            this.mainTablePanel.Size = new System.Drawing.Size(812, 543);
            this.mainTablePanel.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.78908F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.831265F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.25558F));
            this.tableLayoutPanel2.Controls.Add(this.playerOneScoreLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.playerTwoScoreLabel, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 492);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(806, 48);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // playerTwoScoreLabel
            // 
            this.playerTwoScoreLabel.AutoSize = true;
            this.playerTwoScoreLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.playerTwoScoreLabel.Location = new System.Drawing.Point(412, 0);
            this.playerTwoScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerTwoScoreLabel.Name = "playerTwoScoreLabel";
            this.playerTwoScoreLabel.Size = new System.Drawing.Size(69, 48);
            this.playerTwoScoreLabel.TabIndex = 1;
            this.playerTwoScoreLabel.Text = "ePlayer 2:";
            // 
            // TicTacToeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 543);
            this.Controls.Add(this.mainTablePanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TicTacToeForm";
            this.Text = "TicTacToeForm";
            this.mainTablePanel.ResumeLayout(false);
            this.mainTablePanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label playerOneScoreLabel;
        private System.Windows.Forms.TableLayoutPanel mainTablePanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label playerTwoScoreLabel;
    }
}