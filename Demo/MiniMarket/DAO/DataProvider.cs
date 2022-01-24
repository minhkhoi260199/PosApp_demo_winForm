using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class DataProvider
    {
        private String connectionString;
        private SqlConnection conn;

        public DataProvider()
        {
            connectionString = ConfigurationManager.ConnectionStrings["MiniMarketDB"].ConnectionString;
            conn = new SqlConnection(connectionString);
        }

        // Excute Query: for SELECT
        public DataTable ExecuteQuery(String query)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                sqlCommand.CommandType = CommandType.Text; // because input Query

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                conn.Open();
                sqlDataAdapter.Fill(dt);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            
            return dt;
        }

        // Execute Non Query: for INSERT/DELETE/UPDATE
        public Boolean ExecuteNonQuery(String query)
        {
            Boolean flag = true;
            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                sqlCommand.CommandType = CommandType.Text;

                conn.Open();
                int n = sqlCommand.ExecuteNonQuery();

                flag = (n == 0) ? false : true;
            }
            catch (Exception)
            {
                flag = false;
            }
            finally
            {
                conn.Close();
            }
            return flag;
        }
    }
}
