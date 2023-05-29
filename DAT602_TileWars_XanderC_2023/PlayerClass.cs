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
    public class PlayerClass
    {
        private String _FirstName;
        private String _LastName;
        private String _Email;
        private String _Username;
        private String _Password;
        private String _LogAttempt;
        private String _LockedOut;
        private String _IsAdmin;

        private String FirstName { get { return _FirstName; } set { _FirstName = value; } }
        private String LastName { get { return _LastName; } set { _LastName = value; } }
        public String Email { get { return _Email; } set { _Email = value; } }
        private String Username { get { return _Username; } set { _Username = value; } }
        public String Password { get { return _Password; } set { _Password = value; } }
        public String LogAttempt { get { return _LogAttempt; } set { _LogAttempt = value; } }
        public String LockedOut { get { return _LockedOut; } set { _LockedOut = value; } }
        private String IsAdmin { get { return _IsAdmin; } set { _IsAdmin = value; } }
    }
}
