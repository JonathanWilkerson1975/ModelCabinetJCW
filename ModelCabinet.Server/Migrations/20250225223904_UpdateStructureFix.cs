using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModelCabinet.Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStructureFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Asset",
                keyColumn: "AssetId",
                keyValue: 1,
                columns: new[] { "DateCreation", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 39, 3, 727, DateTimeKind.Local).AddTicks(5697), new DateTime(2025, 2, 25, 14, 39, 3, 727, DateTimeKind.Local).AddTicks(5756) });

            migrationBuilder.UpdateData(
                table: "Asset",
                keyColumn: "AssetId",
                keyValue: 2,
                columns: new[] { "DateCreation", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 25, 14, 39, 3, 727, DateTimeKind.Local).AddTicks(5760), new DateTime(2025, 2, 25, 14, 39, 3, 727, DateTimeKind.Local).AddTicks(5761) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Asset",
                keyColumn: "AssetId",
                keyValue: 1,
                columns: new[] { "DateCreation", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 19, 13, 11, 57, 9, DateTimeKind.Local).AddTicks(781), new DateTime(2025, 2, 19, 13, 11, 57, 9, DateTimeKind.Local).AddTicks(817) });

            migrationBuilder.UpdateData(
                table: "Asset",
                keyColumn: "AssetId",
                keyValue: 2,
                columns: new[] { "DateCreation", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 19, 13, 11, 57, 9, DateTimeKind.Local).AddTicks(820), new DateTime(2025, 2, 19, 13, 11, 57, 9, DateTimeKind.Local).AddTicks(822) });
        }
    }
}
