using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Contact.API.Migrations
{
    public partial class InitialMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserContacts_AddressId",
                table: "UserContacts");

            migrationBuilder.CreateIndex(
                name: "IX_UserContacts_AddressId",
                table: "UserContacts",
                column: "AddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserContacts_AddressId",
                table: "UserContacts");

            migrationBuilder.CreateIndex(
                name: "IX_UserContacts_AddressId",
                table: "UserContacts",
                column: "AddressId",
                unique: true,
                filter: "[AddressId] IS NOT NULL");
        }
    }
}
