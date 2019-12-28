using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce_Mvc.DAL.Database;
using eCommerce_Mvc.Entities.Entity;

namespace eCommerce_Mvc.DAL.Repository
{
    public class WriterRepository
    {
        public List<Writer> GetAllWriters()
        {
            List<Writer> writers;
            using (var database = new ProjectContext())
            {
                writers = database.Writers.ToList();
            }

            return writers;
        }
    }
}
