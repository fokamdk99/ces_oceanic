using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OceanicSearchEngine.Data.Migrations.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "oceanic");

            migrationBuilder.CreateTable(
                name: "Cities",
                schema: "oceanic",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parcels",
                schema: "oceanic",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromId = table.Column<long>(type: "bigint", nullable: false),
                    ToId = table.Column<long>(type: "bigint", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parcels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pricings",
                schema: "oceanic",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParcelSize = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pricings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                schema: "oceanic",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Owner = table.Column<int>(type: "int", nullable: false),
                    TravelTime = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "oceanic",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParcelToCities",
                schema: "oceanic",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityId = table.Column<long>(type: "bigint", nullable: false),
                    ParcelId = table.Column<long>(type: "bigint", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParcelToCities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParcelToCities_Cities_CityId",
                        column: x => x.CityId,
                        principalSchema: "oceanic",
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParcelToCities_Parcels_ParcelId",
                        column: x => x.ParcelId,
                        principalSchema: "oceanic",
                        principalTable: "Parcels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "oceanic",
                table: "Cities",
                columns: new[] { "Id", "Modified", "Name" },
                values: new object[,]
                {
                    { 1L, null, "addis abeba" },
                    { 2L, null, "amatave" }
                });

            migrationBuilder.InsertData(
                schema: "oceanic",
                table: "Parcels",
                columns: new[] { "Id", "FromId", "Modified", "Price", "Size", "ToId", "Type", "Weight" },
                values: new object[,]
                {
                    { 1L, 0L, null, 0f, 0, 0L, 0, 2f },
                    { 2L, 0L, null, 0f, 0, 0L, 0, 4f }
                });

            migrationBuilder.InsertData(
                schema: "oceanic",
                table: "Pricings",
                columns: new[] { "Id", "Modified", "ParcelSize", "Price", "Weight" },
                values: new object[,]
                {
                    { 1L, null, 0, 10f, 0f },
                    { 2L, null, 0, 12f, 0f }
                });

            migrationBuilder.InsertData(
                schema: "oceanic",
                table: "Routes",
                columns: new[] { "Id", "Modified", "Owner", "TravelTime" },
                values: new object[,]
                {
                    { 1L, null, 0, 8 },
                    { 2L, null, 0, 8 }
                });

            migrationBuilder.InsertData(
                schema: "oceanic",
                table: "Users",
                columns: new[] { "Id", "Email", "FullName", "Modified" },
                values: new object[,]
                {
                    { 1L, "zulu@oceanic.com", "Mr Zulu", null },
                    { 2L, "stas@oceanic.com", "Stanislaw", null }
                });

            migrationBuilder.InsertData(
                schema: "oceanic",
                table: "ParcelToCities",
                columns: new[] { "Id", "CityId", "Modified", "ParcelId" },
                values: new object[] { 1L, 1L, null, 1L });

            migrationBuilder.CreateIndex(
                name: "IX_Parcels_Id",
                schema: "oceanic",
                table: "Parcels",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ParcelToCities_CityId",
                schema: "oceanic",
                table: "ParcelToCities",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_ParcelToCities_Id",
                schema: "oceanic",
                table: "ParcelToCities",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ParcelToCities_ParcelId",
                schema: "oceanic",
                table: "ParcelToCities",
                column: "ParcelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParcelToCities",
                schema: "oceanic");

            migrationBuilder.DropTable(
                name: "Pricings",
                schema: "oceanic");

            migrationBuilder.DropTable(
                name: "Routes",
                schema: "oceanic");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "oceanic");

            migrationBuilder.DropTable(
                name: "Cities",
                schema: "oceanic");

            migrationBuilder.DropTable(
                name: "Parcels",
                schema: "oceanic");
        }
    }
}
