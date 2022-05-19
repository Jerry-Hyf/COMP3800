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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HWY37N_HAZELTON");
        }
    }
}
