using JBrick.Contracts.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBrick.Core.Security
{
    /// <summary>
    /// Class that creates a new roleValidator instance
    /// </summary>
    public class MockSecurityServiceFactory : ISecurityServiceFactory
    {
        /// <summary>
        /// Gets/Creates a SecurityService object per a given application and user
        /// </summary>
        /// <returns>Instance of ISecurityService</returns>
        public ISecurityService GetSecurityService(string applicationName, string userName)
        {
            return new MockSecurityService(applicationName, userName);
        }
    }
}
