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

            if (context.Customer.Any())
            {
                return;   // DB has been seeded
            }

            /* 
             * abc, hwy37 x3
             * 
             * address, customer, transaction, validation
             * 
             * material, permit, vehicle, waste
             * 
             */
            

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

            foreach (HWY37N_HAZELTON c in hwy37Haz)
            {
                context.HWY37N_HAZELTON.Add(c);
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

            context.SaveChanges();
        }
    }
}
