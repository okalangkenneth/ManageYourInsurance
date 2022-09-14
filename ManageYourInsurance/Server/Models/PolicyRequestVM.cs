using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ManageYourInsurance.Server.Models
{
    public class PolicyRequestVM
    {
        public int Id { get; set; }

        [Display(Name = "Date Requested")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime DateRequested { get; set; }

        [Display(Name = "Policy Type")]
        public PolicyTypeVM PolicyType { get; set; }

        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }

        public string RequestingCustomerId { get; set; }

        public CustomerListVM Customer { get; set; }
        
    }
}
