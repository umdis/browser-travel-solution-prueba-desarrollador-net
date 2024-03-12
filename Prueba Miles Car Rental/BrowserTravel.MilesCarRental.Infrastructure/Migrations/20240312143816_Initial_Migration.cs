using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BrowserTravel.MilesCarRental.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial_Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    State = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LicensePlate = table.Column<string>(type: "TEXT", maxLength: 6, nullable: false),
                    Model = table.Column<string>(type: "TEXT", maxLength: 4, nullable: false),
                    Reference = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    State = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdPickupLocatity = table.Column<int>(type: "INTEGER", nullable: false),
                    IdReturnLocatity = table.Column<int>(type: "INTEGER", nullable: false),
                    IdVehicle = table.Column<int>(type: "INTEGER", nullable: false),
                    State = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rents_Locations_IdPickupLocatity",
                        column: x => x.IdPickupLocatity,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rents_Locations_IdReturnLocatity",
                        column: x => x.IdReturnLocatity,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rents_Vehicles_IdVehicle",
                        column: x => x.IdVehicle,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name", "State" },
                values: new object[,]
                {
                    { 1, "FONTIBON", true },
                    { 2, "CIUDAD BOLIVAR", true },
                    { 3, "SUBA", true },
                    { 4, "RAFAEL URIBE URIBE", true },
                    { 5, "KENNEDY", true },
                    { 6, "USME", true },
                    { 7, "LOS MARTIRES", true },
                    { 8, "BARRIOS UNIDOS", true },
                    { 9, "ENGATIVA", true },
                    { 10, "CANDELARIA", true },
                    { 11, "CHAPINERO", true },
                    { 12, "ANTONIO NARIÑO", true },
                    { 13, "TEUSAQUILLO", true },
                    { 14, "SUMAPAZ", true },
                    { 15, "SAN CRISTOBAL", true },
                    { 16, "USAQUEN", true },
                    { 17, "TUNJUELITO", true },
                    { 18, "BOSA", true },
                    { 19, "PUENTE ARANDA", true }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "LicensePlate", "Model", "Reference", "State" },
                values: new object[,]
                {
                    { 1, "ABC123", "2020", "Toyota Camry", true },
                    { 2, "XYZ789", "2019", "Honda Civic", true },
                    { 3, "DEF456", "2021", "Ford F-150", true },
                    { 4, "GHI789", "2018", "Chevrolet Silverado", true },
                    { 5, "JKL321", "2022", "Tesla Model S", true },
                    { 6, "MNO654", "2017", "Jeep Wrangler", true },
                    { 7, "PQR987", "2020", "Subaru Outback", true },
                    { 8, "STU654", "2019", "Nissan Altima", true },
                    { 9, "VWX321", "2021", "BMW 3 Series", true },
                    { 10, "YZA987", "2018", "Audi A4", true },
                    { 11, "BCD654", "2017", "Mercedes-Benz C-Class", true },
                    { 12, "EFG321", "2020", "Toyota Corolla", true },
                    { 13, "HIJ987", "2019", "Honda Accord", true },
                    { 14, "KLM654", "2021", "Ford Mustang", true },
                    { 15, "NOP321", "2018", "Chevrolet Camaro", true },
                    { 16, "QRS987", "2022", "Tesla Model 3", true },
                    { 17, "TUV654", "2017", "Jeep Grand Cherokee", true },
                    { 18, "VWX321", "2020", "Subaru Forester", true },
                    { 19, "YZA987", "2019", "Nissan Rogue", true },
                    { 20, "BCD654", "2021", "Toyota Highlander", true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rents_IdPickupLocatity",
                table: "Rents",
                column: "IdPickupLocatity");

            migrationBuilder.CreateIndex(
                name: "IX_Rents_IdReturnLocatity",
                table: "Rents",
                column: "IdReturnLocatity");

            migrationBuilder.CreateIndex(
                name: "IX_Rents_IdVehicle",
                table: "Rents",
                column: "IdVehicle");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rents");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
