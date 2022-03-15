using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MotorKontor.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Registration_RegistrationID",
                table: "Vehicle");

            migrationBuilder.DropIndex(
                name: "IX_Vehicle_RegistrationID",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "RegistrationID",
                table: "Vehicle");

            migrationBuilder.AddColumn<DateTime>(
                name: "Leased",
                table: "Registration",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Leased",
                table: "Registration");

            migrationBuilder.AddColumn<int>(
                name: "RegistrationID",
                table: "Vehicle",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_RegistrationID",
                table: "Vehicle",
                column: "RegistrationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Registration_RegistrationID",
                table: "Vehicle",
                column: "RegistrationID",
                principalTable: "Registration",
                principalColumn: "RegistrationID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
