using ApiLocadoraVeiculo.Domain.Core.Interfaces.Repositorys;
using ApiLocadoraVeiculo.Domain.Entitys;

namespace ApiLocadoraVeiculo.Infrastructure.Data.Repositorys
{
    public class RepositoryVeiculo : RepositoryBase<Veiculo>, IRepositoryVeiculo
    {
        private readonly MongoDbContext mongoDbContext;

        public RepositoryVeiculo(MongoDbContext mongoDbContext) 
            : base(mongoDbContext) => this.mongoDbContext = mongoDbContext;
        
    }
}

