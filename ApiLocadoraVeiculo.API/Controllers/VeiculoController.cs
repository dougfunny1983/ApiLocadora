using ApiLocadoraVeiculo.Application.Dtos;
using ApiLocadoraVeiculo.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiLocadoraVeiculo.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        private readonly IApplicationServiceVeiculo applicationServiceVeiculo;

        public VeiculoController(IApplicationServiceVeiculo applicationServiceVeiculo) =>
            this.applicationServiceVeiculo = applicationServiceVeiculo;

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get() => Ok(applicationServiceVeiculo.GetAll());

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id) => Ok(applicationServiceVeiculo.GetById(id));

        [HttpPost]
        public ActionResult Post([FromBody] VeiculoDto veiculoDto)
        {
            try
            {
                if (veiculoDto == null)
                    return NotFound();
                applicationServiceVeiculo.Add(veiculoDto);
                return Ok("cliente cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] VeiculoDto veiculoDto)
        {
            try
            {
                if (veiculoDto == null)
                    return NotFound();
                applicationServiceVeiculo.Update(veiculoDto);
                return Ok("cliente Atualizado com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] VeiculoDto veiculoDto)
        {
            try
            {
                if (veiculoDto == null)
                    return NotFound();
                applicationServiceVeiculo.Remove(veiculoDto);
                return Ok("cliente Removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
