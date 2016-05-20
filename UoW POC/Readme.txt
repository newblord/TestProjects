This demo uses either in In-Memory SQL Repository or an In-Memory Entity Framework Repository.
Steps to run the app:
1. Configure either the SQL or EF Repository
	In file Jbrick.Client.Web.Core.Config.UnityConfig.cs, Uncomment one of the two below IOC configuration blocks
	    //container.RegisterType<IUnitOfWorkFactory, SqlUnitOfWorkFactory>();
            //container.RegisterType<IRepositoryFactory, SqlRepositoryFactory>();
            //container.RegisterType<IRepositoryContextProvider<IDbConnection>, SqlRepositoryContextProvider>();
            container.RegisterType<IUnitOfWorkFactory, EFUnitOfWorkFactory>();
            container.RegisterType<IRepositoryFactory, EFRepositoryFactory>();
            container.RegisterType<IRepositoryContextProvider<DbContext>, EFRepositoryContextProvider>(new ContainerControlledLifetimeManager());
2. Set the JBrick.Client.Web.EquipmentGuide project as the startup
3. Run the App
