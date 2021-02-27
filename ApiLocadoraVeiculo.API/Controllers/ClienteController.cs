using ApiLocadoraVeiculo.Application.Dtos;
using ApiLocadoraVeiculo.Application.Interfaces.AplicationService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApiLocadoraVeiculo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IApplicationServiceCliente applicationServiceCliente;

        public ClienteController(IApplicationServiceCliente applicationServiceCliente) =>
                    this.applicationServiceCliente = applicationServiceCliente;

        [HttpGet]
        public ActionResult<IEnumerable<ClienteDto>> Get()
        {
            var clientes = applicationServiceCliente.Get();
            return Ok(clientes);
        }

        [HttpGet("{id}")]
        public ActionResult<ClienteDto> Get(string id)
        {
            var cliente = applicationServiceCliente.Get(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return cliente;
        }

        [HttpPost]
        public ActionResult<ClienteDto> Post([FromBody] ClienteDto cliente)
        {
            applicationServiceCliente.Create(cliente);

            return Ok(cliente);
        }

        [HttpPut("{id}")]
        public IActionResult Update(string id, ClienteDto cliente)
        {
            var newCliente = applicationServiceCliente.Get(id);

            if (newCliente == null)
            {
                return NotFound();
            }

            applicationServiceCliente.Update(id, cliente);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var cliente = applicationServiceCliente.Get(id);

            if (cliente == null)
            {
                return NotFound();
            }

            applicationServiceCliente.Delete(cliente.Id);

            return NoContent();
        }
    }
}