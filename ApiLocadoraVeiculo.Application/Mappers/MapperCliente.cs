using ApiLocadoraVeiculo.Application.Dtos;
using ApiLocadoraVeiculo.Application.Interfaces.Mappers;
using ApiLocadoraVeiculo.Domain.Entitys;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLocadoraVeiculo.Application.Mappers
{
    public class MapperCliente : IMapperCliente
    {
        public Cliente MapperDtoToEntity(ClienteDto clienteDto) =>
         new Cliente()
         {
             Id = clienteDto.Id,
             Nome = clienteDto.Nome,
             Endereco = clienteDto.Endereco,
             Email = clienteDto.Email
         };

        public ClienteDto MapperEntityToDto(Cliente cliente) =>
         new ClienteDto()
         {
             Id = cliente.Id,
             Nome = cliente.Nome,
             Endereco = cliente.Endereco,
             Email = cliente.Email
         };

        public IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes) =>
            clientes.Select(cliente =>
            new ClienteDto()
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Endereco = cliente.Endereco,
                Email = cliente.Email
            });
    }
}