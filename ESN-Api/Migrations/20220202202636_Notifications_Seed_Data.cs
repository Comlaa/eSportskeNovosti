using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ESN_Api.Migrations
{
    public partial class Notifications_Seed_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Notifications_ArticleId",
                table: "Notifications");

            migrationBuilder.DeleteData(
                table: "UserNotifications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "ArticleId", "CreatedAt", "ModifedAt", "NotificationDate" },
                values: new object[] { 2, 1, new DateTime(2022, 2, 2, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 2, 2, 20, 26, 36, 400, DateTimeKind.Utc).AddTicks(2414), new DateTime(2022, 2, 2, 18, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "UserNotifications",
                columns: new[] { "Id", "CreatedAt", "ModifedAt", "NotificationId", "Read", "UserId" },
                values: new object[] { 2, new DateTime(2022, 2, 2, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 2, 2, 20, 26, 36, 400, DateTimeKind.Utc).AddTicks(3644), 2, false, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_ArticleId",
                table: "Notifications",
                column: "ArticleId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Notifications_ArticleId",
                table: "Notifications");

            migrationBuilder.DeleteData(
                table: "UserNotifications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "ArticleId", "CreatedAt", "ModifedAt", "NotificationDate" },
                values: new object[] { 1, 1, new DateTime(2022, 2, 2, 0, 34, 52, 51, DateTimeKind.Local).AddTicks(8484), new DateTime(2022, 2, 1, 23, 34, 52, 51, DateTimeKind.Utc).AddTicks(8475), new DateTime(2022, 2, 2, 0, 34, 52, 51, DateTimeKind.Local).AddTicks(8476) });

            migrationBuilder.InsertData(
                table: "UserNotifications",
                columns: new[] { "Id", "CreatedAt", "ModifedAt", "NotificationId", "Read", "UserId" },
                values: new object[] { 1, new DateTime(2022, 2, 2, 0, 34, 52, 51, DateTimeKind.Local).AddTicks(9411), new DateTime(2022, 2, 1, 23, 34, 52, 51, DateTimeKind.Utc).AddTicks(9409), 1, false, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_ArticleId",
                table: "Notifications",
                column: "ArticleId");
        }
    }
}
