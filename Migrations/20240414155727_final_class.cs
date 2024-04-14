using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eco_Tanger.Migrations
{
    /// <inheritdoc />
    public partial class final_class : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Citizens_AspNetUsers_UserId",
                table: "Citizens");

            migrationBuilder.DropIndex(
                name: "IX_Citizens_UserId",
                table: "Citizens");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Citizens");

            migrationBuilder.RenameColumn(
                name: "CitizenId",
                table: "Citizens",
                newName: "UserName");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Citizens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Citizens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Citizens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Citizens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Citizens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Citizens",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Citizens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Citizens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Citizens",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Citizens",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Citizens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Citizens",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Citizens",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Citizens",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Citizens",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Citizens",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Citizens",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Citizens",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Citizens",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "Citizens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Citizens",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Citizens",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Citizens");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Citizens");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Citizens");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Citizens");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Citizens");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Citizens");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Citizens");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Citizens");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Citizens");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Citizens");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Citizens");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Citizens");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Citizens");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Citizens");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Citizens");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Citizens");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Citizens");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "Citizens");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Citizens");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Citizens");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Citizens",
                newName: "CitizenId");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Citizens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Citizens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Citizens",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Citizens_UserId",
                table: "Citizens",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Citizens_AspNetUsers_UserId",
                table: "Citizens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
