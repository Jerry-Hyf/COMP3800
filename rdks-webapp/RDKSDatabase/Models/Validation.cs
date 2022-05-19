using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RDKSDatabase.Models
{
    public class Validation
    {



        [Key]
        [Display(Name = "Facility Code")]
        public String? VALID_IMPORT_CODE { get; set; }

        [Required]
        public int? VALID_CODE { get; set; }

        [Required]
        [StringLength(20)]
        public string? VALID_MATERIAL_NAME { get; set; }

        [Required]
        [StringLength(20)]
        public string? VALID_IN_AND_OUT { get; set; }

        [Required]
        [StringLength(20)]
        public string? VALID_AIRSPACE_OR_NONAIRSPACE { get; set; }

        [Required]
        [StringLength(20)]
        public string? VALID_FUNCTION { get; set; }

        [Required]
        [StringLength(20)]
        public string? VALID_FACILITY { get; set; }
        
        [Required]
        [StringLength(20)]
        public string? VALID_MATERIAL_GROUP { get; set; }

        [Required]
        [StringLength(20)]
        public string? VALID_CURBSIED_AREA { get; set; }

        [Required]
        [StringLength(20)]
        public string? VALID_CURBSIDE_STREAM { get; set; }

        [Required]
        [StringLength(20)]
        public string? VALID_FR_ANNUAL_REPORTING_GROUP { get; set; }

        [Required]
        [StringLength(20)]
        public string? VALID_FR_ANNUAL_REPORT_WASTE_TYPE { get; set; }


        [Required]
        [Range(0.0, float.MaxValue)]
        public float? VALID_TIPPING_RATE { get; set; }


        [Required]
        [StringLength(20)]
        public string? VALID_SERVICE_AREA { get; set; }








    }
}
