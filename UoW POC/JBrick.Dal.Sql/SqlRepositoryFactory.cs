using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JBrick.Contracts.Logging;

namespace JBrick.Dal.Sql
{
	public class SqlRepositoryFactory : IRepositoryFactory
	{
		public T GetRepositoryInstance<T,C>(IRepositoryContextProvider<C> repositoryContextProvider, ILogger logger)
		{
            //TODO: Add IIOC to constructor to get these instances from the global IOC Container
            return (T)Activator.CreateInstance(typeof(T), repositoryContextProvider, logger);
		}
	}
}
