using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RDKSDatabase.Models
{
    public class Transaction
    {
        [Key]
        [StringLength(10, MinimumLength = 3)]
        public string? TRANS_NUM { get; set; }

        [Required]
        public int CUS_ID { get; set; }

        [StringLength(10)]
        public string? LICENSE_PLATE { get; set; }

        [DataType(DataType.Date)]
        public DateTime? TRANS_COMPLETION_DATE { get; set; }

        [DataType(DataType.Time)]
        public DateTime? TRANS_COMPLETION_TIME { get; set; }

        [Range(0.0, int.MaxValue)]
        public int TRANS_LOAD_NUM { get; set; }

        [Range(0.0, float.MaxValue)]
        public float TRANS_NETWEIGHT { get; set; }

        [Column(TypeName = "money")]
        [Range(0.0, float.MaxValue)]
        public float TRANS_TOTALPRICE { get; set; }

        [Required]
        [StringLength(30)]
        public string? TRANS_HAULER { get; set; }

        [Required]
        public bool TRANS_DRIVER_EXEMPT_STATUS { get; set; }

        [StringLength(10)]
        public string? VALID_IMPORT_CODE { get; set; }

        [StringLength(15)]
        public string? TRANS_CONTRACT { get; set; }

        [StringLength(10)]
        public string? TRANS_OPERATION { get; set; }

        [StringLength(10)]
        public string? TRANS_STATUS { get; set; }

        [Required]
        public bool TRANS_ISMANUAL { get; set; }

        [Required]
        public bool TRANS_HASEXCEPTION { get; set; }

        [StringLength(10)]
        public string? TRANS_KEYFIELD { get; set; }

        [StringLength(10)]
        public string? TRANS_SOURCE_TYPE { get; set; }

        [Column(TypeName = "money")]
        [Range(0.0, float.MaxValue)]
        public float TRANS_ADJUSTED_PRICE { get; set; }

        [StringLength(5)]
        public string? TRANS_FACILITY_CODE { get; set; }

        [Range(0.0, float.MaxValue)]
        public float TRANS_TONNES { get; set; }

        [Range(0.0, float.MaxValue)]
        public float? TRANS_CUBIC_METERS { get; set; }

        [StringLength(10)]
        public string? TRANS_IN_SERVICE_AREA { get; set; }

        [StringLength(10)]
        public string? TRANS_ASC_NON_ASC { get; set; }

        [StringLength(20)]
        public string? TRANS_FUNCTION { get; set; }

        [StringLength(15)]
        public string? TRANS_CURBSIDE_AREA { get; set; }

        [StringLength(10)]
        public string? TRANS_CURBSIDE_STREAM { get; set; }

        [StringLength(20)]
        public string? TRANS_ANNUAL_REPORTING_GROUP { get; set; }

        [StringLength(29)]
        public string? TRANS_ANNUAL_REPORTING_SOURCE { get; set; }

        [StringLength(15)]
        public string? TRANS_SERVICE_AREA { get; set; }

        public Customer? Customer { get; set; }
        public Vehicle? Vehicle { get; set; }
        public Validation? Validation { get; set; }

    }
}
