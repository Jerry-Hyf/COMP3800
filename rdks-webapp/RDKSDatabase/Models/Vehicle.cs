using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RDKSDatabase.Models
{
    public class Vehicle_badge
    {
        [Key]
        [Display(Name = "License Plate")]
        [Required]
        [StringLength(10, MinimumLength = 6)]
        public string? LICENSE_PLATE { get; set; }

        [Required]
        [Display(Name = "Customer account number")]
        public int CUS_ID { get; set; }

        [Display(Name = "Description")]
        public string? DESCRIPTION { get; set; }

        [Display(Name = "Badge")]
        public int BADGE { get; set; }

        [Display(Name = "Notes")]
        public string? NOTES { get; set; }

        [Display(Name = "Notes2")]
        public string? NOTES_2 { get; set; }



    }
}
