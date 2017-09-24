using AboutNetCore.Version1_0.DefaultTemplate.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AboutNetCore.Version1_0.DefaultTemplate.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Test> Tests { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<Test>()
                .HasKey(k => k.Id);

            builder.Entity<Test>()
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

        }
    }
}
