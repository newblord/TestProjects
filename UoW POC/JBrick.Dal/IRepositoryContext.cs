using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBrick.Dal
{
	public interface IRepositoryContext<T>
	{
		T RepositoryContext { get; }
	}
}
