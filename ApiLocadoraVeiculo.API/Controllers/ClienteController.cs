using ApiLocadoraVeiculo.Application.Dtos;
using ApiLocadoraVeiculo.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public ActionResult<IEnumerable<string>> Get() => Ok(applicationServiceCliente.GetAll());

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id) => Ok(applicationServiceCliente.GetById(id));

        [HttpPost]
        public ActionResult Post([FromBody] ClienteDto clienteDto) 
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();
                applicationServiceCliente.Add(clienteDto);
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

        [HttpDelete]
        public ActionResult Delete([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();
                applicationServiceCliente.Remove(clienteDto);
                return Ok("cliente Removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
