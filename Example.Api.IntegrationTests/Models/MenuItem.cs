#nullable enable
namespace Example.Api.IntegrationTests.Models {
    public class MenuItem {
        public int Id { get; set; }
        public string? Title { get; set; }
        public decimal? Price { get; set; }
        public float? Likes { get; set; }
        public object[]? Badges { get; set; }
        public Nutrition? Nutrition { get; set; }
        public string[]? Images { get; set; }
        public string? ServingSize { get; set; }
        public string? ReadableServingSize { get; set; }
        public int? NumberOfServings { get; set; }
        public Servings? Servings { get; set; }
        public object? SpoonacularScore { get; set; }
        public string[]? Breadcrumbs { get; set; }
        public string? Image { get; set; }
        public string? ImageType { get; set; }
        public string? GeneratedText { get; set; }
        public string? RestaurantChain { get; set; }
    }
}
