using System;
using System.Data;
using JBrick.Contracts.Logging;

namespace JBrick.Dal.Sql
{
    public class SqlUnitOfWorkFactory: IUnitOfWorkFactory
	{
		IRepositoryFactory _repositoryFactory;
		IRepositoryContextProvider<IDbConnection> _repositoryContextProvider;
		ILogger _logger;

		public SqlUnitOfWorkFactory(IRepositoryFactory repositoryFactory, IRepositoryContextProvider<IDbConnection> repositoryContextProvider, ILogger logger)
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
			return new SqlUnitOfWork(_repositoryFactory, _repositoryContextProvider, _logger, true, isolationLevel);
		}

        public IUnitOfWork GetUnitOfWorkWithoutTransaction()
        {
            _repositoryContextProvider.ClearActiveContexts();
            return new SqlUnitOfWork(_repositoryFactory, _repositoryContextProvider, _logger, false);
        }
    }
}
