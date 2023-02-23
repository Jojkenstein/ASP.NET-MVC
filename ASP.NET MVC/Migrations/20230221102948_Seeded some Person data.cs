using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.NET_MVC.Migrations
{
    public partial class SeededsomePersondata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "PhoneNumber" },
                values: new object[] { "44a4ccec-83d8-4beb-827f-e44ac0144108", "Gotemburgo", "Jay Kay", "666-692471337" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "PhoneNumber" },
                values: new object[] { "c78dfab7-a02a-4ae6-8b93-675098bfcdbc", "Austin", "Mike Truk", "555-302540371" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "PhoneNumber" },
                values: new object[] { "cbe4c2e3-55b7-43c1-8f8b-bd8b9cf5be26", "Tallahassee", "Bobson Dugnut", "555-782575942" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "44a4ccec-83d8-4beb-827f-e44ac0144108");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "c78dfab7-a02a-4ae6-8b93-675098bfcdbc");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "cbe4c2e3-55b7-43c1-8f8b-bd8b9cf5be26");
        }
    }
}
