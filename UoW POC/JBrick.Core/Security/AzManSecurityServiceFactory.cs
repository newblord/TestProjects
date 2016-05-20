using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JBrick.Contracts.Security;

namespace JBrick.Core.Security
{
	/// <summary>
	/// Class that creates a new roleValidator instance
	/// </summary>
	public class AzManSecurityServiceFactory : ISecurityServiceFactory
	{
		/// <summary>
		/// Gets/Creates a SecurityService object per a given application and user
		/// </summary>
		/// <param name="applicationName">Name of the application</param>
		/// <param name="userName">Name of the User</param>
		/// <returns>Instance of ISecurityService</returns>
		public ISecurityService GetSecurityService(string applicationName, string userName)
		{
			return new AzManSecurityService(applicationName, userName);
		}
	}
}

///TODO: Implement Caching of security services per user