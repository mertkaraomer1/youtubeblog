using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoutubeBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class DALextensions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("2e14c8cd-2e8f-4b9b-b1e4-9eb529bd0d32"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 2, 17, 19, 52, 981, DateTimeKind.Local).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("2ea45a59-060f-404a-b458-6a45f95f57ac"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 2, 17, 19, 52, 981, DateTimeKind.Local).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0ea2f85b-e76e-4bb0-9c2c-7e2df1a5c113"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 2, 17, 19, 52, 981, DateTimeKind.Local).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cc60a0f7-934b-480c-a634-b019f8e57369"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 2, 17, 19, 52, 981, DateTimeKind.Local).AddTicks(1671));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("0f6cfc4b-d2d4-4f85-bab2-33891caef37e"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 2, 17, 19, 52, 981, DateTimeKind.Local).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2fb21410-e80e-42bb-ba49-e07f16f9bf79"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 2, 17, 19, 52, 981, DateTimeKind.Local).AddTicks(1737));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("2e14c8cd-2e8f-4b9b-b1e4-9eb529bd0d32"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 15, 8, 35, 562, DateTimeKind.Local).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("2ea45a59-060f-404a-b458-6a45f95f57ac"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 15, 8, 35, 562, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0ea2f85b-e76e-4bb0-9c2c-7e2df1a5c113"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 15, 8, 35, 562, DateTimeKind.Local).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cc60a0f7-934b-480c-a634-b019f8e57369"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 15, 8, 35, 562, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("0f6cfc4b-d2d4-4f85-bab2-33891caef37e"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 15, 8, 35, 562, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2fb21410-e80e-42bb-ba49-e07f16f9bf79"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 15, 8, 35, 562, DateTimeKind.Local).AddTicks(1128));
        }
    }
}
