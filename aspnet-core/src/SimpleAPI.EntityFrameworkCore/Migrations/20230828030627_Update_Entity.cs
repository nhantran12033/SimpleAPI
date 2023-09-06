using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "AppItems",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "AppItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "AppItems",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "AppItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "AppItems",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "AppItems",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "AppExpenses",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "AppExpenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "AppExpenses",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "AppExpenses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "AppExpenses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "AppExpenses",
                type: "uniqueidentifier",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "AppItems");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "AppItems");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "AppItems");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "AppItems");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "AppItems");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "AppItems");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "AppExpenses");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "AppExpenses");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "AppExpenses");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "AppExpenses");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "AppExpenses");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "AppExpenses");
        }
    }
}
