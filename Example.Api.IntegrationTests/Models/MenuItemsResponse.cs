#nullable enable
namespace Example.Api.IntegrationTests.Models {
    public class MenuItemsResponse {
        public string? Type { get; set; }
        public MenuItem[]? MenuItems { get; set; }
        public int? Offset { get; set; }
        public int? Number { get; set; }
        public int? TotalMenuItems { get; set; }
        public int? ProcessingTimeMs { get; set; }
        public long? Expires { get; set; }
        public bool? IsStale { get; set; }
    }
}
