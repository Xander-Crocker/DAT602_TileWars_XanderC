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
            get { return "Server=localhost;Port=3306;Database=dat602-project;Uid=root;password=ten9eight;"; }

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

