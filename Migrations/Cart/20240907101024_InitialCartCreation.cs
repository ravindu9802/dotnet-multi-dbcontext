using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnet_dbcontext.Migrations.Cart
{
    /// <inheritdoc />
    public partial class InitialCartCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "cart");

            migrationBuilder.CreateTable(
                name: "Carts",
                schema: "cart",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "cart",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CartId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Carts_CartId",
                        column: x => x.CartId,
                        principalSchema: "cart",
                        principalTable: "Carts",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "cart",
                table: "Products",
                columns: new[] { "Id", "CartId", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("064f7196-51d4-4980-9b2a-8690d5d8ce3e"), null, "Product 9", 13.9m },
                    { new Guid("1f80800e-626e-4f9d-abee-d74e42f17555"), null, "Product 6", 11.7m },
                    { new Guid("5ebabea3-276b-476a-b7ef-a6885598d784"), null, "Product 10", 8.6m },
                    { new Guid("9296c0b6-8e50-49e9-b792-336d6714acd0"), null, "Product 2", 4.77m },
                    { new Guid("ae80a65a-3def-4476-83b7-a636ea2a5d6b"), null, "Product 7", 23.22m },
                    { new Guid("ddafa65d-e579-4193-becf-43921915d304"), null, "Product 1", 2.3m },
                    { new Guid("e0c0e064-dce5-417b-9f66-5536cdffd034"), null, "Product 3", 1.4m },
                    { new Guid("f0367f15-9d61-4c5e-aad5-042c8f93aec3"), null, "Product 5", 8.5m },
                    { new Guid("f5ba74e9-0294-443a-baef-d015626c7359"), null, "Product 8", 18.0m },
                    { new Guid("fa865b4e-f0fa-4847-b9a6-d1e981d0c86b"), null, "Product 4", 5.0m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CartId",
                schema: "cart",
                table: "Products",
                column: "CartId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products",
                schema: "cart");

            migrationBuilder.DropTable(
                name: "Carts",
                schema: "cart");
        }
    }
}
