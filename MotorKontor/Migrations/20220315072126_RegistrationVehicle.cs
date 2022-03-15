using Microsoft.EntityFrameworkCore.Migrations;

namespace MotorKontor.Migrations
{
    public partial class RegistrationVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registration_Customer_CustomerID",
                table: "Registration");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "Registration",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Registration_VehicleID",
                table: "Registration",
                column: "VehicleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Registration_Customer_CustomerID",
                table: "Registration",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Registration_Vehicle_VehicleID",
                table: "Registration",
                column: "VehicleID",
                principalTable: "Vehicle",
                principalColumn: "VehicleID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registration_Customer_CustomerID",
                table: "Registration");

            migrationBuilder.DropForeignKey(
                name: "FK_Registration_Vehicle_VehicleID",
                table: "Registration");

            migrationBuilder.DropIndex(
                name: "IX_Registration_VehicleID",
                table: "Registration");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "Registration",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Registration_Customer_CustomerID",
                table: "Registration",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
