using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBrick.Dal
{
	public interface IRepositoryContextProvider<T>
	{
		IRepositoryContext<T> GetRepositoryContext(string repositoryName);
		IDictionary<string, IRepositoryContext<T>> ActiveContexts { get; }
		void ClearActiveContexts();
	}
}
