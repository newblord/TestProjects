using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System.Data.Entity;
using JBrick.Contracts.Logging;

namespace JBrick.Dal.EF.Tests
{
	[TestClass]
	public class EFUnitOfWorkFactoryTests
	{

		[TestMethod]
		public void EFUnitOfWorkFactory_CreateWithValidParameters()
		{
			//Arrange
			var repositoryFactory = Substitute.For<IRepositoryFactory>();
			var repositoryContextProvider = Substitute.For<IRepositoryContextProvider<DbContext>>();
			var logger = Substitute.For<ILogger>();

			//Act
			var uowFactory = new EfUnitOfWorkFactory(repositoryFactory, repositoryContextProvider, logger);

			//Assert    
			Assert.IsNotNull(uowFactory);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void EFUnitOfWorkFactory_CreateWithNullRepositoryFactory()
		{
			//Arrange
			IRepositoryFactory repositoryFactory = null;
			var repositoryContextProvider = Substitute.For<IRepositoryContextProvider<DbContext>>();
			var logger = Substitute.For<ILogger>();

			//Act
			var uowFactory = new EfUnitOfWorkFactory(repositoryFactory, repositoryContextProvider, logger);

			//Assert    
			Assert.IsTrue(false);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void EFUnitOfWorkFactory_CreateWithNullLogger()
		{
			//Arrange
			var repositoryFactory = Substitute.For<IRepositoryFactory>();
			var repositoryContextProvider = Substitute.For<IRepositoryContextProvider<DbContext>>();
			ILogger logger = null;

			//Act
			var uowFactory = new EfUnitOfWorkFactory(repositoryFactory, repositoryContextProvider, logger);

			//Assert    
			Assert.IsTrue(false);
		}
		
		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void EFUnitOfWorkFactory_CreateWithNullRepositoryContextProvider()
		{
			//Arrange
			var repositoryFactory = Substitute.For<IRepositoryFactory>();
			IRepositoryContextProvider<DbContext> repositoryContextProvider = null;
			var logger = Substitute.For<ILogger>();

			//Act
			var uowFactory = new EfUnitOfWorkFactory(repositoryFactory, repositoryContextProvider, logger);

			//Assert    
			Assert.IsTrue(false);
		}

		[TestMethod]
		public void EFUnitOfWorkFactory_GetUnitOfWork()
		{
			//Arrange
			var repositoryFactory = Substitute.For<IRepositoryFactory>();
			var repositoryContextProvider = Substitute.For<IRepositoryContextProvider<DbContext>>();
			var logger = Substitute.For<ILogger>();

			var uowFactory = new EfUnitOfWorkFactory(repositoryFactory, repositoryContextProvider, logger);

			//Act
			var uow = uowFactory.GetUnitOfWork();

			//Assert    
			Assert.IsNotNull(uow);
			repositoryContextProvider.Received().ClearActiveContexts();
		}
	}
}
