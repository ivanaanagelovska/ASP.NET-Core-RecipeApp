namespace LetsCook.Data.Models.RecipeModel
{
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;
    public class Tag
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(TagNameMaxLenght)]
        public string Name { get; set; }

        public virtual ICollection<RecipeTag> Recipes { get; set; } = new HashSet<RecipeTag>();

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
