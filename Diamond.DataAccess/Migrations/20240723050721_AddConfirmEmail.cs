using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diamond.DataAccess.Migrations
{
    public partial class AddConfirmEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c052ffb4-245b-4c3c-8390-f1bd806828e2",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0dd37400-0ceb-420c-b7cd-c48e0845a4c6", true, "AQAAAAEAACcQAAAAEN7eLua2a/qYnfjPt8MCeAsyual1jxmeVVey5YOEs+X5FBfPC2ljpzpP5zT0x+58+Q==", "d636632d-c929-4853-a84f-2e83b6e29ea6" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c052ffb4-245b-4c3c-8390-f1bd806828e2",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ee7d368-1d11-40d9-94f3-53d8d6cae90a", false, "AQAAAAEAACcQAAAAEF2rsRoTuqX/1ZiFhiprA07JQXOQApemmWHJ9aqbsCKJPcI86e0rijts7bgvSGRN6A==", "70a2923f-927f-4668-ac39-75007c40f65d" });

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
