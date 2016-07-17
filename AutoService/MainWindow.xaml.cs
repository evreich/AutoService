using AutoService.DataSourceContext;
using AutoService.DataSourceHandlers;
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
        BinaryHandler BinHandler;
        XMLHandler XMLHandler;
        AutoServiceContext MySQLDatabase;
        MongoDbHandler MongoDbHandler;
        public MainWindow()
        {
            InitializeComponent();
            SourceData.ItemsSource = new string[] { "MySQL", "MongoDB", "AutoServiceData.xml", "AutoServiceData.dat" };

            BinHandler = new BinaryHandler();
            XMLHandler = new XMLHandler();
            MySQLDatabase = new AutoServiceContext();
            MongoDbHandler = new MongoDbHandler();
        }

        private async void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            switch (SourceData.SelectedIndex)
            {
                case 0:
                    OrdersGrid.ItemsSource = MySQLDatabase.Orders.Local.ToList();
                    break;
                case 1:
                    List<Order> Orders = await MongoDbHandler.LoadDocs();
                    OrdersGrid.ItemsSource = Orders;
                    break;
                case 2:
                    OrdersGrid.ItemsSource = XMLHandler.LoadOrders();
                    break;
                case 3:
                    OrdersGrid.ItemsSource = BinHandler.LoadOrders();
                    break;
                default:
                    break;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MySQLDatabase.Dispose();
        }
    }
}
