using ApiLocadoraVeiculo.Application.Dtos;
using ApiLocadoraVeiculo.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiLocadoraVeiculo.Application.Interfaces.Mappers
{
    public interface IMapperCliente
    {
        Cliente MapperDtoToEntity(ClienteDto cliente);

        IEnumerable<ClienteDto> MapperListClientesDto(Task<IEnumerable<Cliente>> clientes);

        ClienteDto MapperEntityToDto(Task<Cliente> cliente);
    }
}
