using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JBrick.Contracts.Logging;

namespace JBrick.Dal.EF.Tests
{
	public class RepositoryMockWithValidConstructor
	{
		public IRepositoryContextProvider<DbContext> Context { get; private set; }

		public RepositoryMockWithValidConstructor(IRepositoryContextProvider<DbContext> context, ILogger logger)
		{
			Context = context;
		}
	}
}
