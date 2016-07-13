using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Models
{
    public enum TypesOfTransmission
    {
        Mechanical,
        Automatic,
        Robotize
    } 

    [Serializable]
    public class Car
    {
        [NonSerialized]
        public int Id { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Power { get; set; }
        public TypesOfTransmission Transmission { get; set; }

        [NonSerialized]
        public int ClientId { get; set; }
        [NonSerialized]
        public virtual Client Client { get; set; }

        public Car()
        {
        }

        public Car(string mark, string model, int year, int power, TypesOfTransmission transmission)
        {
            Mark = mark;
            Model = model;
            Year = year;
            Power = power;
            Transmission = transmission;
        }
    }
}
