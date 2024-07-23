using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diamond.DataAccess.Migrations
{
    public partial class update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c052ffb4-245b-4c3c-8390-f1bd806828e2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ee7d368-1d11-40d9-94f3-53d8d6cae90a", "AQAAAAEAACcQAAAAEF2rsRoTuqX/1ZiFhiprA07JQXOQApemmWHJ9aqbsCKJPcI86e0rijts7bgvSGRN6A==", "70a2923f-927f-4668-ac39-75007c40f65d" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 21, 23, 6, 7, 202, DateTimeKind.Local).AddTicks(5964), new DateTime(2024, 7, 21, 23, 6, 7, 202, DateTimeKind.Local).AddTicks(5974) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 21, 23, 6, 7, 202, DateTimeKind.Local).AddTicks(5978), new DateTime(2024, 7, 21, 23, 6, 7, 202, DateTimeKind.Local).AddTicks(5978) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 21, 23, 6, 7, 202, DateTimeKind.Local).AddTicks(5979), new DateTime(2024, 7, 21, 23, 6, 7, 202, DateTimeKind.Local).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 21, 23, 6, 7, 202, DateTimeKind.Local).AddTicks(5980), new DateTime(2024, 7, 21, 23, 6, 7, 202, DateTimeKind.Local).AddTicks(5980) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 21, 23, 6, 7, 202, DateTimeKind.Local).AddTicks(5981), new DateTime(2024, 7, 21, 23, 6, 7, 202, DateTimeKind.Local).AddTicks(5981) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 21, 23, 6, 7, 202, DateTimeKind.Local).AddTicks(6032), new DateTime(2024, 7, 21, 23, 6, 7, 202, DateTimeKind.Local).AddTicks(6033) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 21, 23, 6, 7, 202, DateTimeKind.Local).AddTicks(6034), new DateTime(2024, 7, 21, 23, 6, 7, 202, DateTimeKind.Local).AddTicks(6035) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 21, 23, 6, 7, 202, DateTimeKind.Local).AddTicks(6036), new DateTime(2024, 7, 21, 23, 6, 7, 202, DateTimeKind.Local).AddTicks(6036) });
        }
    }
}
