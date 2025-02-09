using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace JohnAssistantFSD.Configurations.Entities
{
    public class UserRoleSeed : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
            new IdentityUserRole<string>
            {
                RoleId = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                UserId = "3781efa7-66dc-47f0-860f-e506d04102e4"
            },
            new IdentityUserRole<string>
            {
                RoleId = "dc46b121-84af-43a2-ab9b-b4387466ff60",
                UserId = "9ebd2118-39da-4440-a42e-0b574bf2da25"
            },
            new IdentityUserRole<string>
            {
                RoleId = "dc46b121-84af-43a2-ab9b-b4387466ff60",
                UserId = "44dc068a-13ca-4b8e-b776-72e2bcd06509"
            },
            new IdentityUserRole<string>
            {
                RoleId = "43688613-3972-4b3c-a932-d528efe25e08",
                UserId = "e42c14c2-c24e-46e5-bbf7-12f4feb65ae6"
            },
            new IdentityUserRole<string>
            {
                RoleId = "43688613-3972-4b3c-a932-d528efe25e08",
                UserId = "66211897-8c20-473c-98cc-1172351a5176"
            },
            new IdentityUserRole<string>
            {
                RoleId = "43688613-3972-4b3c-a932-d528efe25e08",
                UserId = "fb318f66-6952-43f0-be25-d7b8fbf1e42f"
            }
            );
        }
    }
}