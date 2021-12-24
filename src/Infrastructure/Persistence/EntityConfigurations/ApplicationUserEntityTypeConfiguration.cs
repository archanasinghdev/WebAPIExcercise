using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations
{
    class ApplicationUserEntityTypeConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.ToTable("ApplicationUser");
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(u => u.Email)
               .IsRequired()
               .HasMaxLength(150);

            builder.Property(u => u.Address)
               .IsRequired()
               .HasMaxLength(250);

            builder.HasData
           (
               new ApplicationUser
               {
                   Id = 1,
                   Name = "John",
                   Email = "john_doe@gmail.com",
                   Age = 35,
                   Address = "Xyz"
               },
                new ApplicationUser
                {
                    Id = 2,
                    Name = "Patrick",
                    Email = "john_doe@gmail.com",
                    Age = 40,
                    Address = "Xyz"
                });
        }
    }
}
