using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.Unity;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using JBrick.Contracts.Logging;
using JBrick.Client.Web.Core.Attributes;

namespace JBrick.Client.Web.Core.Controllers
{
	public abstract class ECIControllerBase : Controller
	{
		[Dependency]
		public ILogger Logger { get; set; }

	}
}
