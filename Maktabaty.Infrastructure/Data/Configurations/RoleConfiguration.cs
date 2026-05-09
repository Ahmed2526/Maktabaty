using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Maktabaty.Infrastructure.Data.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "8D0D35E0-2C8B-4B7F-9F0B-0D13B930D701",
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    ConcurrencyStamp = "8c6e7308-2a0c-4bb2-9a5e-7a0c0e07ce7e"
                },
                new IdentityRole
                {
                    Id = "47E6F49D-3B9D-4B8F-9A7D-2F96D6E2C3B4",
                    Name = "User",
                    NormalizedName = "USER",
                    ConcurrencyStamp = "a8d9c5aa-2c5e-4a8f-9c59-2d0d4f2b5e9f"
                }
            );
        }
    }
}
