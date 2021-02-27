using ApiLocadoraVeiculo.Application.Dtos;
using ApiLocadoraVeiculo.Domain.Entitys;
using System.Collections.Generic;

namespace ApiLocadoraVeiculo.Application.Interfaces.Mappers
{
    public interface IMapperVeiculo
    {
        Veiculo MapperDtoToEntity(VeiculoDto veiculo);

        IEnumerable<VeiculoDto> MapperListVeiculosDto(IEnumerable<Veiculo> veiculo);

        VeiculoDto MapperEntityToDto(Veiculo veiculo);
    }
}