using Duende.IdentityServer.Models;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ManageYourInsurance.Server.Models
{
    public class PolicyTypeVM
    {
        public int Id { get; set; }

        [Display(Name = "Policy Type Name")]
        [Required]
        public string Name { get; set; }

        
    }
}
