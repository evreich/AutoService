using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Models
{
    [Serializable]
    public class Client
    {
        [NonSerialized]
        private int id;
        public int Id { get { return id; } set { id = value;} }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Midname { get; set; }
        public int Year { get; set; }
        public string Phone { get; set; }

        [NonSerialized]
        private ICollection<Car> cars;
        public virtual ICollection<Car> Cars { get { return cars; } set { cars = value; } }

        public Client()
        {
            Cars = new List<Car>();
        }

        public Client(string surname, string name, string midname, int year, string phone)
        {
            Surname = surname;
            Name = name;
            Midname = midname;
            Year = year;
            Phone = phone;
            Cars = new List<Car>();
        }
    }
}
