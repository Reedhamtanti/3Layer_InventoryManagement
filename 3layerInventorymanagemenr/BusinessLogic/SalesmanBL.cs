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
    public class SalesmanBL
    {
        public int InsertNewSalesman(SalesmanBO salesmanBO)
        {
            SalesmanDA dataAccess = new SalesmanDA();
            var result = dataAccess.ImsertSalesman(salesmanBO);

            return result;
        }

        public DataTable SelectAllSalesman()
        {
            SalesmanDA dataAccess = new SalesmanDA();
            DataTable result = dataAccess.SelectSalesman();

            return result;
        }

        public int UpdateSalesman(SalesmanBO updatedSalesman)
        {
            SalesmanDA dataAccess = new SalesmanDA();
            var result = dataAccess.UpdateSalesman(updatedSalesman);

            return result;
        }

        public int DeleteSalesman(int salesmanID)
        {
            SalesmanDA dataAccess = new SalesmanDA();
            var result = dataAccess.DeleteSalesman(salesmanID);
            return result;
        }
    }
}
