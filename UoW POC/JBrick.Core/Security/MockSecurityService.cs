using JBrick.Contracts.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBrick.Core.Security
{
    public class MockSecurityService : ISecurityService
    {
        public MockSecurityService(string applicationName, string userName)
        {
            ApplicationName = applicationName;
            UserName = userName;
        }

        public string ApplicationName { get; private set; }

        public string UserName { get; private set; }

        public bool IsInRole(string role)
        {
            return true;
        }

        public bool IsInRoles(IEnumerable<string> roles)
        {
            return true;
        }

        public bool HasRight(Contracts.Security.Enums.AppSecurityRight securityRight)
        {
            return true;
        }

        public bool HasRights(IEnumerable<Contracts.Security.Enums.AppSecurityRight> securityRight)
        {
            return true;
        }

        public bool IsInRole(string role, string bp)
        {
            return true;
        }

        public bool IsInRoles(IEnumerable<string> roles, string bp)
        {
            return true;
        }

        public bool HasRight(Contracts.Security.Enums.AppSecurityRight securityRight, string bp)
        {
            return true;
        }

        public bool HasRights(IEnumerable<Contracts.Security.Enums.AppSecurityRight> securityRight, string bp)
        {
            return true;
        }
    }
}
