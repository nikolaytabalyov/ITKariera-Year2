using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipeCatalog.Models; // Заменете с вашето пространство от имена
using System.Threading.Tasks;

public class TestController : Controller {
    private readonly RecipeContext _context;

    public TestController(RecipeContext context) {
        _context = context;
    }

    public async Task<IActionResult> Index() {
        // Опитайте се да извлечете данни от базата данни
        var recipes = await _context.Recipes.ToListAsync();
        return View(recipes); // Можете да създадете изглед, за да покажете резултатите
    }
}