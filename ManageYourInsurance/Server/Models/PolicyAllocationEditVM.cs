namespace ManageYourInsurance.Server.Models
{
    public class PolicyAllocationEditVM :PolicyAllocationVM
    {
        public string CustomerId { get; set; }
        public int PolicyTypeId { get; set; }
        public CustomerListVM Customer { get; set; }
    }
}
