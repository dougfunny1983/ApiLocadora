using ApiLocadoraVeiculo.Domain.Entitys;
using ApiLocadoraVeiculo.Infrastructure.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Linq;

namespace ApiLocadoraVeiculo.Infrastructure.Data
{
    public class MongoDbContext : IMongoDbContext
    {
        private IMongoDatabase Db { get; set; }
        private MongoClient MongoClient { get; set; }
        public IClientSessionHandle Session { get; set; }
        public MongoDbContext(IOptions<LocadoraDatabaseSettings> configuration)
        {
            MongoClient = new MongoClient(configuration.Value.ConnectionString);
            Db = MongoClient.GetDatabase(configuration.Value.DatabaseName);
        }

        public IMongoCollection<T> GetCollection<T>(string name) => Db.GetCollection<T>(name);
        
    }
}