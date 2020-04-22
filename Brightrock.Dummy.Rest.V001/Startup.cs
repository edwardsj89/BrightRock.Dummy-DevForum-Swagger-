using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Brightrock.Dummy.Rest.V001.Startup))]

namespace Brightrock.Dummy.Rest.V001
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			var config = WebApiConfig.Register();
			app.UseWebApi(config);
		}
	}
}
