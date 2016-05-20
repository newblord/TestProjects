using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System.Data.Entity;
using System.Collections.Generic;
using JBrick.Contracts.Logging;

namespace JBrick.Dal.EF.Tests
{
	[TestClass]
	public class EFUnitOfWorkTests
	{

		[TestMethod]
		public void EFUnitOfWork_CreateWithValidParameters()
		{
			//Arrange
			var repositoryFactory = Substitute.For<IRepositoryFactory>();
			var repositoryContextProvider = Substitute.For<IRepositoryContextProvider<DbContext>>();
			var logger = Substitute.For<ILogger>();

			//Act
			var uow = new EfUnitOfWork(repositoryFactory, repositoryContextProvider, logger);

			//Assert    
			Assert.IsNotNull(uow);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void EFUnitOfWork_CreateWithNullRepositoryFactory()
		{
			//Arrange
			IRepositoryFactory repositoryFactory = null;
			var repositoryContextProvider = Substitute.For<IRepositoryContextProvider<DbContext>>();
			var logger = Substitute.For<ILogger>();

			//Act
			var uow = new EfUnitOfWork(repositoryFactory, repositoryContextProvider, logger);

			//Assert    
			Assert.IsTrue(false);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void EFUnitOfWork_CreateWithNullLogger()
		{
			//Arrange
			var repositoryFactory = Substitute.For<IRepositoryFactory>();
			var repositoryContextProvider = Substitute.For<IRepositoryContextProvider<DbContext>>();
			ILogger logger = null;

			//Act
			var uow = new EfUnitOfWork(repositoryFactory, repositoryContextProvider, logger);

			//Assert    
			Assert.IsTrue(false);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void EFUnitOfWork_CreateWithNullRepositoryContextProvider()
		{
			//Arrange
			var repositoryFactory = Substitute.For<IRepositoryFactory>();
			IRepositoryContextProvider<DbContext> repositoryContextProvider = null;
			var logger = Substitute.For<ILogger>();

			//Act
			var uow = new EfUnitOfWork(repositoryFactory, repositoryContextProvider, logger);

			//Assert    
			Assert.IsTrue(false);
		}
		
		[TestMethod]
		public void EFUnitOfWork_GetRepository()
		{
			//Arrange
			var repositoryFactory = Substitute.For<IRepositoryFactory>();
			var repositoryContextProvider = Substitute.For<IRepositoryContextProvider<DbContext>>();
			var logger = Substitute.For<ILogger>();
			var uow = new EfUnitOfWork(repositoryFactory, repositoryContextProvider, logger);
			var repositoryMock = Substitute.For<RepositoryMockWithValidConstructor>(repositoryContextProvider, logger);

			repositoryFactory.GetRepositoryInstance<RepositoryMockWithValidConstructor, DbContext>(repositoryContextProvider, logger).Returns(repositoryMock);
			//Act
			var repository = uow.GetRepository<RepositoryMockWithValidConstructor>();

			//Assert    
			Assert.IsNotNull(repository);
			repositoryFactory.Received().GetRepositoryInstance<RepositoryMockWithValidConstructor, DbContext>(repositoryContextProvider, logger);
		}

		[TestMethod]
		public void EFUnitOfWork_Dispose()
		{
			//Arrange
			var repositoryFactory = Substitute.For<IRepositoryFactory>();
			var repositoryContextProvider = Substitute.For<IRepositoryContextProvider<DbContext>>();
			var logger = Substitute.For<ILogger>();
			var uow = new EfUnitOfWork(repositoryFactory, repositoryContextProvider, logger);
			var repositoryContextMock1 =Substitute.For<IRepositoryContext<DbContext>>();
			var dbContextMock1 = Substitute.For<DbContext>();
			repositoryContextMock1.RepositoryContext.Returns(dbContextMock1);
			var repositoryContextMock2 = Substitute.For<IRepositoryContext<DbContext>>();
			var dbContextMock2 = Substitute.For<DbContext>();
			repositoryContextMock2.RepositoryContext.Returns(dbContextMock2);
			
			var activeContexts = new Dictionary<string, IRepositoryContext<DbContext>>();
			activeContexts.Add("context1", repositoryContextMock1);
			activeContexts.Add("context2", repositoryContextMock2);

			repositoryContextProvider.ActiveContexts.Returns(activeContexts);

			//Act
			uow.Dispose();

			//Assert    
			dbContextMock1.Received().Dispose();
			dbContextMock2.Received().Dispose();
		}
	}
}
