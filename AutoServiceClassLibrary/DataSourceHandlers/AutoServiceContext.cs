using AutoService.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.DataSourceContext
{
    public class AutoServiceContext : DbContext
    {
        public AutoServiceContext() : base("MySQLConnection")
        {
            CheckDb();
        }

        private void CheckDb()
        {
            if ((this.Orders.ToList().Count < 50) || (this.Clients.ToList().Count < 30))
            {
                this.Orders.RemoveRange(this.Orders);
                this.Clients.RemoveRange(this.Clients);
                this.Works.RemoveRange(this.Works);
                this.Cars.RemoveRange(this.Cars);
                this.Orders.AddRange(ObjectsBuilder.GenerateOrders(50, ObjectsBuilder.GenerateClients(30)));
                this.SaveChanges();
            }
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
