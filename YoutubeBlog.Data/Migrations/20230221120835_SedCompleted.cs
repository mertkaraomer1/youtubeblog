using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YoutubeBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class SedCompleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("0ea2f85b-e76e-4bb0-9c2c-7e2df1a5c113"), "admin test", new DateTime(2023, 2, 21, 15, 8, 35, 562, DateTimeKind.Local).AddTicks(1047), null, null, false, null, null, "asp.net core " },
                    { new Guid("cc60a0f7-934b-480c-a634-b019f8e57369"), "admin test", new DateTime(2023, 2, 21, 15, 8, 35, 562, DateTimeKind.Local).AddTicks(1044), null, null, false, null, null, "c# entity framework" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("0f6cfc4b-d2d4-4f85-bab2-33891caef37e"), "admin test", new DateTime(2023, 2, 21, 15, 8, 35, 562, DateTimeKind.Local).AddTicks(1132), null, null, "image/testimage", ".jpg", false, null, null },
                    { new Guid("2fb21410-e80e-42bb-ba49-e07f16f9bf79"), "admin test", new DateTime(2023, 2, 21, 15, 8, 35, 562, DateTimeKind.Local).AddTicks(1128), null, null, "image/testimage", ".png", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("2e14c8cd-2e8f-4b9b-b1e4-9eb529bd0d32"), new Guid("cc60a0f7-934b-480c-a634-b019f8e57369"), "c# Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "admin test", new DateTime(2023, 2, 21, 15, 8, 35, 562, DateTimeKind.Local).AddTicks(813), null, null, new Guid("2fb21410-e80e-42bb-ba49-e07f16f9bf79"), false, null, null, "c# deneme makalesi 1", 0 },
                    { new Guid("2ea45a59-060f-404a-b458-6a45f95f57ac"), new Guid("0ea2f85b-e76e-4bb0-9c2c-7e2df1a5c113"), "Asp.net Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "admin test", new DateTime(2023, 2, 21, 15, 8, 35, 562, DateTimeKind.Local).AddTicks(830), null, null, new Guid("0f6cfc4b-d2d4-4f85-bab2-33891caef37e"), false, null, null, "Asp.net deneme makalesi 1", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("2e14c8cd-2e8f-4b9b-b1e4-9eb529bd0d32"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("2ea45a59-060f-404a-b458-6a45f95f57ac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0ea2f85b-e76e-4bb0-9c2c-7e2df1a5c113"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cc60a0f7-934b-480c-a634-b019f8e57369"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("0f6cfc4b-d2d4-4f85-bab2-33891caef37e"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2fb21410-e80e-42bb-ba49-e07f16f9bf79"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
