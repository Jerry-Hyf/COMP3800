using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RDKSDatabase.Data;
using RDKSDatabase.Models;
using RDKS.Models;
using System;
using System.Linq;

namespace RDKSDatabase.Data
{
    public static class DbInitializer
    {

        public static void Initialize(RDKSDatabaseContext context)
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


            // Create mock data for ABCRecycling
            var abcRecycling = new ABCRecycling[]
                {
                    new ABCRecycling{ABCDateID=new DateTime(2022, 05, 16),ABC_LOCATION="somewhere",ABC_MATERIAL="qwe",TOTAL_POUND_NETWEIGHT=1,TOTAL_TONNAGE_NETWEIGHT=2,TOTAL_TONNAGE_MATERIAL=3},
                    new ABCRecycling{ABCDateID=new DateTime(2022, 05, 27),ABC_LOCATION="Vancouver",ABC_MATERIAL="qwe",TOTAL_POUND_NETWEIGHT=(float)100.35,TOTAL_TONNAGE_NETWEIGHT=2,TOTAL_TONNAGE_MATERIAL=3},
                    new ABCRecycling{ABCDateID=new DateTime(2010, 07, 02),ABC_LOCATION="BCIT",ABC_MATERIAL="qwe",TOTAL_POUND_NETWEIGHT=1,TOTAL_TONNAGE_NETWEIGHT=(float)13.45,TOTAL_TONNAGE_MATERIAL=3},
                    new ABCRecycling{ABCDateID=new DateTime(2009, 08, 24),ABC_LOCATION="Granville Island",ABC_MATERIAL="qwe",TOTAL_POUND_NETWEIGHT=1,TOTAL_TONNAGE_NETWEIGHT=2,TOTAL_TONNAGE_MATERIAL=(float)457.13},
                    new ABCRecycling{ABCDateID=new DateTime(2018, 04, 29),ABC_LOCATION="Burnaby",ABC_MATERIAL="qwe",TOTAL_POUND_NETWEIGHT=1,TOTAL_TONNAGE_NETWEIGHT=2,TOTAL_TONNAGE_MATERIAL=3,ABC_COMPLETED=true},
                };

            foreach (ABCRecycling c in abcRecycling)
            {
                context.ABCRecycling.Add(c);
            }

            context.SaveChanges();

            // Create mock data for HWY37N_HAZELTON
            var hwy37Haz = new HWY37N_HAZELTON[]
                {
                    new HWY37N_HAZELTON{HWY_HAZ_DATE=new DateTime(2022, 05, 16),HWY_HAZ_EST_OCC_TONNES=(float)123.6,HWY_HAZ_OCC_BIN_BILLING=123,HWY_HAZ_MARR_INCOME=-231},
                    new HWY37N_HAZELTON{HWY_HAZ_DATE=new DateTime(2022, 05, 27),HWY_HAZ_EST_OCC_TONNES=34,HWY_HAZ_SCRAP_METAL_TONNES=(float)100.35},
                    new HWY37N_HAZELTON{HWY_HAZ_DATE=new DateTime(2010, 07, 02),HWY_HAZ_EST_OCC_TONNES=(float)62.7,HWY_HAZ_TIRE_COUNTS=(float)13.45,HWY_HAZ_ABC_INCOME=(float)-23.04},
                    new HWY37N_HAZELTON{HWY_HAZ_DATE=new DateTime(2009, 08, 24),HWY_HAZ_EST_OCC_TONNES=(float)24.0,HWY_HAZ_TIRE_COLLECTION_CHARGES=(float)457.13},
                    new HWY37N_HAZELTON{HWY_HAZ_DATE=new DateTime(2018, 04, 29),HWY_HAZ_EST_OCC_TONNES=1,HWY_HAZ_FREON_REMOVAL_CHARGES=1267},
                };
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

            foreach (HWY37N_HAZELTON c in hwy37Haz)
            foreach (WasteSource w in wasteSources)
            {
                context.HWY37N_HAZELTON.Add(c);
                context.WasteSource.Add(w);
            }

            context.SaveChanges();

            // Create mock data for HWY37N_KITWANGA
            var hwy37Kit = new HWY37N_KITWANGA[]
                {
                    new HWY37N_KITWANGA{HWY_KIT_DATE=new DateTime(2022, 05, 16),HWY_KIT_OCC_TONNAGE_EST=(float)123.6,HWY_KIT_PPP_TONNAGE=123,HWY_KIT_EPRA_INCOME=-231},
                    new HWY37N_KITWANGA{HWY_KIT_DATE=new DateTime(2022, 05, 27),HWY_KIT_OCC_TONNAGE_EST=34,HWY_KIT_OCC_HAULING_BIN_RENTAL=(float)100.35},
                    new HWY37N_KITWANGA{HWY_KIT_DATE=new DateTime(2010, 07, 02),HWY_KIT_OCC_TONNAGE_EST=(float)62.7,HWY_KIT_PPP_HAULING=(float)13.45,HWY_KIT_CESA_INCOME=(float)-23.04},
                    new HWY37N_KITWANGA{HWY_KIT_DATE=new DateTime(2009, 08, 24),HWY_KIT_OCC_TONNAGE_EST=(float)24.0,HWY_KIT_RECYCLE_BC_TONNAGE=(float)457.13},
                    new HWY37N_KITWANGA{HWY_KIT_DATE=new DateTime(2018, 04, 29),HWY_KIT_OCC_TONNAGE_EST=1,HWY_KIT_CESA_TONNES=1267},
                };

            foreach (HWY37N_KITWANGA c in hwy37Kit)
            {
                context.HWY37N_KITWANGA.Add(c);
            }

            context.SaveChanges();

            // Create mock data for HWY37N_STEWART
            var hwy37Ste = new HWY37N_STEWART[]
                {
                    new HWY37N_STEWART{HWY_STE_DATE=new DateTime(2022, 05, 16),HWY_STE_OCC_TONNES=(float)123.6,HWY_STE_EPRA_TONNES=123,HWY_STE_RECYCLE_BC_INCOME=-231},
                    new HWY37N_STEWART{HWY_STE_DATE=new DateTime(2022, 05, 27),HWY_STE_BANDSTRA_OCC_HAULING=34,HWY_STE_EPRA_TONNES=(float)100.35},
                    new HWY37N_STEWART{HWY_STE_DATE=new DateTime(2010, 07, 02),HWY_STE_OCC_TOTAL=(float)62.7,HWY_STE_LIGHT_RECYCLE_COUNTS=(float)13.45,HWY_STE_CESA_INCOME=(float)-23.04},
                    new HWY37N_STEWART{HWY_STE_DATE=new DateTime(2009, 08, 24),HWY_STE_RECYCLE_BC_TONNAGE=(float)24.0,HWY_STE_LIGHT_RECYCLE_COUNTS=(float)457.13},
                    new HWY37N_STEWART{HWY_STE_DATE=new DateTime(2018, 04, 29),HWY_STE_CESA_TONNES=1,HWY_STE_PAINT_RECYCLE_COUNTS=1267},
                };

            foreach (HWY37N_STEWART c in hwy37Ste)
            {
                context.HWY37N_STEWART.Add(c);
            }



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

            context.SaveChanges();
            foreach (Material m in masterials)
            {
                context.Material.Add(m);
            }
            context.SaveChanges();
        }
    }
}
