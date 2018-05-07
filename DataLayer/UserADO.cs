using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DataLayer
{
    public class UserADO
    {
        private static DBConnection dataSource;

        public UserADO()
        {
            dataSource = DBConnection.getInstance();
        }

        public String checkUser(User u)
        {
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            MySqlDataReader mysqlReader = null;

            //Unable to connect database.
            String profile = "";

            string sql = "SELECT * FROM users where nickname='" + u.Nickname + "' and password='" + u.Password + "';";
            try
            {
                connection = dataSource.getConnection(); //Establecer la cadena de conexión.
                connection.Open(); //Open connection.

                //User does not exist.
                profile = "no";

                mysqlCmd = new MySqlCommand(sql, connection); //It makes the query
                mysqlReader = mysqlCmd.ExecuteReader(); //Executes query and get result.


                while (mysqlReader.Read())
                {
                    profile = mysqlReader.GetString("rol");
                }
            }
            catch (Exception e)
            {
                profile = "no";
            }
            finally
            {
                if (mysqlCmd != null) mysqlCmd.Dispose();
                if (mysqlReader != null) mysqlReader.Dispose();
                if (connection != null) connection.Close();
            }
            return profile;
        }
    }
}
