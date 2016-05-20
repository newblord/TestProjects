using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using JBrick.Contracts.Security.Enums;

namespace JBrick.Contracts.Security
{
	/// <summary>
	/// ECI Principal interface extending the default .NET IPrincipal
	/// </summary>
	public interface IECIPrincipal : IPrincipal
	{
		bool IsInRoles(IEnumerable<string> roles);
		bool HasRight(AppSecurityRight securityRight);
		bool HasRights(IEnumerable<AppSecurityRight> securityRight);
		bool IsInRole(string role, string bp);
		bool IsInRoles(IEnumerable<string> roles, string bp);
		bool HasRight(AppSecurityRight securityRight, string bp);
		bool HasRights(IEnumerable<AppSecurityRight> securityRight, string bp);
	}
}
