using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageYourInsurance.Shared.Domain
{
    public class PolicyAllocation : BaseDomainModel
    {

       

        [ForeignKey("PolicyTypeId")]
        public PolicyType PolicyType { get; set; }
        public int PolicyTypeId { get; set; }

        public string CustomerId { get; set; }

        
    }
}
