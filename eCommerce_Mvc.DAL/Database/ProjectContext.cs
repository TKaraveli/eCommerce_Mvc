using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce_Mvc.Entities.Entity;

namespace eCommerce_Mvc.DAL.Database
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
            //: base("") //connectionPath
        {
            //Configuration.LazyLoadingEnabled = false;
            //Database.Connection.ConnectionString = @"Server = TAYFUN\SQLEXPRESS;Database = eCommerce_Mvc;Trusted_Connection=True;MultipleActiveResultSets=True;";
            Database.Connection.ConnectionString = @"Server = BK-L206-01IS;Database = eCommerce_Mvc;user id=sa;password=123;MultipleActiveResultSets=True;";

            var value = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public DbSet<Advertisement> Advertisements { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Reviews> Reviews { get; set; }

        public DbSet<Supplier> Supplier { get; set; }

        public DbSet<Wishlists> Wishlists { get; set; }

        public DbSet<Writer> Writers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
