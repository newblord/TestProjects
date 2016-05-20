using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JBrick.Client.Web.Core.Attributes;
using JBrick.Client.Web.Core.Controllers;

namespace JBrick.Client.Web.EquipmentGuide.Controllers
{
	public class HomeController : ECIControllerBase
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();

		}
	}
}