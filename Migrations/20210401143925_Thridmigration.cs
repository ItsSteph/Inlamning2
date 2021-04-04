using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations
{
    public partial class Thridmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Customers_CustomersID",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_CustomersID",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "CustomersID",
                table: "Bookings");

            migrationBuilder.AddColumn<int>(
                name: "BookingsID",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_BookingsID",
                table: "Customers",
                column: "BookingsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Bookings_BookingsID",
                table: "Customers",
                column: "BookingsID",
                principalTable: "Bookings",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Bookings_BookingsID",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_BookingsID",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "BookingsID",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "CustomersID",
                table: "Bookings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CustomersID",
                table: "Bookings",
                column: "CustomersID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Customers_CustomersID",
                table: "Bookings",
                column: "CustomersID",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
