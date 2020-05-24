using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Contoso.SurfaceTemperatureGuard.API.Data.Migrations
{
    public partial class User_BirthDate_Country : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Regions",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthdate",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Regions_ApplicationUserId",
                table: "Regions",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Regions_AspNetUsers_ApplicationUserId",
                table: "Regions",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regions_AspNetUsers_ApplicationUserId",
                table: "Regions");

            migrationBuilder.DropIndex(
                name: "IX_Regions_ApplicationUserId",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "Birthdate",
                table: "AspNetUsers");
        }
    }
}
