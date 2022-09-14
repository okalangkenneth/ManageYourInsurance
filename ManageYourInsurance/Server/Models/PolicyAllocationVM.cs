using Duende.IdentityServer.Models;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ManageYourInsurance.Server.Models
{
    public class PolicyAllocationVM
    {
        [Required]
        public int Id { get; set; }
       
        public PolicyTypeVM PolicyType { get; set; }
    }
}
