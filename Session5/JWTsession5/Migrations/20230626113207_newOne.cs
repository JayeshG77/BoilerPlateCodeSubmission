using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session4.Migrations
{
    public partial class newOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c77f4a1-b1e4-4e34-acf3-a6e5a6e30138");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af01a5f1-2d6d-4df2-a7a2-d318e0f1b2fc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d0fccf9b-d7a0-4b76-9bab-84dd424f2fcb", "a96d10da-64cf-402c-8904-f80527e5cec6", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e96b4631-1704-43bb-bed4-0c9d0800a432", "843e18db-7c86-4f9a-88ef-38d3e2e015fc", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0fccf9b-d7a0-4b76-9bab-84dd424f2fcb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e96b4631-1704-43bb-bed4-0c9d0800a432");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9c77f4a1-b1e4-4e34-acf3-a6e5a6e30138", "10187f66-af5d-466b-99e2-391395ad18fb", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "af01a5f1-2d6d-4df2-a7a2-d318e0f1b2fc", "1c11dd80-9502-4eb3-a8e1-2d2c8c9acaa2", "Administrator", "ADMINISTRATOR" });
        }
    }
}
