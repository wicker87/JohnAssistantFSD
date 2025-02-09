using JohnAssistantFSD.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JohnAssistantFSD.Configurations.Entities
{
    public class HouseholdGroupSeed : IEntityTypeConfiguration<HouseholdGroup>
    {
        public void Configure(EntityTypeBuilder<HouseholdGroup> builder)
        {
            builder.HasData(
                new HouseholdGroup
                {
                    Id = 1,
                    HouseholdId = 1,
                    UserId= "44dc068a-13ca-4b8e-b776-72e2bcd06509",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new HouseholdGroup
                {
                    Id = 2,
                    HouseholdId = 1,
                    UserId = "e42c14c2-c24e-46e5-bbf7-12f4feb65ae6",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new HouseholdGroup
                {
                    Id = 3,
                    HouseholdId = 2,
                    UserId = "9ebd2118-39da-4440-a42e-0b574bf2da25",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new HouseholdGroup
                {
                    Id = 4,
                    HouseholdId = 2,
                    UserId = "fb318f66-6952-43f0-be25-d7b8fbf1e42f",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new HouseholdGroup
                {
                    Id = 5,
                    HouseholdId = 3,
                    UserId = "44dc068a-13ca-4b8e-b776-72e2bcd06509",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new HouseholdGroup
                {
                    Id = 6,
                    HouseholdId = 3,
                    UserId = "66211897-8c20-473c-98cc-1172351a5176",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }


            );
        }
    }
}
