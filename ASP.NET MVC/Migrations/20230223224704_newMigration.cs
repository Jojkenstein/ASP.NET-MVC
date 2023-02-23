using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.NET_MVC.Migrations
{
    public partial class newMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "PhoneNumber" },
                values: new object[] { "26d9df41-598e-4f20-97fe-7b31ba7e94c5", "Austin", "Mike Truk", "555-302540371" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "PhoneNumber" },
                values: new object[] { "8c802057-0499-4460-bdd0-0f6c7ad2ca10", "Tallahassee", "Bobson Dugnut", "555-782575942" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "PhoneNumber" },
                values: new object[] { "b119657e-9d77-4346-92ce-78b473ddddd8", "Gotemburgo", "Jay Kay", "666-692471337" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "26d9df41-598e-4f20-97fe-7b31ba7e94c5");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "8c802057-0499-4460-bdd0-0f6c7ad2ca10");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "b119657e-9d77-4346-92ce-78b473ddddd8");

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
    }
}
