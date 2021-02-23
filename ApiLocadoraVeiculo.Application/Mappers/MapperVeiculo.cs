using ApiLocadoraVeiculo.Application.Dtos;
using ApiLocadoraVeiculo.Application.Interfaces.Mappers;
using ApiLocadoraVeiculo.Domain.Entitys;
using System.Collections.Generic;
using System.Linq;

namespace ApiLocadoraVeiculo.Application.Mappers
{
    public class MapperVeiculo : IMapperVeiculo
    {
        public Veiculo MapperDtoToEntity(VeiculoDto veiculoDto) =>
         new Veiculo()
         {
             Id = veiculoDto.Id,
             Nome = veiculoDto.Nome,
             Marca = veiculoDto.Marca,
             Modelo = veiculoDto.Modelo
         };

        public VeiculoDto MapperEntityToDto(Veiculo veiculo) =>
         new VeiculoDto()
         {
             Id = veiculo.Id,
             Nome = veiculo.Nome,
             Marca = veiculo.Marca,
             Modelo = veiculo.Modelo
         };

        public IEnumerable<VeiculoDto> MapperListVeiculosDto(IEnumerable<Veiculo> veiculos) =>
            veiculos.Select(veiculo =>
            new VeiculoDto()
            {
                Id = veiculo.Id,
                Nome = veiculo.Nome,
                Marca = veiculo.Marca,
                Modelo = veiculo.Modelo
            });
    }
}