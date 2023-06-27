using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session4.Migrations
{
    public partial class initial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "641edf7c-1624-4e00-b31a-337a8e62b2d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84e4042f-34d9-4e39-aa45-c8b0a64e4c27");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3f4ee12f-f441-4c6e-9d5e-445ff8edade8", "912f08ef-9f31-4946-9218-d61768ac9a4e", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a602ab6e-2061-4fe7-98a7-6c2d82faf842", "a86d71b2-3b3d-4528-8af4-dfe8bb948ebf", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f4ee12f-f441-4c6e-9d5e-445ff8edade8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a602ab6e-2061-4fe7-98a7-6c2d82faf842");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "641edf7c-1624-4e00-b31a-337a8e62b2d9", "bcc6a2bf-c7b7-4c18-acaa-a23f9edb7a1b", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "84e4042f-34d9-4e39-aa45-c8b0a64e4c27", "f0e45cb1-72e6-4b08-93f8-60eee77d758e", "User", "USER" });
        }
    }
}
