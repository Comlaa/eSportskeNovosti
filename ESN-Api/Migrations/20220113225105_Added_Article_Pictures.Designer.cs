// <auto-generated />
using System;
using ESN_Api.ESN_Api.dal.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ESN_Api.Migrations
{
    [DbContext(typeof(ESNDbContext))]
    [Migration("20220113225105_Added_Article_Pictures")]
    partial class Added_Article_Pictures
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ESN_Api.ESN_Api.dal.Domain.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("AllowComments")
                        .HasColumnType("bit");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tags")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("ESN_Api.ESN_Api.dal.Domain.ArticleComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("UserId");

                    b.ToTable("ArticleComments");
                });

            modelBuilder.Entity("ESN_Api.ESN_Api.dal.Domain.ArticleRating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("UserId");

                    b.ToTable("ArticleRatings");
                });

            modelBuilder.Entity("ESN_Api.ESN_Api.dal.Domain.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ESN_Api.ESN_Api.dal.Domain.Favourite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Tags")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Favourites");
                });

            modelBuilder.Entity("ESN_Api.ESN_Api.dal.Domain.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2022, 1, 2, 18, 0, 0, 0, DateTimeKind.Utc),
                            ModifedAt = new DateTime(2022, 1, 13, 22, 51, 5, 64, DateTimeKind.Utc).AddTicks(8245),
                            Name = "Male"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2022, 1, 2, 18, 0, 0, 0, DateTimeKind.Utc),
                            ModifedAt = new DateTime(2022, 1, 13, 22, 51, 5, 64, DateTimeKind.Utc).AddTicks(8250),
                            Name = "Female"
                        });
                });

            modelBuilder.Entity("ESN_Api.ESN_Api.dal.Domain.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Permissions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2022, 1, 2, 18, 0, 0, 0, DateTimeKind.Utc),
                            ModifedAt = new DateTime(2022, 1, 13, 22, 51, 5, 64, DateTimeKind.Utc).AddTicks(8637),
                            Name = "Admin",
                            Permissions = "Read, Write, Edit, Create, Delete"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2022, 1, 2, 18, 0, 0, 0, DateTimeKind.Utc),
                            ModifedAt = new DateTime(2022, 1, 13, 22, 51, 5, 64, DateTimeKind.Utc).AddTicks(8639),
                            Name = "Editor",
                            Permissions = "Read, Write, Edit"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2022, 1, 2, 18, 0, 0, 0, DateTimeKind.Utc),
                            ModifedAt = new DateTime(2022, 1, 13, 22, 51, 5, 64, DateTimeKind.Utc).AddTicks(8640),
                            Name = "User",
                            Permissions = "Read"
                        });
                });

            modelBuilder.Entity("ESN_Api.ESN_Api.dal.Domain.SavedArticle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("UserId");

                    b.ToTable("SavedArticles");
                });

            modelBuilder.Entity("ESN_Api.ESN_Api.dal.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2022, 1, 2, 18, 0, 0, 0, DateTimeKind.Utc),
                            Email = "desktop@mail.com",
                            FirstName = "desktop",
                            GenderId = 1,
                            Lastname = "",
                            ModifedAt = new DateTime(2022, 1, 13, 22, 51, 5, 64, DateTimeKind.Utc).AddTicks(8864),
                            PasswordHash = "ExhCoLc0RVU6e1K2veoRh6dUP4FRE2uyFXAkQrsPYKc=",
                            PasswordSalt = "ohIp8ucWEgzGRvqMbu3InQ==",
                            Username = "desktop"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2022, 1, 2, 18, 0, 0, 0, DateTimeKind.Utc),
                            Email = "mobile@mail.com",
                            FirstName = "mobile",
                            GenderId = 1,
                            Lastname = "",
                            ModifedAt = new DateTime(2022, 1, 13, 22, 51, 5, 64, DateTimeKind.Utc).AddTicks(8868),
                            PasswordHash = "ExhCoLc0RVU6e1K2veoRh6dUP4FRE2uyFXAkQrsPYKc=",
                            PasswordSalt = "ohIp8ucWEgzGRvqMbu3InQ==",
                            Username = "mobile"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2022, 1, 2, 18, 0, 0, 0, DateTimeKind.Utc),
                            Email = "korisnik@mail.com",
                            FirstName = "korisnik",
                            GenderId = 1,
                            Lastname = "",
                            ModifedAt = new DateTime(2022, 1, 13, 22, 51, 5, 64, DateTimeKind.Utc).AddTicks(8870),
                            PasswordHash = "ExhCoLc0RVU6e1K2veoRh6dUP4FRE2uyFXAkQrsPYKc=",
                            PasswordSalt = "ohIp8ucWEgzGRvqMbu3InQ==",
                            Username = "korisnik"
                        });
                });

            modelBuilder.Entity("ESN_Api.ESN_Api.dal.Domain.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2022, 1, 13, 22, 51, 5, 65, DateTimeKind.Utc).AddTicks(4924),
                            ModifedAt = new DateTime(2022, 1, 13, 22, 51, 5, 65, DateTimeKind.Utc).AddTicks(4924),
                            RoleId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2022, 1, 13, 22, 51, 5, 65, DateTimeKind.Utc).AddTicks(4927),
                            ModifedAt = new DateTime(2022, 1, 13, 22, 51, 5, 65, DateTimeKind.Utc).AddTicks(4927),
                            RoleId = 1,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2022, 1, 13, 22, 51, 5, 65, DateTimeKind.Utc).AddTicks(4928),
                            ModifedAt = new DateTime(2022, 1, 13, 22, 51, 5, 65, DateTimeKind.Utc).AddTicks(4928),
                            RoleId = 3,
                            UserId = 3
                        });
                });

            modelBuilder.Entity("ESN_Api.ESN_Api.dal.Domain.Article", b =>
                {
                    b.HasOne("ESN_Api.ESN_Api.dal.Domain.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ESN_Api.ESN_Api.dal.Domain.ArticleComment", b =>
                {
                    b.HasOne("ESN_Api.ESN_Api.dal.Domain.Article", "Article")
                        .WithMany("ArticleComments")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ESN_Api.ESN_Api.dal.Domain.User", "User")
                        .WithMany("ArticleComments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ESN_Api.ESN_Api.dal.Domain.ArticleRating", b =>
                {
                    b.HasOne("ESN_Api.ESN_Api.dal.Domain.Article", "Article")
                        .WithMany("ArticleRatings")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ESN_Api.ESN_Api.dal.Domain.User", "User")
                        .WithMany("ArticleRatings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ESN_Api.ESN_Api.dal.Domain.Favourite", b =>
                {
                    b.HasOne("ESN_Api.ESN_Api.dal.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ESN_Api.ESN_Api.dal.Domain.SavedArticle", b =>
                {
                    b.HasOne("ESN_Api.ESN_Api.dal.Domain.Article", "Article")
                        .WithMany("SavedArticles")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ESN_Api.ESN_Api.dal.Domain.User", "User")
                        .WithMany("SavedArticles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ESN_Api.ESN_Api.dal.Domain.User", b =>
                {
                    b.HasOne("ESN_Api.ESN_Api.dal.Domain.Gender", "Gender")
                        .WithMany("Users")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("ESN_Api.ESN_Api.dal.Domain.UserRole", b =>
                {
                    b.HasOne("ESN_Api.ESN_Api.dal.Domain.User", "User")
                        .WithMany("Roles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ESN_Api.ESN_Api.dal.Domain.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ESN_Api.ESN_Api.dal.Domain.Article", b =>
                {
                    b.Navigation("ArticleComments");

                    b.Navigation("ArticleRatings");

                    b.Navigation("SavedArticles");
                });

            modelBuilder.Entity("ESN_Api.ESN_Api.dal.Domain.Gender", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("ESN_Api.ESN_Api.dal.Domain.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("ESN_Api.ESN_Api.dal.Domain.User", b =>
                {
                    b.Navigation("ArticleComments");

                    b.Navigation("ArticleRatings");

                    b.Navigation("Roles");

                    b.Navigation("SavedArticles");
                });
#pragma warning restore 612, 618
        }
    }
}
