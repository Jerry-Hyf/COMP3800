using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RDKS.Models
{
    public class HWY37N_STEWART
    {
        [Key]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime HWY_STE_DATE { get; set; }

        [Float]
        [Display(Name = "HWY_STE_OCC_TONNES")]
        public float HWY_STE_OCC_TONNES { get; set; }

        [Float]
        [Display(Name = "HWY_STE_BANDSTRA_OCC_HAULING")]
        public float HWY_STE_BANDSTRA_OCC_HAULING { get; set; }

        [Float]
        [Display(Name = "HWY_STE_OCC_TOTAL")]
        public float HWY_STE_OCC_TOTAL { get; set; }

        [Float]
        [Display(Name = "HWY_STE_RECYCLE_BC_TONNAGE")]
        public float HWY_STE_RECYCLE_BC_TONNAGE { get; set; }

        [Float]
        [Display(Name = "HWY_STE_CESA_TONNES")]
        public float HWY_STE_CESA_TONNES { get; set; }

        [Float]
        [Display(Name = "HWY_STE_EPRA_TONNES")]
        public float HWY_STE_EPRA_TONNES { get; set; }

        [Float]
        [Display(Name = "HWY_STE_LIGHT_RECYCLE_COUNTS")]
        public float HWY_STE_LIGHT_RECYCLE_COUNTS { get; set; }

        [Float]
        [Display(Name = "HWY_STE_PAINT_RECYCLE_COUNTS")]
        public float HWY_STE_PAINT_RECYCLE_COUNTS { get; set; }

        [Float]
        [Display(Name = "HWY_STE_SCRAP_METAL_MARR_TONNE_EST")]
        public float HWY_STE_SCRAP_METAL_MARR_TONNE_EST { get; set; }

        [Float]
        [Display(Name = "HWY_STE_LAB_TONNES")]
        public float HWY_STE_LAB_TONNES { get; set; }

        [Float]
        [Display(Name = "HWY_STE_TIRE_COUNTS")]
        public float HWY_STE_TIRE_COUNTS { get; set; }

        [Float]
        [Display(Name = "HWY_STE_TIRE_CHARGES")]
        public float HWY_STE_TIRE_CHARGES { get; set; }

        [Float]
        [Display(Name = "HWY_STE_FREON_REMOVAL_CHARGES")]
        public float HWY_STE_FREON_REMOVAL_CHARGES { get; set; }

        [Float]
        [Display(Name = "HWY_STE_RECYCLE_BC_INCOME")]
        public float HWY_STE_RECYCLE_BC_INCOME { get; set; }

        [Float]
        [Display(Name = "HWY_STE_CESA_INCOME")]
        public float HWY_STE_CESA_INCOME { get; set; }

        [Float]
        [Display(Name = "HWY_STE_EPRA_INCOME")]
        public float HWY_STE_EPRA_INCOME { get; set; }

        [Float]
        [Display(Name = "HWY_STE_LIGHT_RECYCLE_INCOME")]
        public float HWY_STE_LIGHT_RECYCLE_INCOME { get; set; }

        [Float]
        [Display(Name = "HWY_STE_RECYCLE_INCOME")]
        public float HWY_STE_RECYCLE_INCOME { get; set; }

        [Float]
        [Display(Name = "HWY_STE_MARR_INCOME")]
        public float HWY_STE_MARR_INCOME { get; set; }

        [Float]
        [Display(Name = "HWY_STE_LAB_INCOME")]
        public float HWY_STE_LAB_INCOME { get; set; }

        [Float]
        [Display(Name = "HWY_STE_TOTAL_TONNES_EPR")]
        public float HWY_STE_TOTAL_TONNES_EPR { get; set; }

        [Float]
        [Display(Name = "HWY_STE_NET_INCOME")]
        public float HWY_STE_NET_INCOME { get; set; }

    }
}
