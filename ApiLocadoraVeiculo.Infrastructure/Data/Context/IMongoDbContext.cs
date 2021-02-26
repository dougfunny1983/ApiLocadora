using MongoDB.Driver;

namespace ApiLocadoraVeiculo.Infrastructure.Data
{
    public interface IMongoDbContext
    {
        IMongoCollection<Book> GetCollection<Book>(string name);
    }
}

