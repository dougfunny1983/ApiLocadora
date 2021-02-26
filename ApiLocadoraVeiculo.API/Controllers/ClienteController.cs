using ApiLocadoraVeiculo.Application.Dtos;
using ApiLocadoraVeiculo.Application.Interfaces;
using ApiLocadoraVeiculo.Application.Interfaces.AplicationService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiLocadoraVeiculo.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IApplicationServiceCliente applicationServiceCliente;

        public ClienteController(IApplicationServiceCliente applicationServiceCliente) =>
            this.applicationServiceCliente = applicationServiceCliente;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> Get() =>
            Ok(await applicationServiceCliente.Get());
        

        [HttpGet("{id}")]
        public ActionResult<string> Get(string id) => 
            Ok(applicationServiceCliente.Get(id));

        [HttpPost]
        public ActionResult Post([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();
                applicationServiceCliente.Create(clienteDto);
                return Ok("cliente cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();
                applicationServiceCliente.Update(clienteDto);
                return Ok("cliente Atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            applicationServiceCliente.Delete(id);
            return Ok("cliente Removido com sucesso!");

        }
        
    }
}