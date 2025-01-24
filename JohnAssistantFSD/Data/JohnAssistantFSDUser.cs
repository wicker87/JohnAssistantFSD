using Microsoft.AspNetCore.Identity;

namespace JohnAssistantFSD.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class JohnAssistantFSDUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

    }
}
