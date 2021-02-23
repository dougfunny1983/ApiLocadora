using ApiLocadoraVeiculo.Application.Dtos;
using ApiLocadoraVeiculo.Application.Interfaces;
using ApiLocadoraVeiculo.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiLocadoraVeiculo.Application
{
    public class ApplicationServiceCliente : IApplicationServiceCliente
    {
        private readonly IServiceCliente serviceCliente;

        private readonly IMapperCliente mapperCliente;

        public void Add(ClienteDto clienteDto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClienteDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public ClienteDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(ClienteDto clienteDto)
        {
            throw new NotImplementedException();
        }

        public void Update(ClienteDto clienteDto)
        {
            throw new NotImplementedException();
        }
    }
}
