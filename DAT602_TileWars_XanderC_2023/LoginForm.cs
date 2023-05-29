using DAT602_TileWars_XanderC_2023;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAT602_TileWars_XanderC_2023
{
    public partial class LoginForm : Form
    {
        private LoginForm _login;
        private MainWindowForm _home;
        private PlayerClass _playerClass;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm _Register = new RegistrationForm();
            _Register.ShowDialog();
        }

        private void LoginLoginButton_Click(object sender, EventArgs e)
        {
            DatabaseAccessObject loginDBAccess = new DatabaseAccessObject();
            string aMessage = loginDBAccess.Login(this.LoginLoginButton.Text, this.LoginLoginButton.Text);
            // MessageBox.Show(aMessage);

            _home = new MainWindowForm();
            this.Hide();
            if (_home.ShowDialog(this, _playerClass))
            {
                this.Show();
            }
        }
    }
}