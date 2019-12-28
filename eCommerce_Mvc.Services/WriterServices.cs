using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce_Mvc.DAL.Repository;
using eCommerce_Mvc.Entities.Entity;

namespace eCommerce_Mvc.Services
{
    public class WriterServices
    {
        private readonly WriterRepository _writerRepository;

        public WriterServices()
        {
            _writerRepository = new WriterRepository();
        }

        public List<Writer> GetWriters()
        {
            var writers = _writerRepository.GetAllWriters();
            return writers;
        }
    }
}
