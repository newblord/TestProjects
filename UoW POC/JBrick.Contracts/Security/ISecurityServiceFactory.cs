using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBrick.Contracts.Security
{
	/// <summary>
	/// Interface defining an object that creates a new SecurityService instance
	/// </summary>
	public interface ISecurityServiceFactory
	{
		/// <summary>
		/// Gets/Creates a SecurityService object per a given application and user
		/// </summary>
		/// <param name="applicationName">Name of the application</param>
		/// <param name="userName">Name of the User</param>
		/// <returns>Instance of ISecurityService</returns>
		ISecurityService GetSecurityService(string applicationName, string userName);
	}
}
