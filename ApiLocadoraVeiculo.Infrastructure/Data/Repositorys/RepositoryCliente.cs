using ApiLocadoraVeiculo.Domain.Core.Interfaces.Repositorys;
using ApiLocadoraVeiculo.Domain.Entitys;

namespace ApiLocadoraVeiculo.Infrastructure.Data.Repositorys
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        private readonly MongoDbContext MongoDbContext;

        public RepositoryCliente(MongoDbContext MongoDbContext) 
            : base(MongoDbContext) => this.MongoDbContext = MongoDbContext;
        
    }
}