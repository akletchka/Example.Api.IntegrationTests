#nullable enable

namespace Example.Api.IntegrationTests.Models {
    public class Nutrient {
        public string? Name { get; set; }
        public float? Amount { get; set; }
        public string? Unit { get; set; }
        public float? PercentOfDailyNeeds { get; set; }
    }
}
