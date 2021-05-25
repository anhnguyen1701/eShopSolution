using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class aspnetcoreidentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRoleRoles",
                table: "AppRoleRoles");

            migrationBuilder.RenameTable(
                name: "AppRoleRoles",
                newName: "AppUserRole");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUserRole",
                table: "AppUserRole",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 0, 29, 59, 395, DateTimeKind.Local).AddTicks(5142));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUserRole",
                table: "AppUserRole");

            migrationBuilder.RenameTable(
                name: "AppUserRole",
                newName: "AppRoleRoles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppRoleRoles",
                table: "AppRoleRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 0, 14, 55, 762, DateTimeKind.Local).AddTicks(9012));
        }
    }
}
