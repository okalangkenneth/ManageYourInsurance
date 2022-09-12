using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageYourInsurance.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string TaxId { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNumber { get; set; }
    }
}
