using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RDKS.Models
{
    public class HWY37N_KITWANGA
    {
        [Key]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime HWY_KIT_DATE { get; set; }

        [Display(Name = "HWY_KIT_OCC_TONNAGE_EST")]
        public float HWY_KIT_OCC_TONNAGE_EST { get; set; }

        [Display(Name = "HWY_KIT_PPP_TONNAGE")]
        public float HWY_KIT_PPP_TONNAGE { get; set; }

        [Display(Name = "HWY_KIT_OCC_HAULING_BIN_RENTAL")]
        public float HWY_KIT_OCC_HAULING_BIN_RENTAL { get; set; }

        [Display(Name = "HWY_KIT_PPP_HAULING")]
        public float HWY_KIT_PPP_HAULING { get; set; }

        [Display(Name = "HWY_KIT_RECYCLE_BC_TONNAGE")]
        public float HWY_KIT_RECYCLE_BC_TONNAGE { get; set; }

        [Display(Name = "HWY_KIT_CESA_TONNES")]
        public float HWY_KIT_CESA_TONNES { get; set; }

        [Display(Name = "HWY_KIT_EPRA_TONNES")]
        public float HWY_KIT_EPRA_TONNES { get; set; }

        [Display(Name = "HWY_KIT_LIGHT_RECYCLE_COUNTS")]
        public float HWY_KIT_LIGHT_RECYCLE_COUNTS { get; set; }

        [Display(Name = "HWY_KIT_PAINT_RECYCLE_COUNTS")]
        public float HWY_KIT_PAINT_RECYCLE_COUNTS { get; set; }

        [Display(Name = "HWY_KIT_SCRAP_METAL_MARR_INCLUDED")]
        public float HWY_KIT_SCRAP_METAL_MARR_INCLUDED { get; set; }

        [Display(Name = "HWY_KIT_LAB_TONNES")]
        public float HWY_KIT_LAB_TONNES { get; set; }

        [Display(Name = "HWY_KIT_TIRE_COUNTS")]
        public float HWY_KIT_TIRE_COUNTS { get; set; }

        [Display(Name = "HWY_KIT_TIRE_CHARGES")]
        public float HWY_KIT_TIRE_CHARGES { get; set; }

        [Display(Name = "HWY_KIT_FREON_REMOVAL_CHARGES")]
        public float HWY_KIT_FREON_REMOVAL_CHARGES { get; set; }

        [Display(Name = "HWY_KIT_RECYCLE_BC_INCOME")]
        public float HWY_KIT_RECYCLE_BC_INCOME { get; set; }

        [Display(Name = "HWY_KIT_CESA_INCOME")]
        public float HWY_KIT_CESA_INCOME { get; set; }

        [Display(Name = "HWY_KIT_EPRA_INCOME")]
        public float HWY_KIT_EPRA_INCOME { get; set; }

        [Display(Name = "HWY_KIT_LIGHT_RECYCLE_INCOME")]
        public float HWY_KIT_LIGHT_RECYCLE_INCOME { get; set; }

        [Display(Name = "HWY_KIT_PAINT_RECYCLE_INCOME")]
        public float HWY_KIT_PAINT_RECYCLE_INCOME { get; set; }

        [Display(Name = "HWY_KIT_MARR_INCOME")]
        public float HWY_KIT_MARR_INCOME { get; set; }

        [Display(Name = "HWY_KIT_LAB_INCOME")]
        public float HWY_KIT_LAB_INCOME { get; set; }

        [Display(Name = "HWY_KIT_TOTAL_TONNES_EPR")]
        public float HWY_KIT_TOTAL_TONNES_EPR { get; set; }

        [Display(Name = "HWY_KIT_NET_INCOME")]
        public float HWY_KIT_NET_INCOME { get; set; }

    }
}
