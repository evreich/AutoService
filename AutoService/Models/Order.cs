using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Models
{
    [Serializable]
    public class Order
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public DateTime TimeBegin { get; set; }
        public DateTime? TimeEnd { get; set; }

        [NonSerialized]
        private int carId;
        public int CarId { get { return carId;} set { carId = value;} }
        public virtual Car Car { get; set; }
        public virtual List<Work> Works { get; set; }

        public Order()
        {
            Works = new List<Work>();
        }
        public Order(int id, int price, DateTime timebegin, DateTime? timeend, Car car, List<Work> works)
        {
            Id = id;
            Price = price;
            TimeBegin = timebegin;
            TimeEnd = timeend;
            Car = car;
            Works = works;
        }
    }
}
