using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

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
        [BsonId]
        public int Id { get { return id; } set { id = value; } }
        public string Mark { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Power { get; set; }
        public TypesOfTransmission Transmission { get; set; }

        [NonSerialized]
        [BsonIgnore]
        private int clientId;
        [BsonIgnore]
        public int ClientId { get { return clientId; } set { clientId = value; } }
        public virtual Client Client { get; set; }

        [NonSerialized]
        [BsonIgnore]
        private List<Order> orders;
        [BsonIgnore]
        public virtual List<Order> Orders { get { return orders; } set { orders = value; } }

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
        public Car(string mark, string model, int power)
        {
            Mark = mark;
            Model = model;
            Power = power;
        }
    }
}
