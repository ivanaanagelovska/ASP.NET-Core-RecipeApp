﻿namespace LetsCook.Data.Models.RecipeModel
{
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;

    public class Recipe
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(RecipeNameMaxLenght)]
        public string Name { get; set; }

        [MaxLength(RecipeDescriptionMaxLenght)]
        public string Description { get; set; }

        public TimeSpan PreparationTime { get; set; }

        public TimeSpan? CookingTime { get; set; }

        public TimeSpan? RestTime { get; set; }

        public virtual ICollection<Image> Images { get; set; } = new HashSet<Image>();

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public int? CuisineId { get; set; }

        public virtual Cuisine Cuisine { get; set; }

        public int DifficultyId { get; set; }

        public virtual Difficulty Difficulty { get; set; }

        public ICollection<RecipeTag> Tags { get; set; }

        public virtual ICollection<RecipePart> RecipeParts { get; set; }
        
        public virtual ICollection<Note> Notes { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
