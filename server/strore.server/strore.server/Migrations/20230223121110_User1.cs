using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace strore.server.Migrations
{
    public partial class User1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "38850218-0568-4c77-b3c3-b984925e9e49");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8628179e-1edf-4c77-b511-3f5fa7ccd884");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ee089d02-315a-40bd-91c7-5bcca5b25475");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "519531cc-3ef7-410f-864f-6ff3d70bcff5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a96798f1-16d0-415d-b826-71ef0db46ea4");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "ImageUrl", "Price", "Quantity", "StoreId", "Title" },
                values: new object[,]
                {
                    { "38850218-0568-4c77-b3c3-b984925e9e49", "category1", "product3 description", "https://picsum.photos/200/300", 30m, 30, "f8b8b8b8-8b8b-8b8b-8b8b-8b8b8b8b8b8b", "product3" },
                    { "8628179e-1edf-4c77-b511-3f5fa7ccd884", "category1", "product1 description", "https://picsum.photos/200/300", 10m, 10, "f6b6b6b6-6b6b-6b6b-6b6b-6b6b6b6b6b6b", "product1" },
                    { "ee089d02-315a-40bd-91c7-5bcca5b25475", "category1", "product2 description", "https://picsum.photos/200/300", 20m, 20, "f7b7b7b7-7b7b-7b7b-7b7b-7b7b7b7b7b7b", "product2" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f5b5b5b5-5b5b-5b5b-5b5b-5b5b5b5b5b5b",
                columns: new[] { "ConcurrencyStamp", "Password" },
                values: new object[] { "ea882bbb-86e7-4e59-863a-45ce3c61a55e", "123456" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "StoreId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "519531cc-3ef7-410f-864f-6ff3d70bcff5", 0, "fe33e4e2-a4a9-4486-aa15-0416dfe6ff1a", "user2@email.com", false, false, null, null, null, "123456", null, null, false, "user", null, "store2", false, "user2" },
                    { "a96798f1-16d0-415d-b826-71ef0db46ea4", 0, "7dfead15-73ed-4a0c-ba66-190cd908a40c", "user1@email.com", false, false, null, null, null, "123456", null, null, false, "user", null, "store1", false, "user1" }
                });
        }
    }
}
