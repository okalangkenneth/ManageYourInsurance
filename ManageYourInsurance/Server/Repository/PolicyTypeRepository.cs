using ManageYourInsurance.Server.Contracts;
using ManageYourInsurance.Server.Data;
using ManageYourInsurance.Shared.Domain;

namespace ManageYourInsurance.Server.Repository
{
    public class PolicyTypeRepository : GenericRepository<PolicyType>, IPolicyTypeRepository
    {
        public PolicyTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
