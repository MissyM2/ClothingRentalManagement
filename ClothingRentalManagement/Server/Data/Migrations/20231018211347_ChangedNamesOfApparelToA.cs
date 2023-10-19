using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClothingRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangedNamesOfApparelToA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wearings_ApparelItems_ApparelItemId",
                table: "Wearings");

            migrationBuilder.DropTable(
                name: "ApparelItems");

            migrationBuilder.DropTable(
                name: "ApparelTypes");

            migrationBuilder.RenameColumn(
                name: "ApparelItemId",
                table: "Wearings",
                newName: "AitemId");

            migrationBuilder.RenameIndex(
                name: "IX_Wearings_ApparelItemId",
                table: "Wearings",
                newName: "IX_Wearings_AitemId");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Wearings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Wearings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Wearers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Wearers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Wearers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Sizes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Sizes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Seasons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Seasons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Colors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Colors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Atypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Aitems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShortDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LongDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    AtypeId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    SeasonId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aitems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aitems_Atypes_AtypeId",
                        column: x => x.AtypeId,
                        principalTable: "Atypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Aitems_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Aitems_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Aitems_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Aitems_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e57ca5a-d16d-437a-8714-fbcaac0d71dd", "AQAAAAIAAYagAAAAEKjM9+UK6oR1KXm7wZ9DNmcPz2h+GIOTIWL+F66gmYfaCu4XhDCSCdXxjjTQuOuQoA==", "c0a2845d-e8ab-48cc-9838-427d9af52947" });

            migrationBuilder.InsertData(
                table: "Atypes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(5698), new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(5743), "Top", "System" },
                    { 2, "System", new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(5745), new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(5746), "Bottom", "System" },
                    { 3, "System", new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(5748), new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(5749), "Dress", "System" },
                    { 4, "System", new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(5752), new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(5753), "Hat", "System" }
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(5957), new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(5959) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(5962), new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(5963) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(5964), new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(5965) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(5967), new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(5968) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(6089), new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(6092), new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(6093) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(6094), new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(7165), new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(7166) });

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(7169), new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(7173), new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(7174) });

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(7177), new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(7976), new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(8139) });

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(8141), new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(8142) });

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(8144), new DateTime(2023, 10, 18, 17, 13, 47, 12, DateTimeKind.Local).AddTicks(8145) });

            migrationBuilder.CreateIndex(
                name: "IX_Aitems_AtypeId",
                table: "Aitems",
                column: "AtypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Aitems_BrandId",
                table: "Aitems",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Aitems_ColorId",
                table: "Aitems",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Aitems_SeasonId",
                table: "Aitems",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Aitems_SizeId",
                table: "Aitems",
                column: "SizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Wearings_Aitems_AitemId",
                table: "Wearings",
                column: "AitemId",
                principalTable: "Aitems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wearings_Aitems_AitemId",
                table: "Wearings");

            migrationBuilder.DropTable(
                name: "Aitems");

            migrationBuilder.DropTable(
                name: "Atypes");

            migrationBuilder.RenameColumn(
                name: "AitemId",
                table: "Wearings",
                newName: "ApparelItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Wearings_AitemId",
                table: "Wearings",
                newName: "IX_Wearings_ApparelItemId");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Wearings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Wearings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Wearers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Wearers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Wearers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Sizes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Sizes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Seasons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Seasons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Colors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Colors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ApparelTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApparelTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApparelItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApparelTypeId = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    SeasonId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LongDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    ShortDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApparelItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApparelItems_ApparelTypes_ApparelTypeId",
                        column: x => x.ApparelTypeId,
                        principalTable: "ApparelTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApparelItems_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApparelItems_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApparelItems_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApparelItems_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ApparelTypes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6348), new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6393), "Top", "System" },
                    { 2, "System", new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6396), new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6397), "Bottom", "System" },
                    { 3, "System", new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6398), new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6399), "Dress", "System" },
                    { 4, "System", new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6401), new DateTime(2023, 10, 17, 20, 47, 2, 147, DateTimeKind.Local).AddTicks(6402), "Hat", "System" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ApparelItems_ApparelTypeId",
                table: "ApparelItems",
                column: "ApparelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ApparelItems_BrandId",
                table: "ApparelItems",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_ApparelItems_ColorId",
                table: "ApparelItems",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_ApparelItems_SeasonId",
                table: "ApparelItems",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_ApparelItems_SizeId",
                table: "ApparelItems",
                column: "SizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Wearings_ApparelItems_ApparelItemId",
                table: "Wearings",
                column: "ApparelItemId",
                principalTable: "ApparelItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
