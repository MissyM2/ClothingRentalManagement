using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClothingRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeededDefaultApparelTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ApparelTypes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(2670), new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(2726), "Top", "System" },
                    { 2, "System", new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(2730), new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(2732), "Bottom", "System" },
                    { 3, "System", new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(2735), new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(2737), "Dress", "System" },
                    { 4, "System", new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(2739), new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(2740), "Hat", "System" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2064adb4-bd13-4d36-a412-6cc532d43fa9", "AQAAAAIAAYagAAAAEJaskO4CQkF5Xj5LxJGGDPzGDLn4aTAw6dhJv43SjTrTs7oHGipeRdCHTLWNF4eYRw==", "f9f9ae2b-4817-4339-9f7c-8358d4e62c51" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(3037), new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(3040) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(3043), new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(3047), new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(3048) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(3051), new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(3052) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(3240), new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(3245), new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(3249), new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(3424), new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(3426) });

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(3429), new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(3433), new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(3434) });

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(3437), new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(3439) });

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(3638), new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(3643), new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(3644) });

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(3647), new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(3648) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApparelTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ApparelTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ApparelTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ApparelTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e77eb6a4-ac73-4c62-a172-36be76b10ad1", "AQAAAAIAAYagAAAAEGdFpMVv0/Uqx5fbpctZuxysWpIosNUGU84htHFTI0fQNa5QmsdMNARWNkUyjzXVCA==", "a5c93dfd-6a5f-4db6-b61a-6f539f257fb4" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(602), new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(641) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(644), new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(645) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(647), new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(648) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(650), new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(651) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(866), new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(867) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(871), new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(872) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(875), new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(876) });

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(1006), new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(1007) });

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(1010), new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(1011) });

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(1012), new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(1015), new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(1016) });

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(1139), new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(1140) });

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(1142), new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(1143) });

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(1145), new DateTime(2023, 10, 16, 17, 43, 12, 149, DateTimeKind.Local).AddTicks(1146) });
        }
    }
}
