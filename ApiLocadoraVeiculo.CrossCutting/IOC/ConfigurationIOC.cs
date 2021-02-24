﻿using ApiLocadoraVeiculo.Application;
using ApiLocadoraVeiculo.Application.Interfaces;
using ApiLocadoraVeiculo.Application.Interfaces.Mappers;
using ApiLocadoraVeiculo.Application.Mappers;
using ApiLocadoraVeiculo.Domain.Core.Interfaces.Repositorys;
using ApiLocadoraVeiculo.Domain.Core.Interfaces.Services;
using ApiLocadoraVeiculo.Domain.Services;
using ApiLocadoraVeiculo.Infrastructure.Data.Repositorys;
using Autofac;
//using AutoMapper;

namespace ApiLocadoraVeiculo.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC (Injeção de Dependência)

            #region Injeção de Dependência da Aplicação
            builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<ApplicationServiceVeiculo>().As<IApplicationServiceVeiculo>();
            #endregion

            #region Injeção de Dependência dos Serviços
            builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
            builder.RegisterType<ServiceVeiculo>().As<IServiceVeiculo>();
            #endregion

            #region Injeção de Dependência dos Repositorys SQL
            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryVeiculo>().As<IRepositoryVeiculo>();
            #endregion

            #region Injeção de Dependência do Mapper
            builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            builder.RegisterType<MapperVeiculo>().As<IMapperVeiculo>();

        //    builder.Register(ctx => new MapperConfiguration(cfg =>
        //    {
        //        cfg.AddProfile(new DtoToModelMappingCliente());
        //        cfg.AddProfile(new ModelToDtoMappingCliente());
        //        cfg.AddProfile(new DtoToModelMappingProduto());
        //        cfg.AddProfile(new ModelToDtoMappingProduto());

        //    }));

        //    builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().InstancePerLifetimeScope();
        //}
        #endregion

        #endregion IOC (Injeção de Dependência)
    }
    }
}