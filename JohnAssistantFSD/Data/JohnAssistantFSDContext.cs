using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using JohnAssistantFSD.Data;

namespace JohnAssistantFSD.Data
{
    public class JohnAssistantFSDContext(DbContextOptions<JohnAssistantFSDContext> options) : IdentityDbContext<JohnAssistantFSDUser>(options)
    {
    }
}
