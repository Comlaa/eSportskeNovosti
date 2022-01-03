using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ESN_Api.Migrations
{
    public partial class PasswordProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PasswordSalt",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ModifedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 5, 23, 405, DateTimeKind.Utc).AddTicks(9472), "ExhCoLc0RVU6e1K2veoRh6dUP4FRE2uyFXAkQrsPYKc=", "ohIp8ucWEgzGRvqMbu3InQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ModifedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 5, 23, 405, DateTimeKind.Utc).AddTicks(9476), "ExhCoLc0RVU6e1K2veoRh6dUP4FRE2uyFXAkQrsPYKc=", "ohIp8ucWEgzGRvqMbu3InQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ModifedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 5, 23, 405, DateTimeKind.Utc).AddTicks(9477), "ExhCoLc0RVU6e1K2veoRh6dUP4FRE2uyFXAkQrsPYKc=", "ohIp8ucWEgzGRvqMbu3InQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifedAt",
                value: new DateTime(2022, 1, 3, 0, 47, 47, 505, DateTimeKind.Utc).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifedAt",
                value: new DateTime(2022, 1, 3, 0, 47, 47, 505, DateTimeKind.Utc).AddTicks(347));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifedAt",
                value: new DateTime(2022, 1, 3, 0, 47, 47, 505, DateTimeKind.Utc).AddTicks(348));
        }
    }
}
