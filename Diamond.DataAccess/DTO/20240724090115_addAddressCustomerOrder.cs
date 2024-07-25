using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diamond.DataAccess.Migrations
{
    public partial class addAddressCustomerOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PickupName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PickupName",
                table: "Orders");

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
        }
    }
}
