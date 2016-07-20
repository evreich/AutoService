using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoService.DataSourceContext;
using AutoService.DataSourceHandlers;
using System.Windows.Input;
using System.Windows;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using AutoService.Models;


namespace AutoService.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private readonly List<string> sources;
        public List<string> Sources
        {
            get
            {
                return sources;
            }
        }

        private int selectedItem;
        public int SelectedItem
        {
            get { return selectedItem; }

            set
            {
                selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }

        private List<Order> container;
        public List<Order> Container
        {
            get
            {
                return container;
            }
            set
            {
                container = value;
                OnPropertyChanged("Container");
            }
        }

        BinaryHandler BinHandler;
        XMLHandler XMLHandler;
        MongoDbHandler MongoDbHandler;

        public MainWindowViewModel()
        {
            BinHandler = new BinaryHandler();
            XMLHandler = new XMLHandler();
            MongoDbHandler = new MongoDbHandler();
            sources = new List<string> { "MySQL", "MongoDB", "AutoServiceData.xml", "AutoServiceData.dat" };
            changeSourceCommand = new Command(arg => ChangeSource());
        }

        private async void ChangeSource()
        {
            switch (SelectedItem)
            {
                case 0:
                    using (var ctx = new AutoServiceContext())
                    {
                        Container = ctx.Orders.Local.ToList();
                        break;
                    }
                case 1:
                    List<Order> Orders = await MongoDbHandler.LoadDocs();
                    Container = Orders;
                    break;
                case 2:
                    Container = XMLHandler.LoadOrders();
                    break;
                case 3:
                    Container = BinHandler.LoadOrders();
                    break;
                default:
                    break;
            } 
        }
        private Command changeSourceCommand;
        public Command ChangeSourceCommand
        {
            get
            {
                return changeSourceCommand;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
