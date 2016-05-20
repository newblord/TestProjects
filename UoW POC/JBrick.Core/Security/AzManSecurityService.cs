using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JBrick.Contracts.Security;

namespace JBrick.Core.Security
{
	public class AzManSecurityService : ISecurityService
	{
		ConcurrentDictionary<int, string> _applicationRights = null;
		ConcurrentBag<string> _applicationRoles = null;

		public AzManSecurityService(string applicationName, string userName)
		{
			if (string.IsNullOrWhiteSpace(applicationName))
			{
				throw new ArgumentNullException("applicationName");
			}
			if (string.IsNullOrWhiteSpace(userName))
			{
				throw new ArgumentNullException("userName");
			}

			ApplicationName = applicationName;
			UserName = userName;
			_applicationRights = new System.Collections.Concurrent.ConcurrentDictionary<int,string>();
			_applicationRoles = new ConcurrentBag<string>();
		}

		/// <summary>
		/// Name of the Application that the roles are checked for
		/// </summary>
		public string ApplicationName { get; private set; }

		/// <summary>
		/// UserName of the user that the roles are checked for
		/// </summary>
		public string UserName { get; private set; }

		/// <summary>
		/// Returns a value indicating whether the current user is in the specified application role.
		/// </summary>
		/// <param name="role">Role to check</param>
		/// <returns></returns>
		public bool IsInRole(string role)
		{
			return true;
		}

		/// <summary>
		/// Returns a value indicating whether the current user is in all of the specified application roles.
		/// </summary>
		/// <param name="roles">List of roles to check</param>
		/// <returns></returns>
		public bool IsInRoles(IEnumerable<string> roles)
		{
			return true;
		}

		/// <summary>
		/// Check if the user has a specific application right
		/// </summary>
		/// <param name="securityRight">security right to check for</param>
		/// <returns>Return a boolean indicating if the user has the right</returns>
		public bool HasRight(Contracts.Security.Enums.AppSecurityRight securityRight)
		{
			return true;
		}

		/// <summary>
		/// Check if the user has list of application rights
		/// </summary>
		/// <param name="securityRight">security rights to check for</param>
		/// <returns>Return a boolean indicating if the user has the rights</returns>
		public bool HasRights(IEnumerable<Contracts.Security.Enums.AppSecurityRight> securityRight)
		{
			return true;
		}

		/// <summary>
		/// Returns a value indicating whether the current user is in the specified application role for the given business partner.
		/// </summary>
		/// <param name="role">Role to check</param>
		/// <param name="bp">The business partner that you need this role for</param>
		/// <returns></returns>
		public bool IsInRole(string role, string bp)
		{
			return true;
		}

		/// <summary>
		/// Returns a value indicating whether the current user is in all of the specified application roles for the given business partner.
		/// </summary>
		/// <param name="roles">List of roles to check</param>
		/// <param name="bp">The business partner that you need these roles for</param>
		/// <returns></returns>
		public bool IsInRoles(IEnumerable<string> roles, string bp)
		{
			return true;
		}

		/// <summary>
		/// Check if the user has a specific application right for the given business partner
		/// </summary>
		/// <param name="bp">The business partner that you need this right for</param>
		/// <returns>Return a boolean indicating if the user has the right</returns>
		public bool HasRight(Contracts.Security.Enums.AppSecurityRight securityRight, string bp)
		{
			return true;
		}

		/// <summary>
		/// Check if the user has list of application rights for the given business partner
		/// </summary>
		/// <param name="securityRight">security rights to check for</param>
		/// <param name="bp">The business partner that you need these rights for</param>
		/// <returns>Return a boolean indicating if the user has the rights</returns>
		public bool HasRights(IEnumerable<Contracts.Security.Enums.AppSecurityRight> securityRight, string bp)
		{
			return true;
		}
	}
}
