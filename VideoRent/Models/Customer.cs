﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoRent.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewLetter { get; set; }

        [Display(Name = "Membership Type")]
        public MembershipType MembershipType { get; set; }
        [Required]
        public byte MembershipTypeId { get; set; }
        [Min18YearIfAMember]
        [Display(Name = "Date of Birth")]
        public DateTime? BirthDate { get; set; }


    }
}
