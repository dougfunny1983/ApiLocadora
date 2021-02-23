using ApiLocadoraVeiculo.Application.Dtos;
using System.Collections.Generic;

namespace ApiLocadoraVeiculo.Application.Interfaces
{
    public interface IApplicationServiceVeiculo
    {
        void Add(VeiculoDto veiculo);

        void Update(VeiculoDto veiculo);

        void Remove(VeiculoDto veiculo);

        IEnumerable<VeiculoDto> GetAll();

        VeiculoDto GetById(int id);
    }
}
