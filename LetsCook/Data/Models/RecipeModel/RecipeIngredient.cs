namespace LetsCook.Data.Models.RecipeModel
{
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;

    public class RecipeIngredient
    {
        public int Id { get; set; }

        public int RecipeId { get; set; }

        public virtual Recipe Recipe { get; set; }

        public int IngredientId { get; set; }

        public virtual Ingredient Ingredient { get; set; }

        [MaxLength(IngredientUnitMaxLenght)]
        public string Unit { get; set; }

        public decimal? Amount { get; set; }

        [MaxLength(IngredientNoteMaxLenght)]
        public string Note { get; set; }

        public int RecipePartId { get; set; }

        public virtual RecipePart RecipePart { get; set; }
    }
}
