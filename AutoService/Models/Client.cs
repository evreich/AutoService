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
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Midname { get; set; }
        public int Year { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<Car> Cars { get; set; }

        public Client()
        {
            Cars = new List<Car>();
        }

        public Client(string surname, string name, string midname, int year, string phone, List<Car> cars)
        {
            Surname = surname;
            Name = name;
            Midname = midname;
            Year = year;
            Phone = phone;
            Cars = cars;
        }
    }
}
