using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce_Mvc.DAL.Database;
using eCommerce_Mvc.Entities.Entity;

namespace eCommerce_Mvc.DAL.Repository
{
    public class ReviewRepository
    {
        public bool AddReview(Reviews review)
        {
            using (var databaseContext = new ProjectContext())
            {
                databaseContext.Entry(review).State = EntityState.Added;
                return databaseContext.SaveChanges() > 0;
            }
        }
    }
}
