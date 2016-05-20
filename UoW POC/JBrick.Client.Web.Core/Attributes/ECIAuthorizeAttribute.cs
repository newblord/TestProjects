using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Web.Mvc;
using JBrick.Contracts.Logging;
using JBrick.Contracts.Security;
using JBrick.Core.Security;

namespace JBrick.Client.Web.Core.Attributes
{
	public class ECIAuthorizeAttribute : AuthorizeAttribute
	{

		[Dependency]
		public ISecurityServiceFactory SecurityServiceFactory { get; set; }
		[Dependency]
		public ILogger Logger { get; set; }

		/// <summary>
		/// Should be called by IoC container which will inject dependent properties
		/// </summary>
		public ECIAuthorizeAttribute()
		{
		}

		/// <summary>
		/// Can be called to inject specific dependencies 
		/// </summary>
		public ECIAuthorizeAttribute(ISecurityServiceFactory securityServiceFactory, ILogger logger)
		{
			if (securityServiceFactory == null)
			{
				throw new ArgumentNullException("securityServiceFactory");
			}
			if (logger == null)
			{
				throw new ArgumentNullException("logger");
			}

			SecurityServiceFactory = securityServiceFactory;
			Logger = logger;
		}

		public override void OnAuthorization(AuthorizationContext filterContext)
		{
			if (filterContext == null)
			{
				throw new ArgumentNullException("filterContext");
			}
			if (filterContext.HttpContext == null)
			{
				throw new NullReferenceException("HttpContext is null");
			}

			if (!(filterContext.HttpContext.User is ECIPrincipal))
			{
				var eciPrincipal = new ECIPrincipal(filterContext.HttpContext.User.Identity, SecurityServiceFactory, Logger);

				filterContext.HttpContext.User = eciPrincipal;
				Thread.CurrentPrincipal = eciPrincipal;
			}

			base.OnAuthorization(filterContext);
		}
	}
}
