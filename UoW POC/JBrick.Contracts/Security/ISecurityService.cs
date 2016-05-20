using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JBrick.Contracts.Security.Enums;

namespace JBrick.Contracts.Security
{
	public interface ISecurityService
	{
		/// <summary>
		/// Name of the Application that the rights are checked for
		/// </summary>
		string ApplicationName { get; }

		/// <summary>
		/// UserName of the user that the rights are checked for
		/// </summary>
		string UserName { get; }

		/// <summary>
		/// Returns a value indicating whether the current user is in the specified application role.
		/// </summary>
		/// <param name="role">Role to check</param>
		/// <returns></returns>
		bool IsInRole(string role);

		/// <summary>
		/// Returns a value indicating whether the current user is in all of the specified application roles.
		/// </summary>
		/// <param name="roles">List of roles to check</param>
		/// <returns></returns>
		bool IsInRoles(IEnumerable<string> roles);

		/// <summary>
		/// Check if the user has a specific application right
		/// </summary>
		/// <param name="securityRight">security right to check for</param>
		/// <returns>Return a boolean indicating if the user has the right</returns>
		bool HasRight(AppSecurityRight securityRight);

		/// <summary>
		/// Check if the user has list of application rights
		/// </summary>
		/// <param name="securityRight">security rights to check for</param>
		/// <returns>Return a boolean indicating if the user has the rights</returns>
		bool HasRights(IEnumerable<AppSecurityRight> securityRight);

		/// <summary>
		/// Returns a value indicating whether the current user is in the specified application role for the given business partner.
		/// </summary>
		/// <param name="role">Role to check</param>
		/// <param name="bp">The business partner that you need this role for</param>
		/// <returns></returns>
		bool IsInRole(string role, string bp);

		/// <summary>
		/// Returns a value indicating whether the current user is in all of the specified application roles for the given business partner.
		/// </summary>
		/// <param name="roles">List of roles to check</param>
		/// <param name="bp">The business partner that you need these roles for</param>
		/// <returns></returns>
		bool IsInRoles(IEnumerable<string> roles, string bp);

		/// <summary>
		/// Check if the user has a specific application right for the given business partner
		/// </summary>
		/// <param name="bp">The business partner that you need this right for</param>
		/// <returns>Return a boolean indicating if the user has the right</returns>
		bool HasRight(AppSecurityRight securityRight, string bp);

		/// <summary>
		/// Check if the user has list of application rights for the given business partner
		/// </summary>
		/// <param name="securityRight">security rights to check for</param>
		/// <param name="bp">The business partner that you need these rights for</param>
		/// <returns>Return a boolean indicating if the user has the rights</returns>
		bool HasRights(IEnumerable<AppSecurityRight> securityRight, string bp);
	}
}
