using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JBrick.Contracts.Logging;

namespace JBrick.Dal
{
	public interface IRepositoryFactory
	{
		T GetRepositoryInstance<T, C>(IRepositoryContextProvider<C> repositoryContextProvider, ILogger logger);
	}
}
