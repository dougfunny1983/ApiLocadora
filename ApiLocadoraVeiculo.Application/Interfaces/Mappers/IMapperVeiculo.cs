using ApiLocadoraVeiculo.Application.Dtos;
using ApiLocadoraVeiculo.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiLocadoraVeiculo.Application.Interfaces.Mappers
{
    public interface IMapperVeiculo
    {
        Veiculo MapperDtoToEntity(VeiculoDto veiculo);

        IEnumerable<VeiculoDto> MapperListVeiculosDto(Task<IEnumerable<Veiculo>> veiculo);

        VeiculoDto MapperEntityToDto(Task<Veiculo> veiculo);
    }
}
