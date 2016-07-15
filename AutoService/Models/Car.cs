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
        Robotized
    } 

    [Serializable]
    public class Car
    {
        [NonSerialized]
        private int id;
        public int Id { get { return id; } set { id = value; } }
        public string Mark { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Power { get; set; }
        public TypesOfTransmission Transmission { get; set; }

        [NonSerialized]
        private int clientId;
        public int ClientId { get { return clientId; } set { clientId = value; } }
        public virtual Client Client { get; set; }

        public Car()
        {
        }

        public Car(string mark, string model, int year, int power, TypesOfTransmission transmission, Client client)
        {
            Mark = mark;
            Model = model;
            Year = year;
            Power = power;
            Transmission = transmission;
            Client = client;
        }
    }
}
