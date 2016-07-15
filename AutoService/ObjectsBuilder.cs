using AutoService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService
{
    public static class ObjectsBuilder
    {
        private static readonly Work[] OrderWorks = { new Work("Замена масла", 3000, 40), new Work("Замена маслянного фильтра", 500, 10), new Work("Замена воздушного фильтра", 500, 10), new Work("Замена тормозных колодок", 2000, 120), 
                                                  new Work("Диагностика", 2000, 120), new Work("Заправка кондиционера", 1000, 30), new Work("Компьютерная диагностика", 3000, 60) };
        private static readonly string[] MaleSurname = new string[] { "Власов", "Кожевников", "Подхолзин", "Иванов", "Кондрахин", "Меликбекян", "Черноухов", "Шарапов", "Шипилов", "Воронин" };
        private static readonly string[] MaleName = new string[] { "Максим", "Кирилл", "Никита", "Илья", "Дмитрий", "Олег", "Ваге", "Сергей", "Александр", "Артур" };
        private static readonly string[] MaleMidname = new string[] { "Сергеевич", "Александрович", "Алексеевич", "Игоревич", "Артурович", "Максимович", "Анатольевич", "Владимирович", "Олегович", "Николаевич" };
        private static readonly string[] FemaleSurname = new string[] { "Свиридова", "Дмитриевцева", "Иванова", "Проскурякова", "Пономарева", "Грудкова", "Кожевникова", "Шарапова", "Малюкова", "Попова" };
        private static readonly string[] FemaleName = new string[] { "Наталья", "Екатерина", "Вероника", "Ирина", "Вера", "Надежда", "Любовь", "Элина", "Виктория", "Татьяна", "Полина" };
        private static readonly string[] FemaleMidname = new string[] { "Юрьевна", "Александровна", "Ивановна", "Игоревна", "Николаевна", "Александровна", "Максимовна", "Сергеевна", "Владимировна", "Максимовна" };
        private static readonly int StartYear = 1960;
        private static readonly int EndYear = 1998;
        private static readonly Car[] Cars = new Car[] {new Car("Hyundai", "Solaris", 107), new Car("Hyandai", "i40", 141), new Car("Audi", "TT", 180), new Car("Audi","Q7", 252), new Car("Toyota", "Camry", 150), 
                                              new Car("Toyota", "Land Cruiser", 249), new Car("Mazda", "6", 150), new Car("Mazda", "CX-5", 170), new Car("Lada", "Granta", 107), new Car("Lada", "XRAY", 122)};
     
        private static DateTime? GenerateDateTime(DateTime from, DateTime to, Random random)
        {
	        if ( from >= to )
	        {
		        throw new Exception("Параметр \"from\" должен быть меньше параметра \"to\"");
	        }
            TimeSpan range = to - from;
            if (range <= new TimeSpan(5, 0, 0, 0))
                return null;
	        var randts = new TimeSpan((long)(random.NextDouble() * range.Ticks));
	        return from + randts;
        }

        private static Client GenerateClient(Random random)
        {
            string Surname = String.Empty, Name = String.Empty, Midname = String.Empty, Phone = String.Empty;
            int Year = 0;
            int gender = random.Next(0,2);
            if (gender == 0) //male
            {
                Surname = MaleSurname[random.Next(0,MaleSurname.Length)];
                Name = MaleName[random.Next(0,MaleName.Length)];
                Midname = MaleMidname[random.Next(0,MaleMidname.Length)];
            }
            else //female
            {
                Surname = FemaleSurname[random.Next(0, FemaleSurname.Length)];
                Name = FemaleName[random.Next(0, FemaleName.Length)];
                Midname = FemaleMidname[random.Next(0, FemaleMidname.Length)];
            }
            Year = random.Next(StartYear, EndYear + 1);
            Phone = "89" + random.Next(0, 999999999).ToString();
            return new Client(Surname, Name, Midname, Year, Phone);
        }

        public static List<Client> GenerateClients(int count)
        {
            if (count<=0)
            {
                throw new Exception("Параметр \"count\" должен быть больше нуля");
            }
            Random random = new Random();
            List<Client> Clients = new List<Client>();
            for (int i = 0; i < count; i++)
                Clients.Add(GenerateClient(random));
            return Clients;
        }

        private static Car GenerateCar(Client client, Random random)
        {
            Car Car = Cars[random.Next(0, Cars.Length)];
            Car.Year = random.Next(2005, DateTime.Now.Year);
            int TypeTransmission = random.Next(0,3);
            switch (TypeTransmission)
            {
                case 0:
                    Car.Transmission = TypesOfTransmission.Mechanical;
                    break;
                case 1:
                    Car.Transmission = TypesOfTransmission.Automatic;
                    break;
                case 2:
                    Car.Transmission = TypesOfTransmission.Robotized;
                    break;
            }
            Car.Client = client;
            return Car;
        }

        private static Order GenerateOrder(int id, Client client, Random random)
        {
            List<Work> Works = new List<Work>();
            int CountWorks = random.Next(1,OrderWorks.Length+1);
            int PriceWorks = 0;
            for(int i=0; i<CountWorks; i++)
            {
                Works.Add(OrderWorks[random.Next(0,OrderWorks.Length)]);
                PriceWorks+= Works[i].Price;
            }
            int Price = PriceWorks;
            DateTime TimeBegin = (DateTime)GenerateDateTime(new DateTime(2016, 6, 1), new DateTime(2016, 6, 30), random);
            DateTime? TimeEnd = GenerateDateTime(TimeBegin, new DateTime(2016, 6, 30), random);
            Car Car = GenerateCar(client, random);
            return new Order(id, Price, TimeBegin, TimeEnd, Car, Works);
        }

        public static List<Order> GenerateOrders(int count, List<Client> clients)
        {
            if (count <= 0)
            {
                throw new Exception("Параметр \"count\" должен быть больше нуля");
            }
            List<Order> Orders = new List<Order>();
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                Client Client = clients[random.Next(0, clients.Count)];
                Orders.Add(GenerateOrder(i+1,Client, random));
            }
            return Orders;
        }
    }
}
