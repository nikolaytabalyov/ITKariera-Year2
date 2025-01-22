namespace RecipeCatalog.Models {
    public class Recipe {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PreparationTime { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}