using System;
using System.Collections.Generic;
using System.Text;

namespace ApiLocadoraVeiculo.Infrastructure.Models
{
    public class LocadoraDatabaseSettings : ILocadoraDatabaseSettings
    {
        public string VeiculosCollectionName { get ; set ; }
        public string ClienteCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
