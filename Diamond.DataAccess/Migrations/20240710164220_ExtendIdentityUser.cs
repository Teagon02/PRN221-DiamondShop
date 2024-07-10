using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diamond.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ExtendIdentityUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 42, 20, 135, DateTimeKind.Local).AddTicks(9347), new DateTime(2024, 7, 10, 23, 42, 20, 135, DateTimeKind.Local).AddTicks(9362) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 42, 20, 135, DateTimeKind.Local).AddTicks(9366), new DateTime(2024, 7, 10, 23, 42, 20, 135, DateTimeKind.Local).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 42, 20, 135, DateTimeKind.Local).AddTicks(9367), new DateTime(2024, 7, 10, 23, 42, 20, 135, DateTimeKind.Local).AddTicks(9368) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 42, 20, 135, DateTimeKind.Local).AddTicks(9369), new DateTime(2024, 7, 10, 23, 42, 20, 135, DateTimeKind.Local).AddTicks(9369) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 42, 20, 135, DateTimeKind.Local).AddTicks(9370), new DateTime(2024, 7, 10, 23, 42, 20, 135, DateTimeKind.Local).AddTicks(9371) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 42, 20, 135, DateTimeKind.Local).AddTicks(9590), new DateTime(2024, 7, 10, 23, 42, 20, 135, DateTimeKind.Local).AddTicks(9593) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 42, 20, 135, DateTimeKind.Local).AddTicks(9596), new DateTime(2024, 7, 10, 23, 42, 20, 135, DateTimeKind.Local).AddTicks(9597) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 42, 20, 135, DateTimeKind.Local).AddTicks(9599), new DateTime(2024, 7, 10, 23, 42, 20, 135, DateTimeKind.Local).AddTicks(9599) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 27, 5, 68, DateTimeKind.Local).AddTicks(7769), new DateTime(2024, 7, 10, 23, 27, 5, 68, DateTimeKind.Local).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 27, 5, 68, DateTimeKind.Local).AddTicks(7784), new DateTime(2024, 7, 10, 23, 27, 5, 68, DateTimeKind.Local).AddTicks(7784) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 27, 5, 68, DateTimeKind.Local).AddTicks(7785), new DateTime(2024, 7, 10, 23, 27, 5, 68, DateTimeKind.Local).AddTicks(7786) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 27, 5, 68, DateTimeKind.Local).AddTicks(7787), new DateTime(2024, 7, 10, 23, 27, 5, 68, DateTimeKind.Local).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 27, 5, 68, DateTimeKind.Local).AddTicks(7788), new DateTime(2024, 7, 10, 23, 27, 5, 68, DateTimeKind.Local).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 27, 5, 68, DateTimeKind.Local).AddTicks(8075), new DateTime(2024, 7, 10, 23, 27, 5, 68, DateTimeKind.Local).AddTicks(8077) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 27, 5, 68, DateTimeKind.Local).AddTicks(8080), new DateTime(2024, 7, 10, 23, 27, 5, 68, DateTimeKind.Local).AddTicks(8080) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 10, 23, 27, 5, 68, DateTimeKind.Local).AddTicks(8082), new DateTime(2024, 7, 10, 23, 27, 5, 68, DateTimeKind.Local).AddTicks(8083) });
        }
    }
}
