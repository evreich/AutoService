using AutoService.Models;
using AutoServiceClassLibrary.DataSourceHandlers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;


namespace AutoService.DataSourceHandlers
{

    public class BinaryHandler : ISerializer
    {
        BinaryFormatter formatter;

        public BinaryHandler(BinaryFormatter formatter)
        {
            this.formatter = formatter;

            if (!File.Exists("AutoServiceData.dat"))
                CreateFullFile();
        }

        public void CreateFullFile()
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
                    MessageBox.Show("Ошибка сериализации. Причина: " + e.Message);
                    throw;
                }
            }
        }

        public List<Order> LoadDataFromFiles()
        {
            using (FileStream fs = new FileStream("AutoServiceData.dat", FileMode.Open))
            {
                try
                {
                    return (List<Order>)formatter.Deserialize(fs);
                }
                catch (SerializationException e)
                {
                    MessageBox.Show("Ошибка десериализации. Причина: " + e.Message);
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
                DialogResult result = MessageBox.Show("Запрашиваемый источник данных не существует. Хотите ли сгенерировать новый файл AutoServiceData.dat?", "Ошибка открытия файла",MessageBoxButtons.YesNo);
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
