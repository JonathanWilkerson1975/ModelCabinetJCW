using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModelCabinet.Server.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Asset",
                keyColumn: "AssetId",
                keyValue: 1,
                columns: new[] { "DateCreation", "DateUpdated", "Path" },
                values: new object[] { new DateTime(2025, 2, 11, 15, 58, 29, 235, DateTimeKind.Local).AddTicks(618), new DateTime(2025, 2, 11, 15, 58, 29, 235, DateTimeKind.Local).AddTicks(621), "C:\\Users\\Willi\\OneDrive\\Desktop\\College Work\\I T\\Project for Bachelor's\\Original\\ModelCabinet\\ModelCabinet.Server\\bin\\Debug\\net8.0\\Assets\\TestProject\\HelloWorld.stl" });

            migrationBuilder.UpdateData(
                table: "Asset",
                keyColumn: "AssetId",
                keyValue: 2,
                columns: new[] { "DateCreation", "DateUpdated", "Path" },
                values: new object[] { new DateTime(2025, 2, 11, 15, 58, 29, 235, DateTimeKind.Local).AddTicks(632), new DateTime(2025, 2, 11, 15, 58, 29, 235, DateTimeKind.Local).AddTicks(635), "C:\\Users\\Willi\\OneDrive\\Desktop\\College Work\\I T\\Project for Bachelor's\\Original\\ModelCabinet\\ModelCabinet.Server\\bin\\Debug\\net8.0\\Assets\\TestProject\\3DBenchy.stl" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 2, 11, 15, 58, 29, 235, DateTimeKind.Local).AddTicks(271), new DateTime(2025, 2, 11, 15, 58, 29, 235, DateTimeKind.Local).AddTicks(349) });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModifiedDate", "Slug" },
                values: new object[] { new DateTime(2025, 2, 11, 15, 58, 29, 235, DateTimeKind.Local).AddTicks(358), new DateTime(2025, 2, 11, 15, 58, 29, 235, DateTimeKind.Local).AddTicks(361), "nomen-est-bonum" });
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
