using Domain;
using Microsoft.EntityFrameworkCore;
using Persistence.EntityConfigurations;

namespace Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ApplicationUser> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string connectionString = @"Data Source = ARCHANA_PC\SQLEXPRESS; Initial Catalog = WebAPIExcercise.UserDb; Integrated Security = true; Connect Timeout=30";
            options.UseSqlServer(connectionString);
            base.OnConfiguring(options);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ApplicationUserEntityTypeConfiguration());
        }
    }
}


