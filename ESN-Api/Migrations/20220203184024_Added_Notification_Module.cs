using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ESN_Api.Migrations
{
    public partial class Added_Notification_Module : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    NotificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserNotifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotificationId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Read = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserNotifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserNotifications_Notifications_NotificationId",
                        column: x => x.NotificationId,
                        principalTable: "Notifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserNotifications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "ArticleRatings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 3, 19, 40, 23, 701, DateTimeKind.Local).AddTicks(6005), new DateTime(2022, 2, 3, 18, 40, 23, 701, DateTimeKind.Utc).AddTicks(6004) });

            migrationBuilder.UpdateData(
                table: "ArticleRatings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 3, 19, 40, 23, 701, DateTimeKind.Local).AddTicks(6010), new DateTime(2022, 2, 3, 18, 40, 23, 701, DateTimeKind.Utc).AddTicks(6009) });

            migrationBuilder.UpdateData(
                table: "ArticleRatings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 3, 19, 40, 23, 701, DateTimeKind.Local).AddTicks(6012), new DateTime(2022, 2, 3, 18, 40, 23, 701, DateTimeKind.Utc).AddTicks(6012) });

            migrationBuilder.UpdateData(
                table: "ArticleRatings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 3, 19, 40, 23, 701, DateTimeKind.Local).AddTicks(6014), new DateTime(2022, 2, 3, 18, 40, 23, 701, DateTimeKind.Utc).AddTicks(6014) });

            migrationBuilder.UpdateData(
                table: "ArticleRatings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 3, 19, 40, 23, 701, DateTimeKind.Local).AddTicks(6017), new DateTime(2022, 2, 3, 18, 40, 23, 701, DateTimeKind.Utc).AddTicks(6016) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Date", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 3, 18, 40, 23, 701, DateTimeKind.Utc).AddTicks(5679), new DateTime(2022, 2, 3, 19, 40, 23, 701, DateTimeKind.Local).AddTicks(5683), new DateTime(2022, 2, 3, 18, 40, 23, 701, DateTimeKind.Utc).AddTicks(5679) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Date", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 3, 18, 40, 23, 701, DateTimeKind.Utc).AddTicks(5724), new DateTime(2022, 2, 3, 19, 40, 23, 701, DateTimeKind.Local).AddTicks(5725), new DateTime(2022, 2, 3, 18, 40, 23, 701, DateTimeKind.Utc).AddTicks(5724) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Date", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 3, 18, 40, 23, 701, DateTimeKind.Utc).AddTicks(5726), new DateTime(2022, 2, 3, 19, 40, 23, 701, DateTimeKind.Local).AddTicks(5727), new DateTime(2022, 2, 3, 18, 40, 23, 701, DateTimeKind.Utc).AddTicks(5726) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 3, 19, 40, 23, 701, DateTimeKind.Local).AddTicks(6175), new DateTime(2022, 2, 3, 18, 40, 23, 701, DateTimeKind.Utc).AddTicks(6174) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 3, 19, 40, 23, 701, DateTimeKind.Local).AddTicks(6179), new DateTime(2022, 2, 3, 18, 40, 23, 701, DateTimeKind.Utc).AddTicks(6179) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 3, 19, 40, 23, 701, DateTimeKind.Local).AddTicks(6182), new DateTime(2022, 2, 3, 18, 40, 23, 701, DateTimeKind.Utc).AddTicks(6181) });

            migrationBuilder.UpdateData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 3, 18, 40, 23, 701, DateTimeKind.Utc).AddTicks(6321), new DateTime(2022, 2, 3, 18, 40, 23, 701, DateTimeKind.Utc).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 3, 18, 40, 23, 701, DateTimeKind.Utc).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 3, 18, 40, 23, 701, DateTimeKind.Utc).AddTicks(7305));

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "ArticleId", "CreatedAt", "ModifedAt", "NotificationDate" },
                values: new object[] { 2, 1, new DateTime(2022, 2, 2, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 2, 3, 18, 40, 23, 701, DateTimeKind.Utc).AddTicks(7555), new DateTime(2022, 2, 2, 18, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 3, 18, 40, 23, 701, DateTimeKind.Utc).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 3, 18, 40, 23, 701, DateTimeKind.Utc).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 3, 18, 40, 23, 701, DateTimeKind.Utc).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "SavedArticles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 3, 18, 40, 23, 701, DateTimeKind.Utc).AddTicks(7855), new DateTime(2022, 2, 3, 18, 40, 23, 701, DateTimeKind.Utc).AddTicks(7855) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 3, 18, 40, 23, 702, DateTimeKind.Utc).AddTicks(3500), new DateTime(2022, 2, 3, 18, 40, 23, 702, DateTimeKind.Utc).AddTicks(3500) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 3, 18, 40, 23, 702, DateTimeKind.Utc).AddTicks(3503), new DateTime(2022, 2, 3, 18, 40, 23, 702, DateTimeKind.Utc).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 3, 18, 40, 23, 702, DateTimeKind.Utc).AddTicks(3504), new DateTime(2022, 2, 3, 18, 40, 23, 702, DateTimeKind.Utc).AddTicks(3504) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 3, 18, 40, 23, 701, DateTimeKind.Utc).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 3, 18, 40, 23, 701, DateTimeKind.Utc).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 3, 18, 40, 23, 701, DateTimeKind.Utc).AddTicks(8086));

            migrationBuilder.InsertData(
                table: "UserNotifications",
                columns: new[] { "Id", "CreatedAt", "ModifedAt", "NotificationId", "Read", "UserId" },
                values: new object[] { 2, new DateTime(2022, 2, 2, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 2, 3, 18, 40, 23, 701, DateTimeKind.Utc).AddTicks(8898), 2, false, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_ArticleId",
                table: "Notifications",
                column: "ArticleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserNotifications_NotificationId",
                table: "UserNotifications",
                column: "NotificationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserNotifications_UserId",
                table: "UserNotifications",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserNotifications");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.UpdateData(
                table: "ArticleRatings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 1, 16, 15, 38, 16, 876, DateTimeKind.Local).AddTicks(2616), new DateTime(2022, 1, 16, 14, 38, 16, 876, DateTimeKind.Utc).AddTicks(2615) });

            migrationBuilder.UpdateData(
                table: "ArticleRatings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 1, 16, 15, 38, 16, 876, DateTimeKind.Local).AddTicks(2622), new DateTime(2022, 1, 16, 14, 38, 16, 876, DateTimeKind.Utc).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "ArticleRatings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 1, 16, 15, 38, 16, 876, DateTimeKind.Local).AddTicks(2624), new DateTime(2022, 1, 16, 14, 38, 16, 876, DateTimeKind.Utc).AddTicks(2624) });

            migrationBuilder.UpdateData(
                table: "ArticleRatings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 1, 16, 15, 38, 16, 876, DateTimeKind.Local).AddTicks(2626), new DateTime(2022, 1, 16, 14, 38, 16, 876, DateTimeKind.Utc).AddTicks(2625) });

            migrationBuilder.UpdateData(
                table: "ArticleRatings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 1, 16, 15, 38, 16, 876, DateTimeKind.Local).AddTicks(2628), new DateTime(2022, 1, 16, 14, 38, 16, 876, DateTimeKind.Utc).AddTicks(2627) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Date", "ModifedAt" },
                values: new object[] { new DateTime(2022, 1, 16, 14, 38, 16, 876, DateTimeKind.Utc).AddTicks(2245), new DateTime(2022, 1, 16, 15, 38, 16, 876, DateTimeKind.Local).AddTicks(2250), new DateTime(2022, 1, 16, 14, 38, 16, 876, DateTimeKind.Utc).AddTicks(2245) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Date", "ModifedAt" },
                values: new object[] { new DateTime(2022, 1, 16, 14, 38, 16, 876, DateTimeKind.Utc).AddTicks(2285), new DateTime(2022, 1, 16, 15, 38, 16, 876, DateTimeKind.Local).AddTicks(2286), new DateTime(2022, 1, 16, 14, 38, 16, 876, DateTimeKind.Utc).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Date", "ModifedAt" },
                values: new object[] { new DateTime(2022, 1, 16, 14, 38, 16, 876, DateTimeKind.Utc).AddTicks(2288), new DateTime(2022, 1, 16, 15, 38, 16, 876, DateTimeKind.Local).AddTicks(2288), new DateTime(2022, 1, 16, 14, 38, 16, 876, DateTimeKind.Utc).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 1, 16, 15, 38, 16, 876, DateTimeKind.Local).AddTicks(2907), new DateTime(2022, 1, 16, 14, 38, 16, 876, DateTimeKind.Utc).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 1, 16, 15, 38, 16, 876, DateTimeKind.Local).AddTicks(2913), new DateTime(2022, 1, 16, 14, 38, 16, 876, DateTimeKind.Utc).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 1, 16, 15, 38, 16, 876, DateTimeKind.Local).AddTicks(2958), new DateTime(2022, 1, 16, 14, 38, 16, 876, DateTimeKind.Utc).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 1, 16, 14, 38, 16, 876, DateTimeKind.Utc).AddTicks(3224), new DateTime(2022, 1, 16, 14, 38, 16, 876, DateTimeKind.Utc).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifedAt",
                value: new DateTime(2022, 1, 16, 14, 38, 16, 876, DateTimeKind.Utc).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifedAt",
                value: new DateTime(2022, 1, 16, 14, 38, 16, 876, DateTimeKind.Utc).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifedAt",
                value: new DateTime(2022, 1, 16, 14, 38, 16, 876, DateTimeKind.Utc).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifedAt",
                value: new DateTime(2022, 1, 16, 14, 38, 16, 876, DateTimeKind.Utc).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifedAt",
                value: new DateTime(2022, 1, 16, 14, 38, 16, 876, DateTimeKind.Utc).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "SavedArticles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 1, 16, 14, 38, 16, 876, DateTimeKind.Utc).AddTicks(4699), new DateTime(2022, 1, 16, 14, 38, 16, 876, DateTimeKind.Utc).AddTicks(4699) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 1, 16, 14, 38, 16, 877, DateTimeKind.Utc).AddTicks(274), new DateTime(2022, 1, 16, 14, 38, 16, 877, DateTimeKind.Utc).AddTicks(274) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 1, 16, 14, 38, 16, 877, DateTimeKind.Utc).AddTicks(277), new DateTime(2022, 1, 16, 14, 38, 16, 877, DateTimeKind.Utc).AddTicks(277) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 1, 16, 14, 38, 16, 877, DateTimeKind.Utc).AddTicks(278), new DateTime(2022, 1, 16, 14, 38, 16, 877, DateTimeKind.Utc).AddTicks(278) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifedAt",
                value: new DateTime(2022, 1, 16, 14, 38, 16, 876, DateTimeKind.Utc).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifedAt",
                value: new DateTime(2022, 1, 16, 14, 38, 16, 876, DateTimeKind.Utc).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifedAt",
                value: new DateTime(2022, 1, 16, 14, 38, 16, 876, DateTimeKind.Utc).AddTicks(4951));
        }
    }
}
