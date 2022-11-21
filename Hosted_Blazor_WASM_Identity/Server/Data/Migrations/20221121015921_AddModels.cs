using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hosted_Blazor_WASM_Identity.Server.Data.Migrations
{
    public partial class AddModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7b82d0d-7f54-4bcb-857e-ba23aa86fd54");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5bb4463-a104-4fd5-81e9-b28e574685c0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a3cd4215-e785-4553-b7d4-5b9593d2be83", "ca410bdd-bc52-471c-b22e-8ce64bb3bd74", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bfc31ea5-3b3f-4633-968b-6fd919bd0c82", "0091d653-913b-46ce-aa54-fe03d0d4adca", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3cd4215-e785-4553-b7d4-5b9593d2be83");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bfc31ea5-3b3f-4633-968b-6fd919bd0c82");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a7b82d0d-7f54-4bcb-857e-ba23aa86fd54", "9f62cd6f-01e0-444f-8192-b31aef64f9fa", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e5bb4463-a104-4fd5-81e9-b28e574685c0", "8ce352bf-7139-4828-baf3-7ed3ccfdf1c3", "User", "USER" });
        }
    }
}
