using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diamond.DataAccess.Migrations
{
    public partial class init_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PriceFormatted",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 10, 20, 57, 11, 673, DateTimeKind.Local).AddTicks(4025), new DateTime(2024, 7, 10, 20, 57, 11, 673, DateTimeKind.Local).AddTicks(4037) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 10, 20, 57, 11, 673, DateTimeKind.Local).AddTicks(4041), new DateTime(2024, 7, 10, 20, 57, 11, 673, DateTimeKind.Local).AddTicks(4042) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 10, 20, 57, 11, 673, DateTimeKind.Local).AddTicks(4043), new DateTime(2024, 7, 10, 20, 57, 11, 673, DateTimeKind.Local).AddTicks(4044) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 10, 20, 57, 11, 673, DateTimeKind.Local).AddTicks(4045), new DateTime(2024, 7, 10, 20, 57, 11, 673, DateTimeKind.Local).AddTicks(4045) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 10, 20, 57, 11, 673, DateTimeKind.Local).AddTicks(4047), new DateTime(2024, 7, 10, 20, 57, 11, 673, DateTimeKind.Local).AddTicks(4047) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "PriceFormatted" },
                values: new object[] { new DateTime(2024, 7, 10, 20, 57, 11, 673, DateTimeKind.Local).AddTicks(4189), new DateTime(2024, 7, 10, 20, 57, 11, 673, DateTimeKind.Local).AddTicks(4190), "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "PriceFormatted" },
                values: new object[] { new DateTime(2024, 7, 10, 20, 57, 11, 673, DateTimeKind.Local).AddTicks(4193), new DateTime(2024, 7, 10, 20, 57, 11, 673, DateTimeKind.Local).AddTicks(4193), "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "PriceFormatted" },
                values: new object[] { new DateTime(2024, 7, 10, 20, 57, 11, 673, DateTimeKind.Local).AddTicks(4195), new DateTime(2024, 7, 10, 20, 57, 11, 673, DateTimeKind.Local).AddTicks(4196), "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PriceFormatted",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 4, 23, 26, 48, 524, DateTimeKind.Local).AddTicks(6076), new DateTime(2024, 6, 4, 23, 26, 48, 524, DateTimeKind.Local).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 4, 23, 26, 48, 524, DateTimeKind.Local).AddTicks(6087), new DateTime(2024, 6, 4, 23, 26, 48, 524, DateTimeKind.Local).AddTicks(6087) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 4, 23, 26, 48, 524, DateTimeKind.Local).AddTicks(6088), new DateTime(2024, 6, 4, 23, 26, 48, 524, DateTimeKind.Local).AddTicks(6089) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 4, 23, 26, 48, 524, DateTimeKind.Local).AddTicks(6089), new DateTime(2024, 6, 4, 23, 26, 48, 524, DateTimeKind.Local).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 4, 23, 26, 48, 524, DateTimeKind.Local).AddTicks(6090), new DateTime(2024, 6, 4, 23, 26, 48, 524, DateTimeKind.Local).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 4, 23, 26, 48, 524, DateTimeKind.Local).AddTicks(6251), new DateTime(2024, 6, 4, 23, 26, 48, 524, DateTimeKind.Local).AddTicks(6251) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 4, 23, 26, 48, 524, DateTimeKind.Local).AddTicks(6254), new DateTime(2024, 6, 4, 23, 26, 48, 524, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 4, 23, 26, 48, 524, DateTimeKind.Local).AddTicks(6256), new DateTime(2024, 6, 4, 23, 26, 48, 524, DateTimeKind.Local).AddTicks(6256) });
        }
    }
}
