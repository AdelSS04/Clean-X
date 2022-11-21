using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hosted_Blazor_WASM_Identity.Server.Data.Migrations
{
    public partial class AddModels12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "245f28a1-0e67-4b8a-8f20-6575a23d3699");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b45ce37-5c03-4099-8091-0be2564f84a8");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Missions",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Missions",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "59ade777-8380-4f50-a3c9-7dead000e635", "43aef2ce-5257-41c1-9fe0-47706723de0d", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fd39314e-fd76-4c21-9709-f8f11c0a1658", "c4997a7b-bebc-46e8-8616-3477711b8722", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59ade777-8380-4f50-a3c9-7dead000e635");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd39314e-fd76-4c21-9709-f8f11c0a1658");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Missions");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Missions");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "245f28a1-0e67-4b8a-8f20-6575a23d3699", "a81c3e10-b9ce-45ee-bad5-9ad564cdb494", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9b45ce37-5c03-4099-8091-0be2564f84a8", "937ccd83-5c44-44ab-9a9b-86dc4b4b56f9", "User", "USER" });
        }
    }
}
