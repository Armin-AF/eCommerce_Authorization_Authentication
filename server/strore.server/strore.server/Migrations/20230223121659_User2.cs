using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace strore.server.Migrations
{
    public partial class User2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6f86a6cf-7aad-4f3b-8e77-daa9f733d4a9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "88113449-fe1f-4bb0-9375-6da5674af38b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bc02c36f-94c0-4826-b5f0-b3a69cbcfce2");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "13800524-be49-49de-9ec8-95ea01fce40e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "be3ad322-e425-46c5-a8e4-1465df611c4b");

            migrationBuilder.AlterColumn<string>(
                name: "StoreId",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "ImageUrl", "Price", "Quantity", "StoreId", "Title" },
                values: new object[,]
                {
                    { "4e82662a-b847-4caa-b3b8-fd10e599e792", "category1", "product3 description", "https://picsum.photos/200/300", 30m, 30, "f8b8b8b8-8b8b-8b8b-8b8b-8b8b8b8b8b8b", "product3" },
                    { "6ca9ab59-a639-4324-b859-4000dd2ae595", "category1", "product1 description", "https://picsum.photos/200/300", 10m, 10, "f6b6b6b6-6b6b-6b6b-6b6b-6b6b6b6b6b6b", "product1" },
                    { "ae38ac8d-0e78-4515-8ebd-186045703dd3", "category1", "product2 description", "https://picsum.photos/200/300", 20m, 20, "f7b7b7b7-7b7b-7b7b-7b7b-7b7b7b7b7b7b", "product2" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f5b5b5b5-5b5b-5b5b-5b5b-5b5b5b5b5b5b",
                column: "ConcurrencyStamp",
                value: "7b8fe9cb-92c4-4040-beb4-3252c068af5a");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "StoreId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9f77d7be-850c-48e2-a5a0-06805ae82e2d", 0, "1df4007f-c456-4d1c-916d-a315ed71cf81", "user1@email.com", false, false, null, null, null, null, null, false, "user", null, "store1", false, "user1" },
                    { "a1f1aa6d-b856-4b02-993d-9d6782a24a5a", 0, "25008377-b468-495d-b156-e7bff20c1fa4", "user2@email.com", false, false, null, null, null, null, null, false, "user", null, "store2", false, "user2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4e82662a-b847-4caa-b3b8-fd10e599e792");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6ca9ab59-a639-4324-b859-4000dd2ae595");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ae38ac8d-0e78-4515-8ebd-186045703dd3");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9f77d7be-850c-48e2-a5a0-06805ae82e2d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a1f1aa6d-b856-4b02-993d-9d6782a24a5a");

            migrationBuilder.AlterColumn<string>(
                name: "StoreId",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "ImageUrl", "Price", "Quantity", "StoreId", "Title" },
                values: new object[,]
                {
                    { "6f86a6cf-7aad-4f3b-8e77-daa9f733d4a9", "category1", "product2 description", "https://picsum.photos/200/300", 20m, 20, "f7b7b7b7-7b7b-7b7b-7b7b-7b7b7b7b7b7b", "product2" },
                    { "88113449-fe1f-4bb0-9375-6da5674af38b", "category1", "product1 description", "https://picsum.photos/200/300", 10m, 10, "f6b6b6b6-6b6b-6b6b-6b6b-6b6b6b6b6b6b", "product1" },
                    { "bc02c36f-94c0-4826-b5f0-b3a69cbcfce2", "category1", "product3 description", "https://picsum.photos/200/300", 30m, 30, "f8b8b8b8-8b8b-8b8b-8b8b-8b8b8b8b8b8b", "product3" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f5b5b5b5-5b5b-5b5b-5b5b-5b5b5b5b5b5b",
                column: "ConcurrencyStamp",
                value: "549feea2-8499-4b20-ab89-4f2b9108713b");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "StoreId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "13800524-be49-49de-9ec8-95ea01fce40e", 0, "dd075fb5-9f30-4c76-b5b9-8d3f9f9943ee", "user1@email.com", false, false, null, null, null, null, null, false, "user", null, "store1", false, "user1" },
                    { "be3ad322-e425-46c5-a8e4-1465df611c4b", 0, "6f66fd87-7106-4345-8588-f537823867c0", "user2@email.com", false, false, null, null, null, null, null, false, "user", null, "store2", false, "user2" }
                });
        }
    }
}
