﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RDKSDatabase.Models
{
    public class Transaction
    {

        public enum OStatus {
            Received,
            Shipped,
            Either
        }

        public enum TStatus { 
            Complete,
            Modified,
            Void
        }

        public enum SourceType {
            CGL,
            LNG,
            Other
        }

        public enum FacilityCode {
            DYP,
            FR,
            HWMF,
            IL,
            KTS,
            ML,
            RL,
            TTS,
            NA
        }

        public enum ServiceArea {
            In,
            Internal,
            Out,
            NA
        }

        public enum Asc
        {
            ASC,
            NonASC,
            NA
        }

        public enum FunctionType {
            Consolidated,
            Curbside,
            External,
            Operational,
            Oper_Internal,
            Transaction,
            NA
        }

        public enum CurbsideArea {
            Kitselas,
            Kitsumkalum,
            Kitvanga,
            RDKS,
            Stewart,
            Terrace,
            NA
        }

        public enum CurbsideStream {
            Organics,
            Recycle,
            Refuse,
            NA
        }

        public enum ServiceRegion {
            HazeltonHwy37N,
            TerraceArea,
            NA
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [StringLength(10, MinimumLength = 3)]
        [Display(Name = "Transaction Number")]
        public string? TRANS_NUM { get; set; }

        [Required]
        [Display(Name = "Customer ID")]
        public int CUS_ID { get; set; }

        [StringLength(10)]
        [Display(Name = "Licence Plate")]
        public string? LICENSE_PLATE { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Completion Date")]
        public DateTime? TRANS_COMPLETION_DATE { get; set; }

        [DataType(DataType.Time)]
        [Display(Name = "Completion Time")]
        public DateTime? TRANS_COMPLETION_TIME { get; set; }

        [Range(0.0, int.MaxValue)]
        [Display(Name = "Load Number")]
        public int TRANS_LOAD_NUM { get; set; }

        [Range(0.0, float.MaxValue)]
        [Display(Name = "Processed Net Weight")]
        public float TRANS_NETWEIGHT { get; set; }

        [Column(TypeName = "money")]
        [Range(0.0, float.MaxValue)]
        [Display(Name = "Total Price")]
        public float TRANS_TOTALPRICE { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Hauler Name")]
        public string? TRANS_HAULER { get; set; }

        [Required]
        [Display(Name = "Driver's Exempt Status")]
        public bool TRANS_DRIVER_EXEMPT_STATUS { get; set; }

        [StringLength(10)]
        [Display(Name = "Material Code")]
        public string? VALID_IMPORT_CODE { get; set; }

        [StringLength(15)]
        [Display(Name = "Contract Number")]
        public string? TRANS_CONTRACT { get; set; }

        [StringLength(10)]
        [Display(Name = "Operation Status")]
        public OStatus? TRANS_OPERATION { get; set; }

        [StringLength(10)]
        [Display(Name = "Completion Status")]
        public TStatus? TRANS_STATUS { get; set; }

        [Required]
        [Display(Name = "Is Manual")]
        public bool TRANS_ISMANUAL { get; set; }

        [Required]
        [Display(Name = "Has Exception")]
        public bool TRANS_HASEXCEPTION { get; set; }

        [StringLength(10)]
        [Display(Name = "Key Field")]
        public string? TRANS_KEYFIELD {
            get {
                return TRANS_NUM + '-' + TRANS_LOAD_NUM;
            }
        }

        [StringLength(10)]
        [Display(Name = "Source Type")]
        public SourceType? TRANS_SOURCE_TYPE { get; set; }

        [Column(TypeName = "money")]
        [Range(0.0, float.MaxValue)]
        [Display(Name = "Adjusted Price")]
        public float TRANS_ADJUSTED_PRICE { get; set; }

        [StringLength(5)]
        [Display(Name = "Facility Code")]
        public string? TRANS_FACILITY_CODE { get; set; }

        [Range(0.0, float.MaxValue)]
        [Display(Name = "Net Weight (Tonnes)")]
        public float TRANS_TONNES { get; set; }

        [Range(0.0, float.MaxValue)]
        [Display(Name = "Volume (Cubic Metres)")]
        public float? TRANS_CUBIC_METERS { get; set; }

        [StringLength(10)]
        [Display(Name = "Service Area")]
        public ServiceArea? TRANS_IN_SERVICE_AREA { get; set; }

        [StringLength(10)]
        [Display(Name = "Asc / Non-Asc")]
        public Asc? TRANS_ASC_NON_ASC { get; set; }

        [StringLength(20)]
        [Display(Name = "Type of Function")]
        public FunctionType? TRANS_FUNCTION { get; set; }

        [StringLength(15)]
        [Display(Name = "Curbside Area")]
        public CurbsideArea? TRANS_CURBSIDE_AREA { get; set; }

        [StringLength(10)]
        [Display(Name = "Curbside Stream")]
        public CurbsideStream? TRANS_CURBSIDE_STREAM { get; set; }

        [StringLength(20)]
        [Display(Name = "Annual Reporting Group")]
        public string? TRANS_ANNUAL_REPORTING_GROUP { get; set; }

        [StringLength(20)]
        [Display(Name = "Annual Reporting Source")]
        public string? TRANS_ANNUAL_REPORTING_SOURCE { get; set; }

        [StringLength(15)]
        [Display(Name = "Service Area")]
        public ServiceRegion? TRANS_SERVICE_AREA { get; set; }

        public Customer? Customer { get; set; }
        public Vehicle? Vehicle { get; set; }
        public Validation? Validation { get; set; }

    }
}
