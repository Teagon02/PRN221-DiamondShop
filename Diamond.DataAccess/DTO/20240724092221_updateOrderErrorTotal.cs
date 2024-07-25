using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diamond.DataAccess.Migrations
{
    public partial class updateOrderErrorTotal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c052ffb4-245b-4c3c-8390-f1bd806828e2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dda157f7-fee6-4002-aecb-1b28664af67f", "AQAAAAEAACcQAAAAEKpu/n5YR7mTqCIx1SInMVe5QQ9OX23E7rEVxhl6Sv0ZUmI2HKRiBBkUGWXOSOG50Q==", "8cbcc4cb-3060-49d7-bcfa-777ecefb2b15" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 24, 16, 22, 21, 241, DateTimeKind.Local).AddTicks(2857), new DateTime(2024, 7, 24, 16, 22, 21, 241, DateTimeKind.Local).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 24, 16, 22, 21, 241, DateTimeKind.Local).AddTicks(2874), new DateTime(2024, 7, 24, 16, 22, 21, 241, DateTimeKind.Local).AddTicks(2874) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 24, 16, 22, 21, 241, DateTimeKind.Local).AddTicks(2875), new DateTime(2024, 7, 24, 16, 22, 21, 241, DateTimeKind.Local).AddTicks(2875) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 24, 16, 22, 21, 241, DateTimeKind.Local).AddTicks(2876), new DateTime(2024, 7, 24, 16, 22, 21, 241, DateTimeKind.Local).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 24, 16, 22, 21, 241, DateTimeKind.Local).AddTicks(2877), new DateTime(2024, 7, 24, 16, 22, 21, 241, DateTimeKind.Local).AddTicks(2877) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 24, 16, 22, 21, 241, DateTimeKind.Local).AddTicks(2937), new DateTime(2024, 7, 24, 16, 22, 21, 241, DateTimeKind.Local).AddTicks(2937) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 24, 16, 22, 21, 241, DateTimeKind.Local).AddTicks(2939), new DateTime(2024, 7, 24, 16, 22, 21, 241, DateTimeKind.Local).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 24, 16, 22, 21, 241, DateTimeKind.Local).AddTicks(2941), new DateTime(2024, 7, 24, 16, 22, 21, 241, DateTimeKind.Local).AddTicks(2941) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c052ffb4-245b-4c3c-8390-f1bd806828e2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26e40e71-920e-434c-9594-5ec8d886eb70", "AQAAAAEAACcQAAAAEEi/Iie4axAmKl4GWgNa0wX4IsdhNyhIZZEHL6nXUHhxdw/dP7CJBVCAAtaNA8M0/A==", "e2069ce0-ba0d-4c05-b1c8-86cd0e07d63f" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 24, 16, 1, 15, 589, DateTimeKind.Local).AddTicks(765), new DateTime(2024, 7, 24, 16, 1, 15, 589, DateTimeKind.Local).AddTicks(776) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 24, 16, 1, 15, 589, DateTimeKind.Local).AddTicks(780), new DateTime(2024, 7, 24, 16, 1, 15, 589, DateTimeKind.Local).AddTicks(781) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 24, 16, 1, 15, 589, DateTimeKind.Local).AddTicks(781), new DateTime(2024, 7, 24, 16, 1, 15, 589, DateTimeKind.Local).AddTicks(782) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 24, 16, 1, 15, 589, DateTimeKind.Local).AddTicks(783), new DateTime(2024, 7, 24, 16, 1, 15, 589, DateTimeKind.Local).AddTicks(783) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 24, 16, 1, 15, 589, DateTimeKind.Local).AddTicks(783), new DateTime(2024, 7, 24, 16, 1, 15, 589, DateTimeKind.Local).AddTicks(784) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 24, 16, 1, 15, 589, DateTimeKind.Local).AddTicks(844), new DateTime(2024, 7, 24, 16, 1, 15, 589, DateTimeKind.Local).AddTicks(845) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 24, 16, 1, 15, 589, DateTimeKind.Local).AddTicks(847), new DateTime(2024, 7, 24, 16, 1, 15, 589, DateTimeKind.Local).AddTicks(847) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 24, 16, 1, 15, 589, DateTimeKind.Local).AddTicks(848), new DateTime(2024, 7, 24, 16, 1, 15, 589, DateTimeKind.Local).AddTicks(848) });
        }
    }
}
