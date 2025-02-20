using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModelCabinet.Server.Migrations
{
    /// <inheritdoc />
    public partial class FixAssetPath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Asset",
                keyColumn: "AssetId",
                keyValue: 1,
                columns: new[] { "DateCreation", "DateUpdated", "Path" },
                values: new object[] { new DateTime(2025, 2, 6, 13, 58, 5, 872, DateTimeKind.Local).AddTicks(986), new DateTime(2025, 2, 6, 13, 58, 5, 872, DateTimeKind.Local).AddTicks(989), "Assets\\TestProject\\HelloWorld.stl" });

            migrationBuilder.UpdateData(
                table: "Asset",
                keyColumn: "AssetId",
                keyValue: 2,
                columns: new[] { "DateCreation", "DateUpdated", "Path" },
                values: new object[] { new DateTime(2025, 2, 6, 13, 58, 5, 872, DateTimeKind.Local).AddTicks(992), new DateTime(2025, 2, 6, 13, 58, 5, 872, DateTimeKind.Local).AddTicks(994), "Assets\\TestProject\\3DBenchy.stl" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 6, 13, 58, 5, 872, DateTimeKind.Local).AddTicks(791), new DateTime(2025, 2, 6, 13, 58, 5, 872, DateTimeKind.Local).AddTicks(835) });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModifiedDate", "Slug" },
                values: new object[] { new DateTime(2025, 2, 6, 13, 58, 5, 872, DateTimeKind.Local).AddTicks(839), new DateTime(2025, 2, 6, 13, 58, 5, 872, DateTimeKind.Local).AddTicks(840), "nomen-est-bonum" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Asset",
                keyColumn: "AssetId",
                keyValue: 1,
                columns: new[] { "DateCreation", "DateUpdated", "Path" },
                values: new object[] { new DateTime(2025, 2, 6, 12, 29, 14, 314, DateTimeKind.Local).AddTicks(7342), new DateTime(2025, 2, 6, 12, 29, 14, 314, DateTimeKind.Local).AddTicks(7347), "C:\\Users\\gaski\\source\\repos\\ModelCabinet\\ModelCabinet.Server\\bin\\Debug\\net8.0\\Assets\\TestProject\\HelloWorld.stl" });

            migrationBuilder.UpdateData(
                table: "Asset",
                keyColumn: "AssetId",
                keyValue: 2,
                columns: new[] { "DateCreation", "DateUpdated", "Path" },
                values: new object[] { new DateTime(2025, 2, 6, 12, 29, 14, 314, DateTimeKind.Local).AddTicks(7354), new DateTime(2025, 2, 6, 12, 29, 14, 314, DateTimeKind.Local).AddTicks(7356), "C:\\Users\\gaski\\source\\repos\\ModelCabinet\\ModelCabinet.Server\\bin\\Debug\\net8.0\\Assets\\TestProject\\3DBenchy.stl" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 6, 12, 29, 14, 314, DateTimeKind.Local).AddTicks(7022), new DateTime(2025, 2, 6, 12, 29, 14, 314, DateTimeKind.Local).AddTicks(7069) });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModifiedDate", "Slug" },
                values: new object[] { new DateTime(2025, 2, 6, 12, 29, 14, 314, DateTimeKind.Local).AddTicks(7074), new DateTime(2025, 2, 6, 12, 29, 14, 314, DateTimeKind.Local).AddTicks(7075), "this is not good" });
        }
    }
}
