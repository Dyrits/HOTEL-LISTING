using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Migrations
{
    public partial class AddingDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2b63dbb4-d723-4125-b714-e85e57c3b799", "5de5149c-74aa-4327-bddb-2381a015b4f1", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c6206db2-381c-49b7-96f8-89594dbaa4ef", "bbcab6a4-8147-4685-9ded-b9535e3ec981", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b63dbb4-d723-4125-b714-e85e57c3b799");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6206db2-381c-49b7-96f8-89594dbaa4ef");
        }
    }
}
