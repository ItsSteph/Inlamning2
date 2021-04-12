using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Manufacture",
                columns: table => new
                {
                    ManufactureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManufactureName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacture", x => x.ManufactureId);
                });

            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    BrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufactureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.BrandId);
                    table.ForeignKey(
                        name: "FK_Brand_Manufacture_ManufactureId",
                        column: x => x.ManufactureId,
                        principalTable: "Manufacture",
                        principalColumn: "ManufactureId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bikes",
                columns: table => new
                {
                    BikeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bikes", x => x.BikeId);
                    table.ForeignKey(
                        name: "FK_Bikes_Brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brand",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    BikeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.BookingId);
                    table.ForeignKey(
                        name: "FK_Bookings_Bikes_BikeId",
                        column: x => x.BikeId,
                        principalTable: "Bikes",
                        principalColumn: "BikeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "EmailAddress", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "jonse@hotmail.com", "Anna", "Johnson", 123456789 },
                    { 2, "eivindarbast@ingemann.se", "Eivind", "Ingemann", 123456789 },
                    { 3, "magdalena.nilson@hotmail.com", "Magdalena", "Nilson", 123456789 },
                    { 4, "herman.nilson@hotmail.com", "Herman", "Nilson", 123456789 },
                    { 5, "gullwijose@gmail.com", "Gullwi", "Josefsson", 123456789 },
                    { 6, "masterdetectiv@protonmail.com", "Kalle", "Blomqvist", 123456789 },
                    { 7, "hernandez.julia@yahoo.com", "Julia", "Hernandéz", 123456789 },
                    { 8, "felixfelicis@gmail.com", "Felix", "Ingvarsson", 123456789 },
                    { 9, "olsongänget@gmail.com", "Matts", "Olson", 123456789 },
                    { 10, "Linda@Nyberg.se", "Linda", "Nyberg", 123456789 }
                });

            migrationBuilder.InsertData(
                table: "Manufacture",
                columns: new[] { "ManufactureId", "ManufactureName" },
                values: new object[,]
                {
                    { 1, "Biltema" },
                    { 2, "Huffy" },
                    { 3, "Kildemose" }
                });

            migrationBuilder.InsertData(
                table: "Brand",
                columns: new[] { "BrandId", "BrandName", "ManufactureId" },
                values: new object[] { 1, "Yosemity", 1 });

            migrationBuilder.InsertData(
                table: "Brand",
                columns: new[] { "BrandId", "BrandName", "ManufactureId" },
                values: new object[] { 2, "Nassau", 2 });

            migrationBuilder.InsertData(
                table: "Brand",
                columns: new[] { "BrandId", "BrandName", "ManufactureId" },
                values: new object[] { 3, "Kildemose", 3 });

            migrationBuilder.InsertData(
                table: "Bikes",
                columns: new[] { "BikeId", "BrandId", "Currency", "Model", "Price" },
                values: new object[,]
                {
                    { 1, 1, "SEK", "Community S", 300 },
                    { 6, 1, "SEK", "Urban City Commuter", 300 },
                    { 2, 2, "SEK", "Women's Cruiser", 375 },
                    { 4, 2, "SEK", "Speed Roller+", 300 },
                    { 3, 3, "SEK", "City Classic", 300 },
                    { 5, 3, "SEK", "Street 687", 450 }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "BookingId", "BikeId", "CustomerId", "Duration", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, "1 DAY", 1 },
                    { 2, 1, 1, "1 DAY", 1 },
                    { 5, 1, 2, "1 DAY", 1 },
                    { 4, 2, 7, "1 DAY", 1 },
                    { 3, 3, 6, "1 DAY", 1 },
                    { 6, 5, 9, "1 DAY", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bikes_BrandId",
                table: "Bikes",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_BikeId",
                table: "Bookings",
                column: "BikeId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CustomerId",
                table: "Bookings",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Brand_ManufactureId",
                table: "Brand",
                column: "ManufactureId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Bikes");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "Manufacture");
        }
    }
}
