using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoWeb.Data.Migrations
{
    public partial class seeddataforuserrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "admin-role", "ae08acc1-7c87-4c7f-a269-a28548e1280b", "Admin", "ADMIN" },
                    { "customer-role", "12c5afc6-387b-4d93-ad03-48d427e2f2b6", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "admin-account", 0, "ede23c3b-8e57-412a-bba0-279127470de1", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEJXvWYrk+zDdTVV2GJP9AqCU36zu8S6fM1QlvaxfWgfej3wNGDdwRp/zEIPiCDJqOw==", null, false, "5c39dd04-ac7b-486a-a134-a75d5faa1b2e", false, "admin@gmail.com" },
                    { "customer-account", 0, "131815d5-ebb9-40af-bf3d-67dee049e397", "cutomer@gmail.com", true, false, null, "CUSTOMER@GMAIL.COM", "CUSTOMER@GMAIL.COM", "AQAAAAEAACcQAAAAEEZPwCmtN5ymlTwmxmxQO/bT1cwmhpiGtBVupwwv6cY2tSWK/vsBJCi56QXMKvURFQ==", null, false, "a171e2f7-1a86-4f05-8c3a-c5c809a6f896", false, "customer@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "admin-account", "admin-role" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "customer-account", "customer-role" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "admin-account", "admin-role" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "customer-account", "customer-role" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin-role");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "customer-role");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-account");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customer-account");
        }
    }
}
