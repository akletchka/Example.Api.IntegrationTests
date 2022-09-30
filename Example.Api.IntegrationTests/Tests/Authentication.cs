using Example.Api.IntegrationTests.Services;
using FluentAssertions;
using NUnit.Framework;
using System.Net;

namespace Example.Api.IntegrationTests.Tests {
    public class Authentication : TestBase {
        [Test]
        public void Successful() {
            //Arrange
            var recipesService = new RecipesService(Client);

            //Act
            var response = recipesService.GetRecipes(TestContext.Parameters["ApiKey"], "Chili", 1);

            //Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [TestCase("bogusKey123456")]
        [TestCase(null)]
        public void Unauthorized(string key) {
            //Arrange
            var recipesService = new RecipesService(Client);

            //Act
            var response = recipesService.GetRecipes(key, "Chili", 1);

            //Assert
            response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
        }

    }
}
