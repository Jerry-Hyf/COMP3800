using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RDKSDatabase.Data;
using RDKSDatabase.Models;
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

            var customers = new Customer[]
            {
                new Customer{CUS_ACCNUM="ABCD0123",CUS_COMPNAME="ABC Company Inc", CUS_FNAME="John", CUS_LNAME="Doe", 
                    CUS_PHONE="222-333-4567", CUS_EMAIL="jdoe@abccompany.com", CUS_FR=false, CUS_TTS=false, CUS_MEZ=true, CUS_DEACTIVATED_COUNT=0},

                new Customer{CUS_ACCNUM="LASJ1234",CUS_COMPNAME="Construction Co.", CUS_FNAME="Kevin", CUS_LNAME="Smith", 
                    CUS_PHONE="234-532-3838", CUS_EMAIL="ksmith@construction.com", CUS_FR=true, CUS_TTS=false, CUS_MEZ=false, CUS_DEACTIVATED_COUNT=1},

                new Customer{CUS_ACCNUM="FJAS2231",CUS_COMPNAME="123 Company Inc", CUS_FNAME="Jane", CUS_LNAME="Doe", 
                    CUS_PHONE="432-123-9888", CUS_EMAIL="jdoe@123company.com", CUS_FR=false, CUS_TTS=true, CUS_MEZ=true, CUS_DEACTIVATED_COUNT=0},

                new Customer{CUS_ACCNUM="SFAF8272",CUS_COMPNAME="BCIT Construction", CUS_FNAME="Chris", CUS_LNAME="Adams", 
                    CUS_PHONE="563-854-7347", CUS_EMAIL="cadams@bcitcon.com", CUS_FR=false, CUS_TTS=false, CUS_MEZ=true, CUS_DEACTIVATED_COUNT=0},

                new Customer{CUS_ACCNUM="HEEW9188",CUS_COMPNAME="Farms Inc", CUS_FNAME="Taylor", CUS_LNAME="Klein", 
                    CUS_PHONE="323-381-5629", CUS_EMAIL="tklein@farmsinc.com", CUS_FR=true, CUS_TTS=false, CUS_MEZ=false, CUS_DEACTIVATED_COUNT=2}
            };

            foreach (Customer c in customers)
            {
                context.Customer.Add(c);
            }
            context.SaveChanges();


            var addressses = new Address[]
            {
                new Address{ADDR_STREET="238 King Street",ADDR_CITY="Vancouver",ADDR_PROV="BC", ADDR_POCODE="A1B1C1", CUS_ID=1},
                new Address{ADDR_STREET="58 Queen Street",ADDR_CITY="Burnaby",ADDR_PROV="BC", ADDR_POCODE="A2B4C1", CUS_ID=2},
                new Address{ADDR_STREET="1789 Jack Street",ADDR_CITY="Burnaby",ADDR_PROV="BC", ADDR_POCODE="A4B2C2", CUS_ID=3},
                new Address{ADDR_STREET="83 Tenth Avenue",ADDR_CITY="Vancouver",ADDR_PROV="BC", ADDR_POCODE="B8A3V2", CUS_ID=4},
                new Address{ADDR_STREET="392 Seventh Avenue",ADDR_CITY="Vancouver",ADDR_PROV="BC", ADDR_POCODE="A9D8N2", CUS_ID=5}
            };

            foreach (Address a in addressses)
            {
                context.Address.Add(a);
            }
            context.SaveChanges();


            var validations = new Validation[]
            {
                new Validation{VALID_IMPORT_CODE="DYP1", VALID_MATERIAL_NAME="Recycle Curbside - Terrace", VALID_IN_AND_OUT="In SA", 
                    VALID_AIRSPACE_OR_NONAIRSPACE="Non-ASC", VALID_FUNCTION="Curbside", VALID_FACILITY="DYP", VALID_MATERIAL_GROUP="Recycle",
                    VALID_CURBSIED_AREA="Terrace", VALID_CURBSIDE_STREAM="Recycle", VALID_SERVICE_AREA="Terrace & Area" },

                new Validation{VALID_IMPORT_CODE="F40", VALID_CODE=40, VALID_MATERIAL_NAME="C&D", VALID_IN_AND_OUT="In SA",
                    VALID_AIRSPACE_OR_NONAIRSPACE="ASC", VALID_FUNCTION="Transactions", VALID_FACILITY="FR", VALID_MATERIAL_GROUP="C&D",
                    VALID_FR_ANNUAL_REPORTING_GROUP="C&D", VALID_FR_ANNUAL_REPORT_WASTE_TYPE="Controlled Waste", VALID_SERVICE_AREA="Terrace & Area" },
                
                new Validation{VALID_IMPORT_CODE="F10", VALID_CODE=10, VALID_MATERIAL_NAME="Refuse", VALID_IN_AND_OUT="In SA",
                    VALID_AIRSPACE_OR_NONAIRSPACE="ASC", VALID_FUNCTION="Transactions", VALID_FACILITY="FR", VALID_MATERIAL_GROUP="Refuse",
                    VALID_FR_ANNUAL_REPORTING_GROUP="Refuse", VALID_FR_ANNUAL_REPORT_WASTE_TYPE="Non-Controlled Waste", VALID_SERVICE_AREA="Terrace & Area" },

                new Validation{VALID_IMPORT_CODE="HWMF10", VALID_CODE=10, VALID_MATERIAL_NAME="Garbage - Uncompacted", VALID_IN_AND_OUT="In SA",
                    VALID_AIRSPACE_OR_NONAIRSPACE="ASC", VALID_FUNCTION="Transactions", VALID_FACILITY="HWMF", VALID_MATERIAL_GROUP="Refuse",
                    VALID_SERVICE_AREA="Hazelton & Highway 37 North" },

                new Validation{VALID_IMPORT_CODE="HWMF11", VALID_CODE=10, VALID_MATERIAL_NAME="Garbage - Compacted", VALID_IN_AND_OUT="In SA",
                    VALID_AIRSPACE_OR_NONAIRSPACE="ASC", VALID_FUNCTION="Transactions", VALID_FACILITY="HWMF", VALID_MATERIAL_GROUP="Refuse",
                    VALID_SERVICE_AREA="Hazelton & Highway 37 North" },
            };

            foreach (Validation v in validations)
            {
                context.Validation.Add(v);
            }
            context.SaveChanges();


            var transactions = new Transaction[]
            {
                new Transaction{TRANS_NUM="TTS89002", LICENSE_PLATE="AB1234", TRANS_COMPLETION_DATE=new DateTime(2021, 10, 27, 2, 48, 00),
                    TRANS_COMPLETION_TIME=new DateTime(2021, 10, 27, 2, 48, 00), TRANS_LOAD_NUM=1, TRANS_NETWEIGHT=450.00F, TRANS_TOTALPRICE=49.50F,
                    TRANS_HAULER="The Yard", CUS_ID=1, VALID_IMPORT_CODE="F10", TRANS_OPERATION="Received", TRANS_STATUS="Complete", TRANS_ISMANUAL=false,
                    TRANS_HASEXCEPTION=false, TRANS_SOURCE_TYPE="Other Waste", TRANS_ADJUSTED_PRICE=49.50F, TRANS_FACILITY_CODE="TTS", TRANS_TONNES=0.45F,
                    TRANS_CUBIC_METERS=450.00F, TRANS_IN_SERVICE_AREA="In SA", TRANS_ASC_NON_ASC="ASC", TRANS_FUNCTION="Transactions", TRANS_CURBSIDE_AREA="0", 
                    TRANS_CURBSIDE_STREAM="0", TRANS_ANNUAL_REPORTING_GROUP="0", TRANS_ANNUAL_REPORTING_SOURCE="0", TRANS_SERVICE_AREA="Terrace & Area" },

                new Transaction{TRANS_NUM="TTS88505", LICENSE_PLATE="AB1234", TRANS_COMPLETION_DATE=new DateTime(2021, 10, 20, 12, 51, 00),
                    TRANS_COMPLETION_TIME=new DateTime(2021, 10, 20, 12, 51, 00), TRANS_LOAD_NUM=1, TRANS_NETWEIGHT=853.00F, TRANS_TOTALPRICE=91.85F,
                    TRANS_HAULER="The Yard", CUS_ID=1, VALID_IMPORT_CODE="F40", TRANS_OPERATION="Received", TRANS_STATUS="Complete", TRANS_ISMANUAL=false,
                    TRANS_HASEXCEPTION=false, TRANS_SOURCE_TYPE="Other Waste", TRANS_ADJUSTED_PRICE=91.85F, TRANS_FACILITY_CODE="TTS", TRANS_TONNES=0.84F,
                    TRANS_CUBIC_METERS=835.00F, TRANS_IN_SERVICE_AREA="In SA", TRANS_ASC_NON_ASC="ASC", TRANS_FUNCTION="Transactions", TRANS_CURBSIDE_AREA="0",
                    TRANS_CURBSIDE_STREAM="0", TRANS_ANNUAL_REPORTING_GROUP="0", TRANS_ANNUAL_REPORTING_SOURCE="0", TRANS_SERVICE_AREA="Terrace & Area" },

                new Transaction{TRANS_NUM="TTS88999", LICENSE_PLATE="BC1234", TRANS_COMPLETION_DATE=new DateTime(2021, 10, 26, 1, 45, 00),
                    TRANS_COMPLETION_TIME=new DateTime(2021, 10, 26, 1, 45, 00), TRANS_LOAD_NUM=1, TRANS_NETWEIGHT=2890.00F, TRANS_TOTALPRICE=0.00F,
                    TRANS_HAULER="Waste Services", CUS_ID=2, VALID_IMPORT_CODE="F10", TRANS_OPERATION="Received", TRANS_STATUS="Complete", TRANS_ISMANUAL=false,
                    TRANS_HASEXCEPTION=false, TRANS_SOURCE_TYPE="Other Waste", TRANS_ADJUSTED_PRICE=0.00F, TRANS_FACILITY_CODE="TTS", TRANS_TONNES=2.89F,
                    TRANS_CUBIC_METERS=2890.00F, TRANS_IN_SERVICE_AREA="In SA", TRANS_ASC_NON_ASC="ASC", TRANS_FUNCTION="Curbside", TRANS_CURBSIDE_AREA="RDKS",
                    TRANS_CURBSIDE_STREAM="Refuse", TRANS_ANNUAL_REPORTING_GROUP="0", TRANS_ANNUAL_REPORTING_SOURCE="0", TRANS_SERVICE_AREA="Terrace & Area" },

                new Transaction{TRANS_NUM="TTS89862", LICENSE_PLATE="BC1234", TRANS_COMPLETION_DATE=new DateTime(2021, 11, 8, 2, 59, 00),
                    TRANS_COMPLETION_TIME=new DateTime(2021, 11, 8, 2, 59, 00), TRANS_LOAD_NUM=1, TRANS_NETWEIGHT=3000.00F, TRANS_TOTALPRICE=0.00F,
                    TRANS_HAULER="Waste Services", CUS_ID=2, VALID_IMPORT_CODE="HWMF10", TRANS_OPERATION="Received", TRANS_STATUS="Complete", TRANS_ISMANUAL=false,
                    TRANS_HASEXCEPTION=false, TRANS_SOURCE_TYPE="Other Waste", TRANS_ADJUSTED_PRICE=0.00F, TRANS_FACILITY_CODE="TTS", TRANS_TONNES=2.89F,
                    TRANS_CUBIC_METERS=3000.00F, TRANS_IN_SERVICE_AREA="In SA", TRANS_ASC_NON_ASC="ASC", TRANS_FUNCTION="Curbside", TRANS_CURBSIDE_AREA="Kitsumkalum",
                    TRANS_CURBSIDE_STREAM="Refuse", TRANS_ANNUAL_REPORTING_GROUP="0", TRANS_ANNUAL_REPORTING_SOURCE="0", TRANS_SERVICE_AREA="Terrace & Area" },

                new Transaction{TRANS_NUM="TTS89935", LICENSE_PLATE="CD2356", TRANS_COMPLETION_DATE=new DateTime(2021, 11, 10, 2, 49, 00),
                    TRANS_COMPLETION_TIME=new DateTime(2021, 11, 10, 2, 49, 00), TRANS_LOAD_NUM=1, TRANS_NETWEIGHT=1030.00F, TRANS_TOTALPRICE=0.00F,
                    TRANS_HAULER="Waste Services", CUS_ID=3, VALID_IMPORT_CODE="HWMF10", TRANS_OPERATION="Received", TRANS_STATUS="Complete", TRANS_ISMANUAL=false,
                    TRANS_HASEXCEPTION=false, TRANS_SOURCE_TYPE="Other Waste", TRANS_ADJUSTED_PRICE=0.00F, TRANS_FACILITY_CODE="TTS", TRANS_TONNES=1.03F,
                    TRANS_CUBIC_METERS=1030.00F, TRANS_IN_SERVICE_AREA="In SA", TRANS_ASC_NON_ASC="Non-ASC", TRANS_FUNCTION="Curbside", TRANS_CURBSIDE_AREA="RDKS",
                    TRANS_CURBSIDE_STREAM="Organics", TRANS_ANNUAL_REPORTING_GROUP="0", TRANS_ANNUAL_REPORTING_SOURCE="0", TRANS_SERVICE_AREA="Terrace & Area" },
            };

            foreach (Transaction t in transactions)
            {
                context.Transaction.Add(t);
            }
            context.SaveChanges();

        }
    }
}
