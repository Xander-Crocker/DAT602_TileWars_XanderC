using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace Dat602_Project
{
    class DatabaseAccessObject
    {
        private static string connectionString
        {
            get { return "Server=localhost;Port=3306;Database=DAT602_TileWars_XanderC_2023;Uid=root;password=Archenemy042;"; }
        }

        private static MySqlConnection _mySqlConnection = null;
        public static MySqlConnection mySqlConnection
        {
            get
            {
                if (_mySqlConnection == null)
                {
                    _mySqlConnection = new MySqlConnection(connectionString);
                }

                return _mySqlConnection;
            }
        }

        public string RegisterPlayer(string pUserName, string pPassword)
        {

            List<MySqlParameter> p = new List<MySqlParameter>();
            var aP = new MySqlParameter("@UserName", MySqlDbType.VarChar, 45);
            aP.Value = pUserName;
            p.Add(aP);

            var bP = new MySqlParameter("@Password", MySqlDbType.VarChar, 45);
            bP.Value = pPassword;
            p.Add(bP);

            var aDataSet = MySqlHelper.ExecuteDataset(DatabaseAccessObject.mySqlConnection, "CALL registerPlayer(@UserName, @Password)", p.ToArray());

            // expecting one table with one row
            return (aDataSet.Tables[0].Rows[0])["MESSAGE"].ToString();
        }

        public Boolean CheckUsernameAndPassword(string pUserName, string pPassword)
        {
            Boolean lcResult = false;
            List<MySqlParameter> p = new List<MySqlParameter>();
            var aP = new MySqlParameter("@UserName", MySqlDbType.VarChar, 45);
            aP.Value = pUserName;
            p.Add(aP);

            var bP = new MySqlParameter("@Password", MySqlDbType.VarChar, 45);
            bP.Value = pPassword;
            p.Add(bP);

            var aDataSet = MySqlHelper.ExecuteDataset(DatabaseAccessObject.mySqlConnection, "CALL checkUsernameAndPassword(@UserName, @Password)", p.ToArray());

            var arow = aDataSet.Tables[0].Rows[0];
            if (lcResult == false)
            {
                lcResult = true;
            }
            else
            {
                // Add lines to display ortgher messages
                lcResult = false;
            }
            return lcResult;
        }

        public String deleteAccount(String pUsername)
        {
            List<MySqlParameter> prmDeleteAccount = new List<MySqlParameter>();

            MySqlParameter scUsername = new MySqlParameter("@Username", MySqlDbType.VarChar, 30);
            scUsername.Value = pUsername;
            prmDeleteAccount.Add(scUsername);

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Call deleteAccount(@Username)", prmDeleteAccount.ToArray());

            return aDataSet.Tables[0].Rows[0].Field<String>("Message");
        }

        public String unlockPlayer(String pUsername)
        {
            List<MySqlParameter> prmUnlockPlayer = new List<MySqlParameter>();

            MySqlParameter scUsername = new MySqlParameter("@Username", MySqlDbType.VarChar, 30);
            scUsername.Value = pUsername;
            prmUnlockPlayer.Add(scUsername);

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Call unlockPlayer(@Username)", prmUnlockPlayer.ToArray());

            return aDataSet.Tables[0].Rows[0].Field<String>("Message");
        }

        public String updatePlayer(String pUsername, String pPassword)
        {
            List<MySqlParameter> prmUpdatePlayer = new List<MySqlParameter>();

            MySqlParameter scUsername = new MySqlParameter("@Username", MySqlDbType.VarChar, 30);
            scUsername.Value = pUsername;
            prmUpdatePlayer.Add(scUsername);

            MySqlParameter scPassword = new MySqlParameter("@Password", MySqlDbType.VarChar, 30);
            scPassword.Value = pPassword;
            prmUpdatePlayer.Add(scPassword);

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Call adminUpdateUser(@Username,@Password)", prmUpdatePlayer.ToArray());

            return aDataSet.Tables[0].Rows[0].Field<String>("Message");
        }

        public String Login(string pEmail, string pPassword)
        {
            List<MySqlParameter> p = new List<MySqlParameter>();

            MySqlParameter aP = new MySqlParameter("@Email", MySqlDbType.VarChar, 30);
            aP.Value = pEmail;
            p.Add(aP);

            MySqlParameter bP = new MySqlParameter("@Password", MySqlDbType.VarChar, 30);
            bP.Value = pPassword;
            p.Add(bP);

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Login(@Email,@Password)", p.ToArray());
            return aDataSet.Tables[0].Rows[0].Field<String>("Message");
        }

        public string AddUserName(String pName, String pPassword)
        {
            List<MySqlParameter> p = new List<MySqlParameter>();

            MySqlParameter aName = new MySqlParameter("@UserName", MySqlDbType.VarChar, 50);
            aName.Value = pName;
            p.Add(aName);

            MySqlParameter aPass = new MySqlParameter("@Password", MySqlDbType.VarChar, 50);
            aPass.Value = pPassword;
            p.Add(aPass);

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Call AddNewUser(@UserName, @Password)", p.ToArray());

            return aDataSet.Tables[0].Rows[0].Field<string>("Message");
        }

        

        public class PlayerInDB
        {

            //    Private _Username As String
            private string _UserName;

            public string UserName
            {
                get
                {
                    return _UserName;
                }
                set
                {

                    _UserName = value;
                }
            }
        }
        
    }
}

