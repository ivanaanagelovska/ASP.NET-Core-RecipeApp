namespace LetsCook.Data.Models.RecipeModel
{
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;
    public class Note
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(RecipeNoteMaxLenght)]
        public string Text { get; set; }

        public int RecipeId { get; set; }

        public virtual Recipe Recipe { get; set; }
    }
}
