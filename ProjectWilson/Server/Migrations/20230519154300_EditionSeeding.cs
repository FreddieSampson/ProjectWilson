using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectWilson.Server.Migrations
{
    /// <inheritdoc />
    public partial class EditionSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Editions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Paperback" },
                    { 2, "E-Book" },
                    { 3, "Audiobook" },
                    { 4, "PC" },
                    { 5, "PlayStation" },
                    { 6, "Xbox" },
                    { 7, "iPhone Pro" },
                    { 8, "iPhone Pro Max" }
                });

            migrationBuilder.InsertData(
                table: "EditionProduct",
                columns: new[] { "EditionsId", "ProductsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 2 },
                    { 4, 3 },
                    { 5, 2 },
                    { 5, 3 },
                    { 6, 2 },
                    { 6, 3 },
                    { 7, 5 },
                    { 8, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
