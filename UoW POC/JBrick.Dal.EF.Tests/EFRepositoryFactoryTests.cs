using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using NSubstitute;
using JBrick.Contracts.Logging;

namespace JBrick.Dal.EF.Tests
{
	[TestClass]
	public class EFRepositoryFactoryTests
	{
		[TestMethod]
		public void EFRepositoryFactory_GetRepositoryInstance_WithValidContext()
		{
			//Arrange
			var factory = new EFRepositoryFactory();
			var context = Substitute.For<IRepositoryContextProvider<DbContext>>();
			var logger = Substitute.For<ILogger>();

			//Act
			var repository = factory.GetRepositoryInstance<RepositoryMockWithValidConstructor, DbContext>(context, logger);

			//Assert    
			Assert.IsInstanceOfType(repository, typeof(RepositoryMockWithValidConstructor));
			Assert.AreSame(context, repository.Context);
		}

		[TestMethod]
		[ExpectedException(typeof(MissingMethodException))]
		public void EFRepositoryFactory_GetRepositoryInstance_WithRepositoryTypeWithInvalidContructionSignature()
		{
			//Arrange
			var factory = new EFRepositoryFactory();
			var context = Substitute.For<IRepositoryContextProvider<DbContext>>();
			var logger = Substitute.For<ILogger>();

			//Act
			var repository = factory.GetRepositoryInstance<RepositoryMockWithInvalidConstructor, DbContext>(context, logger);

			//Assert    
			Assert.IsTrue(false);
		}
	}
}
