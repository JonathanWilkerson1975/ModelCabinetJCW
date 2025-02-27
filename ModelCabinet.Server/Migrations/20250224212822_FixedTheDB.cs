using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModelCabinet.Server.Migrations
{
    /// <inheritdoc />
    public partial class FixedTheDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Asset",
                keyColumn: "AssetId",
                keyValue: 1,
                columns: new[] { "DateCreation", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 24, 13, 28, 20, 585, DateTimeKind.Local).AddTicks(1132), new DateTime(2025, 2, 24, 13, 28, 20, 585, DateTimeKind.Local).AddTicks(1206) });

            migrationBuilder.UpdateData(
                table: "Asset",
                keyColumn: "AssetId",
                keyValue: 2,
                columns: new[] { "DateCreation", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 24, 13, 28, 20, 585, DateTimeKind.Local).AddTicks(1217), new DateTime(2025, 2, 24, 13, 28, 20, 585, DateTimeKind.Local).AddTicks(1220) });
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
