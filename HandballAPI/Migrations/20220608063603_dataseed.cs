using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HandballAPI.Migrations
{
    public partial class dataseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "Description", "Team", "Title" },
                values: new object[] { "Övningen jugge...", "Herrarna", "Jugge" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Utvisningsepelets tanke är att...", "Utvisningspel" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "Description", "Team", "Title" },
                values: new object[] { "Test 11", "P08", "Test 1" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Test 22", "Test 2" });
        }
    }
}
