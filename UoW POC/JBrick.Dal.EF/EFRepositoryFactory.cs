using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JBrick.Contracts.Logging;
using System.Reflection;
using JBrick.Contracts.IoC;
using JBrick.Core.IoC;

namespace JBrick.Dal.EF
{
	public class EFRepositoryFactory : IRepositoryFactory
	{
        ILogger _logger;
        IIoC _ioc;

        public EFRepositoryFactory(ILogger logger, IIoC ioc)
        {
            if (logger == null)
            {
                throw new ArgumentNullException("logger");
            }
            if (ioc == null)
            {
                throw new ArgumentNullException("ioc");
            }

            _ioc = ioc;
            _logger = logger;
        }

        public T GetRepositoryInstance<T, C>(IRepositoryContextProvider<C> repositoryContextProvider, ILogger logger)
        {
            _logger.Debug("Creating repository " + typeof(T).FullName);

            return _ioc.Resolve<T>(new ParameterOverride("repositoryContextProvider", repositoryContextProvider));
        }
    }
}
