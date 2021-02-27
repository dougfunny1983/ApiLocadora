using ApiLocadoraVeiculo.Application;
using ApiLocadoraVeiculo.Application.Interfaces.AplicationService;
using ApiLocadoraVeiculo.Application.Interfaces.Mappers;
using ApiLocadoraVeiculo.Application.Mappers;
using ApiLocadoraVeiculo.Domain.Core.Interfaces.Repositorys;
using ApiLocadoraVeiculo.Domain.Core.Interfaces.Services;
using ApiLocadoraVeiculo.Domain.Services;
using ApiLocadoraVeiculo.Infrastructure.Data.Repositorys;
using Autofac;

namespace ApiLocadoraVeiculo.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC (Inversão de Controles)

            #region IOC Dependência da Aplicação
            builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<ApplicationServiceVeiculo>().As<IApplicationServiceVeiculo>();
            #endregion IOC Dependência da Aplicação

            #region IOC Dependência dos Serviços
            builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
            builder.RegisterType<ServiceVeiculo>().As<IServiceVeiculo>();
            #endregion IOC Dependência dos Serviços

            #region IOC Dependência dos Repositorys SQL
            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryVeiculo>().As<IRepositoryVeiculo>();
            #endregion IOC Dependência dos Repositorys SQL

            #region IOC Dependência do Mapper
            builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            builder.RegisterType<MapperVeiculo>().As<IMapperVeiculo>();
            #endregion IOC Dependência do Mapper

            #endregion IOC (Inversão de Controles)
        }
    }
}