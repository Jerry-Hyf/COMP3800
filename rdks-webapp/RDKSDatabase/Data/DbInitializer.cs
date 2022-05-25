using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RDKSDatabase.Data;
using RDKSDatabase.Models;
using System;
using System.Linq;

namespace RDKSDatabase.Data
{
    public class DbInitializer
    {

        public void Initialize(RDKSDatabaseContext context)
        {
            context.Database.EnsureCreated();

           if (context.Material.Any())
            {
                return;   // DB has been seeded
            }
            var masterials = new Material[]
               {
                    new Material{MaterialCode=44,MaterialType="Asbestos"},
                    new Material{MaterialCode=40,MaterialType="DLC Over 5m3"},
                    new Material{MaterialCode=45,MaterialType="DLC Concrete - no rebar"},
                    new Material{MaterialCode=10,MaterialType="Refuse"},
                    new Material{MaterialCode=22,MaterialType="Organic Cleanwood Burn"},
               };

            foreach (Material m in masterials)
            {
                context.Material.Add(m);
            }
            context.SaveChanges();


            if (context.WasteSource.Any())
            {
                return;   // DB has been seeded
            }
            var wasteSources = new WasteSource[]
               {
                    new WasteSource{WasteGenerator="first",WasteSourceSiteAddress="4901 Walsh"},
                    new WasteSource{WasteGenerator="second",WasteSourceSiteAddress="4620 Lakelse Ave"},
                    new WasteSource{WasteGenerator="thrid",WasteSourceSiteAddress="3747 River Dr"},
                    new WasteSource{WasteGenerator="fourth",WasteSourceSiteAddress="5022 Mcrae Cres"},
                    new WasteSource{WasteGenerator="fifth",WasteSourceSiteAddress="520 Keith Ave"},
               };

            foreach (WasteSource w in wasteSources)
            {
                context.WasteSource.Add(w);
            }
            context.SaveChanges();






            if (context.Permit.Any())
            {
                return;   // DB has been seeded
            }
            var permits = new Permit[]
               {
                    new Permit{PermitId="5360081",FacilityCode="FRWMF",PermitApplicationDate = new DateTime(2016,11,03),EstimatedLoads=0,EstimatedVolume=0,units="NA",Frequency="Bi_Weekly",Comments="NA",ContaminateLoadsDate=new DateTime(2016,11,2),ContaminateLoadsComments="NA",ContaminatedLoads=0,PermitSentToOperatorAndWMF="N",PermitSavedOnServerAndFiled="N",HardCopyPermitSavedInFile="N",ApprovedBy="NA",PermitClosedCardPermissionsRevolked="N",PermitStatus="Permit Issued",PermitType="Single Event",PermitFee=25,ExpirationDate=new DateTime(2016,11,10),ApplicationFeeInvoiced="N",ApplicantName="Universal Restoration Systems LTD",Hauler="Universal",MaterialCode=44, WasteGenerator="first"},
                    new Permit{PermitId="5360083",FacilityCode="FRWMF",PermitApplicationDate = new DateTime(2016,11,16),EstimatedLoads=0,EstimatedVolume=0,units="NA",Frequency="Bi_Monthly",Comments="NA",ContaminateLoadsDate=new DateTime(2016,11,22),ContaminateLoadsComments="NA",ContaminatedLoads=0,PermitSentToOperatorAndWMF="N",PermitSavedOnServerAndFiled="N",HardCopyPermitSavedInFile="N",ApprovedBy="NA",PermitClosedCardPermissionsRevolked="N",PermitStatus="Permit Issued",PermitType="Single Event",PermitFee=25,ExpirationDate=new DateTime(2016,11,30),ApplicationFeeInvoiced="N",ApplicantName="Days Inn",Hauler="Waste Management",MaterialCode=40,WasteGenerator="second"},
                    new Permit{PermitId="5360088",FacilityCode="FRWMF",PermitApplicationDate = new DateTime(2016,11,28),EstimatedLoads=0,EstimatedVolume=0,units="NA",Frequency="Monthly",Comments="NA",ContaminateLoadsComments="NA",ContaminatedLoads=0,PermitSentToOperatorAndWMF="N",PermitSavedOnServerAndFiled="N",HardCopyPermitSavedInFile="N",ApprovedBy="NA",PermitClosedCardPermissionsRevolked="N",PermitStatus="Permit Issued",PermitType="Single Event",PermitFee=25,ExpirationDate=new DateTime(2016,12,30),ApplicationFeeInvoiced="N",ApplicantName="Lafarge concrete",Hauler="Provac",MaterialCode=45,WasteGenerator="third"},
                    new Permit{PermitId="5360089",FacilityCode="FRWMF",PermitApplicationDate = new DateTime(2016,11,29),EstimatedLoads=0,EstimatedVolume=0,units="NA",Frequency="Monthly",Comments="NA",ContaminateLoadsComments="NA",ContaminatedLoads=0,PermitSentToOperatorAndWMF="N",PermitSavedOnServerAndFiled="N",HardCopyPermitSavedInFile="N",ApprovedBy="NA",PermitClosedCardPermissionsRevolked="N",PermitStatus="Permit Issued",PermitType="Single Event",PermitFee=25,ExpirationDate=new DateTime(2017,1,4),ApplicationFeeInvoiced="Y",ApplicantName="Technicon",Hauler="Technicon",MaterialCode=10,WasteGenerator="fourth"},
                    new Permit{PermitId="53600817",FacilityCode="FRWMF",PermitApplicationDate = new DateTime(2016,11,29),EstimatedLoads=0,EstimatedVolume=0,units="NA",Frequency="Semi_Annual",Comments="NA",ContaminateLoadsComments="NA",ContaminatedLoads=0,PermitSentToOperatorAndWMF="N",PermitSavedOnServerAndFiled="N",HardCopyPermitSavedInFile="N",ApprovedBy="NA",PermitClosedCardPermissionsRevolked="N",PermitStatus="Permit Issued",PermitType="Single Event",PermitFee=25,ExpirationDate=new DateTime(2017,1,4),ApplicationFeeInvoiced="Y",ApplicantName="Ministry of Forest",Hauler="NBC",MaterialCode=10,WasteGenerator="fifth"},
               };

            foreach (Material m in masterials)
            {
                context.Material.Add(m);
            }
            context.SaveChanges();
        }
    }
}
