namespace LetsCook.Models.Recipes
{
    using System.ComponentModel.DataAnnotations;

    using static Data.DataConstants;

    public class CreateRecipeFormModel
    {
        [Required(ErrorMessage = "This is a required field")]
        [StringLength(RecipeNameMaxLenght, MinimumLength = RecipeNameMinLenght, ErrorMessage ="Titile should be {2} min")]
        [Display(Name = "Title (keep it short and descriptive)")]
        public string Name { get; init; }

        [MaxLength(RecipeDescriptionMaxLenght)]
        [MinLength(RecipeDescriptionMinLenght)]
        [Display(Name = "Short Intro (20-30 words)")]
        public string Description { get; init; }

        [Required]
        [Display(Name="Image url")]
        [Url]
        public string ImageUrl { get; set; }

        [Display(Name = "Prep Time")]
        public int PreparationTime { get; init; }

        [Display(Name = "Cook Time")]
        public int? CookingTime { get; init; }

        [Display(Name = "Rest Time (Optional)")]
        public int? RestTime { get; init; }

        [Display(Name = "Category")]
        public int CategoryId { get; init; }

        public IEnumerable<CategoryViewModel> Categories { get; set; }

        //public int? CuisineId { get; set; }

        //public Cuisine Cuisine { get; set; }

        //public Difficulty Difficulty { get; set; }

        //public DietTag DietTag { get; set; }

        //public virtual ICollection<RecipeIngredient> Ingredients { get; set; } = new HashSet<RecipeIngredient>();

        //// TODO: Add instructions group name
        //[Required]
        //public ICollection<Instruction> Instructions { get; set; } = new HashSet<Instruction>();
    }
}
