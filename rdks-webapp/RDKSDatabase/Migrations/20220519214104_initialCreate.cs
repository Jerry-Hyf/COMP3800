using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RDKSDatabase.Migrations
{
    public partial class initialCreate : Migration
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ABCRecycling");
        }
    }
}
