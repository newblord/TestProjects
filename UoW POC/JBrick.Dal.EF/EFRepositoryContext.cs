using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBrick.Dal.EF
{
	public class EFRepositoryContext : IRepositoryContext<DbContext>
	{
		public EFRepositoryContext(DbContext dbContext)
		{
			if (dbContext == null)
			{
				throw new ArgumentNullException("dbContext");
			}

			RepositoryContext = dbContext;
		}

		public DbContext RepositoryContext { get; private set; }
	}
}
