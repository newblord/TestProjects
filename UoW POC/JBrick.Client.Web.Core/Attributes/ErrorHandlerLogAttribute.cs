using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using JBrick.Contracts.Logging;

namespace JBrick.Client.Web.Core.Attributes
{
	public class ErrorHandlerLogAttribute : HandleErrorAttribute
	{
		private ILogger _logger;

		public ErrorHandlerLogAttribute(ILogger logger)
		{
			if (logger == null)
			{
				throw new ArgumentNullException("logger");
			}

			_logger = logger;
		}

		public override void OnException(ExceptionContext context)
		{
			if (context != null && !context.ExceptionHandled)
				LogException(context.Exception, context);

			base.OnException(context);
		}

		private void LogException(Exception ex, ExceptionContext context)
		{
			_logger.Error(ex);
		}
	}
}
