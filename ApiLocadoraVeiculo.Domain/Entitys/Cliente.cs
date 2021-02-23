using System;

namespace ApiLocadoraVeiculo.Domain.Entitys
{
    public class Cliente : Base
    {
        public int Nome { get; set; }
        public int Endereco { get; set; }
        public int Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool IsAtivo { get; set; }
    }
}