using ApiLocadoraVeiculo.Domain.Core.Interfaces.Repositorys;
using ApiLocadoraVeiculo.Domain.Entitys;

namespace ApiLocadoraVeiculo.Domain.Services
{
    public class ServiceCliente : ServiceBase<Cliente>
    {
        private readonly IRepositoryCliente repositoryCliente;
        public ServiceCliente(IRepositoryCliente repositoryCliente): base(repositoryCliente)
        {
            this.repositoryCliente = repositoryCliente;
        }

    }
}
