using Microsoft.EntityFrameworkCore.Migrations;

namespace Repositories.Migrations
{
    public partial class FeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "HolidayHomesOwners",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 1, "Fabricio", "Vallasciani" });

            migrationBuilder.InsertData(
                table: "HolidayHomesOwners",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 2, "Susana", "Marcos" });

            migrationBuilder.InsertData(
                table: "HolidayHomes",
                columns: new[] { "Id", "Address", "OwnerId" },
                values: new object[] { 1, "Santa Fe 1291", 1 });

            migrationBuilder.InsertData(
                table: "HolidayHomes",
                columns: new[] { "Id", "Address", "OwnerId" },
                values: new object[] { 2, "Salamanca 13", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HolidayHomes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HolidayHomes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HolidayHomesOwners",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HolidayHomesOwners",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
