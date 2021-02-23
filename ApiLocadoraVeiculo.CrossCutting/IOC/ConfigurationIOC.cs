using ApiLocadoraVeiculo.Application;
using ApiLocadoraVeiculo.Application.Interfaces;
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
            #region IOC

            builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<ApplicationServiceVeiculo>().As<IApplicationServiceVeiculo>();
            builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
            builder.RegisterType<ServiceVeiculo>().As<IServiceVeiculo>();
            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryVeiculo>().As<IRepositoryVeiculo>();
            builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            builder.RegisterType<MapperVeiculo>().As<IMapperVeiculo>();

            #endregion IOC
        }
    }
}