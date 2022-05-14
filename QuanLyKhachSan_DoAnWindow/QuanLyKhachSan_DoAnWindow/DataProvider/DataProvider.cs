using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKhachSan_DoAnWindow.DataProvider
{
    public class DBConnection
    {
        private SqlDataAdapter adapter;
        private SqlConnection connection;
        public DBConnection()
        {
            adapter = new SqlDataAdapter();
            connection = new SqlConnection(Properties.Settings.Default.cnnStr);
        }
        private SqlConnection openConnection()
        {
            if (connection.State == ConnectionState.Closed || connection.State ==
            ConnectionState.Broken)
            {
                connection.Open();
            }
            return connection;
        }

        public void executeInsertQuery(String query, SqlParameter[] sqlParameter)
        {
            using (SqlCommand sqlCommand = new SqlCommand(query, openConnection()))
            {
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddRange(sqlParameter);
                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public object executeScalar(String query, SqlParameter[] sqlParameter)
        {
            using (SqlCommand sqlCommand = new SqlCommand(query, openConnection()))
            {
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddRange(sqlParameter);
                object result = new object();
                try
                {
                    result = sqlCommand.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return result;
            }
        }

        public DataTable executeReader(String query, SqlParameter[] sqlParameter)
        {
            using (SqlCommand sqlCommand = new SqlCommand(query, openConnection()))
            {
                connection = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QuanLyKhachSan;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(query, connection);
                DataTable dt = new DataTable();
                try
                {
                    connection.Open();
                    SqlDataReader dataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    dt.Load(dataReader);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return dt;
            }
        }
    }
}
