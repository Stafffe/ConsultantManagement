using CM.Services.AssignmentProcessApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CM.Services.AssignmentProcessApi.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<AssignmentProcess> Assignments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<AssignmentProcess>().HasData(new AssignmentProcess
            {
                AssignmentProcessId = Guid.NewGuid(),
                Title = "BackEnd",
                Action = "",
                Description = "DEscription come here",
                ImageUrl = "https://dotnetmastery.blob.core.windows.net/mango/14.jpg",
                Brocker = "Nikita",
                Customer = "Volvo",
                Consultant = "NV",
                Status = "Submitted",
                StartDate = DateTime.Now.AddMonths(3)
            });
        }
    }
}
