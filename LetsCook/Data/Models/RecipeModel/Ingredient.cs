namespace LetsCook.Data.Models.RecipeModel
{
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;

    public class Ingredient
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(IngredientNameMaxLenght)]
        public string Name { get; set; }

        public virtual ICollection<RecipeIngredient> Recipes { get; set; } = new HashSet<RecipeIngredient>();

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
