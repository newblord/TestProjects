using System;
using System.Collections.Generic;
using System.Data;
using System.Transactions;
using JBrick.Contracts.Logging;

namespace JBrick.Dal.Sql
{
   public class SqlUnitOfWork : IUnitOfWork
   {
      private TransactionScope _transactionScope = null;
      private IRepositoryFactory _repositoryFactory = null;
      private IRepositoryContextProvider<IDbConnection> _repositoryContextProvider = null;
      private ILogger _logger;

      public bool IsTransactional { get; private set; }

      public SqlUnitOfWork(IRepositoryFactory repositoryFactory, IRepositoryContextProvider<IDbConnection> repositoryContextProvider, ILogger logger, bool useTransaction)
          : this(repositoryFactory, repositoryContextProvider, logger, useTransaction, System.Transactions.IsolationLevel.ReadCommitted)
      {
      }

      public SqlUnitOfWork(IRepositoryFactory repositoryFactory, IRepositoryContextProvider<IDbConnection> repositoryContextProvider, ILogger logger, bool useTransaction, System.Transactions.IsolationLevel isolationLevel)
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
         IsTransactional = useTransaction;

         if (IsTransactional)
         {
            BeginTransaction(isolationLevel);
         }
      }

      public void CommitChanges()
      {
         if (_transactionScope != null)
         {
            _transactionScope.Complete();
         }
      }

      private void BeginTransaction(System.Transactions.IsolationLevel isolationLevel)
      {
         if (!IsTransactional)
         {
            throw new TransactionException("Cannot start a  transaction because transactions are not allowed in a non transaction Unit of Work");
         }

         if (_transactionScope != null)
         {
            throw new TransactionException("Cannot start a new transaction because a transaction is already active");
         }

         var transOptions = new TransactionOptions
         {
            IsolationLevel = isolationLevel,
            Timeout = TransactionManager.MaximumTimeout
         };

         _transactionScope = new TransactionScope(TransactionScopeOption.Required, transOptions);
      }

      public T GetRepository<T>()
      {
         return _repositoryFactory.GetRepositoryInstance<T, IDbConnection>(_repositoryContextProvider, _logger);
      }

      public void Dispose()
      {
         Dispose(true);
         GC.SuppressFinalize(this);
      }

      protected virtual void Dispose(bool disposing)
      {
         if (disposing)
         {
            // free managed resources
            if (_transactionScope != null)
            {
               _transactionScope.Dispose();
               _transactionScope = null;
            }

            if (_repositoryContextProvider != null && _repositoryContextProvider.ActiveContexts != null && _repositoryContextProvider.ActiveContexts.Count > 0)
            {
               foreach (var activeContext in _repositoryContextProvider.ActiveContexts)
               {
                  activeContext.Value.RepositoryContext.Dispose();
               }
            }
         }

         // free native resources if there are any.
      }
   }
}
