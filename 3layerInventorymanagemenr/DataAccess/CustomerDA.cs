using BusinessObject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CustomerDA
    {
        string _connectionString = ConfigurationManager.ConnectionStrings["InventoryConnectionString"].ConnectionString;

        public int ImsertCustomer(CustomerBO newCustomer)
        {

            SqlConnection connection = new SqlConnection(_connectionString);
            try
            {
                string query = $"Insert into customer (customer_id, cust_name, city, grade,salesman_id) values (" +
                    $"'{newCustomer.customer_id}', '{newCustomer.cust_name}', '{newCustomer.city}', '{newCustomer.grade}', '{newCustomer.salesman_id}')";

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
        public DataTable SelectCustomer()
        {

            SqlConnection connection = new SqlConnection(_connectionString);

            string query = $"Select * From customer";
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(query, connection);
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            connection.Open();
            adapter.Fill(table);

            connection.Close();
            return table;

        }
        public int UpdateCustomer(CustomerBO updatedCustomer)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            try
            {
             string query = $"UPDATE customer SET " +
             $"cust_name = '{updatedCustomer.cust_name}', " +
             $"city = '{updatedCustomer.city}', " +
             $"grade = '{updatedCustomer.grade}', " +
             $"salesman_id = '{updatedCustomer.salesman_id}' " +
             $"WHERE customer_id = {updatedCustomer.customer_id}";


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

        public int DeleteCustomer(int customerID)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            try
            {
                string query = $"DELETE FROM customer WHERE Customer_id = {customerID}";

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
