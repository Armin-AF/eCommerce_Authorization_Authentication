using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace strore.server.Migrations
{
    public partial class InitialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StoreId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StoreId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "ImageUrl", "Price", "Quantity", "StoreId", "Title" },
                values: new object[,]
                {
                    { "31d18cde-9ad0-4887-887d-4e179689d82e", "category1", "product1 description", "https://picsum.photos/200/300", 10m, 10, "f6b6b6b6-6b6b-6b6b-6b6b-6b6b6b6b6b6b", "product1" },
                    { "73c1290a-6732-4c7f-b816-d8c54aaec1e2", "category1", "product3 description", "https://picsum.photos/200/300", 30m, 30, "f8b8b8b8-8b8b-8b8b-8b8b-8b8b8b8b8b8b", "product3" },
                    { "ec0c2b37-77f0-4022-a100-ea9b9ca3b536", "category1", "product2 description", "https://picsum.photos/200/300", 20m, 20, "f7b7b7b7-7b7b-7b7b-7b7b-7b7b7b7b7b7b", "product2" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "Id", "AdminId", "Name" },
                values: new object[,]
                {
                    { "f6b6b6b6-6b6b-6b6b-6b6b-6b6b6b6b6b6b", "f5b5b5b5-5b5b-5b5b-5b5b-5b5b5b5b5b5b", "store1" },
                    { "f7b7b7b7-7b7b-7b7b-7b7b-7b7b7b7b7b7b", "f5b5b5b5-5b5b-5b5b-5b5b-5b5b5b5b5b5b", "store2" },
                    { "f8b8b8b8-8b8b-8b8b-8b8b-8b8b8b8b8b8b", "f5b5b5b5-5b5b-5b5b-5b5b-5b5b5b5b5b5b", "store3" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "Role", "StoreId", "UserName" },
                values: new object[,]
                {
                    { "1c1e71fb-4d7f-4fa6-915b-631ce8cea395", "user1@email.com", "123456", "user", "store1", "user1" },
                    { "92a23f0c-df01-441a-98af-f23132d85e98", "user2@email.com", "123456", "user", "store2", "user2" },
                    { "f5b5b5b5-5b5b-5b5b-5b5b-5b5b5b5b5b5b", "admin@email.com", "123456", "admin", "store1", "admin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
