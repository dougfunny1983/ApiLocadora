using ApiLocadoraVeiculo.Application.Dtos;
using ApiLocadoraVeiculo.Application.Interfaces.AplicationService;
using ApiLocadoraVeiculo.Application.Interfaces.Mappers;
using ApiLocadoraVeiculo.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

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

        public void Create(VeiculoDto veiculoDto)
        {
            var veiculo = mapperVeiculo.MapperDtoToEntity(veiculoDto);
            serviceVeiculo.Create(veiculo);
        }

        public IEnumerable<VeiculoDto> Get()
        {
            var veiculos = serviceVeiculo.Get();
            return mapperVeiculo.MapperListVeiculosDto(veiculos);
        }

        public VeiculoDto Get(string id)
        {
            var veiculo = serviceVeiculo.Get(id);
            return mapperVeiculo.MapperEntityToDto(veiculo);
        }

        public void Update(string id, VeiculoDto veiculoDto)
        {
            var veiculo = mapperVeiculo.MapperDtoToEntity(veiculoDto);
            serviceVeiculo.Update(id, veiculo);
        }

        public void Delete(VeiculoDto veiculoDto)
        {
            var veiculo = mapperVeiculo.MapperDtoToEntity(veiculoDto);
            serviceVeiculo.Delete(veiculo);
        }

        public void Delete(string id) =>
            serviceVeiculo.Delete(id);

        //public void Dispose()
        //{
        //    throw new NotImplementedException();
        //}
    }
}