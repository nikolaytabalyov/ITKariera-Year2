using Microsoft.EntityFrameworkCore;
using RecipeCatalog.Models;

public class RecipeContext : DbContext {
    public RecipeContext(DbContextOptions<RecipeContext> options) : base(options) {
    }

    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<Category> Categories { get; set; }
    // Добавете и други DbSet свойства, ако е необходимо
}