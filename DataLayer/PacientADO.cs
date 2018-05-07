using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DataLayer
{
    public class PacientADO
    {
        private static DBConnection dataSource;

        MySqlConnection connection = null;
        MySqlCommand mysqlCmd = null;
        MySqlDataAdapter mysqlAdapter = null;
        DataSet dataPacients = new DataSet();

        bool clicked = false;

        public PacientADO()
        {
            dataSource = DBConnection.getInstance();
        }

        public DataSet getAll()
        {
            
            String sql;
            sql = "SELECT * from pacients;";
            try
            {
                connection = dataSource.getConnection();
                connection.Open();
                mysqlCmd = new MySqlCommand(sql, connection);
                mysqlAdapter = new MySqlDataAdapter(mysqlCmd);
                mysqlAdapter.Fill(dataPacients);
            }
            catch (Exception e)
            {
                dataPacients = new DataSet();
            }
            finally
            {
                if (mysqlCmd != null) mysqlCmd.Dispose();
                if (mysqlAdapter != null) mysqlAdapter.Dispose();
                if (connection != null) connection.Close();
            }
            return dataPacients;
        }

        public DataSet getFromDNI(string dni)
        {
            DataSet dataPacients = new DataSet();

            String sql;
            sql = "SELECT * from pacients where dni=" + dni + ";";
            try
            {
                connection = dataSource.getConnection();
                connection.Open();
                mysqlCmd = new MySqlCommand(sql, connection);
                mysqlAdapter = new MySqlDataAdapter(mysqlCmd);
                mysqlAdapter.Fill(dataPacients);
            }
            catch (Exception e)
            {
                dataPacients = new DataSet();
            }
            finally
            {
                if (mysqlCmd != null) mysqlCmd.Dispose();
                if (mysqlAdapter != null) mysqlAdapter.Dispose();
                if (connection != null) connection.Close();
            }
            return dataPacients;
        }
    }
}
