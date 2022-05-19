using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RDKSDatabase.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Address
    {

        [Key]
        public int ADDR_ID { get; set; }

        [StringLength(30)]
        [Display(Name = "Street Address")]
        public string? ADDR_STREET { get; set; }

        [StringLength(15)]
        [Display(Name = "City")]
        public string? ADDR_CITY { get; set; }

        [StringLength(2)]
        [Display(Name = "Province")]
        public string? ADDR_PROV { get; set; }

        [StringLength(6)]

        public string? ADDR_POCODE { get; set; }          

    }
}
