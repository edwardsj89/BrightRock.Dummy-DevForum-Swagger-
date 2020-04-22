using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Brightrock.Dummy.Rest.V002.Startup))]

namespace Brightrock.Dummy.Rest.V002
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			var config = new HttpConfiguration();

			SwaggerConfig.Register(config);
			WebApiConfig.Register(config);

			app.UseWebApi(config);
		}
	}
}
