using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using NSubstitute;

namespace JBrick.Dal.EF.Tests
{
	[TestClass]
	public class EFRepositoryContextTests
	{
		[TestMethod]
		public void EFRepositoryContext_CreateWithValidParameters()
		{
			//Arrange
			var dbContext = Substitute.For<DbContext>();

			//Act
			var efRepositoryContext = new EFRepositoryContext(dbContext);

			//Assert    
			Assert.AreSame(dbContext, efRepositoryContext.RepositoryContext);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void EFRepositoryContext_CreateWithNullContext()
		{
			//Arrange
			DbContext dbContext = null;

			//Act
			var efRepositoryContext = new EFRepositoryContext(dbContext);

			//Assert    
			Assert.IsTrue(false);
		}
	}
}
