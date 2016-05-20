using Microsoft.Practices.Unity;
using System.Web;
using System.Web.Mvc;

namespace JBrick.Client.Web.EquipmentGuide
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters, IUnityContainer container)
		{
			JBrick.Client.Web.Core.Config.FilterConfig.RegisterGlobalFilters(filters, container);
		}
	}
}
