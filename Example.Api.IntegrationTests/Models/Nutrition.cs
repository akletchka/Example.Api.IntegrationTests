#nullable enable

namespace Example.Api.IntegrationTests.Models {
    public class Nutrition {
        public Nutrient[]? Nutrients { get; set; }
        public Caloricbreakdown? CaloricBreakdown { get; set; }
        public float? Calories { get; set; }
        public string? Fat { get; set; }
        public string? Protein { get; set; }
        public string? Carbs { get; set; }
    }
}
