using JohnAssistantFSD.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace JohnAssistantFSD.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<JohnAssistantFSDUser>
    {
        public void Configure(EntityTypeBuilder<JohnAssistantFSDUser> builder)
        {
            var hasher = new PasswordHasher<JohnAssistantFSDUser>();
            builder.HasData(
            new JohnAssistantFSDUser
            {
                Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                FirstName = "Admin",
                LastName = "User",
                UserName = "admin@localhost.com",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            },
            new JohnAssistantFSDUser
            {
                Id = "9ebd2118-39da-4440-a42e-0b574bf2da25",
                Email = "adamtan@localhost.com",
                NormalizedEmail = "ADAMTAN@LOCALHOST.COM",
                FirstName = "Adam",
                LastName = "Tan",
                UserName = "adamtan@localhost.com",
                NormalizedUserName = "ADAMTAN@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            },
            new JohnAssistantFSDUser
            {
                Id = "44dc068a-13ca-4b8e-b776-72e2bcd06509",
                Email = "johntan@localhost.com",
                NormalizedEmail = "JOHN@LOCALHOST.COM",
                FirstName = "John",
                LastName = "Tan",
                UserName = "johntan@localhost.com",
                NormalizedUserName = "JOHN@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            },
            new JohnAssistantFSDUser
            {
                Id = "e42c14c2-c24e-46e5-bbf7-12f4feb65ae6",
                Email = "pl@localhost.com",
                NormalizedEmail = "PL@LOCALHOST.COM",
                FirstName = "p",
                LastName = "l",
                UserName = "adamtan@localhost.com",
                NormalizedUserName = "PL@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            },
            new JohnAssistantFSDUser
            {
                Id = "66211897-8c20-473c-98cc-1172351a5176",
                Email = "aj@localhost.com",
                NormalizedEmail = "AJ@LOCALHOST.COM",
                FirstName = "A",
                LastName = "J",
                UserName = "aj@localhost.com",
                NormalizedUserName = "AJ@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            },
            new JohnAssistantFSDUser
            {
                Id = "fb318f66-6952-43f0-be25-d7b8fbf1e42f",
                Email = "pt@localhost.com",
                NormalizedEmail = "PT@LOCALHOST.COM",
                FirstName = "P",
                LastName = "T",
                UserName = "pt@localhost.com",
                NormalizedUserName = "PT@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            }
            );
        }
    }
}