using Example.Api.IntegrationTests.Models;
using NUnit.Framework;
using RestSharp;
using System;

namespace Example.Api.IntegrationTests.Services {
    public class MenuItemsService {
        private readonly RestClient _client;
        public MenuItemsService(RestClient client) {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public MenuItemsResponse GetMenuItems(string query, int number) {
            var request = new RestRequest("food/menuItems/search", Method.Get);
            request.AddQueryParameter("apiKey", TestContext.Parameters["ApiKey"]);
            request.AddQueryParameter("query", query);
            request.AddQueryParameter("number", number);

            var response = _client.Execute<MenuItemsResponse>(request);
            return response.Data;
        }

        public MenuItem GetItem(int id) {
            var request = new RestRequest($"food/menuItems/{id}", Method.Get);
            request.AddQueryParameter("apiKey", TestContext.Parameters["ApiKey"]);

            var response = _client.Execute<MenuItem>(request);
            return response.Data;
        }
    }
}
