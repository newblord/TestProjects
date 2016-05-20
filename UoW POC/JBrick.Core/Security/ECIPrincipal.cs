using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using JBrick.Contracts.Logging;
using JBrick.Contracts.Security;

namespace JBrick.Core.Security
{
	/// <summary>
	/// Principal checking if is in role using a role provider to validate
	/// </summary>
	[Serializable]
	public class ECIPrincipal : IECIPrincipal
	{
		private ILogger _logger;
		private IIdentity _identity;
		private ISecurityService _securityService;

		public ECIPrincipal(IIdentity userIdentity, ISecurityServiceFactory securityServiceFactory, ILogger logger)
		{
			if (userIdentity == null)
			{
				throw new ArgumentNullException("userIdentity");
			}
			if (securityServiceFactory == null)
			{
				throw new ArgumentNullException("securityServiceFactory");
			}
			if (logger == null)
			{
				throw new ArgumentNullException("logger");
			}

			_logger = logger;
			_identity = userIdentity;
			_securityService = securityServiceFactory.GetSecurityService(Constants.Constants.Application.ApplicationName, userIdentity.Name);
		}

		/// <summary>
		/// The System.Security.Principal.IIdentity object associated with the current principal
		/// </summary>
		public IIdentity Identity
		{
			get { return _identity; }
		}

		/// <summary>
		/// Determines if the current principal belongs to the specified role
		/// </summary>
		/// <param name="role">Name of the role to check</param>
		/// <returns>Returns boolean indicating if user is in the role</returns>
		public bool IsInRole(string role)
		{
			if (string.IsNullOrEmpty(role))
				return false;

			return _identity != null &&
					 _identity.IsAuthenticated && 
					 _securityService != null &&
					 _securityService.IsInRole(role);
		}

		/// <summary>
		/// Determines if the current principal belongs to the specified roles
		/// </summary>
		/// <param name="roles">List of roles to check making sure user is in all of the roles</param>
		/// <returns>Returns boolean indicating if user is in the roles</returns>
		public bool IsInRoles(IEnumerable<string> roles)
		{
			if (roles == null || !roles.Any())
				return false;

			return _identity != null && 
					 _identity.IsAuthenticated &&
					 _securityService != null &&
					 _securityService.IsInRoles(roles);
		}

		/// <summary>
		/// Determines if the current principal has a specific application right
		/// </summary>
		/// <param name="securityRight"> Security Right enumeration to check for</param>
		/// <returns>Return boolean indicating if user has the application right</returns>
		public bool HasRight(Contracts.Security.Enums.AppSecurityRight securityRight)
		{
			return _identity != null && 
					 _identity.IsAuthenticated &&
					 _securityService != null &&
					 _securityService.HasRight(securityRight);
		}


		/// <summary>
		/// Determines if the current principal has a set of application right
		/// </summary>
		/// <param name="securityRights"> List of Security Right enumeration to check for</param>
		/// <returns>Return boolean indicating if user has all of the passed in application rights</returns>
		public bool HasRights(IEnumerable<Contracts.Security.Enums.AppSecurityRight> securityRights)
		{
			return _identity != null &&
					 _identity.IsAuthenticated &&
					 _securityService != null &&
					 _securityService.HasRights(securityRights);
		}

		/// <summary>
		/// Determines if the current principal belongs to the specified role for the given business partner 
		/// </summary>
		/// <param name="role">Name of the role to check</param>
		/// <param name="bp">The business partner that you need this role for</param>
		/// <returns>Returns boolean indicating if user is in the role</returns>
		public bool IsInRole(string role, string bp)
		{
			if (string.IsNullOrEmpty(role))
				return false;

			return _identity != null &&
					 _identity.IsAuthenticated &&
					 _securityService != null &&
					 _securityService.IsInRole(role, bp);
		}

		/// <summary>
		/// Determines if the current principal belongs to the specified roles for the given business partner
		/// </summary>
		/// <param name="roles">List of roles to check making sure user is in all of the roles</param>
		/// <param name="bp">The business partner that you need these roles for</param>
		/// <returns>Returns boolean indicating if user is in the roles</returns>
		public bool IsInRoles(IEnumerable<string> roles, string bp)
		{
			if (roles == null || !roles.Any())
				return false;

			return _identity != null &&
					 _identity.IsAuthenticated &&
					 _securityService != null &&
					 _securityService.IsInRoles(roles, bp);
		}

		/// <summary>
		/// Determines if the current principal has a specific application right for the given business partner
		/// </summary>
		/// <param name="securityRight"> Security Right to check for</param>
		/// <param name="bp">The business partner that you need this right for</param>
		/// <returns>Return boolean indicating if user has the application right</returns>
		public bool HasRight(Contracts.Security.Enums.AppSecurityRight securityRight, string bp)
		{
			return _identity != null &&
					 _identity.IsAuthenticated &&
					 _securityService != null &&
					 _securityService.HasRight(securityRight, bp);
		}


		/// <summary>
		/// Determines if the current principal has a set of application rights for the given business partner
		/// </summary>
		/// <param name="securityRights"> List of Security Rights to check for</param>
		/// <param name="bp">The business partner that you need these rights for</param>
		/// <returns>Return boolean indicating if user has all of the passed in application rights</returns>
		public bool HasRights(IEnumerable<Contracts.Security.Enums.AppSecurityRight> securityRights, string bp)
		{
			return _identity != null &&
					 _identity.IsAuthenticated &&
					 _securityService != null &&
					 _securityService.HasRights(securityRights, bp);
		}
	}
}
