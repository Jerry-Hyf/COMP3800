using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RDKSDatabase.Models
{
    public class Permit
    {
        [Key]
        [Required]
        public string PermitNumberPrefix { get; set; }
        [Key]
        public int PermitNumber { get; set; }




        public WasteSource WasteSource { get; set; }

        public Material Material { get; set; }

        

    }
}
