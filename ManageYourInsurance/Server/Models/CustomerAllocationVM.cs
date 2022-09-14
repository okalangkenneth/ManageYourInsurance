namespace ManageYourInsurance.Server.Models
{
    public class CustomerAllocationVM : CustomerListVM
    {

        public List<PolicyAllocationVM> PolicyAllocations { get; set; }
    }
}
