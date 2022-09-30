using Example.Api.IntegrationTests.Services;
using FluentAssertions;
using NUnit.Framework;
using System.Linq;

namespace Example.Api.IntegrationTests.Tests {
    public class MenuItems : TestBase {
        [TestCase("Big Mac", 2)]
        [TestCase("Whopper", 3)]
        [TestCase("Cheeseburger", 5)]
        public void GetMenuItems(string query, int number) {
            //Arrange
            var menuItemsService = new MenuItemsService(Client);

            //Act
            var menuItemsResponse = menuItemsService.GetMenuItems(query, number);

            //Assert
            menuItemsResponse.Number.Should().Be(number);
            foreach (var item in menuItemsResponse.MenuItems) {
                TestContext.WriteLine($"Item title: {item.Title}");
                item.Title.Should().Contain(query);
            }
        }

        [Test]
        public void GetMenuItemById() {
            //Arrange
            var menuItemsService = new MenuItemsService(Client);

            //Act
            var menuItemsResponse = menuItemsService.GetMenuItems("Big Mac", 2);
            var itemId = menuItemsResponse.MenuItems.FirstOrDefault(x => x.RestaurantChain == "McDonald's").Id;
            var menuItem = menuItemsService.GetItem(itemId);

            //Assert
            menuItem.Should().NotBeNull();
            menuItem.Title.Should().Be("Big Mac");
            menuItem.RestaurantChain.Should().Be("McDonald's");
            menuItem.Nutrition.Should().NotBeNull().And.BeAssignableTo<Models.Nutrition>();
            menuItem.Nutrition.Calories.Should().Be((float)540.0);
        }

    }
}
