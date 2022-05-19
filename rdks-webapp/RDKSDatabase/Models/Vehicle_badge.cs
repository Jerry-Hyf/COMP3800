using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RDKSDatabase.Models
{
    public class Vehicle_badge
    {
        [Key]
        [Required]
        [StringLength(10, MinimumLength = 6)]
        public string? LICENSE_PLATE { get; set; }

        public int CUS_ID { get; set; }
        public string? DESCRIPTION { get; set; }

        public int BADGE { get; set; }

        public string? NOTES { get; set; }

        public string? NOTES_2 { get; set; }



    }
}
