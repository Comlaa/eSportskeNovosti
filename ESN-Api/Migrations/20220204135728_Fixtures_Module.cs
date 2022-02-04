using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ESN_Api.Migrations
{
    public partial class Fixtures_Module : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fixtures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Team1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Team2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatchTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fixtures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fixtures_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "ArticleRatings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 14, 57, 28, 467, DateTimeKind.Local).AddTicks(1660), new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "ArticleRatings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 14, 57, 28, 467, DateTimeKind.Local).AddTicks(1664), new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "ArticleRatings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 14, 57, 28, 467, DateTimeKind.Local).AddTicks(1666), new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "ArticleRatings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 14, 57, 28, 467, DateTimeKind.Local).AddTicks(1667), new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(1667) });

            migrationBuilder.UpdateData(
                table: "ArticleRatings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 14, 57, 28, 467, DateTimeKind.Local).AddTicks(1673), new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Date", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(1376), new DateTime(2022, 2, 4, 14, 57, 28, 467, DateTimeKind.Local).AddTicks(1382), new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Date", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(1419), new DateTime(2022, 2, 4, 14, 57, 28, 467, DateTimeKind.Local).AddTicks(1420), new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(1419) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Date", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(1422), new DateTime(2022, 2, 4, 14, 57, 28, 467, DateTimeKind.Local).AddTicks(1422), new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(1422) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 14, 57, 28, 467, DateTimeKind.Local).AddTicks(1825), new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(1824) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 14, 57, 28, 467, DateTimeKind.Local).AddTicks(1828), new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(1828) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 14, 57, 28, 467, DateTimeKind.Local).AddTicks(1830), new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(1829) });

            migrationBuilder.UpdateData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(2077), new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(2076) });

            migrationBuilder.InsertData(
                table: "Fixtures",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "MatchTime", "ModifedAt", "Result", "Team1", "Team2" },
                values: new object[] { 1, 1, new DateTime(2022, 2, 4, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 2, 4, 21, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(2228), "2:1", "Barcelona", "Real Madrid" });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(3111));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(3535));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "SavedArticles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(3683), new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(3683) });

            migrationBuilder.UpdateData(
                table: "SupportTickets",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "UserNotifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(8544), new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(8544) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(8547), new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(8547) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(8548), new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(8548) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.CreateIndex(
                name: "IX_Fixtures_CategoryId",
                table: "Fixtures",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fixtures");

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
        }
    }
}
