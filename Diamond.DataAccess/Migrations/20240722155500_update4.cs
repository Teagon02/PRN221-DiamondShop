using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diamond.DataAccess.Migrations
{
    public partial class update4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CartItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "CartItems");

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
        }
    }
}
