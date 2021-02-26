using ApiLocadoraVeiculo.Domain.Core.Interfaces.Repositorys;
using ApiLocadoraVeiculo.Domain.Core.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiLocadoraVeiculo.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repository;

        public ServiceBase(IRepositoryBase<TEntity> repository) => this.repository = repository;


        public Task Create(TEntity obj) => repository.Create(obj);
        
        public void Delete(string id) => repository.Delete(id);      

        public Task<TEntity> Get(string id) => repository.Get(id);

        public Task<IEnumerable<TEntity>> Get() => repository.Get();

        public void Update(TEntity obj) => repository.Update(obj);
    }
}