using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session4.Migrations
{
    public partial class initialSession5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "9c77f4a1-b1e4-4e34-acf3-a6e5a6e30138", "10187f66-af5d-466b-99e2-391395ad18fb", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "af01a5f1-2d6d-4df2-a7a2-d318e0f1b2fc", "1c11dd80-9502-4eb3-a8e1-2d2c8c9acaa2", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "3f4ee12f-f441-4c6e-9d5e-445ff8edade8", "912f08ef-9f31-4946-9218-d61768ac9a4e", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a602ab6e-2061-4fe7-98a7-6c2d82faf842", "a86d71b2-3b3d-4528-8af4-dfe8bb948ebf", "Administrator", "ADMINISTRATOR" });
        }
    }
}
