using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContext : ICatalogContext
    {
        public CatalogContext(IConfiguration configuration)
        {
            string connectionString = configuration.GetValue<string>("ConnectionStrings:ConnectionString");
            var client = new MongoClient(connectionString);
            string name = configuration.GetValue<string>("ConnectionStrings:DatabaseName");
            var database = client.GetDatabase(name);
            string collectionName = configuration.GetValue<string>("ConnectionStrings:CollectionName");
            Products = database.GetCollection<Product>(collectionName);
            CatalogContextSeed.SeedData(Products);
        }
        public IMongoCollection<Product> Products { get; }
    }
}
