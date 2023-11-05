using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FindJobSolution.Data.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("70e7a246-e168-45e9-b78c-6f66b23f4633"),
                column: "ConcurrencyStamp",
                value: "bd9d1fc0-7fd1-4aa5-83ea-634056ff96fb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("728d69ec-5ff4-4688-9107-d8906b264f79"),
                column: "ConcurrencyStamp",
                value: "b07f2e0b-0cd6-47c3-badc-257bfeff2c8b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f91c93e9-5527-4162-b7c5-dd3cba713a49"),
                column: "ConcurrencyStamp",
                value: "074a6fe5-4465-43b5-a013-03770e344f9c");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d1a052be-b2e2-4dbf-8778-da82a7bbcb98"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "fb2d958f-d2ff-4df5-9563-03815a8ae3d2", "admin@gmail.com", "admin@gmail.com", "admin", "AQAAAAEAACcQAAAAENCK8UgcrobvRKg5aRAJg0qKuXcTWc+szn57hZ9cH3o0XvIapFqvnAfjHZ8xGS4Ilg==", "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("70e7a246-e168-45e9-b78c-6f66b23f4633"),
                column: "ConcurrencyStamp",
                value: "72698436-a03a-4ad6-9ebe-ac98c0002f39");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("728d69ec-5ff4-4688-9107-d8906b264f79"),
                column: "ConcurrencyStamp",
                value: "acecfeb8-b639-4660-aac7-b70aef1f073f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f91c93e9-5527-4162-b7c5-dd3cba713a49"),
                column: "ConcurrencyStamp",
                value: "b003ec6f-72fb-45ed-bd49-e5e7a65647ab");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d1a052be-b2e2-4dbf-8778-da82a7bbcb98"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "799d3db8-35fe-4a51-9467-dc50a9a2cb87", "thanh26092000@gmail.com", "thanh26092000@gmail.com", "Lxthanh", "AQAAAAEAACcQAAAAEG5xGHHrUxW1jmaznULbqxoKVJTRyjxV7BPkffh1i/MbeNf/EqT2QoDcsejb7w9GZA==", "Lxthanh" });
        }
    }
}
