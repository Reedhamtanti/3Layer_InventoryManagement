using BusinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CustomerBL
    {
        public int InsertNewCustomer(CustomerBO customerBO)
        {
            CustomerDA dataAccess = new CustomerDA();
            var result = dataAccess.ImsertCustomer(customerBO);

            return result;
        }

        public DataTable SelectAllCustomer()
        {
            CustomerDA dataAccess = new CustomerDA();
            DataTable result = dataAccess.SelectCustomer();

            return result;
        }

        public int UpdateCustomer(CustomerBO updatedCustomer)
        {
            CustomerDA dataAccess = new CustomerDA();
            var result = dataAccess.UpdateCustomer(updatedCustomer);

            return result;
        }

        public int DeleteCustomer(int customerID)
        {
            CustomerDA dataAccess = new CustomerDA();
            var result = dataAccess.DeleteCustomer(customerID);
            return result;
        }
    }
}
