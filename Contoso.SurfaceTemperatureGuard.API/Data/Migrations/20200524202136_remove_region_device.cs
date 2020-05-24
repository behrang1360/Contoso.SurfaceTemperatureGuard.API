using Microsoft.EntityFrameworkCore.Migrations;

namespace Contoso.SurfaceTemperatureGuard.API.Data.Migrations
{
    public partial class remove_region_device : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegionDevices");

            migrationBuilder.AddColumn<int>(
                name: "RegionId",
                table: "Devices",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Devices_RegionId",
                table: "Devices",
                column: "RegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Regions_RegionId",
                table: "Devices",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Regions_RegionId",
                table: "Devices");

            migrationBuilder.DropIndex(
                name: "IX_Devices_RegionId",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "RegionId",
                table: "Devices");

            migrationBuilder.CreateTable(
                name: "RegionDevices",
                columns: table => new
                {
                    RegionId = table.Column<int>(nullable: false),
                    DeviceId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegionDevices", x => new { x.RegionId, x.DeviceId });
                    table.ForeignKey(
                        name: "FK_RegionDevices_Devices_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegionDevices_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RegionDevices_DeviceId",
                table: "RegionDevices",
                column: "DeviceId");
        }
    }
}
