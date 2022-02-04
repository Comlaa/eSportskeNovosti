using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ESN_Api.Migrations
{
    public partial class SupportTicket_Name_Change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupportTicket_Users_UserId",
                table: "SupportTicket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SupportTicket",
                table: "SupportTicket");

            migrationBuilder.RenameTable(
                name: "SupportTicket",
                newName: "SupportTickets");

            migrationBuilder.RenameIndex(
                name: "IX_SupportTicket_UserId",
                table: "SupportTickets",
                newName: "IX_SupportTickets_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SupportTickets",
                table: "SupportTickets",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "ArticleRatings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 12, 9, 57, 65, DateTimeKind.Local).AddTicks(8636), new DateTime(2022, 2, 4, 11, 9, 57, 65, DateTimeKind.Utc).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "ArticleRatings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 12, 9, 57, 65, DateTimeKind.Local).AddTicks(8641), new DateTime(2022, 2, 4, 11, 9, 57, 65, DateTimeKind.Utc).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "ArticleRatings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 12, 9, 57, 65, DateTimeKind.Local).AddTicks(8644), new DateTime(2022, 2, 4, 11, 9, 57, 65, DateTimeKind.Utc).AddTicks(8643) });

            migrationBuilder.UpdateData(
                table: "ArticleRatings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 12, 9, 57, 65, DateTimeKind.Local).AddTicks(8647), new DateTime(2022, 2, 4, 11, 9, 57, 65, DateTimeKind.Utc).AddTicks(8646) });

            migrationBuilder.UpdateData(
                table: "ArticleRatings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 12, 9, 57, 65, DateTimeKind.Local).AddTicks(8649), new DateTime(2022, 2, 4, 11, 9, 57, 65, DateTimeKind.Utc).AddTicks(8649) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Date", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 11, 9, 57, 65, DateTimeKind.Utc).AddTicks(8050), new DateTime(2022, 2, 4, 12, 9, 57, 65, DateTimeKind.Local).AddTicks(8054), new DateTime(2022, 2, 4, 11, 9, 57, 65, DateTimeKind.Utc).AddTicks(8050) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Date", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 11, 9, 57, 65, DateTimeKind.Utc).AddTicks(8099), new DateTime(2022, 2, 4, 12, 9, 57, 65, DateTimeKind.Local).AddTicks(8100), new DateTime(2022, 2, 4, 11, 9, 57, 65, DateTimeKind.Utc).AddTicks(8099) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Date", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 11, 9, 57, 65, DateTimeKind.Utc).AddTicks(8103), new DateTime(2022, 2, 4, 12, 9, 57, 65, DateTimeKind.Local).AddTicks(8110), new DateTime(2022, 2, 4, 11, 9, 57, 65, DateTimeKind.Utc).AddTicks(8103) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 12, 9, 57, 65, DateTimeKind.Local).AddTicks(8886), new DateTime(2022, 2, 4, 11, 9, 57, 65, DateTimeKind.Utc).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 12, 9, 57, 65, DateTimeKind.Local).AddTicks(8892), new DateTime(2022, 2, 4, 11, 9, 57, 65, DateTimeKind.Utc).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 12, 9, 57, 65, DateTimeKind.Local).AddTicks(8895), new DateTime(2022, 2, 4, 11, 9, 57, 65, DateTimeKind.Utc).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 11, 9, 57, 65, DateTimeKind.Utc).AddTicks(9129), new DateTime(2022, 2, 4, 11, 9, 57, 65, DateTimeKind.Utc).AddTicks(9128) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 11, 9, 57, 66, DateTimeKind.Utc).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 11, 9, 57, 66, DateTimeKind.Utc).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 11, 9, 57, 66, DateTimeKind.Utc).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 11, 9, 57, 66, DateTimeKind.Utc).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 11, 9, 57, 66, DateTimeKind.Utc).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 11, 9, 57, 66, DateTimeKind.Utc).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "SavedArticles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 11, 9, 57, 66, DateTimeKind.Utc).AddTicks(955), new DateTime(2022, 2, 4, 11, 9, 57, 66, DateTimeKind.Utc).AddTicks(955) });

            migrationBuilder.UpdateData(
                table: "SupportTickets",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 11, 9, 57, 66, DateTimeKind.Utc).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "UserNotifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 11, 9, 57, 66, DateTimeKind.Utc).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 11, 9, 57, 66, DateTimeKind.Utc).AddTicks(6647), new DateTime(2022, 2, 4, 11, 9, 57, 66, DateTimeKind.Utc).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 11, 9, 57, 66, DateTimeKind.Utc).AddTicks(6651), new DateTime(2022, 2, 4, 11, 9, 57, 66, DateTimeKind.Utc).AddTicks(6651) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 11, 9, 57, 66, DateTimeKind.Utc).AddTicks(6651), new DateTime(2022, 2, 4, 11, 9, 57, 66, DateTimeKind.Utc).AddTicks(6651) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 11, 9, 57, 66, DateTimeKind.Utc).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 11, 9, 57, 66, DateTimeKind.Utc).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 11, 9, 57, 66, DateTimeKind.Utc).AddTicks(1273));

            migrationBuilder.AddForeignKey(
                name: "FK_SupportTickets_Users_UserId",
                table: "SupportTickets",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupportTickets_Users_UserId",
                table: "SupportTickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SupportTickets",
                table: "SupportTickets");

            migrationBuilder.RenameTable(
                name: "SupportTickets",
                newName: "SupportTicket");

            migrationBuilder.RenameIndex(
                name: "IX_SupportTickets_UserId",
                table: "SupportTicket",
                newName: "IX_SupportTicket_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SupportTicket",
                table: "SupportTicket",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "ArticleRatings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 11, 41, 28, 685, DateTimeKind.Local).AddTicks(997), new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(995) });

            migrationBuilder.UpdateData(
                table: "ArticleRatings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 11, 41, 28, 685, DateTimeKind.Local).AddTicks(1001), new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(1001) });

            migrationBuilder.UpdateData(
                table: "ArticleRatings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 11, 41, 28, 685, DateTimeKind.Local).AddTicks(1003), new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "ArticleRatings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 11, 41, 28, 685, DateTimeKind.Local).AddTicks(1005), new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(1005) });

            migrationBuilder.UpdateData(
                table: "ArticleRatings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 11, 41, 28, 685, DateTimeKind.Local).AddTicks(1007), new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(1007) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Date", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(703), new DateTime(2022, 2, 4, 11, 41, 28, 685, DateTimeKind.Local).AddTicks(708), new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(703) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Date", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(739), new DateTime(2022, 2, 4, 11, 41, 28, 685, DateTimeKind.Local).AddTicks(739), new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(739) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Date", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(742), new DateTime(2022, 2, 4, 11, 41, 28, 685, DateTimeKind.Local).AddTicks(742), new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(742) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 11, 41, 28, 685, DateTimeKind.Local).AddTicks(1241), new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(1240) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 11, 41, 28, 685, DateTimeKind.Local).AddTicks(1246), new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(1245) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 11, 41, 28, 685, DateTimeKind.Local).AddTicks(1248), new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(1247) });

            migrationBuilder.UpdateData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(1432), new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(1431) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(2357));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(2826));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "SavedArticles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(2983), new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "SupportTicket",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(3181));

            migrationBuilder.UpdateData(
                table: "UserNotifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(8320), new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(8322), new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(8322) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(8323), new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(8323) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(3350));

            migrationBuilder.AddForeignKey(
                name: "FK_SupportTicket_Users_UserId",
                table: "SupportTicket",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
