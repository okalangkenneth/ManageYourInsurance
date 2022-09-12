using Duende.IdentityServer.EntityFramework.Options;
using ManageYourInsurance.Server.Configurations.Entities;
using ManageYourInsurance.Server.Models;
using ManageYourInsurance.Shared.Domain;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ManageYourInsurance.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<PolicyType> PolicyTypes { get; set; }
        public DbSet<PolicyAllocation> PolicyAllocations { get; set; }
        public DbSet<PolicyRequest> PolicyRequests { get; set; }
    }

    
}