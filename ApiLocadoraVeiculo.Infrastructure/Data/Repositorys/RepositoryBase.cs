using ApiLocadoraVeiculo.Domain.Core.Interfaces.Base;
using ApiLocadoraVeiculo.Domain.Entitys;
using MongoDB.Driver;
using System.Collections.Generic;

namespace ApiLocadoraVeiculo.Infrastructure.Data.Repositorys
{
    public abstract class RepositoryBase<TEntity> : IBase<TEntity> where TEntity : Base
    {
        protected readonly IMongoDbContext Context;
        protected IMongoCollection<TEntity> DbSet;

        protected RepositoryBase(IMongoDbContext context)
        {
            this.Context = context;
            DbSet = this.Context.GetCollection<TEntity>(typeof(TEntity).Name);
        }

        public IEnumerable<TEntity> Get() =>
            DbSet.Find(isValid => true).ToList();

        public TEntity Get(string id) =>
            DbSet.Find(colectionObj => colectionObj.Id == id).FirstOrDefault();

        public void Create(TEntity obj) => DbSet.InsertOne(obj);

        public void Update(string id, TEntity obj) =>
            DbSet.ReplaceOne(colectionObj => colectionObj.Id == id, obj);

        public void Delete(TEntity obj) =>
            DbSet.DeleteOne(colectionObj => colectionObj.Id == obj.Id);

        public void Delete(string id) =>
            DbSet.DeleteOne(colectionObj => colectionObj.Id == id);

    }
}