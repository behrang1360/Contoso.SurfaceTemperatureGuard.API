using Microsoft.EntityFrameworkCore.Migrations;

namespace Contoso.SurfaceTemperatureGuard.API.Data.Migrations
{
    public partial class add_region_toConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Configs");

            migrationBuilder.CreateIndex(
                name: "IX_Configs_RegionId",
                table: "Configs",
                column: "RegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Configs_Regions_RegionId",
                table: "Configs",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Configs_Regions_RegionId",
                table: "Configs");

            migrationBuilder.DropIndex(
                name: "IX_Configs_RegionId",
                table: "Configs");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Configs",
                nullable: false,
                defaultValue: 0);
        }
    }
}
