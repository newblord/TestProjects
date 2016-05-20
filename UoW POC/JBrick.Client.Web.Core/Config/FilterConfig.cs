using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using JBrick.Client.Web.Core.Attributes;

namespace JBrick.Client.Web.Core.Config
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters, IUnityContainer container)
		{
			filters.Add(container.Resolve<ECIAuthorizeAttribute>());
			filters.Add(container.Resolve<ErrorHandlerLogAttribute>());
			filters.Add(container.Resolve<ControllerActionLogAttribute>());
		}
	}
}
