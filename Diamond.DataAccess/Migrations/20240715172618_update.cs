using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diamond.DataAccess.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 16, 0, 26, 17, 985, DateTimeKind.Local).AddTicks(3129), new DateTime(2024, 7, 16, 0, 26, 17, 985, DateTimeKind.Local).AddTicks(3137) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 16, 0, 26, 17, 985, DateTimeKind.Local).AddTicks(3140), new DateTime(2024, 7, 16, 0, 26, 17, 985, DateTimeKind.Local).AddTicks(3140) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 16, 0, 26, 17, 985, DateTimeKind.Local).AddTicks(3141), new DateTime(2024, 7, 16, 0, 26, 17, 985, DateTimeKind.Local).AddTicks(3142) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 16, 0, 26, 17, 985, DateTimeKind.Local).AddTicks(3142), new DateTime(2024, 7, 16, 0, 26, 17, 985, DateTimeKind.Local).AddTicks(3143) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 16, 0, 26, 17, 985, DateTimeKind.Local).AddTicks(3144), new DateTime(2024, 7, 16, 0, 26, 17, 985, DateTimeKind.Local).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 16, 0, 26, 17, 985, DateTimeKind.Local).AddTicks(3292), new DateTime(2024, 7, 16, 0, 26, 17, 985, DateTimeKind.Local).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 16, 0, 26, 17, 985, DateTimeKind.Local).AddTicks(3295), new DateTime(2024, 7, 16, 0, 26, 17, 985, DateTimeKind.Local).AddTicks(3296) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 16, 0, 26, 17, 985, DateTimeKind.Local).AddTicks(3297), new DateTime(2024, 7, 16, 0, 26, 17, 985, DateTimeKind.Local).AddTicks(3298) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 10, 20, 57, 11, 673, DateTimeKind.Local).AddTicks(4189), new DateTime(2024, 7, 10, 20, 57, 11, 673, DateTimeKind.Local).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 10, 20, 57, 11, 673, DateTimeKind.Local).AddTicks(4193), new DateTime(2024, 7, 10, 20, 57, 11, 673, DateTimeKind.Local).AddTicks(4193) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 10, 20, 57, 11, 673, DateTimeKind.Local).AddTicks(4195), new DateTime(2024, 7, 10, 20, 57, 11, 673, DateTimeKind.Local).AddTicks(4196) });
        }
    }
}
