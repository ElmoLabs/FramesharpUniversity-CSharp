﻿using System;
using System.Configuration;
using System.Reflection;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Framesharp.Data.Interceptors;
using NHibernate;
using NHibernate.Bytecode;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;

namespace FramesharpUniversity.Configuration
{
    /// <summary>
    /// This class is responsible for building the NHibernate Session Factory configuration
    /// </summary>
    public class DatabaseSettings
    {
        /// <summary>
        /// Builds the NHibernate Configuration class according 
        ///  to the specifications for this application
        /// </summary>
        /// <returns>A <see cref="NHibernate.Cfg.Configuration"/> instance</returns>
        public static ISessionFactory BuildSessionFactory()
        {
            return Fluently.Configure()
              .Database(MsSqlConfiguration.MsSql2012.ConnectionString(ConfigurationManager.ConnectionStrings["conexao"].ToString()))
              .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.Load("FramesharpUniversity.Repository")))
              .BuildSessionFactory();
        }
    }
}