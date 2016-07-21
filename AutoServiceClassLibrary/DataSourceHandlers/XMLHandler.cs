using AutoService.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace AutoService.DataSourceHandlers
{
    public interface ISerializer
    {
        List<Order> LoadOrders();
    }

    public class XMLHandler : ISerializer
    {
        XmlSerializer formatter;

        public XMLHandler(XmlSerializer formatter)
        {
            this.formatter = formatter;

            if (!File.Exists("AutoServiceData.xml"))
                CreateFullFile();
        }

        private void CreateFullFile()
        {
            List<Order> Orders = ObjectsBuilder.GenerateOrders(50, ObjectsBuilder.GenerateClients(30));
            using (FileStream fs = new FileStream("AutoServiceData.xml", FileMode.Create))
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
            using (FileStream fs = new FileStream("AutoServiceData.xml", FileMode.Open))
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
            if (File.Exists("AutoServiceData.xml"))
                return LoadDataFromFiles();
            else
            {
                DialogResult result = MessageBox.Show("Запрашиваемый источник данных не существует. Хотите ли сгенерировать новый файл AutoServiceData.xml?", "Ошибка открытия файла", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
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
