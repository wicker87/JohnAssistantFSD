using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace JohnAssistantFSD.Configurations.Entities
{
    public class RoleSeed : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
            new IdentityRole
            {
                Id = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR"
            },
            new IdentityRole
            {
                Id = "dc46b121-84af-43a2-ab9b-b4387466ff60",
                Name = "User",
                NormalizedName = "USER"
            },
            new IdentityRole
            {
                Id = "43688613-3972-4b3c-a932-d528efe25e08",
                Name = "Child",
                NormalizedName = "CHILD"
            }
            );
        }
    }
}