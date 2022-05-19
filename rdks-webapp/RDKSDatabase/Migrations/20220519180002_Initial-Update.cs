using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RDKSDatabase.Migrations
{
    public partial class InitialUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_Address_CustomerCUS_ID",
                table: "Address",
                column: "CustomerCUS_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
