using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiLocadoraVeiculo.Domain.Core.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        Task Create(TEntity obj);

        void Update(TEntity obj);

        void Delete(TEntity obj);

        Task<TEntity> Get(string id);

        Task<IEnumerable<TEntity>> Get();
    }
}