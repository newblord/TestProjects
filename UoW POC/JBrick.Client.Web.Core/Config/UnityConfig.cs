using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using JBrick.Client.Web.Core.Attributes;
using JBrick.Contracts.Logging;
using JBrick.Contracts.Logging.Enums;
using JBrick.Contracts.Security;
using JBrick.Core.Constants;
using JBrick.Core.Logging;
using JBrick.Core.Security;
using JBrick.Dal;
using JBrick.Dal.Sql;
using System.Data;
using JBrick.Dal.EF;
using System.Data.Entity;
using JBrick.Contracts.IoC;
using JBrick.Core.IoC;

namespace JBrick.Client.Web.Core.Config
{
    public class UnityConfig
    {
        /// <summary>
        /// Registers the type mappings with the Unity container that are common to all ECI web applications.
        /// </summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        public static void RegisterCommonTypes(IUnityContainer container)
        {
            string applicationLogLevelConfigValue = ConfigurationManager.AppSettings[Constants.Application.AppConfig_LogLevel];
            LogLevel applicationLogLevel = LogLevel.None;
            Enum.TryParse(applicationLogLevelConfigValue, out applicationLogLevel);

            container.RegisterType<IIoC, IoC>(new ContainerControlledLifetimeManager(), new InjectionConstructor(container));
            container.RegisterType<ILogger, ConsoleLogger>();
            container.RegisterType<AuthorizeAttribute, ECIAuthorizeAttribute>();
            container.RegisterType<ISecurityServiceFactory, MockSecurityServiceFactory>();

            //Uncomment either the SQL or EF UoW registrations
            //container.RegisterType<IUnitOfWorkFactory, SqlUnitOfWorkFactory>();
            //container.RegisterType<IRepositoryFactory, SqlRepositoryFactory>();
            //container.RegisterType<IRepositoryContextProvider<IDbConnection>, SqlRepositoryContextProvider>();
            container.RegisterType<IUnitOfWorkFactory, EFUnitOfWorkFactory>();
            container.RegisterType<IRepositoryFactory, EFRepositoryFactory>();
            container.RegisterType<IRepositoryContextProvider<DbContext>, EFRepositoryContextProvider>(new ContainerControlledLifetimeManager());

            container.RegisterType<ControllerActionLogAttribute>();
            container.RegisterType<ErrorHandlerLogAttribute>();
        }
    }
}
