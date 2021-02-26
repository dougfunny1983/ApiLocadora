using ApiLocadoraVeiculo.Application.Dtos;
using ApiLocadoraVeiculo.Application.Interfaces;
using ApiLocadoraVeiculo.Application.Interfaces.AplicationService;
using ApiLocadoraVeiculo.Application.Interfaces.Mappers;
using ApiLocadoraVeiculo.Domain.Core.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiLocadoraVeiculo.Application
{
    public class ApplicationServiceVeiculo : IApplicationServiceVeiculo
    {
        private readonly IServiceVeiculo serviceVeiculo;

        private readonly IMapperVeiculo mapperVeiculo;

        public ApplicationServiceVeiculo(IServiceVeiculo serviceVeiculo, IMapperVeiculo mapperVeiculo)
        {
            this.serviceVeiculo = serviceVeiculo;
            this.mapperVeiculo = mapperVeiculo;
        }

        public async Task Create(VeiculoDto veiculoDto)
        {
            var veiculo = mapperVeiculo.MapperDtoToEntity(veiculoDto);
            await serviceVeiculo.Create(veiculo);
        }

        public Task<IEnumerable<VeiculoDto>> Get()
        {
            var veiculos = serviceVeiculo.Get();
            return Task.FromResult(mapperVeiculo.MapperListVeiculosDto(veiculos));
        }

        public Task<VeiculoDto> Get(string id)
        {
            var veiculo = serviceVeiculo.Get(id);
            return Task.FromResult(mapperVeiculo.MapperEntityToDto(veiculo));
        }

        public void Delete(VeiculoDto veiculoDto)
        {
            var veiculo = mapperVeiculo.MapperDtoToEntity(veiculoDto);
            serviceVeiculo.Delete(veiculo);
        }

        public void Update(VeiculoDto veiculoDto)
        {
            var veiculo = mapperVeiculo.MapperDtoToEntity(veiculoDto);
            serviceVeiculo.Update(veiculo);
        }
        
    }
}