using ManageYourInsurance.Server.Contracts;
using ManageYourInsurance.Server.Data;
using ManageYourInsurance.Shared.Domain;

namespace ManageYourInsurance.Server.Repository
{
    public class PolicyRequestRepository : GenericRepository<PolicyRequest>, IPolicyRequestRepository
    {
        public PolicyRequestRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
