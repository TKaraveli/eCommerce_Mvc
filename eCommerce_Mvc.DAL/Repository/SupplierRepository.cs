using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce_Mvc.DAL.Database;
using eCommerce_Mvc.Entities.Entity;

namespace eCommerce_Mvc.DAL.Repository
{
    public class SupplierRepository
    {
        public List<Supplier> GetAllSuppliers()
        {
            List<Supplier> suppliers;
            using (var database = new ProjectContext())
            {
                suppliers = database.Supplier.ToList();
            }

            return suppliers;
        }
    }
}
