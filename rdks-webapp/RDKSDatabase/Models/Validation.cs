﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RDKSDatabase.Models
{
    /// <summary>
    /// The validation class represents whether the input value is valid or not,
    /// and is the basis for generating the import code.
    /// </summary>
    public class Validation
    {

        //The VALID_IMPORT_CODE property which is the PK represents the Material Code.
        [Key]
        [Display(Name = "Material Code")]
        public string? VALID_IMPORT_CODE { get; set; }

        //The VALID_CODE property represents the postfix number of Material Code.
        [Required]
        public int? VALID_CODE { get; set; }

        //The VALID_MATERIAL_NAME property represents the Material name.
        [Required]
        [StringLength(20)]
        public string? VALID_MATERIAL_NAME { get; set; }

        //The VALID_IN_AND_OUT property represents whether the Material is in SA, out of SA or internal.
        [Required]
        [StringLength(20)]
        public string? VALID_IN_AND_OUT { get; set; }

        //The VALID_AIRSPACE_OR_NONAIRSPACE property represents whether the Material is airspace or non airspace.
        [Required]
        [StringLength(20)]
        public string? VALID_AIRSPACE_OR_NONAIRSPACE { get; set; }

        //The VALID_FUNCTION property represents the function of Material.
        [Required]
        [StringLength(20)]
        public string? VALID_FUNCTION { get; set; }

        //The VALID_FACILITY property represents the abbreviation of facility.
        [Required]
        [StringLength(20)]
        public string? VALID_FACILITY { get; set; }

        //The VALID_MATERIAL_GROUP property represents the group of material.
        [Required]
        [StringLength(20)]
        public string? VALID_MATERIAL_GROUP { get; set; }

        //The VALID_CURBSIED_AREA property represents the curbside area of material.
        [Required]
        [StringLength(20)]
        public string? VALID_CURBSIED_AREA { get; set; }

        //The VALID_CURBSIDE_STREAM property represents the type of material.
        [Required]
        [StringLength(20)]
        public string? VALID_CURBSIDE_STREAM { get; set; }

        //The VALID_FR_ANNUAL_REPORTING_GROUP property represents the FR annual reporting group.
        [Required]
        [StringLength(20)]
        public string? VALID_FR_ANNUAL_REPORTING_GROUP { get; set; }

        //The VALID_FR_ANNUAL_REPORT_WASTE_TYPE property represents the  FR annual report waste type.
        [Required]
        [StringLength(20)]
        public string? VALID_FR_ANNUAL_REPORT_WASTE_TYPE { get; set; }

        //The VALID_TIPPING_RATE property represents the tipping rate.
        [Required]
        [Range(0.0, float.MaxValue)]
        public float? VALID_TIPPING_RATE { get; set; }

        //The VALID_SERVICE_AREA property represents the service area.
        [Required]
        [StringLength(20)]
        public string? VALID_SERVICE_AREA { get; set; }

        //The Transactions property is a navigation property.
        //The validation entity can be related to any number of Transactions entities.
        public ICollection<Transaction>? Transactions { get; set; }


    }
}
