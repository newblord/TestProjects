using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JBrick.Dal;

namespace JBrick.BL.Core
{
	public abstract class BusinessServiceBase
	{
		protected IUnitOfWorkFactory UnitOfWorkFactory { get; private set; }

		protected BusinessServiceBase(IUnitOfWorkFactory unitOfWorkFactory)
		{
			UnitOfWorkFactory = unitOfWorkFactory;
		}

	}
}
