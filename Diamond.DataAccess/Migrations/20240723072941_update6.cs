using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diamond.DataAccess.Migrations
{
    public partial class update6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_CartItems_CartItemId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropIndex(
                name: "IX_Products_CartItemId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CartItemId",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c052ffb4-245b-4c3c-8390-f1bd806828e2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d97f7b05-709d-4b51-b8cf-1d34f41ab94b", "AQAAAAEAACcQAAAAELgn6ONh56S5i4migr7j8rlKUGoU2WQaWGfsqlaNu6ZFEJNvWTxL6flenmtVh3x48w==", "76651d42-4d56-40e3-a79c-75911a097a13" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 23, 14, 29, 40, 483, DateTimeKind.Local).AddTicks(3301), new DateTime(2024, 7, 23, 14, 29, 40, 483, DateTimeKind.Local).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 23, 14, 29, 40, 483, DateTimeKind.Local).AddTicks(3320), new DateTime(2024, 7, 23, 14, 29, 40, 483, DateTimeKind.Local).AddTicks(3321) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 23, 14, 29, 40, 483, DateTimeKind.Local).AddTicks(3322), new DateTime(2024, 7, 23, 14, 29, 40, 483, DateTimeKind.Local).AddTicks(3323) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 23, 14, 29, 40, 483, DateTimeKind.Local).AddTicks(3324), new DateTime(2024, 7, 23, 14, 29, 40, 483, DateTimeKind.Local).AddTicks(3325) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 23, 14, 29, 40, 483, DateTimeKind.Local).AddTicks(3326), new DateTime(2024, 7, 23, 14, 29, 40, 483, DateTimeKind.Local).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 23, 14, 29, 40, 483, DateTimeKind.Local).AddTicks(3453), new DateTime(2024, 7, 23, 14, 29, 40, 483, DateTimeKind.Local).AddTicks(3454) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 23, 14, 29, 40, 483, DateTimeKind.Local).AddTicks(3458), new DateTime(2024, 7, 23, 14, 29, 40, 483, DateTimeKind.Local).AddTicks(3458) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 23, 14, 29, 40, 483, DateTimeKind.Local).AddTicks(3462), new DateTime(2024, 7, 23, 14, 29, 40, 483, DateTimeKind.Local).AddTicks(3462) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CartItemId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    CartItemId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.CartItemId);
                    table.ForeignKey(
                        name: "FK_CartItems_Users_CartItemId",
                        column: x => x.CartItemId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c052ffb4-245b-4c3c-8390-f1bd806828e2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19e28948-ab68-4a99-96ac-69aed12b196c", "AQAAAAEAACcQAAAAEDAMMbpwaFZZ+fV7VHXe/3rwtlAqa1ZyhNsT0I1u7UrWUr4eqtt8ZMVJvwg2hsfITQ==", "5f828d1b-3769-41cf-b3ff-9d9218501088" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 23, 12, 47, 12, 679, DateTimeKind.Local).AddTicks(7135), new DateTime(2024, 7, 23, 12, 47, 12, 679, DateTimeKind.Local).AddTicks(7145) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 23, 12, 47, 12, 679, DateTimeKind.Local).AddTicks(7151), new DateTime(2024, 7, 23, 12, 47, 12, 679, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 23, 12, 47, 12, 679, DateTimeKind.Local).AddTicks(7154), new DateTime(2024, 7, 23, 12, 47, 12, 679, DateTimeKind.Local).AddTicks(7155) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 23, 12, 47, 12, 679, DateTimeKind.Local).AddTicks(7157), new DateTime(2024, 7, 23, 12, 47, 12, 679, DateTimeKind.Local).AddTicks(7158) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 23, 12, 47, 12, 679, DateTimeKind.Local).AddTicks(7160), new DateTime(2024, 7, 23, 12, 47, 12, 679, DateTimeKind.Local).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 23, 12, 47, 12, 679, DateTimeKind.Local).AddTicks(7302), new DateTime(2024, 7, 23, 12, 47, 12, 679, DateTimeKind.Local).AddTicks(7303) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 23, 12, 47, 12, 679, DateTimeKind.Local).AddTicks(7307), new DateTime(2024, 7, 23, 12, 47, 12, 679, DateTimeKind.Local).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 23, 12, 47, 12, 679, DateTimeKind.Local).AddTicks(7312), new DateTime(2024, 7, 23, 12, 47, 12, 679, DateTimeKind.Local).AddTicks(7313) });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CartItemId",
                table: "Products",
                column: "CartItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CartItems_CartItemId",
                table: "Products",
                column: "CartItemId",
                principalTable: "CartItems",
                principalColumn: "CartItemId");
        }
    }
}
