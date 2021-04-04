using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations
{
    public partial class newmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bikes_Bookings_BookingsID",
                table: "Bikes");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Bookings_BookingsID",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_BookingsID",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Bikes_BookingsID",
                table: "Bikes");

            migrationBuilder.DropColumn(
                name: "BookingsID",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "BookingsID",
                table: "Bikes");

            migrationBuilder.AddColumn<int>(
                name: "BookingID",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BikeID",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BikesID",
                table: "Bookings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomersID",
                table: "Bookings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_BikesID",
                table: "Bookings",
                column: "BikesID");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CustomersID",
                table: "Bookings",
                column: "CustomersID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Bikes_BikesID",
                table: "Bookings",
                column: "BikesID",
                principalTable: "Bikes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Customers_CustomersID",
                table: "Bookings",
                column: "CustomersID",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Bikes_BikesID",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Customers_CustomersID",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_BikesID",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_CustomersID",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "BookingID",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "BikeID",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "BikesID",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "CustomersID",
                table: "Bookings");

            migrationBuilder.AddColumn<int>(
                name: "BookingsID",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookingsID",
                table: "Bikes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_BookingsID",
                table: "Customers",
                column: "BookingsID");

            migrationBuilder.CreateIndex(
                name: "IX_Bikes_BookingsID",
                table: "Bikes",
                column: "BookingsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bikes_Bookings_BookingsID",
                table: "Bikes",
                column: "BookingsID",
                principalTable: "Bookings",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Bookings_BookingsID",
                table: "Customers",
                column: "BookingsID",
                principalTable: "Bookings",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
