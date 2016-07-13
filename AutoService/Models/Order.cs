using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Models
{
    [Serializable]
    class Order
    {
        [NonSerialized]
        public int Id { get; set; }
        public int Price { get; set; }
        public DateTime TimeBegin { get; set; }
        public DateTime TimeEnd { get; set; }

        [NonSerialized]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        public virtual ICollection<Work> Works { get; set; }

        public Order()
        {
            Works = new List<Work>();
        }
        public Order(int price, DateTime timebegin, DateTime timeend, Client client, List<Work> works)
        {
            Price = price;
            TimeBegin = timebegin;
            TimeEnd = timeend;
            Client = client;
            Works = works;
        }
    }
}
