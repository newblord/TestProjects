using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;
using JBrick.Contracts.Logging;

namespace JBrick.Client.Web.Core.Attributes
{
	public class ControllerActionLogAttribute : ActionFilterAttribute
	{
		private ILogger _logger;

		public ControllerActionLogAttribute(ILogger logger)
		{
			if (logger == null)
			{
				throw new ArgumentNullException("logger");
			}

			_logger = logger;
		}

		public override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			Log("OnActionExecuting", filterContext.RouteData);
		}

		public override void OnActionExecuted(ActionExecutedContext filterContext)
		{
			Log("OnActionExecuted", filterContext.RouteData);
		}

		public override void OnResultExecuting(ResultExecutingContext filterContext)
		{
			Log("OnResultExecuting", filterContext.RouteData);
		}

		public override void OnResultExecuted(ResultExecutedContext filterContext)
		{
			Log("OnResultExecuted", filterContext.RouteData);
		}

		private void Log(string methodName, RouteData routeData)
		{
			var controllerName = routeData.Values["controller"];
			var actionName = routeData.Values["action"];
			var message = string.Format("{0} controller: {1} action: {2}", methodName, controllerName, actionName);
			_logger.Debug(message);
		}
	}
}
