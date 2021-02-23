using ApiLocadoraVeiculo.Application.Dtos;
using ApiLocadoraVeiculo.Application.Interfaces;
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

        public void Add(VeiculoDto veiculoDto)
        {
            var veiculo = mapperVeiculo.MapperDtoToEntity(veiculoDto);
            serviceVeiculo.Add(veiculo);
        }

        public IEnumerable<VeiculoDto> GetAll()
        {
            var veiculos = serviceVeiculo.GetAll();
            return mapperVeiculo.MapperListVeiculosDto(veiculos);
        }

        public VeiculoDto GetById(int id)
        {
            var veiculo = serviceVeiculo.GetById(id);
            return mapperVeiculo.MapperEntityToDto(veiculo);
        }

        public void Remove(VeiculoDto veiculoDto)
        {
            var veiculo = mapperVeiculo.MapperDtoToEntity(veiculoDto);
            serviceVeiculo.Remove(veiculo);
        }

        public void Update(VeiculoDto veiculoDto)
        {
            var veiculo = mapperVeiculo.MapperDtoToEntity(veiculoDto);
            serviceVeiculo.Update(veiculo);
        }
    }
}