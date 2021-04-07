using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bikes",
                columns: table => new
                {
                    BikeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bikes", x => x.BikeId);
                });

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
                table: "Bikes",
                columns: new[] { "BikeId", "Currency", "Model", "Price" },
                values: new object[,]
                {
                    { 1, "SEK", "Community S", 300 },
                    { 2, "SEK", "Women's Cruiser", 375 },
                    { 3, "SEK", "City Classic", 300 },
                    { 4, "SEK", "Speed Roller+", 300 },
                    { 5, "SEK", "Racing", 450 },
                    { 6, "SEK", "Urban City Commuter", 300 }
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
                table: "Bookings",
                columns: new[] { "BookingId", "BikeId", "CustomerId", "Duration", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, "1 DAY", 1 },
                    { 2, 1, 1, "1 DAY", 1 },
                    { 5, 1, 2, "1 DAY", 1 },
                    { 3, 3, 6, "1 DAY", 1 },
                    { 4, 2, 7, "1 DAY", 1 },
                    { 6, 5, 9, "1 DAY", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_BikeId",
                table: "Bookings",
                column: "BikeId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CustomerId",
                table: "Bookings",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Bikes");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
