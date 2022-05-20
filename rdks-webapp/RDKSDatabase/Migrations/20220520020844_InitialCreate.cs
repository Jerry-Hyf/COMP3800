using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RDKSDatabase.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ABCRecycling",
                columns: table => new
                {
                    ABCDateID = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ABC_LOCATION = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ABC_MATERIAL = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ABC_NET_WEIGHT_IN_POUND = table.Column<float>(type: "real", nullable: false),
                    ABC_TOTAL_NET_WEIGHT_IN_TONNAGE = table.Column<float>(type: "real", nullable: false),
                    ABC_TOTAL_METRIC_TON = table.Column<float>(type: "real", nullable: false),
                    ABC_COMPLETED = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ABCRecycling", x => x.ABCDateID);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CUS_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CUS_ACCNUM = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    CUS_COMPNAME = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CUS_FNAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CUS_LNAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CUS_PHONE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CUS_ALT_PHONE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CUS_EMAIL = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CUS_ALT_EMAIL = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CUS_ADDRESS = table.Column<int>(type: "int", nullable: false),
                    CUS_ALT_ADDRESS = table.Column<int>(type: "int", nullable: false),
                    CUS_FR = table.Column<bool>(type: "bit", nullable: false),
                    CUS_TTS = table.Column<bool>(type: "bit", nullable: false),
                    CUS_MEZ = table.Column<bool>(type: "bit", nullable: false),
                    CUS_DEACTIVATED_COUNT = table.Column<int>(type: "int", nullable: false),
                    CUS_NOTE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CUS_ID);
                });

            migrationBuilder.CreateTable(
                name: "HWY37N_HAZELTON",
                columns: table => new
                {
                    HWY_HAZ_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HWY_HAZ_EST_OCC_TONNES = table.Column<float>(type: "real", nullable: true),
                    HWY_HAZ_OCC_BIN_BILLING = table.Column<float>(type: "real", nullable: true),
                    HWY_HAZ_SCRAP_METAL_TONNES = table.Column<float>(type: "real", nullable: true),
                    HWY_HAZ_TIRE_COUNTS = table.Column<float>(type: "real", nullable: true),
                    HWY_HAZ_TIRE_COLLECTION_CHARGES = table.Column<float>(type: "real", nullable: true),
                    HWY_HAZ_FREON_REMOVAL_CHARGES = table.Column<float>(type: "real", nullable: true),
                    HWY_HAZ_MARR_INCOME = table.Column<float>(type: "real", nullable: true),
                    HWY_HAZ_ABC_INCOME = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HWY37N_HAZELTON", x => x.HWY_HAZ_DATE);
                });

            migrationBuilder.CreateTable(
                name: "HWY37N_KITWANGA",
                columns: table => new
                {
                    HWY_KIT_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HWY_KIT_OCC_TONNAGE_EST = table.Column<float>(type: "real", nullable: true),
                    HWY_KIT_PPP_TONNAGE = table.Column<float>(type: "real", nullable: true),
                    HWY_KIT_OCC_HAULING_BIN_RENTAL = table.Column<float>(type: "real", nullable: true),
                    HWY_KIT_PPP_HAULING = table.Column<float>(type: "real", nullable: true),
                    HWY_KIT_RECYCLE_BC_TONNAGE = table.Column<float>(type: "real", nullable: true),
                    HWY_KIT_CESA_TONNES = table.Column<float>(type: "real", nullable: true),
                    HWY_KIT_EPRA_TONNES = table.Column<float>(type: "real", nullable: true),
                    HWY_KIT_LIGHT_RECYCLE_COUNTS = table.Column<float>(type: "real", nullable: true),
                    HWY_KIT_PAINT_RECYCLE_COUNTS = table.Column<float>(type: "real", nullable: true),
                    HWY_KIT_SCRAP_METAL_MARR_INCLUDED = table.Column<float>(type: "real", nullable: true),
                    HWY_KIT_LAB_TONNES = table.Column<float>(type: "real", nullable: true),
                    HWY_KIT_TIRE_COUNTS = table.Column<float>(type: "real", nullable: true),
                    HWY_KIT_TIRE_CHARGES = table.Column<float>(type: "real", nullable: true),
                    HWY_KIT_FREON_REMOVAL_CHARGES = table.Column<float>(type: "real", nullable: true),
                    HWY_KIT_RECYCLE_BC_INCOME = table.Column<float>(type: "real", nullable: true),
                    HWY_KIT_CESA_INCOME = table.Column<float>(type: "real", nullable: true),
                    HWY_KIT_EPRA_INCOME = table.Column<float>(type: "real", nullable: true),
                    HWY_KIT_LIGHT_RECYCLE_INCOME = table.Column<float>(type: "real", nullable: true),
                    HWY_KIT_PAINT_RECYCLE_INCOME = table.Column<float>(type: "real", nullable: true),
                    HWY_KIT_MARR_INCOME = table.Column<float>(type: "real", nullable: true),
                    HWY_KIT_LAB_INCOME = table.Column<float>(type: "real", nullable: true),
                    HWY_KIT_TOTAL_TONNES_EPR = table.Column<float>(type: "real", nullable: true),
                    HWY_KIT_NET_INCOME = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HWY37N_KITWANGA", x => x.HWY_KIT_DATE);
                });

            migrationBuilder.CreateTable(
                name: "HWY37N_STEWART",
                columns: table => new
                {
                    HWY_STE_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HWY_STE_OCC_TONNES = table.Column<float>(type: "real", nullable: true),
                    HWY_STE_BANDSTRA_OCC_HAULING = table.Column<float>(type: "real", nullable: true),
                    HWY_STE_OCC_TOTAL = table.Column<float>(type: "real", nullable: true),
                    HWY_STE_RECYCLE_BC_TONNAGE = table.Column<float>(type: "real", nullable: true),
                    HWY_STE_CESA_TONNES = table.Column<float>(type: "real", nullable: true),
                    HWY_STE_EPRA_TONNES = table.Column<float>(type: "real", nullable: true),
                    HWY_STE_LIGHT_RECYCLE_COUNTS = table.Column<float>(type: "real", nullable: true),
                    HWY_STE_PAINT_RECYCLE_COUNTS = table.Column<float>(type: "real", nullable: true),
                    HWY_STE_SCRAP_METAL_MARR_TONNE_EST = table.Column<float>(type: "real", nullable: true),
                    HWY_STE_LAB_TONNES = table.Column<float>(type: "real", nullable: true),
                    HWY_STE_TIRE_COUNTS = table.Column<float>(type: "real", nullable: true),
                    HWY_STE_TIRE_CHARGES = table.Column<float>(type: "real", nullable: true),
                    HWY_STE_FREON_REMOVAL_CHARGES = table.Column<float>(type: "real", nullable: true),
                    HWY_STE_RECYCLE_BC_INCOME = table.Column<float>(type: "real", nullable: true),
                    HWY_STE_CESA_INCOME = table.Column<float>(type: "real", nullable: true),
                    HWY_STE_EPRA_INCOME = table.Column<float>(type: "real", nullable: true),
                    HWY_STE_LIGHT_RECYCLE_INCOME = table.Column<float>(type: "real", nullable: true),
                    HWY_STE_RECYCLE_INCOME = table.Column<float>(type: "real", nullable: true),
                    HWY_STE_MARR_INCOME = table.Column<float>(type: "real", nullable: true),
                    HWY_STE_LAB_INCOME = table.Column<float>(type: "real", nullable: true),
                    HWY_STE_TOTAL_TONNES_EPR = table.Column<float>(type: "real", nullable: true),
                    HWY_STE_NET_INCOME = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HWY37N_STEWART", x => x.HWY_STE_DATE);
                });

            migrationBuilder.CreateTable(
                name: "Material",
                columns: table => new
                {
                    MaterialCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => x.MaterialCode);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    LICENSE_PLATE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CUS_ID = table.Column<int>(type: "int", nullable: false),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BADGE = table.Column<int>(type: "int", nullable: false),
                    NOTES = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOTES_2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.LICENSE_PLATE);
                });

            migrationBuilder.CreateTable(
                name: "WasteSource",
                columns: table => new
                {
                    WasteGenerator = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WasteSourceSiteAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WasteSource", x => x.WasteGenerator);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    ADDR_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADDR_STREET = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ADDR_CITY = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    ADDR_PROV = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    ADDR_POCODE = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    CustomerCUS_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.ADDR_ID);
                    table.ForeignKey(
                        name: "FK_Address_Customer_CustomerCUS_ID",
                        column: x => x.CustomerCUS_ID,
                        principalTable: "Customer",
                        principalColumn: "CUS_ID");
                });

            migrationBuilder.CreateTable(
                name: "Permit",
                columns: table => new
                {
                    PermitNumberPrefix = table.Column<int>(type: "int", nullable: false),
                    PermitNumber = table.Column<int>(type: "int", nullable: false),
                    facilityCode = table.Column<int>(type: "int", nullable: false),
                    PermitApplicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstimatedVolume = table.Column<float>(type: "real", nullable: false),
                    units = table.Column<int>(type: "int", nullable: true),
                    EstimatedLoads = table.Column<int>(type: "int", nullable: false),
                    frequency = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContaminateLoadsDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContaminateLoadsComments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contaminatedLoads = table.Column<int>(type: "int", nullable: false),
                    permitSentToOperatorAndWMF = table.Column<int>(type: "int", nullable: true),
                    permitSavedOnServerAndFiled = table.Column<int>(type: "int", nullable: true),
                    hardCopyPermitSavedInFile = table.Column<int>(type: "int", nullable: false),
                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermitClosedCardPermissionsRevolked = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    permitStatus = table.Column<int>(type: "int", nullable: false),
                    PermitType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermitFee = table.Column<float>(type: "real", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    applicationFeeInvoiced = table.Column<int>(type: "int", nullable: false),
                    ApplicantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicantPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicantEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hauler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hauler2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerID = table.Column<int>(name: "Customer ID", type: "int", nullable: false),
                    CustomerCUS_ID = table.Column<int>(type: "int", nullable: false),
                    WasteGenerator = table.Column<string>(name: "Waste Generator", type: "nvarchar(max)", nullable: false),
                    WasteSourceWasteGenerator = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaterialCode = table.Column<int>(name: "Material Code", type: "int", nullable: false),
                    MaterialCode1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permit", x => new { x.PermitNumberPrefix, x.PermitNumber });
                    table.ForeignKey(
                        name: "FK_Permit_Customer_CustomerCUS_ID",
                        column: x => x.CustomerCUS_ID,
                        principalTable: "Customer",
                        principalColumn: "CUS_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Permit_Material_MaterialCode1",
                        column: x => x.MaterialCode1,
                        principalTable: "Material",
                        principalColumn: "MaterialCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Permit_WasteSource_WasteSourceWasteGenerator",
                        column: x => x.WasteSourceWasteGenerator,
                        principalTable: "WasteSource",
                        principalColumn: "WasteGenerator",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_CustomerCUS_ID",
                table: "Address",
                column: "CustomerCUS_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Permit_CustomerCUS_ID",
                table: "Permit",
                column: "CustomerCUS_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Permit_MaterialCode1",
                table: "Permit",
                column: "MaterialCode1");

            migrationBuilder.CreateIndex(
                name: "IX_Permit_WasteSourceWasteGenerator",
                table: "Permit",
                column: "WasteSourceWasteGenerator");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ABCRecycling");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "HWY37N_HAZELTON");

            migrationBuilder.DropTable(
                name: "HWY37N_KITWANGA");

            migrationBuilder.DropTable(
                name: "HWY37N_STEWART");

            migrationBuilder.DropTable(
                name: "Permit");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Material");

            migrationBuilder.DropTable(
                name: "WasteSource");
        }
    }
}
