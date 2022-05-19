﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RDKSDatabase.Models

{
    
    public enum FacilityCode
    {
        
        ML=53600902,
        HWMF=53600901,
        FRWMF=536008

    }
    public enum Units
    {
        Bags,
        Imperial_Gallon,
        Kg,Lbs,Litre,
        Cubic_Meter,Tonnes,US_Gallon,Cubic_Yard
    }

    public enum Frequency
    {
        Bi_Weekly,
        Bi_Monthly,
        Weekly,
        Monthly,
        Daily,
        Once

    }

    public enum PermitSentToOperatorAndWMF
    {
        Yes,
        Pending
    }

    public enum HardCopyPermitSavedInFile
    {
        Y,N
    }

    public enum PermitSavedOnServerAndFiled
    {
        Y, N
    }

    public enum PermitStatus
    {
        Semi_Annual,
        Single_Event,
        Annual,
        Multi_Day

    }

    public enum ApplicationFeeInvoiced
    {
        Y,N
    }

    public enum ContaminatedLoads
    {
        One = 1,
        Two = 2
    }
    public class Permit
    {   
       
        [Required]
        public int PermitNumberPrefix { get; set; }

        public int PermitNumber { get; set; }

        [Key]
        public string PermitNum {
            get {
               
                     return  PermitNumberPrefix + "-" + PermitNumber;    
                    
                }
                
            }
       

        [Display(Name ="Facility Code")]
        [Required]
        public string FacilityCode { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:MM-dd-yyyy}",ApplyFormatInEditMode =true)]
        [Display(Name ="Permit Application Date")]
        public  DateTime PermitApplicationDate { get; set; }

        [Range(0,float.MaxValue)]
        [Display(Name ="Estimated Volume")]
        public float EstimatedVolume { get; set; }

        
        public string? Units { get; set; }

        [Range(0,int.MaxValue)]
        public int EstimatedLoads { get; set; }

        public string? Frequency { get; set; }

        public string? Comments { get; set; }

        [Display(Name ="Contaminated Loads Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ContaminateLoadsDate { get; set; }

        [Display(Name = "Contaminate Loads Comments")]
        public string? ContaminateLoadsComments { get; set; }

        [Display(Name = "Contaminated Loads")]
        [Range(0,int.MaxValue)]

        public int ContaminatedLoads { get; set; }

        [Display(Name = "Permit Sent To Operator And WMF")]
        public string? PermitSentToOperatorAndWMF { get; set; }

        [Display(Name = "Permit Saved On Server And Filed")]

        public char? PermitSavedOnServerAndFiled { get; set; }

        [Display(Name = "Hard Copy Permit Saved In File")]

        public char HardCopyPermitSavedInFile { get; set; }

        [Display(Name = "Approved By")]

        public string? ApprovedBy { get; set; }

        [Display(Name = "Permit Closed Card Permissions Revolked")]
        public string? PermitClosedCardPermissionsRevolked { get; set; }

        [Required]
        [Display(Name = "Permit Status")]
        public PermitStatus permitStatus{ get; set; }


        [Required]
        [Display(Name = "Permit Type")]
        public string PermitType { get; set; }

        [Required]
        [Display(Name = "Permit Fee")]
        public float PermitFee { get; set; }

        [Display(Name = "Expiration Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ExpirationDate { get; set; }

        [Required]
        [Display(Name = "Application Fee Invoiced")]
        public bool ApplicationFeeInvoiced { get; set; }


        [Display(Name = "Applicant Name")]
        [Required]
        public string ApplicantName { get; set; }

        [Display(Name = "Applicant Phone")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        [Required]
        public string ApplicantPhone { get; set; }

        [Display(Name = "Applicant Email")]
        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string ApplicantEmail { get; set; }

        
        public string? Hauler { get; set; }
        public string? Hauler2 { get; set; } 

        public Customer Customer { get; set; }

        public WasteSource WasteSource { get; set; }

        public Material Material { get; set; }
    }
}
