namespace ManageYourInsurance.Server.Models
{
    public class CustomerPolicyRequestViewVM
    {
        public CustomerPolicyRequestViewVM(List<PolicyAllocationVM> policyAllocations, List<PolicyRequestVM> policyRequests)
        {
            PolicyAllocations = policyAllocations;
            PolicyRequests = policyRequests;
        }

        public List<PolicyAllocationVM> PolicyAllocations { get; set; }
        public List<PolicyRequestVM> PolicyRequests { get; set; }

    }
}
