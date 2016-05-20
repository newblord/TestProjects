using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JBrick.Contracts.Logging;
using System.Reflection;

namespace JBrick.Dal.EF
{
	public class EFRepositoryFactory : IRepositoryFactory
	{
		public T GetRepositoryInstance<T, C>(IRepositoryContextProvider<C> repositoryContextProvider, ILogger logger)
		{
            //TODO: Add IIOC to constructor to get these instances from the global IOC Container
			return (T)Activator.CreateInstance(typeof(T), repositoryContextProvider, logger);
		}
	}
}
