This demo uses either an In-Memory SQL Repository or an In-Memory Entity Framework Repository to make it easy to Run.
Steps to run the app:
1. Configure either the SQL or EF Repository
	a. In file Jbrick.Client.Web.Core.Config.UnityConfig.cs, Uncomment one of the two below IOC registration blocks
			//container.RegisterType<IUnitOfWorkFactory, SqlUnitOfWorkFactory>();
            //container.RegisterType<IRepositoryFactory, SqlRepositoryFactory>();
            //container.RegisterType<IRepositoryContextProvider<IDbConnection>, SqlRepositoryContextProvider>();
            container.RegisterType<IUnitOfWorkFactory, EFUnitOfWorkFactory>();
            container.RegisterType<IRepositoryFactory, EFRepositoryFactory>();
            container.RegisterType<IRepositoryContextProvider<DbContext>, EFRepositoryContextProvider>(new ContainerControlledLifetimeManager());
	b. In file JBrick.Client.Web.EquipmentGuide.App_Start.UnityConfig.cs, Uncomment one of the two below Ioc registration blocks
	        //// Uncomment the registration section for either EF or Sql UoW implementation
            //container.RegisterTypes(
            //    AllClasses.FromLoadedAssemblies().Where(t => t.Namespace != null && t.Namespace.StartsWith("JBrick.Dal.Sql.MockEquipmentGuide")),
            //    WithMappings.FromMatchingInterface,
            //    overwriteExistingMappings: false);

            //container.RegisterTypes(
            //    AllClasses.FromLoadedAssemblies().Where(t => t.Namespace != null && t.Namespace.StartsWith("JBrick.Dal.Sql")),
            //    WithMappings.FromMatchingInterface,
            //    overwriteExistingMappings: false);

            container.RegisterTypes(
                AllClasses.FromLoadedAssemblies().Where(t => t.Namespace != null && t.Namespace.StartsWith("JBrick.Dal.EF.EquipmentGuide")),
                WithMappings.FromMatchingInterface,
                overwriteExistingMappings: false);

            container.RegisterTypes(
                AllClasses.FromLoadedAssemblies().Where(t => t.Namespace != null && t.Namespace.StartsWith("JBrick.Dal.EF")),
                WithMappings.FromMatchingInterface,
                overwriteExistingMappings: false);
2. Set the JBrick.Client.Web.EquipmentGuide project as the startup
3. Run the App
