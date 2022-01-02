using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ESN_Api.Migrations
{
    public partial class Initial_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Permissions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tags = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArticleComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArticleComments_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleComments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArticleRatings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleRatings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArticleRatings_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleRatings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favourites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Tags = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favourites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Favourites_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SavedArticles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavedArticles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SavedArticles_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SavedArticles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_UserId",
                        column: x => x.UserId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "ModifedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 2, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 1, 2, 17, 54, 8, 627, DateTimeKind.Utc).AddTicks(4457), "Male" },
                    { 2, new DateTime(2022, 1, 2, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 1, 2, 17, 54, 8, 627, DateTimeKind.Utc).AddTicks(4462), "Female" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "ModifedAt", "Name", "Permissions" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 2, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 1, 2, 17, 54, 8, 627, DateTimeKind.Utc).AddTicks(4833), "Admin", "Read, Write, Edit, Create, Delete" },
                    { 2, new DateTime(2022, 1, 2, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 1, 2, 17, 54, 8, 627, DateTimeKind.Utc).AddTicks(4835), "Editor", "Read, Write, Edit" },
                    { 3, new DateTime(2022, 1, 2, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 1, 2, 17, 54, 8, 627, DateTimeKind.Utc).AddTicks(4836), "User", "Read" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "GenderId", "Lastname", "ModifedAt", "Username" },
                values: new object[] { 1, new DateTime(2022, 1, 2, 18, 0, 0, 0, DateTimeKind.Utc), "desktop@mail.com", "desktop", 1, "", new DateTime(2022, 1, 2, 17, 54, 8, 627, DateTimeKind.Utc).AddTicks(5061), "desktop" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "GenderId", "Lastname", "ModifedAt", "Username" },
                values: new object[] { 2, new DateTime(2022, 1, 2, 18, 0, 0, 0, DateTimeKind.Utc), "mobile@mail.com", "mobile", 1, "", new DateTime(2022, 1, 2, 17, 54, 8, 627, DateTimeKind.Utc).AddTicks(5063), "mobile" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "GenderId", "Lastname", "ModifedAt", "Username" },
                values: new object[] { 3, new DateTime(2022, 1, 2, 18, 0, 0, 0, DateTimeKind.Utc), "korisnik@mail.com", "korisnik", 1, "", new DateTime(2022, 1, 2, 17, 54, 8, 627, DateTimeKind.Utc).AddTicks(5065), "korisnik" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "ModifedAt", "RoleId", "UserId" },
                values: new object[] { 1, new DateTime(2022, 1, 2, 17, 54, 8, 628, DateTimeKind.Utc).AddTicks(692), new DateTime(2022, 1, 2, 17, 54, 8, 628, DateTimeKind.Utc).AddTicks(692), 1, 1 });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "ModifedAt", "RoleId", "UserId" },
                values: new object[] { 2, new DateTime(2022, 1, 2, 17, 54, 8, 628, DateTimeKind.Utc).AddTicks(696), new DateTime(2022, 1, 2, 17, 54, 8, 628, DateTimeKind.Utc).AddTicks(696), 1, 2 });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "ModifedAt", "RoleId", "UserId" },
                values: new object[] { 3, new DateTime(2022, 1, 2, 17, 54, 8, 628, DateTimeKind.Utc).AddTicks(697), new DateTime(2022, 1, 2, 17, 54, 8, 628, DateTimeKind.Utc).AddTicks(697), 3, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleComments_ArticleId",
                table: "ArticleComments",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleComments_UserId",
                table: "ArticleComments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleRatings_ArticleId",
                table: "ArticleRatings",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleRatings_UserId",
                table: "ArticleRatings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Favourites_UserId",
                table: "Favourites",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SavedArticles_ArticleId",
                table: "SavedArticles",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_SavedArticles_UserId",
                table: "SavedArticles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_GenderId",
                table: "Users",
                column: "GenderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleComments");

            migrationBuilder.DropTable(
                name: "ArticleRatings");

            migrationBuilder.DropTable(
                name: "Favourites");

            migrationBuilder.DropTable(
                name: "SavedArticles");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Genders");
        }
    }
}
