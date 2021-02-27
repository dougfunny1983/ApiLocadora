using ApiLocadoraVeiculo.Domain.Core.Interfaces.Base;
using System.Collections.Generic;

namespace ApiLocadoraVeiculo.Domain.Services
{
    public class ServiceBase<TEntity> : IBase<TEntity> where TEntity : class
    {
        private readonly IBase<TEntity> repository;

        public ServiceBase(IBase<TEntity> repository) => this.repository = repository;

        public TEntity Get(string id) => repository.Get(id);

        public IEnumerable<TEntity> Get() => repository.Get();

        public void Create(TEntity obj) => repository.Create(obj);

        public void Update(string id, TEntity obj) => repository.Update(id, obj);

        public void Delete(string id) => repository.Delete(id);

        public void Delete(TEntity obj) => repository.Delete(obj);
    }
}