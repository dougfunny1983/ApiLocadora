using ApiLocadoraVeiculo.Application.Dtos;
using ApiLocadoraVeiculo.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiLocadoraVeiculo.Application.Interfaces.Mappers
{
    public interface IMapperCliente
    {
        Cliente MapperDtoToEntity(ClienteDto cliente);

        IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes);

        ClienteDto MapperEntityToDto(Cliente cliente);
    }
}
