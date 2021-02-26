using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiLocadoraVeiculo.Application.Interfaces.AplicationService
{
    public interface IApplicationServiceBase<TEntity> where TEntity : class
    {
        Task Create(TEntity obj);

        void Update(TEntity obj);

        //void Delete(Task<TEntity> obj);

        void Delete(string id);

        Task<TEntity> Get(string id);

        Task<IEnumerable<TEntity>> Get();


        
    }
}
