using Microsoft.EntityFrameworkCore.Migrations;

namespace Repositories.Migrations
{
    public partial class HolidayHomesOwnersDbInitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HolidayHomesOwners",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HolidayHomesOwners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HolidayHomes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(nullable: false),
                    OwnerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HolidayHomes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HolidayHomes_HolidayHomesOwners_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "HolidayHomesOwners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HolidayHomes_OwnerId",
                table: "HolidayHomes",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HolidayHomes");

            migrationBuilder.DropTable(
                name: "HolidayHomesOwners");
        }
    }
}
