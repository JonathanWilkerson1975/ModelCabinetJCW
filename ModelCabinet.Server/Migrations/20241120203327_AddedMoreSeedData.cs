using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModelCabinet.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedMoreSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Asset",
                keyColumn: "AssetId",
                keyValue: 1,
                columns: new[] { "DateCreation", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 33, 26, 724, DateTimeKind.Local).AddTicks(9003), new DateTime(2024, 11, 20, 12, 33, 26, 724, DateTimeKind.Local).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "Asset",
                keyColumn: "AssetId",
                keyValue: 2,
                columns: new[] { "DateCreation", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 33, 26, 724, DateTimeKind.Local).AddTicks(9013), new DateTime(2024, 11, 20, 12, 33, 26, 724, DateTimeKind.Local).AddTicks(9015) });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 33, 26, 724, DateTimeKind.Local).AddTicks(8805), new DateTime(2024, 11, 20, 12, 33, 26, 724, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ProjectId", "Author", "CreationDate", "Description", "ModifiedDate", "Name", "Version", "shortDescription" },
                values: new object[] { 2, "Author", new DateTime(2024, 11, 20, 12, 33, 26, 724, DateTimeKind.Local).AddTicks(8856), "Description", new DateTime(2024, 11, 20, 12, 33, 26, 724, DateTimeKind.Local).AddTicks(8858), "Test Project Two", "0.0.1", "Desc" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Asset",
                keyColumn: "AssetId",
                keyValue: 1,
                columns: new[] { "DateCreation", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 26, 46, 836, DateTimeKind.Local).AddTicks(8078), new DateTime(2024, 11, 20, 12, 26, 46, 836, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Asset",
                keyColumn: "AssetId",
                keyValue: 2,
                columns: new[] { "DateCreation", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 26, 46, 836, DateTimeKind.Local).AddTicks(8083), new DateTime(2024, 11, 20, 12, 26, 46, 836, DateTimeKind.Local).AddTicks(8084) });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 26, 46, 836, DateTimeKind.Local).AddTicks(7942), new DateTime(2024, 11, 20, 12, 26, 46, 836, DateTimeKind.Local).AddTicks(7976) });
        }
    }
}
