using Autofac;

namespace ApiLocadoraVeiculo.CrossCutting.IOC
{
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            ConfigurationIOC.Load(builder);
        }
    }
}

// manipulação de dados; performace do banco de dados; estudar sobre task (async, await);
