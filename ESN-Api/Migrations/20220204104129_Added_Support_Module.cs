using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ESN_Api.Migrations
{
    public partial class Added_Support_Module : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SupportTicket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportTicket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SupportTicket_Users_UserId",
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

            migrationBuilder.InsertData(
                table: "SupportTicket",
                columns: new[] { "Id", "CreatedAt", "Email", "ModifedAt", "Text", "UserId" },
                values: new object[] { 1, new DateTime(2022, 1, 2, 18, 0, 0, 0, DateTimeKind.Utc), "korisnik@mail.com", new DateTime(2022, 2, 4, 10, 41, 28, 685, DateTimeKind.Utc).AddTicks(3181), "Testiranje funkcionalnosti podrske.", 3 });

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

            migrationBuilder.CreateIndex(
                name: "IX_SupportTicket_UserId",
                table: "SupportTicket",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SupportTicket");

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

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 3, 18, 40, 23, 701, DateTimeKind.Utc).AddTicks(7555));

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
                table: "UserNotifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 3, 18, 40, 23, 701, DateTimeKind.Utc).AddTicks(8898));

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
        }
    }
}
