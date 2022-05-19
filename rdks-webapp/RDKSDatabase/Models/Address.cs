using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RDKSDatabase.Models
{
    public class Address
    {
        [Key]
        public int ADDR_ID { get; set; }

        [StringLength(30)]
        public string? ADDR_STREET { get; set; }

        [StringLength(15)]
        public string? ADDR_CITY { get; set; }

        [StringLength(2)]
        public string? ADDR_PROV { get; set; }

        [StringLength(6)]
        public string? ADDR_POCODE { get; set; }          

    }
}
