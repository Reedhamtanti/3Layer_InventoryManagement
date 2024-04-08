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
    public partial class WebForm1 : System.Web.UI.Page
    {
        string _connectionString = ConfigurationManager.ConnectionStrings["InventoryConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindSalesmanData();
            }

        }

            protected void btnSubmit_Click(object sender, EventArgs e)
            {
                try
                {
                    int salesmanID = int.Parse(txtID.Text);

                    String name = txtSalesmanName.Text;

                    String city = txtCity.Text;

                    float commission = float.Parse(txtCommission.Text);

                    SalesmanBO newSalesman = new SalesmanBO()
                    {
                        SalesmanID = salesmanID,
                        SalesmanName = name,
                        SalesmanCity = city,
                        SalesmanCommission = commission,

                    };

                    SalesmanBL businessLogic = new SalesmanBL();
                    int result = businessLogic.InsertNewSalesman(newSalesman);

                    if (result == 0)
                    {
                        lblSalesmanResult.Text = "Insert unsuccessful.";
                    }
                    else
                    {
                        lblSalesmanResult.Text = "Insert successful.";
                    }
                    BindSalesmanData();

                }
                catch (Exception ex)
                {
                
                    string errorMessage = "Error: " + ex.Message + "\nStackTrace: " + ex.StackTrace;
                    Console.WriteLine(errorMessage);
                }

            

            }

        private void BindSalesmanData()
        {
            SalesmanDA dal = new SalesmanDA();
            
            DataTable table = dal.SelectSalesman(); 
          
            if (table != null && table.Rows.Count > 0)
            {
                gvSalesman.DataSource = table;
                gvSalesman.DataBind();
            }
            
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int salesmanID = int.Parse(txtID.Text);
                string name = txtSalesmanName.Text;
                string city = txtCity.Text;
                float commission = float.Parse(txtCommission.Text);

                SalesmanBO updatedSalesman = new SalesmanBO()
                {
                    SalesmanID = salesmanID,
                    SalesmanName = name,
                    SalesmanCity = city,
                    SalesmanCommission = commission,
                };

                SalesmanBL businessLogic = new SalesmanBL();
                int result = businessLogic.UpdateSalesman(updatedSalesman);

                if (result == 0)
                {
                    lblSalesmanResult.Text = "Update unsuccessful.";
                }
                else
                {
                    lblSalesmanResult.Text = "Update successful.";
                }

                BindSalesmanData();
            }
            catch (Exception ex)
            {
                string errorMessage = "Error: " + ex.Message + "\nStackTrace: " + ex.StackTrace;
                Console.WriteLine(errorMessage);
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int salesmanID = int.Parse(txtID.Text);
                
                SalesmanBL businessLogic = new SalesmanBL();
                int result = businessLogic.DeleteSalesman(salesmanID);

                if (result == 0)
                {
                    lblSalesmanResult.Text = "Salesman not deleted.";
                }
                else
                {
                    lblSalesmanResult.Text = "Delet successful.";
                }

                BindSalesmanData();
            }
            catch (Exception ex)
            {
                string errorMessage = "Error: " + ex.Message + "\nStackTrace: " + ex.StackTrace;
                Console.WriteLine(errorMessage);
            }
        }
    }
}