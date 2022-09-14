﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ManageYourInsurance.Server.Models
{
    public class CustomerListVM
    {
        public string Id { get; set; }


        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [Display(Name = "Date Joined")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime DateJoined { get; set; }


        [Display(Name = "Email Address")]
        public string Email { get; set; }

    }
}
