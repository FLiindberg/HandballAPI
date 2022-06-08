using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HandballAPI.Migrations
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "Description",
                value: "Utvisningsepelets tanke ör att isolera en 2:a för att får ett man man läge mellan 3 och 2 på sin starkaste sida.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "Description",
                value: "Utvisningsepelets tanke är att...");
        }
    }
}
