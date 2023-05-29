﻿namespace DAT602_TileWars_XanderC_2023
{
    partial class GameBoardForm
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
            gameBoardDataGrid = new DataGridView();
            backBtn = new Button();
            YourScoreboard = new Label();
            OpponentsScoreboard = new Label();
            ((System.ComponentModel.ISupportInitialize)gameBoardDataGrid).BeginInit();
            SuspendLayout();
            // 
            // gameBoardDataGrid
            // 
            gameBoardDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gameBoardDataGrid.Location = new Point(220, 15);
            gameBoardDataGrid.Name = "gameBoardDataGrid";
            gameBoardDataGrid.RowHeadersWidth = 51;
            gameBoardDataGrid.RowTemplate.Height = 29;
            gameBoardDataGrid.Size = new Size(504, 421);
            gameBoardDataGrid.TabIndex = 4;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(39, 387);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(134, 28);
            backBtn.TabIndex = 5;
            backBtn.Text = "Back to Home";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // YourScoreboard
            // 
            YourScoreboard.AutoSize = true;
            YourScoreboard.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            YourScoreboard.Location = new Point(12, 36);
            YourScoreboard.Name = "YourScoreboard";
            YourScoreboard.Size = new Size(143, 25);
            YourScoreboard.TabIndex = 7;
            YourScoreboard.Text = "Your Score = 0";
            // 
            // OpponentsScoreboard
            // 
            OpponentsScoreboard.AutoSize = true;
            OpponentsScoreboard.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OpponentsScoreboard.Location = new Point(12, 81);
            OpponentsScoreboard.Name = "OpponentsScoreboard";
            OpponentsScoreboard.Size = new Size(199, 25);
            OpponentsScoreboard.TabIndex = 8;
            OpponentsScoreboard.Text = "Opponents Score = 0";
            // 
            // GameBoardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 448);
            Controls.Add(OpponentsScoreboard);
            Controls.Add(YourScoreboard);
            Controls.Add(backBtn);
            Controls.Add(gameBoardDataGrid);
            Name = "GameBoardForm";
            Text = "Game Board";
            ((System.ComponentModel.ISupportInitialize)gameBoardDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView gameBoardDataGrid;
        private Button backBtn;
        private Label YourScoreboard;
        private Label OpponentsScoreboard;
    }
}