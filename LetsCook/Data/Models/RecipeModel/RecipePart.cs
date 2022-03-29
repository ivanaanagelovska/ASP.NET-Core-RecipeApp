namespace LetsCook.Data.Models.RecipeModel
{
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;
    public class RecipePart
    {
        public int Id { get; set; }

        [MaxLength(RecipePartNameMaxLenght)]
        public string Name { get; set; }

        public virtual ICollection<InstructionStep> Instructions { get; set; } = new HashSet<InstructionStep>();

        public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new HashSet<RecipeIngredient>();

        public int RecipeId { get; set; }

        public virtual Recipe Recipe { get; set; }
    }
}
