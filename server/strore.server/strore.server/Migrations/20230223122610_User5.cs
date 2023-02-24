using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace strore.server.Migrations
{
    public partial class User5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "IdentityUserRole<string>",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserRole<string>", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "ImageUrl", "Price", "Quantity", "StoreId", "Title" },
                values: new object[,]
                {
                    { "12cec80f-90e5-4c3c-adcd-f7716efa1487", "category1", "product3 description", "https://picsum.photos/200/300", 30m, 30, "f8b8b8b8-8b8b-8b8b-8b8b-8b8b8b8b8b8b", "product3" },
                    { "9133bf6b-e110-4ee7-8e3d-12622e716ea6", "category1", "product2 description", "https://picsum.photos/200/300", 20m, 20, "f7b7b7b7-7b7b-7b7b-7b7b-7b7b7b7b7b7b", "product2" },
                    { "d2a611f7-7496-4d4a-b1d1-f1d7ea566fdc", "category1", "product1 description", "https://picsum.photos/200/300", 10m, 10, "f6b6b6b6-6b6b-6b6b-6b6b-6b6b6b6b6b6b", "product1" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f5b5b5b5-5b5b-5b5b-5b5b-5b5b5b5b5b5b",
                column: "ConcurrencyStamp",
                value: "776808f6-3f61-4866-ada1-0baf6da79280");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "StoreId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "e7ea4ab1-daf2-41d9-b113-3712226715d2", 0, "62b3fd2c-080d-4904-8900-40d7e05a1f28", "user1@email.com", false, false, null, null, null, null, null, false, "user", null, "store1", false, "user1" },
                    { "ed643353-1dac-4ba2-acd2-09046bbd9df4", 0, "b894e580-77e4-4c83-a90f-8bb5a6fb070c", "user2@email.com", false, false, null, null, null, null, null, false, "user", null, "store2", false, "user2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityUserRole<string>");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "12cec80f-90e5-4c3c-adcd-f7716efa1487");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9133bf6b-e110-4ee7-8e3d-12622e716ea6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d2a611f7-7496-4d4a-b1d1-f1d7ea566fdc");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e7ea4ab1-daf2-41d9-b113-3712226715d2");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ed643353-1dac-4ba2-acd2-09046bbd9df4");

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
    }
}
