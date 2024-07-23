using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diamond.DataAccess.Migrations.AuthDb
{
    public partial class updateConfirmEmailForAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c052ffb4-245b-4c3c-8390-f1bd806828e2",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00a4d872-a97a-4bd5-8501-038447da44c2", true, "AQAAAAEAACcQAAAAECr0ct/7RGnEzA35+aOD0B06hb5W7I2IxNb5dKtMrdroM45YQC9fPJmvdBwBaiJXmA==", "aad97021-e97f-4a67-9bdf-ab0bc1d69c16" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c052ffb4-245b-4c3c-8390-f1bd806828e2",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0253f1f0-66d3-433e-b503-6858e4b6ad9e", false, "AQAAAAEAACcQAAAAEEulQzHsQTUu8guJ6XAy+iQwqpsQSW+PKSqWR69GSUjcN/4Vks2743cjyoNnlqWIfw==", "ceffd50d-193a-4d48-a7d3-d6b2c5b93db3" });
        }
    }
}
