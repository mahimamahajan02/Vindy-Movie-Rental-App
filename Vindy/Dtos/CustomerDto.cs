using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Vindy.Models;

namespace Vindy.Dtos
{
    public class CustomerDto
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "pls type name")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewLetter { get; set; }


       
        public byte MembershipTypeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

        [Display(Name = "Date of Birth")]
       // [Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }

    }
}