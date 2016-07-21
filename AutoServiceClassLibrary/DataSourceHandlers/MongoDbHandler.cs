using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using AutoService.Models;

namespace AutoService.DataSourceHandlers
{
    public class MongoDbHandler
    {
        MongoClient Client;
        IMongoDatabase Database;
        IMongoCollection<Order> Orders;

        public MongoDbHandler(MongoClient Client)
        {
            this.Client = Client;
            Database = Client.GetDatabase("dbAutoService");
            Orders = Database.GetCollection<Order>("Orders");
            CheckDb();
        }

        private async void CheckDb()
        {
            var count = await CountDocs();
            if (count < 50)
            {
                await Orders.DeleteManyAsync(new BsonDocument());
                await SaveDocs();
            }
        }
        private async Task<long> CountDocs()
        {
            return await Orders.CountAsync(new BsonDocument());
        }

        private async Task SaveDocs()
        {
            await Orders.InsertManyAsync(ObjectsBuilder.GenerateOrders(50, ObjectsBuilder.GenerateClients(30)));
        }

        public async Task<List<Order>> LoadDocs()
        {
            return await Orders.Find(new BsonDocument()).ToListAsync();
        }
    }
}
