using AutoService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceClassLibrary.DataSourceHandlers
{
    public interface ISerializer
    {
        List<Order> LoadOrders();
        void CreateFullFile();
        List<Order> LoadDataFromFiles();
    }
}
