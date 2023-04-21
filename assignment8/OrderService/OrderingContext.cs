using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.EntityFramework;

namespace OrderApp {
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class OrderingContext : DbContext
    {
        public OrderingContext() : base("OrderDataBase")
        {
            Database.SetInitializer(
              new DropCreateDatabaseIfModelChanges<OrderingContext>());
        }

        public DbSet<Order> Orders { get; set; }
       
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Goods> Goodss { get; set; }
        public DbSet<Customer> Customers { get; set; }
        
    }
}
