namespace LetsCook.Data
{
    using LetsCook.Data.Models.RecipeModel;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class LetsCookDbContext : IdentityDbContext
    {
        public LetsCookDbContext(DbContextOptions<LetsCookDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Cuisine> Cuisines { get; set; }

        public DbSet<Difficulty> Difficulties { get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<Ingredient> Ingredients { get; set; }

        public DbSet<InstructionStep> InstructionSteps { get; set; }

        public DbSet<Note> Notes { get; set; }

        public DbSet<Recipe> Recipes { get; set; }

        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }

        public DbSet<RecipePart> RecipeParts { get; set; }

        public DbSet<RecipeTag> RecipeTags { get; set; }

        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<RecipeIngredient>()
                .Property(p => p.Amount)
                .HasColumnType("decimal(4,2)");
            //builder
            //    .Entity<Recipe>(entity =>
            //    {
            //        entity.HasOne(e => e.Category)
            //            .WithMany(e => e.Recipes)
            //            .HasForeignKey(e => e.CategoryId)
            //            .OnDelete(DeleteBehavior.Restrict);

            //        entity.HasOne(e => e.Cuisine)
            //            .WithMany(e => e.Recipes)
            //            .HasForeignKey(e => e.CuisineId)
            //            .OnDelete(DeleteBehavior.Restrict);

            //        entity.HasMany(e => e.Instructions)
            //            .WithOne(e => e.Recipe)
            //            .HasForeignKey(e => e.RecipeId)
            //            .OnDelete(DeleteBehavior.Restrict);
            //    });
        }
    }
}
