﻿// <auto-generated />
using System;
using BookReviews.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookReviews.Migrations
{
    [DbContext(typeof(BookReviewContext))]
    [Migration("20220223162925_MoreSeedData")]
    partial class MoreSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookReviews.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "A",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6a31de41-be09-47e8-ba25-a336b253b10f",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Brian Bird",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "72451096-df6e-4b46-a1a1-ac8a50da7743",
                            TwoFactorEnabled = false,
                            UserName = "BrianB"
                        },
                        new
                        {
                            Id = "B",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7a224645-0faa-4186-9447-e3cbe3f6137f",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Emma Watson",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2e6b6d76-b097-443a-884c-61992b25838b",
                            TwoFactorEnabled = false,
                            UserName = "EmmaW"
                        },
                        new
                        {
                            Id = "C",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c7390f05-b62a-4ab5-b448-9b758635b1e8",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Daniel Radcliffe",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7c2ba419-d85f-471e-a1ba-203ba694ada2",
                            TwoFactorEnabled = false,
                            UserName = "DanielR"
                        },
                        new
                        {
                            Id = "D",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "818b5f83-1b59-46ee-a0df-0e85b2870db3",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Scarlett Johansson",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8f0e25fc-15d2-449f-a32c-d8c0bf617f0e",
                            TwoFactorEnabled = false,
                            UserName = "ScarlettJ"
                        });
                });

            modelBuilder.Entity("BookReviews.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CommentText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommenterId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ReviewId")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.HasIndex("CommenterId");

                    b.HasIndex("ReviewId");

                    b.ToTable("Comment");

                    b.HasData(
                        new
                        {
                            CommentId = 1,
                            CommentDate = new DateTime(2020, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CommentText = "I loved that book as a kid too!",
                            CommenterId = "A",
                            ReviewId = 6
                        },
                        new
                        {
                            CommentId = 2,
                            CommentDate = new DateTime(2020, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CommentText = "I'm glad you were able to get into the book. I never could.",
                            CommenterId = "C",
                            ReviewId = 5
                        },
                        new
                        {
                            CommentId = 3,
                            CommentDate = new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CommentText = "Wow, how are you related to Lief Enger?",
                            CommenterId = "B",
                            ReviewId = 3
                        },
                        new
                        {
                            CommentId = 4,
                            CommentDate = new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CommentText = "Yes, and as professor Kirk says, it's all about logic.",
                            CommenterId = "B",
                            ReviewId = 7
                        },
                        new
                        {
                            CommentId = 5,
                            CommentDate = new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CommentText = "I'm not sure how we're related. Some kind of distant cousin on my Mom's side.",
                            CommenterId = "A",
                            ReviewId = 3
                        });
                });

            modelBuilder.Entity("BookReviews.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReviewText")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("ReviewerId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ReviewId");

                    b.HasIndex("ReviewerId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            AuthorName = "Samuel Shellabarger",
                            BookTitle = "Prince of Foxes",
                            Rating = 5,
                            ReviewDate = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReviewText = "Great book, a must read!",
                            ReviewerId = "B"
                        },
                        new
                        {
                            ReviewId = 2,
                            AuthorName = "Samuel Shellabarger",
                            BookTitle = "Prince of Foxes",
                            Rating = 5,
                            ReviewDate = new DateTime(2020, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReviewText = "I love the clever, witty dialog",
                            ReviewerId = "C"
                        },
                        new
                        {
                            ReviewId = 3,
                            AuthorName = "Lief Enger",
                            BookTitle = "Virgil Wander",
                            Rating = 5,
                            ReviewDate = new DateTime(2020, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReviewText = "Wonderful book, written by a distant relative of mine.",
                            ReviewerId = "A"
                        },
                        new
                        {
                            ReviewId = 4,
                            AuthorName = "Lief Enger",
                            BookTitle = "Virgil Wander",
                            Rating = 4,
                            ReviewDate = new DateTime(2019, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReviewText = "This book is a bit surreal, but it kept me engaged and reading right to the end.",
                            ReviewerId = "D"
                        },
                        new
                        {
                            ReviewId = 5,
                            AuthorName = "Sir Walter Scott",
                            BookTitle = "Ivanho",
                            Rating = 4,
                            ReviewDate = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReviewText = "It was a little hard going at first, but then I loved it!",
                            ReviewerId = "A"
                        },
                        new
                        {
                            ReviewId = 6,
                            AuthorName = "C. S. Lewis",
                            BookTitle = "The Lion, the Witch and the Wardrobe",
                            Rating = 4,
                            ReviewDate = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReviewText = "I loved this book as a kid and I still love it!",
                            ReviewerId = "B"
                        },
                        new
                        {
                            ReviewId = 7,
                            AuthorName = "C. S. Lewis",
                            BookTitle = "The Lion, the Witch and the Wardrobe",
                            Rating = 4,
                            ReviewDate = new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReviewText = "This book inspired me to believe in things that others think are impossible.",
                            ReviewerId = "D"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("BookReviews.Models.Comment", b =>
                {
                    b.HasOne("BookReviews.Models.AppUser", "Commenter")
                        .WithMany()
                        .HasForeignKey("CommenterId");

                    b.HasOne("BookReviews.Models.Review", null)
                        .WithMany("Comments")
                        .HasForeignKey("ReviewId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookReviews.Models.Review", b =>
                {
                    b.HasOne("BookReviews.Models.AppUser", "Reviewer")
                        .WithMany()
                        .HasForeignKey("ReviewerId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BookReviews.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BookReviews.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookReviews.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BookReviews.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
