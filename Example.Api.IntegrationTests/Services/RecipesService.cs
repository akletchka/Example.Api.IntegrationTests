using RestSharp;
using System;

namespace Example.Api.IntegrationTests.Services {
    public class RecipesService {
        private readonly RestClient _client;
        public RecipesService(RestClient client) {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public RestResponse GetRecipes(string apiKey, string query, int number) {
            var request = new RestRequest("recipes/complexSearch", Method.Get);
            if (!string.IsNullOrEmpty(apiKey))
                request.AddQueryParameter("apiKey", apiKey);
            request.AddQueryParameter("query", query);
            request.AddQueryParameter("number", number);

            return _client.Execute(request);
        }
    }
}
