using BusinessLogic;
using BusinessObject;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Configuration;
using DataAccess;

namespace _3layerInventorymanagemenr
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        string _connectionString = ConfigurationManager.ConnectionStrings["InventoryConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCustomerData();
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                int customer_id = int.Parse(txtCustomerID.Text);

                String cust_name = txtCustomerName.Text;

                String city = txtCity.Text;

                int grade = int.Parse(txtGrade.Text);

                int salesman_id = int.Parse(txtSalemanID.Text);

                CustomerBO newCustomer = new CustomerBO()
                {
                    customer_id = customer_id,
                    cust_name = cust_name,
                    city = city,
                    grade = grade,
                    salesman_id = salesman_id

                };

                CustomerBL businessLogic = new CustomerBL();
                int result = businessLogic.InsertNewCustomer(newCustomer);

                if (result == 0)
                {
                    lblCustomerResult.Text = "Insert unsuccessful.";
                }
                else
                {
                    lblCustomerResult.Text = "Insert successful.";
                    Form.Attributes.Clear();
                }
                BindCustomerData();

            }
            catch (Exception ex)
            {

                string errorMessage = "Error: " + ex.Message + "\nStackTrace: " + ex.StackTrace;
                Console.WriteLine(errorMessage);
            }
        }
       

        protected void UpdateCutomerBtn_Click1(object sender, EventArgs e)
        {
            try
            {
                int customer_id = int.Parse(txtCustomerID.Text);

                String cust_name = txtCustomerName.Text;

                String city = txtCity.Text;

                int grade = int.Parse(txtGrade.Text);

                int salesman_id = int.Parse(txtSalemanID.Text);

                CustomerBO updatedCustomer = new CustomerBO()
                {
                    customer_id = customer_id,
                    cust_name = cust_name,
                    city = city,
                    grade = grade,
                    salesman_id = salesman_id

                };

                CustomerBL businessLogic = new CustomerBL();
                int result = businessLogic.UpdateCustomer(updatedCustomer);

                if (result == 0)
                {
                    lblCustomerResult.Text = "Update unsuccessful.";
                }
                else
                {
                    lblCustomerResult.Text = "Update successful.";
                    
                }

                BindCustomerData();
            }
            catch (Exception ex)
            {
                string errorMessage = "Error: " + ex.Message + "\nStackTrace: " + ex.StackTrace;
                Console.WriteLine(errorMessage);
            }
        }

        protected void DeleteCutomerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int customer_id = int.Parse(txtCustomerID.Text);

                CustomerBL businessLogic = new CustomerBL();
                int result = businessLogic.DeleteCustomer(customer_id);

                if (result == 0)
                {
                    lblCustomerResult.Text = "Customer not deleted.";
                }
                else
                {
                    lblCustomerResult.Text = "Delet successful.";
                }

                BindCustomerData();
            }
            catch (Exception ex)
            {
                string errorMessage = "Error: " + ex.Message + "\nStackTrace: " + ex.StackTrace;
                Console.WriteLine(errorMessage);
            }
        }
        private void BindCustomerData()
        {
            CustomerDA dal = new CustomerDA();

            DataTable table = dal.SelectCustomer();

            if (table != null && table.Rows.Count > 0)
            {
                gvcustomer.DataSource = table;
                gvcustomer.DataBind();
            }

        }
    }
}