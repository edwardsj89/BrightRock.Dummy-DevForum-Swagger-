using System;
using System.Web.Http;
using System.Web.Http.Filters;

namespace Brightrock.Dummy.Rest.V001
{
	public class WebApiConfig
	{
		public static HttpConfiguration Register()
		{
			var config = new HttpConfiguration();

			config.MapHttpAttributeRoutes();

			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "{controller}/{id}",
				defaults: new { id = RouteParameter.Optional });

			return config;
		}
	}
}