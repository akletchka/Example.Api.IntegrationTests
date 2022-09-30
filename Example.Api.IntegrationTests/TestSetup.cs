using NUnit.Framework;
using System;

namespace Example.Api.IntegrationTests {
    [SetUpFixture]
    public class TestSetup {
        public static string ApiKey { get; set; }

        [OneTimeSetUp]
        public static void FirstThingFirst() {
            if (string.IsNullOrEmpty(TestContext.Parameters["TargetEnvironment"]))
                throw new Exception("Select a runsettings file or define the target environment");

            if (string.IsNullOrEmpty(TestContext.Parameters["ApiKey"]))
                throw new Exception("Define your Spoonacular api key in runsettings");
        }
    }
}