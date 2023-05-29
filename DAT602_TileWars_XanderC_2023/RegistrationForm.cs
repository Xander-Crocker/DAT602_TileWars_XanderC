using DAT602_TileWars_XanderC_2023;
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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            DatabaseAccessObject aDB = new DatabaseAccessObject();
            string aMessage = aDB.AddUser(this.EmailTextbox.Text, this.EmailTextbox.Text);
            MessageBox.Show(aMessage);

            DialogResult = DialogResult.OK;

            this.Hide();
            LoginForm _login = new LoginForm();
            _login.ShowDialog();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm _login = new LoginForm();
            _login.ShowDialog();
        }
    }
}
