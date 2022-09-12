using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageYourInsurance.Shared.Domain
{
    public class PolicyRequest : BaseDomainModel
    {

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [ForeignKey("PolicyTypeId")]
        public PolicyType PolicyType { get; set; }
        public int PolicyTypeId { get; set; }

        public DateTime DateRequested { get; set; }

        public string RequestComments { get; set; }

        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }

        public string RequestingCustomerId { get; set; }
    }
}
