using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModelCabinet.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedDataForAssetsAndProjects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Asset",
                columns: new[] { "AssetId", "Name" },
                values: new object[] { 1, "Test Asset" });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ProjectId", "Name" },
                values: new object[] { 1, "Test Project" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "AssetId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1);
        }
    }
}
