﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VideoRent.Models;

namespace VideoRent.Dto
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewLetter { get; set; }

        public byte MembershipTypeId { get; set; }

        [Min18YearIfAMember]
        public DateTime? BirthDate { get; set; }
    }
}