﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechArtProfileProject.Lib.Infrastructure;

namespace TechArtProfileProject.Lib.Infrastructure.Migrations
{
    [DbContext(typeof(UserProfileDbContext))]
    partial class UserProfileDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("TechArtProfileProject.Lib.Model.Models.Contact", b =>
                {
                    b.Property<int>("SenderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("SenderEmail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SenderMessage")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SenderName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TimeSent")
                        .HasColumnType("TEXT");

                    b.HasKey("SenderId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("TechArtProfileProject.Lib.Model.Models.Education", b =>
                {
                    b.Property<int>("EducationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DegreeObtained")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discipline")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("GraduationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("SchoolName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserProfileId")
                        .HasColumnType("TEXT");

                    b.HasKey("EducationId");

                    b.HasIndex("UserProfileId");

                    b.ToTable("Educations");

                    b.HasData(
                        new
                        {
                            EducationId = 1,
                            DegreeObtained = "HND",
                            Discipline = "Computer Engineering",
                            GraduationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SchoolName = "Lagos State Polytechnic",
                            StartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1,
                            UserProfileId = "2438b126-7410-43dc-84f8-f5e6c5c71289"
                        },
                        new
                        {
                            EducationId = 2,
                            DegreeObtained = "OND",
                            Discipline = "Computer Engineering",
                            GraduationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SchoolName = "Lagos State Polytechnic",
                            StartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1,
                            UserProfileId = "2438b126-7410-43dc-84f8-f5e6c5c71289"
                        },
                        new
                        {
                            EducationId = 3,
                            DegreeObtained = "BSC",
                            Discipline = "Computer Science",
                            GraduationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SchoolName = "Lagos State University",
                            StartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 2,
                            UserProfileId = "77fe5873-b45c-482e-89f3-decad6c4ed3d"
                        },
                        new
                        {
                            EducationId = 4,
                            DegreeObtained = "MSc",
                            Discipline = "Software Engineering",
                            GraduationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SchoolName = "University of Ibadan",
                            StartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 2,
                            UserProfileId = "77fe5873-b45c-482e-89f3-decad6c4ed3d"
                        },
                        new
                        {
                            EducationId = 5,
                            DegreeObtained = "BSc",
                            Discipline = "Biomedical Engineering",
                            GraduationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SchoolName = "Lagos State Polytechnic",
                            StartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 3,
                            UserProfileId = "9e0444fb-e663-4b8a-88eb-1c9e256a0f48"
                        },
                        new
                        {
                            EducationId = 6,
                            DegreeObtained = "HND",
                            Discipline = "Soil Science",
                            GraduationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SchoolName = "Lagos State Polytechnic",
                            StartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 3,
                            UserProfileId = "9e0444fb-e663-4b8a-88eb-1c9e256a0f48"
                        });
                });

            modelBuilder.Entity("TechArtProfileProject.Lib.Model.Models.UserServices", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ServiceDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserProfileId")
                        .HasColumnType("TEXT");

                    b.HasKey("ServiceId");

                    b.HasIndex("UserProfileId");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            ServiceId = 1,
                            ServiceDescription = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                            ServiceName = "Web development",
                            UserId = 1,
                            UserProfileId = "2438b126-7410-43dc-84f8-f5e6c5c71289"
                        },
                        new
                        {
                            ServiceId = 2,
                            ServiceDescription = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                            ServiceName = "Software Development",
                            UserId = 1,
                            UserProfileId = "2438b126-7410-43dc-84f8-f5e6c5c71289"
                        },
                        new
                        {
                            ServiceId = 3,
                            ServiceDescription = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                            ServiceName = "Project Management",
                            UserId = 1,
                            UserProfileId = "2438b126-7410-43dc-84f8-f5e6c5c71289"
                        },
                        new
                        {
                            ServiceId = 4,
                            ServiceDescription = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                            ServiceName = "Mobile development",
                            UserId = 2,
                            UserProfileId = "77fe5873-b45c-482e-89f3-decad6c4ed3d"
                        },
                        new
                        {
                            ServiceId = 5,
                            ServiceDescription = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                            ServiceName = "Front-End Development",
                            UserId = 2,
                            UserProfileId = "77fe5873-b45c-482e-89f3-decad6c4ed3d"
                        },
                        new
                        {
                            ServiceId = 6,
                            ServiceDescription = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                            ServiceName = "Mean Stack Engineer",
                            UserId = 2,
                            UserProfileId = "77fe5873-b45c-482e-89f3-decad6c4ed3d"
                        },
                        new
                        {
                            ServiceId = 7,
                            ServiceDescription = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                            ServiceName = "Web development",
                            UserId = 3,
                            UserProfileId = "9e0444fb-e663-4b8a-88eb-1c9e256a0f48"
                        },
                        new
                        {
                            ServiceId = 8,
                            ServiceDescription = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                            ServiceName = "Web development",
                            UserId = 3,
                            UserProfileId = "9e0444fb-e663-4b8a-88eb-1c9e256a0f48"
                        },
                        new
                        {
                            ServiceId = 9,
                            ServiceDescription = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                            ServiceName = "Web development",
                            UserId = 3,
                            UserProfileId = "9e0444fb-e663-4b8a-88eb-1c9e256a0f48"
                        });
                });

            modelBuilder.Entity("TechArtProfileProject.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProjectDescription")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectLink")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserProfileId")
                        .HasColumnType("TEXT");

                    b.HasKey("ProjectId");

                    b.HasIndex("UserProfileId");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            ProjectId = 1,
                            ProjectDescription = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue. Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy. Fusce aliquet pede non pede. Suspendisse dapibus lorem pellentesque magna. Integer nulla. Donec blandit feugiat ligula",
                            ProjectLink = "https://github.com/Aitem2012/BankAccountModel",
                            ProjectName = "Bank App",
                            UserId = 1,
                            UserProfileId = "77fe5873-b45c-482e-89f3-decad6c4ed3d"
                        },
                        new
                        {
                            ProjectId = 2,
                            ProjectDescription = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue. Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy. Fusce aliquet pede non pede. Suspendisse dapibus lorem pellentesque magna. Integer nulla. Donec blandit feugiat ligula",
                            ProjectLink = "https://github.com/Aitem2012/BankAccountModel",
                            ProjectName = "MVC",
                            UserId = 1,
                            UserProfileId = "77fe5873-b45c-482e-89f3-decad6c4ed3d"
                        },
                        new
                        {
                            ProjectId = 3,
                            ProjectDescription = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue. Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy. Fusce aliquet pede non pede. Suspendisse dapibus lorem pellentesque magna. Integer nulla. Donec blandit feugiat ligula",
                            ProjectLink = "https://github.com/Aitem2012/BankAccountModel",
                            ProjectName = "Fire Alarm",
                            UserId = 2,
                            UserProfileId = "2438b126-7410-43dc-84f8-f5e6c5c71289"
                        },
                        new
                        {
                            ProjectId = 4,
                            ProjectDescription = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue. Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy. Fusce aliquet pede non pede. Suspendisse dapibus lorem pellentesque magna. Integer nulla. Donec blandit feugiat ligula",
                            ProjectLink = "https://github.com/Aitem2012/BankAccountModel",
                            ProjectName = "Mobile SMS Sender",
                            UserId = 2,
                            UserProfileId = "2438b126-7410-43dc-84f8-f5e6c5c71289"
                        },
                        new
                        {
                            ProjectId = 5,
                            ProjectDescription = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue. Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy. Fusce aliquet pede non pede. Suspendisse dapibus lorem pellentesque magna. Integer nulla. Donec blandit feugiat ligula",
                            ProjectLink = "https://github.com/Aitem2012/BankAccountModel",
                            ProjectName = "Intruder Detection System",
                            UserId = 3,
                            UserProfileId = "9e0444fb-e663-4b8a-88eb-1c9e256a0f48"
                        },
                        new
                        {
                            ProjectId = 6,
                            ProjectDescription = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue. Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy. Fusce aliquet pede non pede. Suspendisse dapibus lorem pellentesque magna. Integer nulla. Donec blandit feugiat ligula",
                            ProjectLink = "https://github.com/Aitem2012/BankAccountModel",
                            ProjectName = "Mobile Metal Detector",
                            UserId = 3,
                            UserProfileId = "9e0444fb-e663-4b8a-88eb-1c9e256a0f48"
                        });
                });

            modelBuilder.Entity("TechArtProfileProject.Models.UserProfile", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Biography")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasDiscriminator().HasValue("UserProfile");

                    b.HasData(
                        new
                        {
                            Id = "9e0444fb-e663-4b8a-88eb-1c9e256a0f48",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3f3eeb64-7b23-401b-9bb4-728b67852829",
                            Email = "ajumokoibrahimtemitope@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "bea3a5ce-b0e2-42c0-8840-de8a44105629",
                            TwoFactorEnabled = false,
                            Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                            FirstName = "Ibrahim",
                            Image = "images/aitem.jpg",
                            JobTitle = "Software Developer",
                            LastName = "Temitope",
                            UserId = 1
                        },
                        new
                        {
                            Id = "2438b126-7410-43dc-84f8-f5e6c5c71289",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "39a38606-c842-49ac-bfdc-6ff85d285ee3",
                            Email = "ucheeugene@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6a9f5b73-ed73-49f2-bf1a-a772a933dc9b",
                            TwoFactorEnabled = false,
                            Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                            FirstName = "Uche",
                            Image = "images/LinkedIn-Profile-1.jpg",
                            JobTitle = "Software Developer",
                            LastName = "Eugene",
                            UserId = 2
                        },
                        new
                        {
                            Id = "77fe5873-b45c-482e-89f3-decad6c4ed3d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8ab1b5cc-f493-4b78-a5c8-be44e9659804",
                            Email = "solomon_young@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "cc195842-afb1-448e-8b54-a459a596c9f6",
                            TwoFactorEnabled = false,
                            Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                            FirstName = "Solomon",
                            Image = "images/image2.jpg",
                            JobTitle = "Software Developer",
                            LastName = "Young",
                            UserId = 3
                        });
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TechArtProfileProject.Lib.Model.Models.Education", b =>
                {
                    b.HasOne("TechArtProfileProject.Models.UserProfile", "UserProfile")
                        .WithMany("Educations")
                        .HasForeignKey("UserProfileId");

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("TechArtProfileProject.Lib.Model.Models.UserServices", b =>
                {
                    b.HasOne("TechArtProfileProject.Models.UserProfile", "UserProfile")
                        .WithMany("Services")
                        .HasForeignKey("UserProfileId");

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("TechArtProfileProject.Models.Project", b =>
                {
                    b.HasOne("TechArtProfileProject.Models.UserProfile", "UserProfile")
                        .WithMany("Projects")
                        .HasForeignKey("UserProfileId");

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("TechArtProfileProject.Models.UserProfile", b =>
                {
                    b.Navigation("Educations");

                    b.Navigation("Projects");

                    b.Navigation("Services");
                });
#pragma warning restore 612, 618
        }
    }
}
