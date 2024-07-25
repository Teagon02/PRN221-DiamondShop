using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diamond.DataAccess.Migrations
{
    public partial class UpdateFieldOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TransactionId",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "OrderItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "OrderItems",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c052ffb4-245b-4c3c-8390-f1bd806828e2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "052279e2-8de9-41b4-9bc5-3c6c43910910", "AQAAAAEAACcQAAAAEK0nekjhzxJKf07jB8FxfGU7+nO+1iOVMOr1WbR85rLPsYHyxlqRxgM7FXDMYgXrhw==", "2b8fb659-3674-431a-88a3-5921c3728e0f" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 24, 14, 39, 57, 838, DateTimeKind.Local).AddTicks(8818), new DateTime(2024, 7, 24, 14, 39, 57, 838, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 24, 14, 39, 57, 838, DateTimeKind.Local).AddTicks(8834), new DateTime(2024, 7, 24, 14, 39, 57, 838, DateTimeKind.Local).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 24, 14, 39, 57, 838, DateTimeKind.Local).AddTicks(8878), new DateTime(2024, 7, 24, 14, 39, 57, 838, DateTimeKind.Local).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 24, 14, 39, 57, 838, DateTimeKind.Local).AddTicks(8880), new DateTime(2024, 7, 24, 14, 39, 57, 838, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 24, 14, 39, 57, 838, DateTimeKind.Local).AddTicks(8881), new DateTime(2024, 7, 24, 14, 39, 57, 838, DateTimeKind.Local).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 24, 14, 39, 57, 838, DateTimeKind.Local).AddTicks(8959), new DateTime(2024, 7, 24, 14, 39, 57, 838, DateTimeKind.Local).AddTicks(8959) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 24, 14, 39, 57, 838, DateTimeKind.Local).AddTicks(8961), new DateTime(2024, 7, 24, 14, 39, 57, 838, DateTimeKind.Local).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 24, 14, 39, 57, 838, DateTimeKind.Local).AddTicks(8963), new DateTime(2024, 7, 24, 14, 39, 57, 838, DateTimeKind.Local).AddTicks(8963) });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId1",
                table: "Orders",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId1",
                table: "Orders",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId1",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserId1",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Comments",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "TransactionId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "OrderItems");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
