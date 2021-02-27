using ApiLocadoraVeiculo.Domain.Core.Interfaces.Repositorys;
using ApiLocadoraVeiculo.Domain.Core.Interfaces.Services;
using ApiLocadoraVeiculo.Domain.Entitys;

namespace ApiLocadoraVeiculo.Domain.Services
{
    public class ServiceVeiculo : ServiceBase<Veiculo>, IServiceVeiculo
    {
        private readonly IRepositoryVeiculo repositoryVeiculo;

        public ServiceVeiculo(IRepositoryVeiculo repositoryVeiculo)
            : base(repositoryVeiculo) => this.repositoryVeiculo = repositoryVeiculo;
    }
}