using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClothingRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeededDefaultApparelData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", null, "User", "USER" },
                    { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "e77eb6a4-ac73-4c62-a172-36be76b10ad1", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAIAAYagAAAAEGdFpMVv0/Uqx5fbpctZuxysWpIosNUGU84htHFTI0fQNa5QmsdMNARWNkUyjzXVCA==", null, false, "a5c93dfd-6a5f-4db6-b61a-6f539f257fb4", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(602), new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(641), "LuluLemon", "System" },
                    { 2, "System", new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(644), new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(645), "Patagonia", "System" },
                    { 3, "System", new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(647), new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(648), "TopShop", "System" },
                    { 4, "System", new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(650), new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(651), "JCrew", "System" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(866), new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(867), "Black", "System" },
                    { 2, "System", new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(871), new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(872), "White", "System" },
                    { 3, "System", new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(875), new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(876), "Red", "System" }
                });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(1006), new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(1007), "Winter", "System" },
                    { 2, "System", new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(1010), new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(1011), "Spring", "System" },
                    { 3, "System", new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(1012), new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(1013), "Summer", "System" },
                    { 4, "System", new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(1015), new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(1016), "Fall", "System" }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(1139), new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(1140), "Small", "System" },
                    { 2, "System", new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(1142), new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(1143), "Medium", "System" },
                    { 3, "System", new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(1145), new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(1146), "Large", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9");
        }
    }
}
