using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class removeTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                schema: "identityTablesss",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                schema: "identityTablesss",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                schema: "identityTablesss",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                schema: "identityTablesss",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                schema: "identityTablesss",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                schema: "identityTablesss",
                table: "AspNetUsers");

            migrationBuilder.EnsureSchema(
                name: "identityTables");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                schema: "identityTablesss",
                newName: "AspNetUserTokens",
                newSchema: "identityTables");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                schema: "identityTablesss",
                newName: "AspNetUsers",
                newSchema: "identityTables");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                schema: "identityTablesss",
                newName: "AspNetUserRoles",
                newSchema: "identityTables");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                schema: "identityTablesss",
                newName: "AspNetUserLogins",
                newSchema: "identityTables");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                schema: "identityTablesss",
                newName: "AspNetUserClaims",
                newSchema: "identityTables");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                schema: "identityTablesss",
                newName: "AspNetRoles",
                newSchema: "identityTables");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                schema: "identityTablesss",
                newName: "AspNetRoleClaims",
                newSchema: "identityTables");

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                schema: "identityTables",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "identityTablesss");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                schema: "identityTables",
                newName: "AspNetUserTokens",
                newSchema: "identityTablesss");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                schema: "identityTables",
                newName: "AspNetUsers",
                newSchema: "identityTablesss");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                schema: "identityTables",
                newName: "AspNetUserRoles",
                newSchema: "identityTablesss");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                schema: "identityTables",
                newName: "AspNetUserLogins",
                newSchema: "identityTablesss");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                schema: "identityTables",
                newName: "AspNetUserClaims",
                newSchema: "identityTablesss");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                schema: "identityTables",
                newName: "AspNetRoles",
                newSchema: "identityTablesss");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                schema: "identityTables",
                newName: "AspNetRoleClaims",
                newSchema: "identityTablesss");

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                schema: "identityTablesss",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                schema: "identityTablesss",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                schema: "identityTablesss",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                schema: "identityTablesss",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                schema: "identityTablesss",
                table: "AspNetUsers",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                schema: "identityTablesss",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                schema: "identityTablesss",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
