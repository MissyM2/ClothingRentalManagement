using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClothingRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedFieldsToWearerAndDecorations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Wearings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Wearers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Wearers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Wearers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "ApparelTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6348), new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6393) });

            migrationBuilder.UpdateData(
                table: "ApparelTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6396), new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6397) });

            migrationBuilder.UpdateData(
                table: "ApparelTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6398), new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6399) });

            migrationBuilder.UpdateData(
                table: "ApparelTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6401), new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6402) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "500f8b26-4d50-4b85-ad58-25e503dd7bf6", "AQAAAAIAAYagAAAAEGQnRNeQsNJNg+p3aJU0gWUYzxzALWWvSuBMLLLajq/A354m7LRFjGS0dsUpiWwbbQ==", "7b5eebdd-5f1d-4a87-b5d8-1bc988079845" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6628), new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6629) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6631), new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6632) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6634), new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6635) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6637), new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6638) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6774), new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6777), new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6780), new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6904), new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6906) });

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6908), new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6910), new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6912) });

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6913), new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6914) });

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(7055), new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(7056) });

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(7058), new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(7059) });

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(7061), new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(7062) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Wearers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Wearers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Wearings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Wearers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.UpdateData(
                table: "ApparelTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(2670), new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(2726) });

            migrationBuilder.UpdateData(
                table: "ApparelTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(2730), new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "ApparelTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(2735), new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "ApparelTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(2739), new DateTime(2023, 10, 17, 18, 44, 14, 527, DateTimeKind.Local).AddTicks(2740) });

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
    }
}
