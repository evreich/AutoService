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
using Microsoft.Practices.Unity;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using MongoDB.Driver;
using System.Configuration;


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
        
        MongoDbHandler MongoDbHandler;
        private UnityContainer Source;

        public MainWindowViewModel()
        {
            Source = new UnityContainer();
            Source.RegisterType<ISerializer, BinaryHandler>("Binary", new ContainerControlledLifetimeManager()).RegisterType<BinaryFormatter>(new InjectionConstructor());
            Source.RegisterType<ISerializer, XMLHandler>("XML", new ContainerControlledLifetimeManager()).RegisterType<XmlSerializer>(new InjectionConstructor(new InjectionParameter(typeof(List<Order>))));
            Source.RegisterType<AutoServiceContext>(new ContainerControlledLifetimeManager(), new InjectionConstructor());
            Source.RegisterType<MongoDbHandler>(new ContainerControlledLifetimeManager()).RegisterType<MongoClient>(new InjectionConstructor(new InjectionParameter(ConfigurationManager.ConnectionStrings["MongoDbConnection"].ConnectionString)));
            sources = new List<string> { "MySQL", "MongoDB", "AutoServiceData.xml", "AutoServiceData.dat" };
            changeSourceCommand = new Command(arg => ChangeSource());
        }

        private async void ChangeSource()
        {
            switch (SelectedItem)
            {
                case 0:
                    Container = Source.Resolve<AutoServiceContext>().Orders.ToList();
                    break;
                case 1:
                    List<Order> Orders = await Source.Resolve<MongoDbHandler>().LoadDocs();
                    Container = Orders;
                    break;
                case 2:
                    Container = Source.Resolve<ISerializer>("XML").LoadOrders();
                    break;
                case 3:
                    Container = Source.Resolve<ISerializer>("Binary").LoadOrders();
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
