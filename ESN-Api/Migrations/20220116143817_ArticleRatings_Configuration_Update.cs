using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ESN_Api.Migrations
{
    public partial class ArticleRatings_Configuration_Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "ArticleRatings",
                columns: new[] { "Id", "ArticleId", "CreatedAt", "ModifedAt", "Rating", "UserId" },
                values: new object[] { 5, 3, new DateTime(2022, 1, 16, 15, 38, 16, 876, DateTimeKind.Local).AddTicks(2628), new DateTime(2022, 1, 16, 14, 38, 16, 876, DateTimeKind.Utc).AddTicks(2627), 4, 1 });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArticleRatings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "ArticleRatings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 1, 16, 13, 32, 34, 708, DateTimeKind.Local).AddTicks(5005), new DateTime(2022, 1, 16, 12, 32, 34, 708, DateTimeKind.Utc).AddTicks(5004) });

            migrationBuilder.UpdateData(
                table: "ArticleRatings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 1, 16, 13, 32, 34, 708, DateTimeKind.Local).AddTicks(5012), new DateTime(2022, 1, 16, 12, 32, 34, 708, DateTimeKind.Utc).AddTicks(5012) });

            migrationBuilder.UpdateData(
                table: "ArticleRatings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 1, 16, 13, 32, 34, 708, DateTimeKind.Local).AddTicks(5014), new DateTime(2022, 1, 16, 12, 32, 34, 708, DateTimeKind.Utc).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "ArticleRatings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 1, 16, 13, 32, 34, 708, DateTimeKind.Local).AddTicks(5016), new DateTime(2022, 1, 16, 12, 32, 34, 708, DateTimeKind.Utc).AddTicks(5016) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Date", "ModifedAt" },
                values: new object[] { new DateTime(2022, 1, 16, 12, 32, 34, 708, DateTimeKind.Utc).AddTicks(4414), new DateTime(2022, 1, 16, 13, 32, 34, 708, DateTimeKind.Local).AddTicks(4422), new DateTime(2022, 1, 16, 12, 32, 34, 708, DateTimeKind.Utc).AddTicks(4414) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Date", "ModifedAt" },
                values: new object[] { new DateTime(2022, 1, 16, 12, 32, 34, 708, DateTimeKind.Utc).AddTicks(4459), new DateTime(2022, 1, 16, 13, 32, 34, 708, DateTimeKind.Local).AddTicks(4460), new DateTime(2022, 1, 16, 12, 32, 34, 708, DateTimeKind.Utc).AddTicks(4459) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Date", "ModifedAt" },
                values: new object[] { new DateTime(2022, 1, 16, 12, 32, 34, 708, DateTimeKind.Utc).AddTicks(4462), new DateTime(2022, 1, 16, 13, 32, 34, 708, DateTimeKind.Local).AddTicks(4462), new DateTime(2022, 1, 16, 12, 32, 34, 708, DateTimeKind.Utc).AddTicks(4462) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 1, 16, 13, 32, 34, 708, DateTimeKind.Local).AddTicks(5608), new DateTime(2022, 1, 16, 12, 32, 34, 708, DateTimeKind.Utc).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 1, 16, 13, 32, 34, 708, DateTimeKind.Local).AddTicks(5615), new DateTime(2022, 1, 16, 12, 32, 34, 708, DateTimeKind.Utc).AddTicks(5615) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 1, 16, 13, 32, 34, 708, DateTimeKind.Local).AddTicks(5617), new DateTime(2022, 1, 16, 12, 32, 34, 708, DateTimeKind.Utc).AddTicks(5617) });

            migrationBuilder.UpdateData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 1, 16, 12, 32, 34, 708, DateTimeKind.Utc).AddTicks(5893), new DateTime(2022, 1, 16, 12, 32, 34, 708, DateTimeKind.Utc).AddTicks(5892) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifedAt",
                value: new DateTime(2022, 1, 16, 12, 32, 34, 708, DateTimeKind.Utc).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifedAt",
                value: new DateTime(2022, 1, 16, 12, 32, 34, 708, DateTimeKind.Utc).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifedAt",
                value: new DateTime(2022, 1, 16, 12, 32, 34, 708, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifedAt",
                value: new DateTime(2022, 1, 16, 12, 32, 34, 708, DateTimeKind.Utc).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifedAt",
                value: new DateTime(2022, 1, 16, 12, 32, 34, 708, DateTimeKind.Utc).AddTicks(7479));

            migrationBuilder.UpdateData(
                table: "SavedArticles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 1, 16, 12, 32, 34, 708, DateTimeKind.Utc).AddTicks(8017), new DateTime(2022, 1, 16, 12, 32, 34, 708, DateTimeKind.Utc).AddTicks(8017) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 1, 16, 12, 32, 34, 709, DateTimeKind.Utc).AddTicks(6015), new DateTime(2022, 1, 16, 12, 32, 34, 709, DateTimeKind.Utc).AddTicks(6015) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 1, 16, 12, 32, 34, 709, DateTimeKind.Utc).AddTicks(6020), new DateTime(2022, 1, 16, 12, 32, 34, 709, DateTimeKind.Utc).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 1, 16, 12, 32, 34, 709, DateTimeKind.Utc).AddTicks(6021), new DateTime(2022, 1, 16, 12, 32, 34, 709, DateTimeKind.Utc).AddTicks(6021) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifedAt",
                value: new DateTime(2022, 1, 16, 12, 32, 34, 708, DateTimeKind.Utc).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifedAt",
                value: new DateTime(2022, 1, 16, 12, 32, 34, 708, DateTimeKind.Utc).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifedAt",
                value: new DateTime(2022, 1, 16, 12, 32, 34, 708, DateTimeKind.Utc).AddTicks(8222));
        }
    }
}
