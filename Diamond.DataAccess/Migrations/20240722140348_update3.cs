using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diamond.DataAccess.Migrations
{
    public partial class update3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_CartItems_CartItemId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_CartItems_CartItemId1",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CartItemId1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CartItemId1",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c052ffb4-245b-4c3c-8390-f1bd806828e2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b98ed0f-2e8d-401e-8cba-b71bd2e1a1a3", "AQAAAAEAACcQAAAAEPEoAtjFas4nJ0aE01P/htFQG0csT6LveUnDfExBNXKwYhnekePpEI0dhCfAcY+HMQ==", "4ca17cb8-32dd-4678-ac16-3c2f8f01d89d" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 3, 47, 693, DateTimeKind.Local).AddTicks(1051), new DateTime(2024, 7, 22, 21, 3, 47, 693, DateTimeKind.Local).AddTicks(1059) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 3, 47, 693, DateTimeKind.Local).AddTicks(1064), new DateTime(2024, 7, 22, 21, 3, 47, 693, DateTimeKind.Local).AddTicks(1065) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 3, 47, 693, DateTimeKind.Local).AddTicks(1066), new DateTime(2024, 7, 22, 21, 3, 47, 693, DateTimeKind.Local).AddTicks(1067) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 3, 47, 693, DateTimeKind.Local).AddTicks(1069), new DateTime(2024, 7, 22, 21, 3, 47, 693, DateTimeKind.Local).AddTicks(1070) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 3, 47, 693, DateTimeKind.Local).AddTicks(1071), new DateTime(2024, 7, 22, 21, 3, 47, 693, DateTimeKind.Local).AddTicks(1072) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 3, 47, 693, DateTimeKind.Local).AddTicks(1174), new DateTime(2024, 7, 22, 21, 3, 47, 693, DateTimeKind.Local).AddTicks(1175) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 3, 47, 693, DateTimeKind.Local).AddTicks(1178), new DateTime(2024, 7, 22, 21, 3, 47, 693, DateTimeKind.Local).AddTicks(1179) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 3, 47, 693, DateTimeKind.Local).AddTicks(1181), new DateTime(2024, 7, 22, 21, 3, 47, 693, DateTimeKind.Local).AddTicks(1182) });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CartItems_CartItemId",
                table: "Products",
                column: "CartItemId",
                principalTable: "CartItems",
                principalColumn: "CartItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_CartItems_CartItemId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "CartItemId1",
                table: "Products",
                type: "int",
                nullable: true);

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
    }
}
