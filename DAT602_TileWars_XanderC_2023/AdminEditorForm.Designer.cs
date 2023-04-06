namespace DAT602_TileWars_XanderC_2023
{
    partial class AdminEditorForm
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
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.LastNameTextbox = new System.Windows.Forms.TextBox();
            this.FirstNameTextbox = new System.Windows.Forms.TextBox();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.LockoutCheckbox = new System.Windows.Forms.CheckBox();
            this.AdminCheckbox = new System.Windows.Forms.CheckBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Location = new System.Drawing.Point(294, 212);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(211, 27);
            this.UsernameTextbox.TabIndex = 3;
            this.UsernameTextbox.Text = "Username";
            // 
            // LastNameTextbox
            // 
            this.LastNameTextbox.Location = new System.Drawing.Point(294, 100);
            this.LastNameTextbox.Name = "LastNameTextbox";
            this.LastNameTextbox.Size = new System.Drawing.Size(211, 27);
            this.LastNameTextbox.TabIndex = 1;
            this.LastNameTextbox.Text = "Last Name";
            // 
            // FirstNameTextbox
            // 
            this.FirstNameTextbox.Location = new System.Drawing.Point(294, 42);
            this.FirstNameTextbox.Name = "FirstNameTextbox";
            this.FirstNameTextbox.Size = new System.Drawing.Size(211, 27);
            this.FirstNameTextbox.TabIndex = 0;
            this.FirstNameTextbox.Text = "First Name";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(294, 266);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(211, 27);
            this.PasswordTextbox.TabIndex = 4;
            this.PasswordTextbox.Text = "Password";
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Location = new System.Drawing.Point(294, 157);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(211, 27);
            this.EmailTextbox.TabIndex = 2;
            this.EmailTextbox.Text = "Email";
            // 
            // LockoutCheckbox
            // 
            this.LockoutCheckbox.AutoSize = true;
            this.LockoutCheckbox.Location = new System.Drawing.Point(294, 321);
            this.LockoutCheckbox.Name = "LockoutCheckbox";
            this.LockoutCheckbox.Size = new System.Drawing.Size(78, 24);
            this.LockoutCheckbox.TabIndex = 5;
            this.LockoutCheckbox.Text = "Locked";
            this.LockoutCheckbox.UseVisualStyleBackColor = true;
            // 
            // AdminCheckbox
            // 
            this.AdminCheckbox.AutoSize = true;
            this.AdminCheckbox.Location = new System.Drawing.Point(416, 321);
            this.AdminCheckbox.Name = "AdminCheckbox";
            this.AdminCheckbox.Size = new System.Drawing.Size(89, 24);
            this.AdminCheckbox.TabIndex = 6;
            this.AdminCheckbox.Text = "Is Admin";
            this.AdminCheckbox.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(411, 382);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(94, 29);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // AdminEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AdminCheckbox);
            this.Controls.Add(this.LockoutCheckbox);
            this.Controls.Add(this.UsernameTextbox);
            this.Controls.Add(this.LastNameTextbox);
            this.Controls.Add(this.FirstNameTextbox);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.EmailTextbox);
            this.Name = "AdminEditorForm";
            this.Text = "Admin Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox UsernameTextbox;
        private TextBox LastNameTextbox;
        private TextBox FirstNameTextbox;
        private TextBox PasswordTextbox;
        private TextBox EmailTextbox;
        private CheckBox LockoutCheckbox;
        private CheckBox AdminCheckbox;
        private Button UpdateButton;
    }
}