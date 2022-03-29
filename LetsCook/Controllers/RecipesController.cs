namespace LetsCook.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using LetsCook.Models.Recipes;
    using LetsCook.Data;
    using LetsCook.Data.Models.RecipeModel;
    public class RecipesController : Controller
    {
        private readonly LetsCookDbContext dbContext;

        public RecipesController(LetsCookDbContext dbContext)
        => this.dbContext = dbContext;

        public IActionResult Index() => View();

        public IActionResult Create() => View(new CreateRecipeFormModel
        {
            Categories = this.GetRecipeCategories(),
        });

        [HttpPost]
        public IActionResult Create(CreateRecipeFormModel recipe)
        {
            if (this.dbContext.Categories.Any(c => c.Id == recipe.CategoryId))
            {
                this.ModelState.AddModelError(nameof(recipe.CategoryId), "Category does not exist");
            }
            if (!ModelState.IsValid)
            {
                recipe.Categories = this.GetRecipeCategories();
                return View(recipe);
            }

            var recipeData = new Recipe
            {
                CategoryId = recipe.CategoryId,
            };

            this.dbContext.Recipes.Add(recipeData);
            this.dbContext.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        private IEnumerable<CategoryViewModel> GetRecipeCategories()
            => this.dbContext
            .Categories
            .Select(c => new CategoryViewModel
            {
                Id = c.Id,
                Name = c.Name,
            })
            .ToList();
    }
}
