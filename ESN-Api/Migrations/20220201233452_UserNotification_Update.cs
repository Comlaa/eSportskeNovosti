using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ESN_Api.Migrations
{
    public partial class UserNotification_Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NotificationId",
                table: "UserNotifications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserNotifications_NotificationId",
                table: "UserNotifications",
                column: "NotificationId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserNotifications_Notifications_NotificationId",
                table: "UserNotifications",
                column: "NotificationId",
                principalTable: "Notifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserNotifications_Notifications_NotificationId",
                table: "UserNotifications");

            migrationBuilder.DropIndex(
                name: "IX_UserNotifications_NotificationId",
                table: "UserNotifications");

            migrationBuilder.DropColumn(
                name: "NotificationId",
                table: "UserNotifications");
        }
    }
}
