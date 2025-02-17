using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModelCabinet.Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Project",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Project",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Project",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Project",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Version",
                table: "Project",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "shortDescription",
                table: "Project",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreation",
                table: "Asset",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Asset",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "FileSize",
                table: "Asset",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "Asset",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Asset",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Asset",
                keyColumn: "AssetId",
                keyValue: 1,
                columns: new[] { "DateCreation", "DateUpdated", "FileSize", "Path", "ProjectId" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 20, 21, 654, DateTimeKind.Local).AddTicks(509), new DateTime(2024, 11, 20, 12, 20, 21, 654, DateTimeKind.Local).AddTicks(510), 446684L, "C:\\Users\\jesse.harlan\\Desktop\\ModelCabinet\\ModelCabinet.Server\\bin\\Debug\\net8.0\\Assets\\TestProject\\HelloWorld.stl", null });

            migrationBuilder.UpdateData(
                table: "Asset",
                keyColumn: "AssetId",
                keyValue: 2,
                columns: new[] { "DateCreation", "DateUpdated", "FileSize", "Name", "Path", "ProjectId" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 20, 21, 654, DateTimeKind.Local).AddTicks(515), new DateTime(2024, 11, 20, 12, 20, 21, 654, DateTimeKind.Local).AddTicks(516), 11285384L, "Benchy", "C:\\Users\\jesse.harlan\\Desktop\\ModelCabinet\\ModelCabinet.Server\\bin\\Debug\\net8.0\\Assets\\TestProject\\3DBenchy.stl", null });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "Author", "CreationDate", "Description", "ModifiedDate", "Version", "shortDescription" },
                values: new object[] { "Author", new DateTime(2024, 11, 20, 12, 20, 21, 654, DateTimeKind.Local).AddTicks(346), "Description", new DateTime(2024, 11, 20, 12, 20, 21, 654, DateTimeKind.Local).AddTicks(385), "0.0.1", "Desc" });

            migrationBuilder.CreateIndex(
                name: "IX_Asset_ProjectId",
                table: "Asset",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_Project_ProjectId",
                table: "Asset",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "ProjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asset_Project_ProjectId",
                table: "Asset");

            migrationBuilder.DropIndex(
                name: "IX_Asset_ProjectId",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "Author",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "shortDescription",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "DateCreation",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "FileSize",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "Path",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Asset");

            migrationBuilder.UpdateData(
                table: "Asset",
                keyColumn: "AssetId",
                keyValue: 2,
                column: "Name",
                value: "Test Benchy");
        }
    }
}
