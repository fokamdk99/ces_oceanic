using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OceanicSearchEngine.Data.Migrations.Migrations
{
    public partial class ExpandEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParcelToCities_Cities_CityId",
                schema: "oceanic",
                table: "ParcelToCities");

            migrationBuilder.DropIndex(
                name: "IX_ParcelToCities_CityId",
                schema: "oceanic",
                table: "ParcelToCities");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                schema: "oceanic",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Role",
                schema: "oceanic",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "DestinationId",
                schema: "oceanic",
                table: "Routes",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "OriginId",
                schema: "oceanic",
                table: "Routes",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                schema: "oceanic",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Password",
                value: "abc123");

            migrationBuilder.UpdateData(
                schema: "oceanic",
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Password",
                value: "abc123");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                schema: "oceanic",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Role",
                schema: "oceanic",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DestinationId",
                schema: "oceanic",
                table: "Routes");

            migrationBuilder.DropColumn(
                name: "OriginId",
                schema: "oceanic",
                table: "Routes");

            migrationBuilder.CreateIndex(
                name: "IX_ParcelToCities_CityId",
                schema: "oceanic",
                table: "ParcelToCities",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_ParcelToCities_Cities_CityId",
                schema: "oceanic",
                table: "ParcelToCities",
                column: "CityId",
                principalSchema: "oceanic",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
