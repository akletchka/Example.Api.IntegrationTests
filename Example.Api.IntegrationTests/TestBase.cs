using NUnit.Framework;
using RestSharp;
using System;

namespace Example.Api.IntegrationTests {
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    public class TestBase {
        internal RestClient Client { get; set; }

        [SetUp]
        public void Setup() {
            Client = new RestClient(!string.IsNullOrEmpty(TestContext.Parameters["Client"]) ? TestContext.Parameters["Client"] : String.Empty);
        }

    }
}
