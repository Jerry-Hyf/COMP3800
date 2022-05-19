using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RDKSDatabase.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicle");
        }
    }
}
