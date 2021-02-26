﻿using ApiLocadoraVeiculo.Domain.Core.Interfaces.Repositorys;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiLocadoraVeiculo.Infrastructure.Data.Repositorys
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected readonly IMongoDbContext _mongoContext;
        protected IMongoCollection<TEntity> _dbCollection;

        protected RepositoryBase(IMongoDbContext context)
        {
            _mongoContext = context;
            _dbCollection = _mongoContext.GetCollection<TEntity>(typeof(TEntity).Name);
        }

        public async Task Create(TEntity obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(typeof(TEntity).Name + " object is null");
            }
            await _dbCollection.InsertOneAsync(obj);
        }

        public async Task<TEntity> Get(string id)
        {
            var objectId = new ObjectId(id);

            FilterDefinition<TEntity> filter = Builders<TEntity>.Filter.Eq("_id", objectId);

            return await _dbCollection.FindAsync(filter).Result.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<TEntity>> Get()
        {
            var all = await _dbCollection.FindAsync(Builders<TEntity>.Filter.Empty);
            return await all.ToListAsync();
        }

        public void Delete(string id)
        {
            var objectId = new ObjectId(id);
            _dbCollection.DeleteOneAsync(Builders<TEntity>.Filter.Eq("_id", objectId));
        }

        public virtual void Update(TEntity obj)
        {
            _dbCollection.ReplaceOneAsync(Builders<TEntity>.Filter.Eq("_id", obj.GetId()), obj);
        }
    }
}