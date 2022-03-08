using Microsoft.EntityFrameworkCore.Migrations;

namespace MotorKontor.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customor_Address_UserAddressID",
                table: "Customor");

            migrationBuilder.DropForeignKey(
                name: "FK_Registration_Customor_CustomerID",
                table: "Registration");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customor",
                table: "Customor");

            migrationBuilder.RenameTable(
                name: "Customor",
                newName: "Customer");

            migrationBuilder.RenameIndex(
                name: "IX_Customor_UserAddressID",
                table: "Customer",
                newName: "IX_Customer_UserAddressID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Address_UserAddressID",
                table: "Customer",
                column: "UserAddressID",
                principalTable: "Address",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Registration_Customer_CustomerID",
                table: "Registration",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Address_UserAddressID",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Registration_Customer_CustomerID",
                table: "Registration");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customor");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_UserAddressID",
                table: "Customor",
                newName: "IX_Customor_UserAddressID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customor",
                table: "Customor",
                column: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customor_Address_UserAddressID",
                table: "Customor",
                column: "UserAddressID",
                principalTable: "Address",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Registration_Customor_CustomerID",
                table: "Registration",
                column: "CustomerID",
                principalTable: "Customor",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
