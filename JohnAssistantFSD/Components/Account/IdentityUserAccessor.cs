using JohnAssistantFSD.Data;
using Microsoft.AspNetCore.Identity;

namespace JohnAssistantFSD.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<JohnAssistantFSDUser> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<JohnAssistantFSDUser> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
