using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JBrick.Dal.EF.Tests
{
	[TestClass]
	public class EFRepositoryContextProviderTests
	{
		[TestMethod]
		public void EFRepositoryContextProvider_Create()
		{
			//Arrange

			//Act
			var efRepositoryContextProvider = new EFRepositoryContextProvider();

			//Assert    
			Assert.IsNotNull(efRepositoryContextProvider);
			Assert.IsNotNull(efRepositoryContextProvider.ActiveContexts);
			Assert.IsTrue(efRepositoryContextProvider.ActiveContexts.Count == 0);
		}
	}
}
