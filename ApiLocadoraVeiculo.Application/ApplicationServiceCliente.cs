using ApiLocadoraVeiculo.Application.Dtos;
using ApiLocadoraVeiculo.Application.Interfaces.AplicationService;
using ApiLocadoraVeiculo.Application.Interfaces.Mappers;
using ApiLocadoraVeiculo.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace ApiLocadoraVeiculo.Application
{
    public class ApplicationServiceCliente : IApplicationServiceCliente
    {
        private readonly IServiceCliente serviceCliente;

        private readonly IMapperCliente mapperCliente;

        public ApplicationServiceCliente(IServiceCliente serviceCliente, IMapperCliente mapperCliente)
        {
            this.serviceCliente = serviceCliente;
            this.mapperCliente = mapperCliente;
        }

        public void Create(ClienteDto clienteDto)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
            serviceCliente.Create(cliente);
        }

        public IEnumerable<ClienteDto> Get()
        {
            var clientes = serviceCliente.Get();
            return mapperCliente.MapperListClientesDto(clientes);
        }

        public ClienteDto Get(string id)
        {
            var cliente = serviceCliente.Get(id);
            var result = mapperCliente.MapperEntityToDto(cliente);
            return result;
        }

        public void Update(string id, ClienteDto clienteDto)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
            serviceCliente.Update(id, cliente);
        }

        public void Delete(ClienteDto clienteDto)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
            serviceCliente.Delete(cliente);
        }

        public void Delete(string id)
        {
            var clienteDto = Get(id);
            var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
            serviceCliente.Delete(cliente.Id);
        }
    }
}