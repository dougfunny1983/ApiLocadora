using System.Collections.Generic;

namespace ApiLocadoraVeiculo.Domain.Core.Interfaces.Base
{
    public interface IBase<TEntity> where TEntity : class
    {
        void Create(TEntity obj);

        TEntity Get(string id);

        IEnumerable<TEntity> Get();

        void Update(string id, TEntity obj);

        void Delete(string id);

        void Delete(TEntity obj);
    }
}