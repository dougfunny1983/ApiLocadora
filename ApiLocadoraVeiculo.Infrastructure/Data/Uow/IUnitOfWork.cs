using System;
using System.Threading.Tasks;

namespace ApiLocadoraVeiculo.Infrastructure.Data.Uow
{
    public interface IUnitOfWork : IDisposable
    {
        Task<bool> Commit();
    }
}