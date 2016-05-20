using System;
using System.Data;

namespace JBrick.Dal.Sql
{
	public class SqlRepositoryContext : IRepositoryContext<IDbConnection>
	{
		public SqlRepositoryContext(IDbConnection connection)
		{
			if (connection == null)
			{
				throw new ArgumentNullException("connection");
			}

			RepositoryContext = connection;
		}

		public IDbConnection RepositoryContext { get; private set; }
	}
}
