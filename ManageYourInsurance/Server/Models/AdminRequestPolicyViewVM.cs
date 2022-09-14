using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ManageYourInsurance.Server.Models
{
    public class AdminRequestPolicyViewVM
    {
        [Display(Name = "Total Number of Requests")]
        public int TotalRequests { get; set; }

        [Display(Name = "Approved Requests")]
        public int ApprovedRequests { get; set; }

        [Display(Name = "Pending Requests")]
        public int PendingRequests { get; set; }

        [Display(Name = "Rejected Requests")]
        public int RejectedRequests { get; set; }

        public List<PolicyRequestVM> PolicyRequests { get; set; }
    }
}
