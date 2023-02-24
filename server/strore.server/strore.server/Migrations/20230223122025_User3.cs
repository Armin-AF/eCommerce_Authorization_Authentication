using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace strore.server.Migrations
{
    public partial class User3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "ImageUrl", "Price", "Quantity", "StoreId", "Title" },
                values: new object[,]
                {
                    { "6de33d24-7304-4216-8f9f-00726cd035cc", "category1", "product1 description", "https://picsum.photos/200/300", 10m, 10, "f6b6b6b6-6b6b-6b6b-6b6b-6b6b6b6b6b6b", "product1" },
                    { "d377d749-6242-47c4-8252-62895d2f08e1", "category1", "product3 description", "https://picsum.photos/200/300", 30m, 30, "f8b8b8b8-8b8b-8b8b-8b8b-8b8b8b8b8b8b", "product3" },
                    { "dd356745-2d90-48bc-85a5-1368c51d8da9", "category1", "product2 description", "https://picsum.photos/200/300", 20m, 20, "f7b7b7b7-7b7b-7b7b-7b7b-7b7b7b7b7b7b", "product2" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f5b5b5b5-5b5b-5b5b-5b5b-5b5b5b5b5b5b",
                column: "ConcurrencyStamp",
                value: "10bf9de7-b808-44d4-86bf-33ef41bd018e");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "StoreId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "235c9e66-574c-4247-9f8d-3d8110a1ae44", 0, "81ed56d5-c984-43ce-9ea0-4a163368902d", "user1@email.com", false, false, null, null, null, null, null, false, "user", null, "store1", false, "user1" },
                    { "800a7c50-0038-4f23-8334-931ccb8829e0", 0, "e21c7c1d-6f44-4392-92aa-343fe5c044fe", "user2@email.com", false, false, null, null, null, null, null, false, "user", null, "store2", false, "user2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6de33d24-7304-4216-8f9f-00726cd035cc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d377d749-6242-47c4-8252-62895d2f08e1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dd356745-2d90-48bc-85a5-1368c51d8da9");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "235c9e66-574c-4247-9f8d-3d8110a1ae44");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "800a7c50-0038-4f23-8334-931ccb8829e0");

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
    }
}
