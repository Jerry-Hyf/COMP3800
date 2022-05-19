using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RDKS.Models
{
    public class HWY37N_HAZELTON
    {
        [Key]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime HWY_HAZ_DATE { get; set; }
        
        [Float]
        [Display(Name = "HWY_HAZ_EST_OCC_TONNES")]
        public float HWY_HAZ_EST_OCC_TONNES { get; set; }

        [Float]
        [Display(Name = "HWY_HAZ_OCC_BIN_BILLING")]
        public float HWY_HAZ_OCC_BIN_BILLING { get; set; }

        [Float]
        [Display(Name = "HWY_HAZ_SCRAP_METAL_TONNES")]
        public float HWY_HAZ_SCRAP_METAL_TONNES { get; set; }

        [Float]
        [Display(Name = "HWY_HAZ_TIRE_COUNTS")]
        public float HWY_HAZ_TIRE_COUNTS { get; set; }

        [Float]
        [Display(Name = "HWY_HAZ_TIRE_COLLECTION_CHARGES")]
        public float HWY_HAZ_TIRE_COLLECTION_CHARGES { get; set; }

        [Float]
        [Display(Name = "HWY_HAZ_FREON_REMOVAL_CHARGES")]
        public float HWY_HAZ_FREON_REMOVAL_CHARGES { get; set; }

        [Float]
        [Display(Name = "HWY_HAZ_MARR_INCOME")]
        public float HWY_HAZ_MARR_INCOME { get; set; }

        [Float]
        [Display(Name = "HWY_HAZ_ABC_INCOME")]
        public float HWY_HAZ_ABC_INCOME { get; set; }

    }
}
