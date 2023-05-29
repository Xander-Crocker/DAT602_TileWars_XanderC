using DAT602_TileWars_XanderC_2023;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace DAT602_TileWars_XanderC_2023
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

        public string RegisterPlayer(string pFirstName, string PLastName, string pEmail, string pUsername, string pPassword)
        {

            List<MySqlParameter> p = new List<MySqlParameter>();

            var aP = new MySqlParameter("@FirstName", MySqlDbType.VarChar, 50);
            aP.Value = pFirstName;
            p.Add(aP);

            var bP = new MySqlParameter("@LastName", MySqlDbType.VarChar, 50);
            bP.Value = pUsername;
            p.Add(bP);

            var cP = new MySqlParameter("@Email", MySqlDbType.VarChar, 50);
            cP.Value = pEmail;
            p.Add(cP);

            var dP = new MySqlParameter("@UserName", MySqlDbType.VarChar, 50);
            dP.Value = pUsername;
            p.Add(dP);

            var eP = new MySqlParameter("@Password", MySqlDbType.VarChar, 50);
            eP.Value = pPassword;
            p.Add(eP);

            var aDataSet = MySqlHelper.ExecuteDataset(DatabaseAccessObject.mySqlConnection, "CALL registerPlayer(@UserName, @Password)", p.ToArray());

            // expecting one table with one row
            return (aDataSet.Tables[0].Rows[0])["MESSAGE"].ToString();
        }

        public Boolean CheckUsernameAndPassword(string pUsername, string pPassword)
        {
            Boolean lcResult = false;
            List<MySqlParameter> p = new List<MySqlParameter>();

            var aP = new MySqlParameter("@Username", MySqlDbType.VarChar, 50);
            aP.Value = pUsername;
            p.Add(aP);

            var bP = new MySqlParameter("@Password", MySqlDbType.VarChar, 50);
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

            MySqlParameter scUsername = new MySqlParameter("@Username", MySqlDbType.VarChar, 50);
            scUsername.Value = pUsername;
            prmDeleteAccount.Add(scUsername);

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Call deleteAccount(@Username)", prmDeleteAccount.ToArray());

            return aDataSet.Tables[0].Rows[0].Field<String>("Message");
        }

        public String unlockPlayer(String pUsername)
        {
            List<MySqlParameter> prmUnlockPlayer = new List<MySqlParameter>();

            MySqlParameter scUsername = new MySqlParameter("@Username", MySqlDbType.VarChar, 50);
            scUsername.Value = pUsername;
            prmUnlockPlayer.Add(scUsername);

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Call unlockPlayer(@Username)", prmUnlockPlayer.ToArray());

            return aDataSet.Tables[0].Rows[0].Field<String>("Message");
        }

        public String updatePlayer(String pUsername, String pPassword)
        {
            List<MySqlParameter> prmUpdatePlayer = new List<MySqlParameter>();

            MySqlParameter scUsername = new MySqlParameter("@Username", MySqlDbType.VarChar, 50);
            scUsername.Value = pUsername;
            prmUpdatePlayer.Add(scUsername);

            MySqlParameter scPassword = new MySqlParameter("@Password", MySqlDbType.VarChar, 50);
            scPassword.Value = pPassword;
            prmUpdatePlayer.Add(scPassword);

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Call adminUpdateUser(@Username,@Password)", prmUpdatePlayer.ToArray());

            return aDataSet.Tables[0].Rows[0].Field<String>("Message");
        }

        public String Login(string pUsername, string pPassword)
        {
            List<MySqlParameter> p = new List<MySqlParameter>();

            MySqlParameter aP = new MySqlParameter("@Username", MySqlDbType.VarChar, 50);
            aP.Value = pUsername;
            p.Add(aP);

            MySqlParameter bP = new MySqlParameter("@Password", MySqlDbType.VarChar, 50);
            bP.Value = pPassword;
            p.Add(bP);

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Login(@Username,@Password)", p.ToArray());
            return aDataSet.Tables[0].Rows[0].Field<String>("Message");
        }

        public string AddUser(String pUsername, String pPassword)
        {
            List<MySqlParameter> p = new List<MySqlParameter>();

            MySqlParameter aUsername = new MySqlParameter("@UserName", MySqlDbType.VarChar, 50);
            aUsername.Value = pUsername;
            p.Add(aUsername);

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

