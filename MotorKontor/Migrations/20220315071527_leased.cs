using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MotorKontor.Migrations
{
    public partial class leased : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Leased",
                table: "Registration");

            migrationBuilder.AddColumn<string>(
                name: "CustomerFullName",
                table: "Registration",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LeasedCreated",
                table: "Registration",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LeasedEnding",
                table: "Registration",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerFullName",
                table: "Registration");

            migrationBuilder.DropColumn(
                name: "LeasedCreated",
                table: "Registration");

            migrationBuilder.DropColumn(
                name: "LeasedEnding",
                table: "Registration");

            migrationBuilder.AddColumn<DateTime>(
                name: "Leased",
                table: "Registration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
