using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TechArtProfileProject.Lib.Infrastructure.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true).
                            Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true),
                    Image = table.Column<string>(type: "TEXT", nullable: true),
                    Biography = table.Column<string>(type: "TEXT", nullable: true),
                    JobTitle = table.Column<string>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    SenderId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SenderName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    SenderMessage = table.Column<string>(type: "TEXT", nullable: false),
                    SenderEmail = table.Column<string>(type: "TEXT", nullable: false),
                    TimeSent = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.SenderId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    EducationId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DegreeObtained = table.Column<string>(type: "TEXT", nullable: false),
                    SchoolName = table.Column<string>(type: "TEXT", nullable: false),
                    Discipline = table.Column<string>(type: "TEXT", nullable: true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    GraduationDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserProfileId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.EducationId);
                    table.ForeignKey(
                        name: "FK_Educations_AspNetUsers_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProjectDescription = table.Column<string>(type: "TEXT", maxLength: 300, nullable: false),
                    ProjectName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    ProjectLink = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserProfileId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                    table.ForeignKey(
                        name: "FK_Projects_AspNetUsers_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ServiceName = table.Column<string>(type: "TEXT", nullable: false),
                    ServiceDescription = table.Column<string>(type: "TEXT", nullable: false),
                    UserProfileId = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceId);
                    table.ForeignKey(
                        name: "FK_Services_AspNetUsers_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Biography", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "Image", "JobTitle", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserId", "UserName" },
                values: new object[] { "9e0444fb-e663-4b8a-88eb-1c9e256a0f48", 0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "3f3eeb64-7b23-401b-9bb4-728b67852829", "UserProfile", "ajumokoibrahimtemitope@gmail.com", false, "Ibrahim", "images/aitem.jpg", "Software Developer", "Temitope", false, null, null, null, null, null, false, "bea3a5ce-b0e2-42c0-8840-de8a44105629", false, 1, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Biography", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "Image", "JobTitle", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserId", "UserName" },
                values: new object[] { "2438b126-7410-43dc-84f8-f5e6c5c71289", 0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "39a38606-c842-49ac-bfdc-6ff85d285ee3", "UserProfile", "ucheeugene@gmail.com", false, "Uche", "images/LinkedIn-Profile-1.jpg", "Software Developer", "Eugene", false, null, null, null, null, null, false, "6a9f5b73-ed73-49f2-bf1a-a772a933dc9b", false, 2, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Biography", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "Image", "JobTitle", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserId", "UserName" },
                values: new object[] { "77fe5873-b45c-482e-89f3-decad6c4ed3d", 0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "8ab1b5cc-f493-4b78-a5c8-be44e9659804", "UserProfile", "solomon_young@gmail.com", false, "Solomon", "images/image2.jpg", "Software Developer", "Young", false, null, null, null, null, null, false, "cc195842-afb1-448e-8b54-a459a596c9f6", false, 3, null });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "EducationId", "DegreeObtained", "Discipline", "GraduationDate", "SchoolName", "StartDate", "UserId", "UserProfileId" },
                values: new object[] { 5, "BSc", "Biomedical Engineering", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lagos State Polytechnic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "9e0444fb-e663-4b8a-88eb-1c9e256a0f48" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "EducationId", "DegreeObtained", "Discipline", "GraduationDate", "SchoolName", "StartDate", "UserId", "UserProfileId" },
                values: new object[] { 6, "HND", "Soil Science", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lagos State Polytechnic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "9e0444fb-e663-4b8a-88eb-1c9e256a0f48" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "EducationId", "DegreeObtained", "Discipline", "GraduationDate", "SchoolName", "StartDate", "UserId", "UserProfileId" },
                values: new object[] { 4, "MSc", "Software Engineering", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "University of Ibadan", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "77fe5873-b45c-482e-89f3-decad6c4ed3d" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "EducationId", "DegreeObtained", "Discipline", "GraduationDate", "SchoolName", "StartDate", "UserId", "UserProfileId" },
                values: new object[] { 3, "BSC", "Computer Science", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lagos State University", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "77fe5873-b45c-482e-89f3-decad6c4ed3d" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "EducationId", "DegreeObtained", "Discipline", "GraduationDate", "SchoolName", "StartDate", "UserId", "UserProfileId" },
                values: new object[] { 1, "HND", "Computer Engineering", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lagos State Polytechnic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "2438b126-7410-43dc-84f8-f5e6c5c71289" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "EducationId", "DegreeObtained", "Discipline", "GraduationDate", "SchoolName", "StartDate", "UserId", "UserProfileId" },
                values: new object[] { 2, "OND", "Computer Engineering", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lagos State Polytechnic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "2438b126-7410-43dc-84f8-f5e6c5c71289" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectDescription", "ProjectLink", "ProjectName", "UserId", "UserProfileId" },
                values: new object[] { 4, "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue. Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy. Fusce aliquet pede non pede. Suspendisse dapibus lorem pellentesque magna. Integer nulla. Donec blandit feugiat ligula", "https://github.com/Aitem2012/BankAccountModel", "Mobile SMS Sender", 2, "2438b126-7410-43dc-84f8-f5e6c5c71289" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectDescription", "ProjectLink", "ProjectName", "UserId", "UserProfileId" },
                values: new object[] { 3, "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue. Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy. Fusce aliquet pede non pede. Suspendisse dapibus lorem pellentesque magna. Integer nulla. Donec blandit feugiat ligula", "https://github.com/Aitem2012/BankAccountModel", "Fire Alarm", 2, "2438b126-7410-43dc-84f8-f5e6c5c71289" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectDescription", "ProjectLink", "ProjectName", "UserId", "UserProfileId" },
                values: new object[] { 1, "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue. Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy. Fusce aliquet pede non pede. Suspendisse dapibus lorem pellentesque magna. Integer nulla. Donec blandit feugiat ligula", "https://github.com/Aitem2012/BankAccountModel", "Bank App", 1, "77fe5873-b45c-482e-89f3-decad6c4ed3d" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectDescription", "ProjectLink", "ProjectName", "UserId", "UserProfileId" },
                values: new object[] { 2, "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue. Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy. Fusce aliquet pede non pede. Suspendisse dapibus lorem pellentesque magna. Integer nulla. Donec blandit feugiat ligula", "https://github.com/Aitem2012/BankAccountModel", "MVC", 1, "77fe5873-b45c-482e-89f3-decad6c4ed3d" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectDescription", "ProjectLink", "ProjectName", "UserId", "UserProfileId" },
                values: new object[] { 6, "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue. Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy. Fusce aliquet pede non pede. Suspendisse dapibus lorem pellentesque magna. Integer nulla. Donec blandit feugiat ligula", "https://github.com/Aitem2012/BankAccountModel", "Mobile Metal Detector", 3, "9e0444fb-e663-4b8a-88eb-1c9e256a0f48" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectDescription", "ProjectLink", "ProjectName", "UserId", "UserProfileId" },
                values: new object[] { 5, "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue. Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy. Fusce aliquet pede non pede. Suspendisse dapibus lorem pellentesque magna. Integer nulla. Donec blandit feugiat ligula", "https://github.com/Aitem2012/BankAccountModel", "Intruder Detection System", 3, "9e0444fb-e663-4b8a-88eb-1c9e256a0f48" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "ServiceId", "ServiceDescription", "ServiceName", "UserId", "UserProfileId" },
                values: new object[] { 3, "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.", "Project Management", 1, "2438b126-7410-43dc-84f8-f5e6c5c71289" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "ServiceId", "ServiceDescription", "ServiceName", "UserId", "UserProfileId" },
                values: new object[] { 9, "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.", "Web development", 3, "9e0444fb-e663-4b8a-88eb-1c9e256a0f48" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "ServiceId", "ServiceDescription", "ServiceName", "UserId", "UserProfileId" },
                values: new object[] { 8, "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.", "Web development", 3, "9e0444fb-e663-4b8a-88eb-1c9e256a0f48" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "ServiceId", "ServiceDescription", "ServiceName", "UserId", "UserProfileId" },
                values: new object[] { 7, "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.", "Web development", 3, "9e0444fb-e663-4b8a-88eb-1c9e256a0f48" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "ServiceId", "ServiceDescription", "ServiceName", "UserId", "UserProfileId" },
                values: new object[] { 4, "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.", "Mobile development", 2, "77fe5873-b45c-482e-89f3-decad6c4ed3d" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "ServiceId", "ServiceDescription", "ServiceName", "UserId", "UserProfileId" },
                values: new object[] { 5, "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.", "Front-End Development", 2, "77fe5873-b45c-482e-89f3-decad6c4ed3d" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "ServiceId", "ServiceDescription", "ServiceName", "UserId", "UserProfileId" },
                values: new object[] { 6, "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.", "Mean Stack Engineer", 2, "77fe5873-b45c-482e-89f3-decad6c4ed3d" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "ServiceId", "ServiceDescription", "ServiceName", "UserId", "UserProfileId" },
                values: new object[] { 1, "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.", "Web development", 1, "2438b126-7410-43dc-84f8-f5e6c5c71289" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "ServiceId", "ServiceDescription", "ServiceName", "UserId", "UserProfileId" },
                values: new object[] { 2, "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.", "Software Development", 1, "2438b126-7410-43dc-84f8-f5e6c5c71289" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Educations_UserProfileId",
                table: "Educations",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_UserProfileId",
                table: "Projects",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_UserProfileId",
                table: "Services",
                column: "UserProfileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
