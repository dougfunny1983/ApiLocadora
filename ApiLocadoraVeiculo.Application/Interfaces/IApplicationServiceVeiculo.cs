using ApiLocadoraVeiculo.Application.Dtos;
using System.Collections.Generic;

namespace ApiLocadoraVeiculo.Application.Interfaces
{
    public interface IApplicationServiceVeiculo
    {
        void Add(VeiculoDto veiculoDto);

        void Update(VeiculoDto veiculoDto);

        void Remove(VeiculoDto veiculoDto);

        IEnumerable<VeiculoDto> GetAll();

        VeiculoDto GetById(int id);
    }
}
