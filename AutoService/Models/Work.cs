using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Models
{
    [Serializable]
    public class Work
    {
        [NonSerialized]
        private int id;
        public int Id { get { return id; } set { id = value; } }
        public string Title { get; set; }
        public int Price { get; set; }
        public int Runtime { get; set; }
        [NonSerialized]
        private List<Order> orders;
        public virtual List<Order> Orders { get { return orders; } set { orders = value;} }

        public Work()
        {
            Orders = new List<Order>();
        }

        public Work(string title, int price, int runtime)
        {
            Title = title;
            Price = price;
            Runtime = runtime;
            Orders = new List<Order>();
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
