using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RDKSDatabase.Models
{
    public class Customer
    {

        [Key]
        public int CUS_ID { get; set; }

        [Required]
        [StringLength(12)]
        [Display(Name ="Customer Account Number")]
        public string? CUS_ACCNUM { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Company Name")]
        public string? CUS_COMPNAME { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Contact First Name")]
        public string? CUS_FNAME { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Contact Last Name")]
        public string? CUS_LNAME { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "Contact Phone Number")]
        public string? CUS_PHONE { get; set; }

        [StringLength(15)]
        [Display(Name = "Alternative Phone Numbe")]
        public string? CUS_ALT_PHONE { get; set; }

        [StringLength(30)]
        [Display(Name = "Contact Email")]
        public string? CUS_EMAIL { get; set; }

        [StringLength(30)]
        [Display(Name = "Alt. Email")]
        public string? CUS_ALT_EMAIL { get; set; }

        [Required]
        [Display(Name = "Access to FR")]
        public bool CUS_FR { get; set; }

        [Required]
        [Display(Name = "Access to TTS")]
        public bool CUS_TTS { get; set; }

        [Required]
        [Display(Name = "Access to MEZ")]
        public bool CUS_MEZ { get; set; }

        [Required]
        [Display(Name = "Deactivated Count")]
        public int CUS_DEACTIVATED_COUNT { get; set; }

        [StringLength(100)]
        [Display(Name = "Notes")]
        public string? CUS_NOTE { get; set; }

        public ICollection<Address>? Addresses { get; set; }
        public ICollection<Vehicle>? Vehicles { get; set; }
        public ICollection<Transaction>? Transactions { get; set; }
        public ICollection<Permit>? Permits { get; set; }

    }
}
