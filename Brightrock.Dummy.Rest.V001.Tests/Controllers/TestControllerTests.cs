using NUnit.Framework;
using Brightrock.Dummy.Rest.V001.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Testing;
using Owin;
using Microsoft.Owin;
using System.Net.Http;


namespace Brightrock.Dummy.Rest.V001.Controllers.Tests
{
	[TestFixture()]
	public class TestControllerTests
	{
		[Test()]
		public void TestControllerTest()
		{
			Assert.Fail();
		}

		[Test()]
		public void GetTest()
		{
			using (var server = TestServer.Create<Startup>())
			{
				var response = server.HttpClient.GetAsync("/test").GetAwaiter().GetResult();
				var result = response.Content.ReadAsAsync<string[]>().GetAwaiter().GetResult()[0];

				Assert.AreEqual("value1", result);
			}
		}

		[Test()]
		public void GetTest1()
		{
			using (var server = TestServer.Create<Startup>())
			{
				int id = 1;
				
				var response = server.HttpClient.GetAsync($"/test/{id}").GetAwaiter().GetResult();
				var result = response.Content.ReadAsAsync<string>().GetAwaiter().GetResult();

				Assert.AreEqual("value", result);
			}
		}

		[Test()]
		public void PostTest()
		{
			using (var server = TestServer.Create<Startup>())
			{
				HttpContent content = null;

				var response = server.HttpClient.PostAsync("/test", content).GetAwaiter().GetResult();
			}
		}

		[Test()]
		public void PutTest()
		{
			Assert.Fail();
		}

		[Test()]
		public void DeleteTest()
		{
			Assert.Fail();
		}
	}
}