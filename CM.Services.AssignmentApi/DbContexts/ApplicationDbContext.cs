using CM.Services.AssignmentApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CM.Services.AssignmentApi.DbContexts
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Assignment_Category>()
                .HasOne(c => c.Assignment)
                .WithMany(cb=>cb.Assignment_Category)
                .HasForeignKey(ci => ci.AssignmentId);
            modelBuilder.Entity<Assignment_Category>()
                .HasOne(c => c.Category)
                .WithMany(cb => cb.Assignment_Category)
                .HasForeignKey(ci => ci.CategoryId);

            modelBuilder.Entity<Assignment_Length>()
              .HasOne(c => c.Assignment)
              .WithMany(cb => cb.Assignment_Length)
              .HasForeignKey(ci => ci.AssignmentId);
            modelBuilder.Entity<Assignment_Length>()
                .HasOne(c => c.Length)
                .WithMany(cb => cb.Assignment_Length)
                .HasForeignKey(ci => ci.LengthId);

            modelBuilder.Entity<Assignment_Type>()
            .HasOne(c => c.Assignment)
            .WithMany(cb => cb.Assignment_Type)
            .HasForeignKey(ci => ci.AssignmentId);
            modelBuilder.Entity<Assignment_Type>()
                .HasOne(c => c.AssignmentType)
                .WithMany(cb => cb.Assignment_Type)
                .HasForeignKey(ci => ci.TypeId);

        }
        public DbSet<Assignment> Assignments { get ; set ; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Assignment_Category> Assignment_Categories { get; set; }
        public DbSet<Assignment_Length> Assignment_Lengths { get; set; }
        public DbSet<Length> Lengths { get; set; }
        public DbSet<Assignment_Type> Assignment_Types { get; set; }
        public DbSet<AssignmentType> AssignmentTypes { get; set; }
        public DbSet<Specification> Specifications { get; set; }

    }
}
