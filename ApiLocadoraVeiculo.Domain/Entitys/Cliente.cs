﻿using System;

namespace ApiLocadoraVeiculo.Domain.Entitys
{
    public class Cliente : Base
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public bool IsAtivo { get; set; }
    }
}