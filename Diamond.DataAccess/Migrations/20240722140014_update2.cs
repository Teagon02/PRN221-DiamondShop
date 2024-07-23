using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diamond.DataAccess.Migrations
{
    public partial class update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CartItemId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CartItemId1",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    CartItemId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
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
                values: new object[] { "352906e4-39a1-441b-8747-91e5e2b9f115", "AQAAAAEAACcQAAAAEAMoZt0RD6arYWz96XG/TjjxQr11XkCypwc8zccg7+0jU5m/r+EuqR9B1TMrk6BOxA==", "3edd2e53-6e2f-4759-b7ce-8b83e023ae40" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 0, 13, 435, DateTimeKind.Local).AddTicks(7602), new DateTime(2024, 7, 22, 21, 0, 13, 435, DateTimeKind.Local).AddTicks(7617) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 0, 13, 435, DateTimeKind.Local).AddTicks(7629), new DateTime(2024, 7, 22, 21, 0, 13, 435, DateTimeKind.Local).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 0, 13, 435, DateTimeKind.Local).AddTicks(7631), new DateTime(2024, 7, 22, 21, 0, 13, 435, DateTimeKind.Local).AddTicks(7631) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 0, 13, 435, DateTimeKind.Local).AddTicks(7633), new DateTime(2024, 7, 22, 21, 0, 13, 435, DateTimeKind.Local).AddTicks(7634) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 0, 13, 435, DateTimeKind.Local).AddTicks(7635), new DateTime(2024, 7, 22, 21, 0, 13, 435, DateTimeKind.Local).AddTicks(7636) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 0, 13, 435, DateTimeKind.Local).AddTicks(7763), new DateTime(2024, 7, 22, 21, 0, 13, 435, DateTimeKind.Local).AddTicks(7764) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 0, 13, 435, DateTimeKind.Local).AddTicks(7767), new DateTime(2024, 7, 22, 21, 0, 13, 435, DateTimeKind.Local).AddTicks(7768) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 0, 13, 435, DateTimeKind.Local).AddTicks(7770), new DateTime(2024, 7, 22, 21, 0, 13, 435, DateTimeKind.Local).AddTicks(7771) });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CartItemId",
                table: "Products",
                column: "CartItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CartItemId1",
                table: "Products",
                column: "CartItemId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CartItems_CartItemId",
                table: "Products",
                column: "CartItemId",
                principalTable: "CartItems",
                principalColumn: "CartItemId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CartItems_CartItemId1",
                table: "Products",
                column: "CartItemId1",
                principalTable: "CartItems",
                principalColumn: "CartItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_CartItems_CartItemId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_CartItems_CartItemId1",
                table: "Products");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropIndex(
                name: "IX_Products_CartItemId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CartItemId1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CartItemId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CartItemId1",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c052ffb4-245b-4c3c-8390-f1bd806828e2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49f3f809-2aa2-4096-bb74-413582f45638", "AQAAAAEAACcQAAAAEFvkKm/ksqBJGTjPyT0xAkl1tn8Yppi8GurFL9LceK6S6J3kz16nMXuCsxnBmE74fg==", "155ad19a-f9ba-4757-ad6a-30ac5bca5911" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 22, 19, 12, 26, 947, DateTimeKind.Local).AddTicks(7389), new DateTime(2024, 7, 22, 19, 12, 26, 947, DateTimeKind.Local).AddTicks(7400) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 22, 19, 12, 26, 947, DateTimeKind.Local).AddTicks(7407), new DateTime(2024, 7, 22, 19, 12, 26, 947, DateTimeKind.Local).AddTicks(7408) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 22, 19, 12, 26, 947, DateTimeKind.Local).AddTicks(7411), new DateTime(2024, 7, 22, 19, 12, 26, 947, DateTimeKind.Local).AddTicks(7412) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 22, 19, 12, 26, 947, DateTimeKind.Local).AddTicks(7413), new DateTime(2024, 7, 22, 19, 12, 26, 947, DateTimeKind.Local).AddTicks(7414) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 22, 19, 12, 26, 947, DateTimeKind.Local).AddTicks(7416), new DateTime(2024, 7, 22, 19, 12, 26, 947, DateTimeKind.Local).AddTicks(7417) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 22, 19, 12, 26, 947, DateTimeKind.Local).AddTicks(7591), new DateTime(2024, 7, 22, 19, 12, 26, 947, DateTimeKind.Local).AddTicks(7593) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 22, 19, 12, 26, 947, DateTimeKind.Local).AddTicks(7598), new DateTime(2024, 7, 22, 19, 12, 26, 947, DateTimeKind.Local).AddTicks(7599) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 22, 19, 12, 26, 947, DateTimeKind.Local).AddTicks(7602), new DateTime(2024, 7, 22, 19, 12, 26, 947, DateTimeKind.Local).AddTicks(7604) });
        }
    }
}
