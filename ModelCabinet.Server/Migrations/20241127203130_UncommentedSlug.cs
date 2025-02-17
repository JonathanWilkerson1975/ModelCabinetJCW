using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModelCabinet.Server.Migrations
{
    /// <inheritdoc />
    public partial class UncommentedSlug : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "shortDescription",
                table: "Project",
                newName: "ShortDescription");

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "Project",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Asset",
                keyColumn: "AssetId",
                keyValue: 1,
                columns: new[] { "DateCreation", "DateUpdated", "Path" },
                values: new object[] { new DateTime(2024, 11, 27, 12, 31, 28, 793, DateTimeKind.Local).AddTicks(3778), new DateTime(2024, 11, 27, 12, 31, 28, 793, DateTimeKind.Local).AddTicks(3786), "C:\\Users\\gaski\\source\\repos\\ModelCabinet\\ModelCabinet.Server\\bin\\Debug\\net8.0\\Assets\\TestProject\\HelloWorld.stl" });

            migrationBuilder.UpdateData(
                table: "Asset",
                keyColumn: "AssetId",
                keyValue: 2,
                columns: new[] { "DateCreation", "DateUpdated", "Path" },
                values: new object[] { new DateTime(2024, 11, 27, 12, 31, 28, 793, DateTimeKind.Local).AddTicks(3800), new DateTime(2024, 11, 27, 12, 31, 28, 793, DateTimeKind.Local).AddTicks(3804), "C:\\Users\\gaski\\source\\repos\\ModelCabinet\\ModelCabinet.Server\\bin\\Debug\\net8.0\\Assets\\TestProject\\3DBenchy.stl" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModifiedDate", "Slug" },
                values: new object[] { new DateTime(2024, 11, 27, 12, 31, 28, 793, DateTimeKind.Local).AddTicks(3181), new DateTime(2024, 11, 27, 12, 31, 28, 793, DateTimeKind.Local).AddTicks(3290), "nomen est omen" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModifiedDate", "Slug" },
                values: new object[] { new DateTime(2024, 11, 27, 12, 31, 28, 793, DateTimeKind.Local).AddTicks(3300), new DateTime(2024, 11, 27, 12, 31, 28, 793, DateTimeKind.Local).AddTicks(3305), "nomen est omen" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Project");

            migrationBuilder.RenameColumn(
                name: "ShortDescription",
                table: "Project",
                newName: "shortDescription");

            migrationBuilder.UpdateData(
                table: "Asset",
                keyColumn: "AssetId",
                keyValue: 1,
                columns: new[] { "DateCreation", "DateUpdated", "Path" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 33, 26, 724, DateTimeKind.Local).AddTicks(9003), new DateTime(2024, 11, 20, 12, 33, 26, 724, DateTimeKind.Local).AddTicks(9006), "C:\\Users\\jesse.harlan\\Desktop\\ModelCabinet\\ModelCabinet.Server\\bin\\Debug\\net8.0\\Assets\\TestProject\\HelloWorld.stl" });

            migrationBuilder.UpdateData(
                table: "Asset",
                keyColumn: "AssetId",
                keyValue: 2,
                columns: new[] { "DateCreation", "DateUpdated", "Path" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 33, 26, 724, DateTimeKind.Local).AddTicks(9013), new DateTime(2024, 11, 20, 12, 33, 26, 724, DateTimeKind.Local).AddTicks(9015), "C:\\Users\\jesse.harlan\\Desktop\\ModelCabinet\\ModelCabinet.Server\\bin\\Debug\\net8.0\\Assets\\TestProject\\3DBenchy.stl" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 33, 26, 724, DateTimeKind.Local).AddTicks(8805), new DateTime(2024, 11, 20, 12, 33, 26, 724, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 33, 26, 724, DateTimeKind.Local).AddTicks(8856), new DateTime(2024, 11, 20, 12, 33, 26, 724, DateTimeKind.Local).AddTicks(8858) });
        }
    }
}
