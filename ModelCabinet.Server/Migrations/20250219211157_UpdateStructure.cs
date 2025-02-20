using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModelCabinet.Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Asset",
                keyColumn: "AssetId",
                keyValue: 1,
                columns: new[] { "DateCreation", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 17, 15, 34, 26, 497, DateTimeKind.Local).AddTicks(7375), new DateTime(2025, 2, 17, 15, 34, 26, 497, DateTimeKind.Local).AddTicks(7434) });

            migrationBuilder.UpdateData(
                table: "Asset",
                keyColumn: "AssetId",
                keyValue: 2,
                columns: new[] { "DateCreation", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 17, 15, 34, 26, 497, DateTimeKind.Local).AddTicks(7437), new DateTime(2025, 2, 17, 15, 34, 26, 497, DateTimeKind.Local).AddTicks(7439) });
        }
    }
}
