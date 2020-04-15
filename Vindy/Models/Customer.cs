﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vindy.Models;
using Vindy.ViewModels;

namespace Vindy.Models
{
    public class Customer
    {

        public int Id { get; set; }

        [Required(ErrorMessage ="pls type name")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewLetter { get; set; }

        
        public MembershipType MembershipType { get; set; }
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        [Display(Name="Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }


    }
}