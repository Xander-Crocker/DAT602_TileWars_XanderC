namespace DAT602_TileWars_XanderC_2023
{
    partial class RegistrationForm
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
            label1 = new Label();
            PasswordTextbox = new TextBox();
            EmailTextbox = new TextBox();
            RegistrationButton = new Button();
            LoginButton = new Button();
            LastNameTextbox = new TextBox();
            FirstNameTextbox = new TextBox();
            UsernameTextbox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(248, 9);
            label1.Name = "label1";
            label1.Size = new Size(274, 81);
            label1.TabIndex = 9;
            label1.Text = "Tile Wars";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.Location = new Point(279, 329);
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.Size = new Size(211, 27);
            PasswordTextbox.TabIndex = 4;
            PasswordTextbox.Text = "Password";
            // 
            // EmailTextbox
            // 
            EmailTextbox.Location = new Point(279, 220);
            EmailTextbox.Name = "EmailTextbox";
            EmailTextbox.Size = new Size(211, 27);
            EmailTextbox.TabIndex = 3;
            EmailTextbox.Text = "Email";
            // 
            // RegistrationButton
            // 
            RegistrationButton.Location = new Point(396, 386);
            RegistrationButton.Name = "RegistrationButton";
            RegistrationButton.Size = new Size(94, 29);
            RegistrationButton.TabIndex = 5;
            RegistrationButton.Text = "Register";
            RegistrationButton.UseVisualStyleBackColor = true;
            RegistrationButton.Click += RegistrationButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(279, 386);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(94, 29);
            LoginButton.TabIndex = 6;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // LastNameTextbox
            // 
            LastNameTextbox.Location = new Point(279, 163);
            LastNameTextbox.Name = "LastNameTextbox";
            LastNameTextbox.Size = new Size(211, 27);
            LastNameTextbox.TabIndex = 1;
            LastNameTextbox.Text = "Last Name";
            // 
            // FirstNameTextbox
            // 
            FirstNameTextbox.Location = new Point(279, 105);
            FirstNameTextbox.Name = "FirstNameTextbox";
            FirstNameTextbox.Size = new Size(211, 27);
            FirstNameTextbox.TabIndex = 0;
            FirstNameTextbox.Text = "First Name";
            // 
            // UsernameTextbox
            // 
            UsernameTextbox.Location = new Point(279, 275);
            UsernameTextbox.Name = "UsernameTextbox";
            UsernameTextbox.Size = new Size(211, 27);
            UsernameTextbox.TabIndex = 3;
            UsernameTextbox.Text = "Username";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UsernameTextbox);
            Controls.Add(LastNameTextbox);
            Controls.Add(FirstNameTextbox);
            Controls.Add(label1);
            Controls.Add(PasswordTextbox);
            Controls.Add(EmailTextbox);
            Controls.Add(RegistrationButton);
            Controls.Add(LoginButton);
            Name = "RegistrationForm";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox PasswordTextbox;
        private TextBox EmailTextbox;
        private Button RegistrationButton;
        private Button LoginButton;
        private TextBox LastNameTextbox;
        private TextBox FirstNameTextbox;
        private TextBox UsernameTextbox;
    }
}