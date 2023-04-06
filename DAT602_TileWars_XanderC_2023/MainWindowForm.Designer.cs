namespace DAT602_TileWars_XanderC_2023
{
    partial class MainWindowForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.JoinGameButton = new System.Windows.Forms.Button();
            this.AdminConsoleButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(258, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 81);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tile Wars";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewGameButton
            // 
            this.NewGameButton.Location = new System.Drawing.Point(322, 158);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(144, 69);
            this.NewGameButton.TabIndex = 0;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = true;
            // 
            // JoinGameButton
            // 
            this.JoinGameButton.Location = new System.Drawing.Point(322, 264);
            this.JoinGameButton.Name = "JoinGameButton";
            this.JoinGameButton.Size = new System.Drawing.Size(144, 69);
            this.JoinGameButton.TabIndex = 1;
            this.JoinGameButton.Text = "Join Game";
            this.JoinGameButton.UseVisualStyleBackColor = true;
            // 
            // AdminConsoleButton
            // 
            this.AdminConsoleButton.Location = new System.Drawing.Point(694, 385);
            this.AdminConsoleButton.Name = "AdminConsoleButton";
            this.AdminConsoleButton.Size = new System.Drawing.Size(94, 53);
            this.AdminConsoleButton.TabIndex = 2;
            this.AdminConsoleButton.Text = "Admin Controles";
            this.AdminConsoleButton.UseVisualStyleBackColor = true;
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(12, 385);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(94, 53);
            this.LogOutButton.TabIndex = 9;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.AdminConsoleButton);
            this.Controls.Add(this.JoinGameButton);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.label1);
            this.Name = "MainWindowForm";
            this.Text = "Main Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button NewGameButton;
        private Button JoinGameButton;
        private Button AdminConsoleButton;
        private Button LogOutButton;
    }
}