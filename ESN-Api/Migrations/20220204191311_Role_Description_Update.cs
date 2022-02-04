using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ESN_Api.Migrations
{
    public partial class Role_Description_Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Permissions",
                table: "Roles",
                newName: "Description");

            migrationBuilder.UpdateData(
                table: "ArticleRatings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 20, 13, 10, 747, DateTimeKind.Local).AddTicks(3966), new DateTime(2022, 2, 4, 19, 13, 10, 747, DateTimeKind.Utc).AddTicks(3965) });

            migrationBuilder.UpdateData(
                table: "ArticleRatings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 20, 13, 10, 747, DateTimeKind.Local).AddTicks(3970), new DateTime(2022, 2, 4, 19, 13, 10, 747, DateTimeKind.Utc).AddTicks(3970) });

            migrationBuilder.UpdateData(
                table: "ArticleRatings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 20, 13, 10, 747, DateTimeKind.Local).AddTicks(3973), new DateTime(2022, 2, 4, 19, 13, 10, 747, DateTimeKind.Utc).AddTicks(3972) });

            migrationBuilder.UpdateData(
                table: "ArticleRatings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 20, 13, 10, 747, DateTimeKind.Local).AddTicks(3975), new DateTime(2022, 2, 4, 19, 13, 10, 747, DateTimeKind.Utc).AddTicks(3975) });

            migrationBuilder.UpdateData(
                table: "ArticleRatings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 20, 13, 10, 747, DateTimeKind.Local).AddTicks(3977), new DateTime(2022, 2, 4, 19, 13, 10, 747, DateTimeKind.Utc).AddTicks(3977) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Date", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 19, 13, 10, 747, DateTimeKind.Utc).AddTicks(3613), new DateTime(2022, 2, 4, 20, 13, 10, 747, DateTimeKind.Local).AddTicks(3622), new DateTime(2022, 2, 4, 19, 13, 10, 747, DateTimeKind.Utc).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Date", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 19, 13, 10, 747, DateTimeKind.Utc).AddTicks(3678), new DateTime(2022, 2, 4, 20, 13, 10, 747, DateTimeKind.Local).AddTicks(3679), new DateTime(2022, 2, 4, 19, 13, 10, 747, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Date", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 19, 13, 10, 747, DateTimeKind.Utc).AddTicks(3680), new DateTime(2022, 2, 4, 20, 13, 10, 747, DateTimeKind.Local).AddTicks(3681), new DateTime(2022, 2, 4, 19, 13, 10, 747, DateTimeKind.Utc).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 20, 13, 10, 747, DateTimeKind.Local).AddTicks(4164), new DateTime(2022, 2, 4, 19, 13, 10, 747, DateTimeKind.Utc).AddTicks(4163) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 20, 13, 10, 747, DateTimeKind.Local).AddTicks(4168), new DateTime(2022, 2, 4, 19, 13, 10, 747, DateTimeKind.Utc).AddTicks(4168) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 20, 13, 10, 747, DateTimeKind.Local).AddTicks(4170), new DateTime(2022, 2, 4, 19, 13, 10, 747, DateTimeKind.Utc).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 19, 13, 10, 747, DateTimeKind.Utc).AddTicks(4404), new DateTime(2022, 2, 4, 19, 13, 10, 747, DateTimeKind.Utc).AddTicks(4403) });

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 19, 13, 10, 747, DateTimeKind.Utc).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 19, 13, 10, 747, DateTimeKind.Utc).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 19, 13, 10, 747, DateTimeKind.Utc).AddTicks(5516));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 19, 13, 10, 747, DateTimeKind.Utc).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ModifedAt" },
                values: new object[] { "Admin related role. Admin has all the rights on the system.", new DateTime(2022, 2, 4, 19, 13, 10, 747, DateTimeKind.Utc).AddTicks(5961) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ModifedAt" },
                values: new object[] { "Editor related role. Has less rights than admin, but more than User role", new DateTime(2022, 2, 4, 19, 13, 10, 747, DateTimeKind.Utc).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ModifedAt" },
                values: new object[] { "User related role", new DateTime(2022, 2, 4, 19, 13, 10, 747, DateTimeKind.Utc).AddTicks(5963) });

            migrationBuilder.UpdateData(
                table: "SavedArticles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 19, 13, 10, 747, DateTimeKind.Utc).AddTicks(6134), new DateTime(2022, 2, 4, 19, 13, 10, 747, DateTimeKind.Utc).AddTicks(6134) });

            migrationBuilder.UpdateData(
                table: "SupportTickets",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 19, 13, 10, 747, DateTimeKind.Utc).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "UserNotifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 19, 13, 10, 747, DateTimeKind.Utc).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 19, 13, 10, 748, DateTimeKind.Utc).AddTicks(1594), new DateTime(2022, 2, 4, 19, 13, 10, 748, DateTimeKind.Utc).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 19, 13, 10, 748, DateTimeKind.Utc).AddTicks(1597), new DateTime(2022, 2, 4, 19, 13, 10, 748, DateTimeKind.Utc).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2022, 2, 4, 19, 13, 10, 748, DateTimeKind.Utc).AddTicks(1598), new DateTime(2022, 2, 4, 19, 13, 10, 748, DateTimeKind.Utc).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 19, 13, 10, 747, DateTimeKind.Utc).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 19, 13, 10, 747, DateTimeKind.Utc).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 19, 13, 10, 747, DateTimeKind.Utc).AddTicks(6449));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Roles",
                newName: "Permissions");

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

            migrationBuilder.UpdateData(
                table: "Fixtures",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifedAt",
                value: new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(2228));

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
                columns: new[] { "ModifedAt", "Permissions" },
                values: new object[] { new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(3535), "Read, Write, Edit, Create, Delete" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ModifedAt", "Permissions" },
                values: new object[] { new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(3536), "Read, Write, Edit" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ModifedAt", "Permissions" },
                values: new object[] { new DateTime(2022, 2, 4, 13, 57, 28, 467, DateTimeKind.Utc).AddTicks(3537), "Read, Write" });

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
        }
    }
}
