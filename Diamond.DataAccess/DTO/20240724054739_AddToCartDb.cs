using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diamond.DataAccess.Migrations
{
    public partial class AddToCartDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    CartItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.CartItemId);
                    table.ForeignKey(
                        name: "FK_CartItems_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c052ffb4-245b-4c3c-8390-f1bd806828e2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3178610-2a4e-41d7-ac26-45538a9520d7", "AQAAAAEAACcQAAAAEE4p2ZY62EPsgwp8WgxQFTs2MVqFBQjO4iPPzulwX3LH+DSzgoqodsKjBNKhyCD4OQ==", "7b5fc9f2-8c1b-400a-a053-9ba685b2094d" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 24, 12, 47, 39, 28, DateTimeKind.Local).AddTicks(6310), new DateTime(2024, 7, 24, 12, 47, 39, 28, DateTimeKind.Local).AddTicks(6324) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 24, 12, 47, 39, 28, DateTimeKind.Local).AddTicks(6328), new DateTime(2024, 7, 24, 12, 47, 39, 28, DateTimeKind.Local).AddTicks(6328) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 24, 12, 47, 39, 28, DateTimeKind.Local).AddTicks(6329), new DateTime(2024, 7, 24, 12, 47, 39, 28, DateTimeKind.Local).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 24, 12, 47, 39, 28, DateTimeKind.Local).AddTicks(6330), new DateTime(2024, 7, 24, 12, 47, 39, 28, DateTimeKind.Local).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 24, 12, 47, 39, 28, DateTimeKind.Local).AddTicks(6331), new DateTime(2024, 7, 24, 12, 47, 39, 28, DateTimeKind.Local).AddTicks(6332) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 24, 12, 47, 39, 28, DateTimeKind.Local).AddTicks(6388), new DateTime(2024, 7, 24, 12, 47, 39, 28, DateTimeKind.Local).AddTicks(6389) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 24, 12, 47, 39, 28, DateTimeKind.Local).AddTicks(6391), new DateTime(2024, 7, 24, 12, 47, 39, 28, DateTimeKind.Local).AddTicks(6391) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 24, 12, 47, 39, 28, DateTimeKind.Local).AddTicks(6392), new DateTime(2024, 7, 24, 12, 47, 39, 28, DateTimeKind.Local).AddTicks(6393) });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_UserId",
                table: "CartItems",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c052ffb4-245b-4c3c-8390-f1bd806828e2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0dd37400-0ceb-420c-b7cd-c48e0845a4c6", "AQAAAAEAACcQAAAAEN7eLua2a/qYnfjPt8MCeAsyual1jxmeVVey5YOEs+X5FBfPC2ljpzpP5zT0x+58+Q==", "d636632d-c929-4853-a84f-2e83b6e29ea6" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 23, 12, 7, 20, 994, DateTimeKind.Local).AddTicks(5571), new DateTime(2024, 7, 23, 12, 7, 20, 994, DateTimeKind.Local).AddTicks(5581) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 23, 12, 7, 20, 994, DateTimeKind.Local).AddTicks(5584), new DateTime(2024, 7, 23, 12, 7, 20, 994, DateTimeKind.Local).AddTicks(5585) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 23, 12, 7, 20, 994, DateTimeKind.Local).AddTicks(5585), new DateTime(2024, 7, 23, 12, 7, 20, 994, DateTimeKind.Local).AddTicks(5586) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 23, 12, 7, 20, 994, DateTimeKind.Local).AddTicks(5586), new DateTime(2024, 7, 23, 12, 7, 20, 994, DateTimeKind.Local).AddTicks(5587) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 23, 12, 7, 20, 994, DateTimeKind.Local).AddTicks(5587), new DateTime(2024, 7, 23, 12, 7, 20, 994, DateTimeKind.Local).AddTicks(5588) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 23, 12, 7, 20, 994, DateTimeKind.Local).AddTicks(5703), new DateTime(2024, 7, 23, 12, 7, 20, 994, DateTimeKind.Local).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 23, 12, 7, 20, 994, DateTimeKind.Local).AddTicks(5705), new DateTime(2024, 7, 23, 12, 7, 20, 994, DateTimeKind.Local).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 23, 12, 7, 20, 994, DateTimeKind.Local).AddTicks(5707), new DateTime(2024, 7, 23, 12, 7, 20, 994, DateTimeKind.Local).AddTicks(5707) });
        }
    }
}
