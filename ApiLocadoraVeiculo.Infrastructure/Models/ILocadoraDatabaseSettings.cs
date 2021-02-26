using System;
using System.Collections.Generic;
using System.Text;

namespace ApiLocadoraVeiculo.Infrastructure.Models
{
  
    public interface ILocadoraDatabaseSettings
    {
        string VeiculosCollectionName { get; set; }
        string ClienteCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }


}
