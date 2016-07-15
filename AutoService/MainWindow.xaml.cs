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
        public MainWindow()
        {
            InitializeComponent();
            SourceData.ItemsSource = new string[] { "MySQL", "MongoDB", "AutoServiceData.xml", "AutoServiceData.dat" };

            BinHandler = new BinaryHandler();
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            switch (SourceData.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    OrdersGrid.ItemsSource = BinHandler.LoadOrders();
                    break;
                default:
                    break;
            }
        }
    }
}
