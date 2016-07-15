using AutoService.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.DataSourceContext
{
    class AutoServiceContext : DbContext
    {
        public AutoServiceContext() : base("MySQLConnection")
        {
            if ((this.Orders.ToList().Count < 50) || (this.Clients.ToList().Count < 30))
            {
                this.Database.Delete(); 
                List<Client> Clients = ObjectsBuilder.GenerateClients(30);
                this.Clients.AddRange(Clients);
                this.Orders.AddRange(ObjectsBuilder.GenerateOrders(50, Clients));
                this.SaveChanges();
            }
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
