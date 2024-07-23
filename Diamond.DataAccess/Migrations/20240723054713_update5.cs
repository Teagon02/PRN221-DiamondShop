using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diamond.DataAccess.Migrations
{
    public partial class update5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "CartItems",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "CartItems",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c052ffb4-245b-4c3c-8390-f1bd806828e2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1b210e4-9c59-473c-93a1-f1c391c80b26", "AQAAAAEAACcQAAAAEBcMo5MADpJu/bEsCmkxeFdp3OaRX1u0lkUwSGVPnLq3npiCptbwMg3bo8Jv8Ysjtg==", "3119d0d9-3248-48cd-8595-702071e9848d" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 22, 22, 54, 59, 355, DateTimeKind.Local).AddTicks(3015), new DateTime(2024, 7, 22, 22, 54, 59, 355, DateTimeKind.Local).AddTicks(3029) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 22, 22, 54, 59, 355, DateTimeKind.Local).AddTicks(3034), new DateTime(2024, 7, 22, 22, 54, 59, 355, DateTimeKind.Local).AddTicks(3035) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 22, 22, 54, 59, 355, DateTimeKind.Local).AddTicks(3036), new DateTime(2024, 7, 22, 22, 54, 59, 355, DateTimeKind.Local).AddTicks(3037) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 22, 22, 54, 59, 355, DateTimeKind.Local).AddTicks(3038), new DateTime(2024, 7, 22, 22, 54, 59, 355, DateTimeKind.Local).AddTicks(3039) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 22, 22, 54, 59, 355, DateTimeKind.Local).AddTicks(3040), new DateTime(2024, 7, 22, 22, 54, 59, 355, DateTimeKind.Local).AddTicks(3041) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 22, 22, 54, 59, 355, DateTimeKind.Local).AddTicks(3159), new DateTime(2024, 7, 22, 22, 54, 59, 355, DateTimeKind.Local).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 22, 22, 54, 59, 355, DateTimeKind.Local).AddTicks(3163), new DateTime(2024, 7, 22, 22, 54, 59, 355, DateTimeKind.Local).AddTicks(3164) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 22, 22, 54, 59, 355, DateTimeKind.Local).AddTicks(3166), new DateTime(2024, 7, 22, 22, 54, 59, 355, DateTimeKind.Local).AddTicks(3167) });
        }
    }
}
