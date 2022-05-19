using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RDKSDatabase.Models
{
    public class ABCRecycling
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Column("ABC_DATE")]
        public DateTime ABCDateID { get; set; }

        [Required]
        [StringLength(20)]
        public string ABC_LOCATION { get; set; }

        [Required]
        [StringLength(10)]
        public string ABC_MATERIAL { get; set; }

        [Required]
        [Range(0.0, float.MaxValue)]
        [Column("ABC_NET_WEIGHT_IN_POUND")]
        public float TOTAL_POUND_NETWEIGHT { get; set; }

        [Required]
        [Range(0.0, float.MaxValue)]
        [Column("ABC_TOTAL_NET_WEIGHT_IN_TONNAGE")]
        public float TOTAL_TONNAGE_NETWEIGHT { get; set; }

        [Required]
        [Range(0.0, float.MaxValue)]
        [Column("ABC_TOTAL_METRIC_TON")]
        public float TOTAL_TONNAGE_MATERIAL { get; set; }

        public bool ABC_COMPLETED { get; set; }





    }
}
