using ApiLocadoraVeiculo.Application.Dtos;
using ApiLocadoraVeiculo.Application.Interfaces.AplicationService;
using ApiLocadoraVeiculo.Application.Interfaces.Mappers;
using ApiLocadoraVeiculo.Domain.Core.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        public async Task Create(ClienteDto clienteDto)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
            await serviceCliente.Create(cliente);
        }

        public Task <IEnumerable<ClienteDto>> Get()
        {
            var clientes = serviceCliente.Get();
            return Task.FromResult(mapperCliente.MapperListClientesDto(clientes));
        }

        public Task <ClienteDto> Get(string id)
        {
            var cliente = serviceCliente.Get(id);
            return Task.FromResult(mapperCliente.MapperEntityToDto(cliente));
        }

        public async Task Delete(string id)
        {
            var clienteDto = await Get(id);
            var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
            serviceCliente.Delete(cliente);
        }

        public void Update(ClienteDto clienteDto)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
            serviceCliente.Update(cliente);
        }

    }
}