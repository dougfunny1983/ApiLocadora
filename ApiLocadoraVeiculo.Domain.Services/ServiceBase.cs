﻿using ApiLocadoraVeiculo.Domain.Core.Interfaces.Repositorys;
using ApiLocadoraVeiculo.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiLocadoraVeiculo.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            this.repository = repository;
        }
        public void Add(TEntity obj)
        {
            repository.Add(obj);
        }

        public IEnumerable<TEntity> GetAll() => repository.GetAll();

        public TEntity GetById(int id) => repository.GetById(id);

        public void Remove(TEntity obj)
        {
            repository.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            repository.Update(obj);
        }
    }
}
