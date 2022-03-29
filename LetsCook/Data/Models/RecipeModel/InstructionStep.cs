namespace LetsCook.Data.Models.RecipeModel
{
    using System.ComponentModel.DataAnnotations;

    public class InstructionStep
    {
        public int Id { get; set; }

        public int StepNumber { get; set; }

        [Required]
        public string Description { get; set; }

        public int RecipePartId { get; set; }

        public virtual RecipePart RecipePart { get; set; }
    }
}
