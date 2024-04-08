using BusinessObject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SalesmanDA
    {
        string _connectionString = ConfigurationManager.ConnectionStrings["InventoryConnectionString"].ConnectionString;

        public int ImsertSalesman(SalesmanBO newSalesman)
        {

            SqlConnection connection = new SqlConnection(_connectionString);
            try
            {
                string query = $"Insert into salesman (Salesman_id, name, city, commission) values (" +
                    $"'{newSalesman.SalesmanID}', '{newSalesman.SalesmanName}', '{newSalesman.SalesmanCity}', '{newSalesman.SalesmanCommission}')";

                SqlCommand cmd = new SqlCommand(query, connection);

                connection.Open();
                int result = cmd.ExecuteNonQuery();

                return result;
            }
            catch (Exception ex)
            {
                var error = ex.Message + ex.StackTrace;
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }
        public DataTable SelectSalesman()
        {

            SqlConnection connection = new SqlConnection(_connectionString);

            string query = $"Select * From salesman";
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(query, connection);
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            connection.Open();
            adapter.Fill(table);

            connection.Close();
            return table;
            
        }
        public int UpdateSalesman(SalesmanBO updatedSalesman)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            try
            {
                string query = $"UPDATE salesman SET " +
               $"name = '{updatedSalesman.SalesmanName}', " +
               $"city = '{updatedSalesman.SalesmanCity}', " +
               $"commission = '{updatedSalesman.SalesmanCommission}' " +
               $"WHERE Salesman_id = {updatedSalesman.SalesmanID}";


                SqlCommand cmd = new SqlCommand(query, connection);
                

                connection.Open();
                int result = cmd.ExecuteNonQuery();

                return result;
            }
            catch (Exception ex)
            {
                var error = ex.Message + ex.StackTrace;
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }

        public int DeleteSalesman(int salesmanID)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            try
            {
                string query = $"DELETE FROM salesman WHERE Salesman_id = {salesmanID}";

                SqlCommand cmd = new SqlCommand(query, connection);

                connection.Open();
                int result = cmd.ExecuteNonQuery();

                return result;
            }
            catch (Exception ex)
            {
                var error = ex.Message + ex.StackTrace;
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

