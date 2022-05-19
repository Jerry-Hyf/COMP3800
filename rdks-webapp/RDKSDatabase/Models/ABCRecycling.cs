using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RDKSDatabase.Models
{
    public class ABCRecycling
    {
        [Key]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date")]
        public DateTime? ABCDateID { get; set; }

        [Display(Name = "Facility location")]
        [Required]
        [StringLength(20)]
        public string? ABC_LOCATION { get; set; }

        [Display(Name = "Recyclable material")]
        [Required]
        [StringLength(10)]
        public string? ABC_MATERIAL { get; set; }

        [Display(Name = "Material weight in pound")]
        [Required]
        [Range(0.0, float.MaxValue)]
        [Column("ABC_NET_WEIGHT_IN_POUND")]
        public float? TOTAL_POUND_NETWEIGHT { get; set; }

        [Display(Name = "Material weight in tonnage")]
        [Required]
        [Range(0.0, float.MaxValue)]
        [Column("ABC_TOTAL_NET_WEIGHT_IN_TONNAGE")]
        public float? TOTAL_TONNAGE_NETWEIGHT { get; set; }


        [Display(Name = "Total Material weight in tonnage")]
        [Required]
        [Range(0.0, float.MaxValue)]
        [Column("ABC_TOTAL_METRIC_TON")]
        public float? TOTAL_TONNAGE_MATERIAL { get; set; }

        [Display(Name = "Is completed")]
        public bool? ABC_COMPLETED { get; set; }





    }
}
