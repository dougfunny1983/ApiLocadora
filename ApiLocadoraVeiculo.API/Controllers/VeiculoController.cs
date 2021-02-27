using ApiLocadoraVeiculo.Application.Dtos;
using ApiLocadoraVeiculo.Application.Interfaces.AplicationService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApiLocadoraVeiculo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        private readonly IApplicationServiceVeiculo applicationServiceVeiculo;

        public VeiculoController(IApplicationServiceVeiculo applicationServiceVeiculo) =>
            this.applicationServiceVeiculo = applicationServiceVeiculo;

        [HttpGet]
        public ActionResult<IEnumerable<VeiculoDto>> Get()
        {
            var veiculos = applicationServiceVeiculo.Get();
            return Ok(veiculos);
        }

        [HttpGet("{id}")]
        public ActionResult<VeiculoDto> Get(string id)
        {
            var veiculos = applicationServiceVeiculo.Get(id);

            if (veiculos == null)
            {
                return NotFound();
            }

            return Ok(veiculos);
        }

        [HttpPost]
        public ActionResult<VeiculoDto> Post([FromBody] VeiculoDto veiculo)
        {
            applicationServiceVeiculo.Create(veiculo);

            return Ok(veiculo);
        }

        [HttpPut("{id}")]
        public IActionResult Update(string id, VeiculoDto veiculo)
        {
            var newCliente = applicationServiceVeiculo.Get(id);

            if (newCliente == null)
            {
                return NotFound();
            }

            applicationServiceVeiculo.Update(id, veiculo);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var veiculo = applicationServiceVeiculo.Get(id);

            if (veiculo == null)
            {
                return NotFound();
            }

            applicationServiceVeiculo.Delete(veiculo.Id);

            return NoContent();
        }
    }
}