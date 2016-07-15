using AutoService.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AutoService.DataSourceHandlers
{
    [Serializable]
    public class SerializeData
    {
        public List<Client> Clients { get; private set; }
        public List<Order> Orders { get; private set; }

        public SerializeData(List<Client> clients, List<Order> orders)
        {
            Clients = clients;
            Orders = orders;
        }
        public SerializeData()
        {
        }
    }

    class BinaryHandler
    {
        BinaryFormatter formatter;

        public BinaryHandler()
        {
            formatter = new BinaryFormatter();

            if (!File.Exists("AutoServiceData.dat"))
                CreateFullFile();
        }

        private void CreateFullFile()
        {
            List<Client> Clients = ObjectsBuilder.GenerateClients(30);
            List<Order> Orders = ObjectsBuilder.GenerateOrders(50, Clients);
            SerializeData SerializeData = new SerializeData(Clients, Orders);
            using (FileStream fs = new FileStream("AutoServiceData.dat", FileMode.Create))
            {
                try
                {
                    formatter.Serialize(fs, SerializeData);
                }
                catch (SerializationException e)
                {
                    Console.WriteLine("Ошибка сериализации. Причина: " + e.Message);
                    throw;
                }
            }
        }

        private SerializeData LoadDataFromFiles()
        {
            using (FileStream fs = new FileStream("AutoServiceData.dat", FileMode.Open))
            {
                try
                {
                    return (SerializeData)formatter.Deserialize(fs);
                }
                catch (SerializationException e)
                {
                    Console.WriteLine("Ошибка десериализации. Причина: " + e.Message);
                    throw;
                }
            }
        }

        public List<Order> LoadOrders()
        {
            if (File.Exists("AutoServiceData.dat"))
                return LoadDataFromFiles().Orders;
            else
            {
                MessageBoxResult result = MessageBox.Show("Запрашиваемый источник данных не существует. Хотите ли сгенерировать новый файл AutoServiceData.dat?", "Ошибка открытия файла", MessageBoxButton.YesNo, MessageBoxImage.Error);
                if (result == MessageBoxResult.Yes)
                {
                    CreateFullFile();
                    return LoadDataFromFiles().Orders;
                }
                else
                    return null;
            }
        }
    }
}
