using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using JohnAssistantFSD.Data;
using JohnAssistantFSD.Domain;
using JohnAssistantFSD.Configurations.Entities;

namespace JohnAssistantFSD.Data
{
    public class JohnAssistantFSDContext(DbContextOptions<JohnAssistantFSDContext> options) : IdentityDbContext<JohnAssistantFSDUser>(options)
    {
        public DbSet<JohnAssistantFSD.Domain.ShoppingList> ShoppingList { get; set; } = default!;
        public DbSet<JohnAssistantFSD.Domain.ToDoList> ToDoList { get; set; } = default!;
        public DbSet<JohnAssistantFSD.Domain.Events> Events { get; set; } = default!;
        public DbSet<JohnAssistantFSD.Domain.EventGroup> EventGroup { get; set; } = default!;
        public DbSet<JohnAssistantFSD.Domain.Household> Household { get; set; } = default!;
        public DbSet<JohnAssistantFSD.Domain.HouseholdGroup> HouseholdGroup { get; set; } = default!;
        public DbSet<JohnAssistantFSD.Domain.SListGroup> SListGroup { get; set; } = default!;
        public DbSet<JohnAssistantFSD.Domain.TDListGroup> TDListGroup { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new HouseholdSeed());
            builder.ApplyConfiguration(new HouseholdGroupSeed());
        }
    }
}
