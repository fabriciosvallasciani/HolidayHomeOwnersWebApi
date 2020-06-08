using Microsoft.EntityFrameworkCore.Migrations;

namespace Repositories.Migrations.HolidayHomesOwners
{
    public partial class InitialHomesOwners : Migration
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
                    Description = table.Column<string>(nullable: false),
                    Bedrooms = table.Column<byte>(nullable: false),
                    LivingArea = table.Column<long>(nullable: false),
                    HasWiFi = table.Column<bool>(nullable: false),
                    Sleeps = table.Column<byte>(nullable: false),
                    TerraceArea = table.Column<long>(nullable: false),
                    HasBalcony = table.Column<bool>(nullable: false),
                    Bathrooms = table.Column<byte>(nullable: false),
                    GardenArea = table.Column<long>(nullable: false),
                    HasPatio = table.Column<bool>(nullable: false),
                    DistanceToAirport = table.Column<byte>(nullable: false),
                    DistanceToBeach = table.Column<byte>(nullable: false),
                    DistanceToShopping = table.Column<byte>(nullable: false),
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

            migrationBuilder.CreateTable(
                name: "HolidayHomeImage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    HolidayHomeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HolidayHomeImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HolidayHomeImage_HolidayHomes_HolidayHomeId",
                        column: x => x.HolidayHomeId,
                        principalTable: "HolidayHomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "HolidayHomesOwners",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 1, "Fabricio", "Vallasciani" });

            migrationBuilder.InsertData(
                table: "HolidayHomesOwners",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 2, "Susana", "Marcos" });

            migrationBuilder.InsertData(
                table: "HolidayHomesOwners",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 3, "Peter", "Petrelli" });

            migrationBuilder.InsertData(
                table: "HolidayHomes",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Description", "DistanceToAirport", "DistanceToBeach", "DistanceToShopping", "GardenArea", "HasBalcony", "HasPatio", "HasWiFi", "LivingArea", "OwnerId", "Sleeps", "TerraceArea" },
                values: new object[] { 1, (byte)2, (byte)3, "Santa Fe 1291", (byte)12, (byte)60, (byte)2, 70L, false, true, true, 20L, 1, (byte)5, 0L });

            migrationBuilder.InsertData(
                table: "HolidayHomes",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Description", "DistanceToAirport", "DistanceToBeach", "DistanceToShopping", "GardenArea", "HasBalcony", "HasPatio", "HasWiFi", "LivingArea", "OwnerId", "Sleeps", "TerraceArea" },
                values: new object[] { 2, (byte)3, (byte)4, "Avenida Siempre Viva 1234", (byte)15, (byte)10, (byte)3, 50L, true, true, true, 40L, 1, (byte)4, 30L });

            migrationBuilder.InsertData(
                table: "HolidayHomes",
                columns: new[] { "Id", "Bathrooms", "Bedrooms", "Description", "DistanceToAirport", "DistanceToBeach", "DistanceToShopping", "GardenArea", "HasBalcony", "HasPatio", "HasWiFi", "LivingArea", "OwnerId", "Sleeps", "TerraceArea" },
                values: new object[] { 3, (byte)1, (byte)5, "Calle Salamanca 13", (byte)50, (byte)70, (byte)8, 0L, true, false, true, 10L, 1, (byte)5, 10L });

            migrationBuilder.InsertData(
                table: "HolidayHomeImage",
                columns: new[] { "Id", "Description", "HolidayHomeId", "Url" },
                values: new object[,]
                {
                    { 1, "1", 1, "//d1ez3020z2uu9b.cloudfront.net/imagecache/rental-homes-photos-spain/Original/55424/9700320-55424-L%27Estartit-Apartment_Crop_450_337.jpg" },
                    { 2, "2", 1, "//d1ez3020z2uu9b.cloudfront.net/imagecache/rental-homes-photos-spain/Original/55424/9700325-55424-L'Estartit-Apartment_Crop_450_337.jpg" },
                    { 3, "3", 1, "//d1ez3020z2uu9b.cloudfront.net/imagecache/rental-homes-photos-spain/Original/55424/9700326-55424-L'Estartit-Apartment_Crop_450_337.jpg" },
                    { 4, "4", 2, "//d1ez3020z2uu9b.cloudfront.net/imagecache/rental-homes-photos-spain/Original/30984/5704854-30984-Roses-Apartment_Crop_450_337.jpg" },
                    { 5, "5", 2, "//d1ez3020z2uu9b.cloudfront.net/imagecache/rental-homes-photos-spain/Original/30984/5807028-30984-Roses-Apartment_Crop_450_337.jpg" },
                    { 6, "6", 2, "//d1ez3020z2uu9b.cloudfront.net/imagecache/rental-homes-photos-spain/Original/30984/5798711-30984-Roses-Apartment_Crop_450_337.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HolidayHomeImage_HolidayHomeId",
                table: "HolidayHomeImage",
                column: "HolidayHomeId");

            migrationBuilder.CreateIndex(
                name: "IX_HolidayHomes_OwnerId",
                table: "HolidayHomes",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HolidayHomeImage");

            migrationBuilder.DropTable(
                name: "HolidayHomes");

            migrationBuilder.DropTable(
                name: "HolidayHomesOwners");
        }
    }
}
