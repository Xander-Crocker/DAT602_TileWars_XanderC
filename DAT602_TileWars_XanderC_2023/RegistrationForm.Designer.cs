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
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LastNameTextbox = new System.Windows.Forms.TextBox();
            this.FirstNameTextbox = new System.Windows.Forms.TextBox();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 81);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tile Wars";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(279, 329);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(211, 27);
            this.PasswordTextbox.TabIndex = 4;
            this.PasswordTextbox.Text = "Password";
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Location = new System.Drawing.Point(279, 220);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(211, 27);
            this.EmailTextbox.TabIndex = 3;
            this.EmailTextbox.Text = "Email";
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Location = new System.Drawing.Point(396, 386);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(94, 29);
            this.RegistrationButton.TabIndex = 5;
            this.RegistrationButton.Text = "Register";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(279, 386);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(94, 29);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // LastNameTextbox
            // 
            this.LastNameTextbox.Location = new System.Drawing.Point(279, 163);
            this.LastNameTextbox.Name = "LastNameTextbox";
            this.LastNameTextbox.Size = new System.Drawing.Size(211, 27);
            this.LastNameTextbox.TabIndex = 1;
            this.LastNameTextbox.Text = "Last Name";
            // 
            // FirstNameTextbox
            // 
            this.FirstNameTextbox.Location = new System.Drawing.Point(279, 105);
            this.FirstNameTextbox.Name = "FirstNameTextbox";
            this.FirstNameTextbox.Size = new System.Drawing.Size(211, 27);
            this.FirstNameTextbox.TabIndex = 0;
            this.FirstNameTextbox.Text = "First Name";
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Location = new System.Drawing.Point(279, 275);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(211, 27);
            this.UsernameTextbox.TabIndex = 3;
            this.UsernameTextbox.Text = "Username";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UsernameTextbox);
            this.Controls.Add(this.LastNameTextbox);
            this.Controls.Add(this.FirstNameTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.EmailTextbox);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.LoginButton);
            this.Name = "RegistrationForm";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

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