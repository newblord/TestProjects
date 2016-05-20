using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using JBrick.Contracts.Logging;
using System.Data;

namespace JBrick.Dal.EF
{
	public class EFUnitOfWorkFactory : IUnitOfWorkFactory
	{
		IRepositoryFactory _repositoryFactory;
		IRepositoryContextProvider<DbContext> _repositoryContextProvider;
		ILogger _logger;

		public EFUnitOfWorkFactory(IRepositoryFactory repositoryFactory, IRepositoryContextProvider<DbContext> repositoryContextProvider, ILogger logger)
		{
			if (repositoryFactory == null)
			{
				throw new ArgumentNullException("repositoryFactory");
			}
			if (repositoryContextProvider == null)
			{
				throw new ArgumentNullException("repositoryContextProvider");
			}
			if (logger == null)
			{
				throw new ArgumentNullException("logger");
			}

			_repositoryFactory = repositoryFactory;
			_repositoryContextProvider = repositoryContextProvider;
			_logger = logger;
		}
		public IUnitOfWork GetUnitOfWork()
		{
			return GetUnitOfWork(System.Transactions.IsolationLevel.ReadCommitted);
		}

		public IUnitOfWork GetUnitOfWork(System.Transactions.IsolationLevel isolationLevel)
		{
			_repositoryContextProvider.ClearActiveContexts();
			return new EfUnitOfWork(_repositoryFactory, _repositoryContextProvider, _logger, true, isolationLevel);
		}

        public IUnitOfWork GetUnitOfWorkWithoutTransaction()
        {
            _repositoryContextProvider.ClearActiveContexts();
            return new EfUnitOfWork(_repositoryFactory, _repositoryContextProvider, _logger, false);
        }
    }
}
