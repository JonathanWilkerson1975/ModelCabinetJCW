using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ModelCabinet.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedTagging : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    TagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.TagId);
                });

            migrationBuilder.CreateTable(
                name: "AssetTag",
                columns: table => new
                {
                    AssetId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetTag", x => new { x.AssetId, x.TagId });
                    table.ForeignKey(
                        name: "FK_AssetTag_Asset_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Asset",
                        principalColumn: "AssetId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssetTag_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTag",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTag", x => new { x.ProjectId, x.TagId });
                    table.ForeignKey(
                        name: "FK_ProjectTag_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectTag_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Asset",
                keyColumn: "AssetId",
                keyValue: 1,
                columns: new[] { "DateCreation", "DateUpdated", "Path" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Projects\\Large_Projects\\ModelCabinet-Fork\\ModelCabinet.Server\\bin\\Debug\\net8.0\\Assets\\TestProject\\HelloWorld.stl" });

            migrationBuilder.UpdateData(
                table: "Asset",
                keyColumn: "AssetId",
                keyValue: 2,
                columns: new[] { "DateCreation", "DateUpdated", "Path" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:\\Projects\\Large_Projects\\ModelCabinet-Fork\\ModelCabinet.Server\\bin\\Debug\\net8.0\\Assets\\TestProject\\3DBenchy.stl" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModifiedDate", "Slug" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nomen-est-bonum" });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "TagId", "TagName" },
                values: new object[,]
                {
                    { 1, "Stress Test" },
                    { 2, "D&D" },
                    { 3, "Pathfinder" },
                    { 4, "Low Detail" },
                    { 5, "High Detail" },
                    { 6, "Video Game" }
                });

            migrationBuilder.InsertData(
                table: "AssetTag",
                columns: new[] { "AssetId", "TagId" },
                values: new object[,]
                {
                    { 1, 6 },
                    { 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProjectTag",
                columns: new[] { "ProjectId", "TagId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssetTag_TagId",
                table: "AssetTag",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTag_TagId",
                table: "ProjectTag",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Tag_TagName",
                table: "Tag",
                column: "TagName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssetTag");

            migrationBuilder.DropTable(
                name: "ProjectTag");

            migrationBuilder.DropTable(
                name: "Tag");

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
