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
            List<Order> Orders = ObjectsBuilder.GenerateOrders(50, ObjectsBuilder.GenerateClients(30));
            using (FileStream fs = new FileStream("AutoServiceData.dat", FileMode.Create))
            {
                try
                {
                    formatter.Serialize(fs, Orders);
                }
                catch (SerializationException e)
                {
                    Console.WriteLine("Ошибка сериализации. Причина: " + e.Message);
                    throw;
                }
            }
        }

        private List<Order> LoadDataFromFiles()
        {
            using (FileStream fs = new FileStream("AutoServiceData.dat", FileMode.Open))
            {
                try
                {
                    return (List<Order>)formatter.Deserialize(fs);
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
                return LoadDataFromFiles();
            else
            {
                MessageBoxResult result = MessageBox.Show("Запрашиваемый источник данных не существует. Хотите ли сгенерировать новый файл AutoServiceData.dat?", "Ошибка открытия файла", MessageBoxButton.YesNo, MessageBoxImage.Error);
                if (result == MessageBoxResult.Yes)
                {
                    CreateFullFile();
                    return LoadDataFromFiles();
                }
                else
                    return null;
            }
        }
    }
}
