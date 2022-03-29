namespace LetsCook.Data.Models.RecipeModel
{
    using System.ComponentModel.DataAnnotations;

    public class Image
    {
        public int Id { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public int RecipeId { get; set; }

        public virtual Recipe Recipe { get; set; }
    }
}
