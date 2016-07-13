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
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public int Runtime { get; set; }
        [NonSerialized]
        public virtual ICollection<Order> Orders { get; set; }

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
    }
}
