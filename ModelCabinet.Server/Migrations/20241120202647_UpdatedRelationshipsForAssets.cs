using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModelCabinet.Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRelationshipsForAssets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asset_Project_ProjectId",
                table: "Asset");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Asset",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Asset",
                keyColumn: "AssetId",
                keyValue: 1,
                columns: new[] { "DateCreation", "DateUpdated", "ProjectId" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 26, 46, 836, DateTimeKind.Local).AddTicks(8078), new DateTime(2024, 11, 20, 12, 26, 46, 836, DateTimeKind.Local).AddTicks(8079), 1 });

            migrationBuilder.UpdateData(
                table: "Asset",
                keyColumn: "AssetId",
                keyValue: 2,
                columns: new[] { "DateCreation", "DateUpdated", "ProjectId" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 26, 46, 836, DateTimeKind.Local).AddTicks(8083), new DateTime(2024, 11, 20, 12, 26, 46, 836, DateTimeKind.Local).AddTicks(8084), 1 });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 26, 46, 836, DateTimeKind.Local).AddTicks(7942), new DateTime(2024, 11, 20, 12, 26, 46, 836, DateTimeKind.Local).AddTicks(7976) });

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_Project_ProjectId",
                table: "Asset",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asset_Project_ProjectId",
                table: "Asset");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Asset",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Asset",
                keyColumn: "AssetId",
                keyValue: 1,
                columns: new[] { "DateCreation", "DateUpdated", "ProjectId" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 20, 21, 654, DateTimeKind.Local).AddTicks(509), new DateTime(2024, 11, 20, 12, 20, 21, 654, DateTimeKind.Local).AddTicks(510), null });

            migrationBuilder.UpdateData(
                table: "Asset",
                keyColumn: "AssetId",
                keyValue: 2,
                columns: new[] { "DateCreation", "DateUpdated", "ProjectId" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 20, 21, 654, DateTimeKind.Local).AddTicks(515), new DateTime(2024, 11, 20, 12, 20, 21, 654, DateTimeKind.Local).AddTicks(516), null });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 20, 21, 654, DateTimeKind.Local).AddTicks(346), new DateTime(2024, 11, 20, 12, 20, 21, 654, DateTimeKind.Local).AddTicks(385) });

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_Project_ProjectId",
                table: "Asset",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "ProjectId");
        }
    }
}
