﻿using NUnit.Framework;

namespace PivotSecurity.Tests
{
    public class RestClientTests
    {
        private const string BASE_URL = "http://localhost:8888/";

        [Test]
        [TestCase(Method.GET, Method.POST)]
        [TestCase(Method.POST, Method.GET)]
        [TestCase(Method.DELETE, Method.GET)]
        [TestCase(Method.HEAD, Method.POST)]
        [TestCase(Method.PUT, Method.PATCH)]
        [TestCase(Method.PATCH, Method.PUT)]
        [TestCase(Method.POST, Method.PUT)]
        [TestCase(Method.GET, Method.DELETE)]
        public void Execute_with_IRestRequest_and_Method_overrides_previous_request_method(Method reqMethod, Method overrideMethod)
        {
            var req = new RestRequest(reqMethod);
            var client = new RestClient(BASE_URL);

            client.Execute(req, overrideMethod);

            Assert.AreEqual(req.Method, overrideMethod);
        }

        [Test]
        public void ConfigureHttp_will_set_proxy_to_null_with_no_exceptions_When_no_proxy_can_be_found()
        {
            var req = new RestRequest();
            var client = new RestClient(BASE_URL) {Proxy = null};

            Assert.DoesNotThrow(() => client.Execute(req));
            Assert.IsNull(client.Proxy);
        }        
    }
}
