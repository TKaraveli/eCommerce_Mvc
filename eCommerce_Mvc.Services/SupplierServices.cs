using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce_Mvc.DAL.Repository;
using eCommerce_Mvc.Entities.Entity;

namespace eCommerce_Mvc.Services
{
    public class SupplierServices
    {
        private readonly SupplierRepository _supplierRepository;

        public SupplierServices()
        {
            _supplierRepository = new SupplierRepository();
        }

        public List<Supplier> GetSuppliers()
        {
            var suppliers = _supplierRepository.GetAllSuppliers();
            return suppliers;
        }   
    }
}
