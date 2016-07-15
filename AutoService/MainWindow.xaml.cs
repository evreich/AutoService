using AutoService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AutoService
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SourceData.ItemsSource = new string[] { "MySQL", "MongoDB", "AutoServiceData.xml", "AutoServiceData.dat" };
            List<Order> test = new List<Order>();
            Client cl = new Client("Vlasov", "Maxim","Sergeevich", 1995, "8-962-328-89-33");
            Car mazda = new Car("Mazda","RX-7",1995,256,TypesOfTransmission.Mechanical, cl);
            Car uaz = new Car("UAZ", "Patriot", 1990, 9000, TypesOfTransmission.Automatic, cl);
            Work work1 = new Work("Замена масла",1000,20);
            Work work2 = new Work("Диагностика автомобиля", 2000, 30);
            Work work3 = new Work("Заправка кондиционера", 100000, 20);
            test.Add(new Order(1, 300000,DateTime.MinValue,DateTime.Now, mazda, new List<Work>() {work1, work2}));
            test.Add(new Order(2, 20000, DateTime.MinValue, DateTime.Now, uaz, new List<Work>() {work3, work1 }));
            OrdersGrid.ItemsSource = test;
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
