using Microsoft.EntityFrameworkCore.Migrations;

namespace TechArtProfileProject.Lib.Infrastructure.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Services",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Projects",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Educations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2438b126-7410-43dc-84f8-f5e6c5c71289",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UserId" },
                values: new object[] { "7e08dc80-3a29-4d0c-9822-92e8af23396e", "67d740b0-7ab4-4145-87d6-541843892d64", 2 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77fe5873-b45c-482e-89f3-decad6c4ed3d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UserId" },
                values: new object[] { "b7ab9a97-020f-46ff-8fe6-84aa5eec1ddf", "bd2bf4b0-a61a-488b-b1b6-c806a94728b2", 3 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e0444fb-e663-4b8a-88eb-1c9e256a0f48",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UserId" },
                values: new object[] { "86a07da6-27f6-42fa-8ef0-84898f0bf204", "b1eab757-0431-4478-bbc7-faba93dd1f48", 1 });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 1,
                column: "UserId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 2,
                column: "UserId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 3,
                column: "UserId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 4,
                column: "UserId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 5,
                column: "UserId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 6,
                column: "UserId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "UserId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "UserId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "UserId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4,
                column: "UserId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5,
                column: "UserId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 6,
                column: "UserId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 1,
                column: "UserId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 2,
                column: "UserId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 3,
                column: "UserId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 4,
                column: "UserId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 5,
                column: "UserId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 6,
                column: "UserId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 7,
                column: "UserId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 8,
                column: "UserId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 9,
                column: "UserId",
                value: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2438b126-7410-43dc-84f8-f5e6c5c71289",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "03a92561-fc01-4491-b83b-1e904a5531c2", "87d208a8-da25-46d1-a417-40af6180c872" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77fe5873-b45c-482e-89f3-decad6c4ed3d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7c3e457e-6c11-4c39-bdb5-d401a3d028ce", "3f201549-fef5-44b7-a0e7-a2d8ab3257e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e0444fb-e663-4b8a-88eb-1c9e256a0f48",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fe13eeab-27cd-4905-b143-942a9eecbfe1", "5cd4ef9f-1931-4c44-bff6-4d22e5e41b23" });
        }
    }
}
