using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RDKSDatabase.Models
{
    public class Transaction
    {
        [Key]
        [Required]
        [StringLength(10, MinimumLength = 3)]
        public string? TRANS_NUM { get; set; }

        public int CUS_ID { get; set; }
        public int LICENSE_PLATE { get; set; }

        [DataType()]
        public DateTime? TRANS_COMPLETION_DATE { get; set; }
        public string? TRANS_COMPLETION_TIME { get; set; }
        public string? TRANS_LOAD_NUM { get; set; }
        public string? TRANS_NETWEIGHT { get; set; }
        public string? TRANS_TOTALPRICE { get; set; }
        public string? TRANS_HAULER { get; set; }
        public string? TRANS_DRIVER_EXEPT_STATUS { get; set; }

        public string? VALID_IMPORT_CODE { get; set; }

        public string? TRANS_CONTRACT { get; set; }
        public string? TRANS_OPERATION { get; set; }
        public string? TRANS_STATUS { get; set; }
        public string? TRANS_ISMANUAL { get; set; }
        public string? TRANS_HASEXCEPTION { get; set; }
        public string? TRANS_KEYFIELD { get; set; }
        public string? TRANS_SOURCE_TYPE { get; set; }
        public string? TRANS_ADJUSTED_PRICE { get; set; }
        public string? TRANS_FACILITY_CODE { get; set; }
        public string? TRANS_TONNES { get; set; }
        public string? TRANS_CUBIC_METERS { get; set; }
        public string? TRANS_IN_SERVICE_AREA { get; set; }
        public string? TRANS_ASC_NON_ASC { get; set; }
        public string? TRANS_FUNCTION { get; set; }
        public string? TRANS_CURBSIDE_AREA { get; set; }
        public string? TRANS_CURBSIDE_STREAM { get; set; }
        public string? TRANS_ANNUAL_REPORTING_GROUP { get; set; }
        public string? TRANS_ANNUAL_REPORTING_SOURCE { get; set; }
        public string? TRANS_SERVICE_AREA { get; set; }

    }
}
