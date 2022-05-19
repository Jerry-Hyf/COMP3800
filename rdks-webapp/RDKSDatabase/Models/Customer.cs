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

        [StringLength(12)]
        public string? CUS_ACCNUM { get; set; }

        [StringLength(30)]
        public string? CUS_COMPNAME { get; set; }

        [Required]
        [StringLength(20)]
        public string? CUS_FNAME { get; set; }

        [Required]
        [StringLength(20)]
        public string? CUS_LNAME { get; set; }

        [Required]
        [StringLength(15)]
        public string? CUS_PHONE { get; set; }

        [StringLength(15)]
        public string? CUS_ALT_PHONE { get; set; }

        [StringLength(30)]
        public string? CUS_EMAIL { get; set; }

        [StringLength(30)]
        public string? CUS_ALT_EMAIL { get; set; }

        [Required]
        [Column("CUS_ADDRESS")]
        public int ADDR_ID { get; set; }

        [Column("CUS_ALT_ADDRESS")]
        public int ALT_ADDR_ID { get; set; }

        [Required]
        public bool CUS_FR { get; set; }

        [Required]
        public bool CUS_TTS { get; set; }

        [Required]
        public bool CUS_MEZ { get; set; }

        [Required]
        public int CUS_DEACTIVATED_COUNT { get; set; }

        [StringLength(50)]
        public string? CUS_NOTE { get; set; }

        public ICollection<Address>? Addresses { get; set; }

    }
}
