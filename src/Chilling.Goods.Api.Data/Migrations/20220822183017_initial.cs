using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chilling.Goods.Api.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypeDbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IsDisplay = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypeDbo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BrandDboProductTypeDbo",
                columns: table => new
                {
                    BrandsId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductTypesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandDboProductTypeDbo", x => new { x.BrandsId, x.ProductTypesId });
                    table.ForeignKey(
                        name: "FK_BrandDboProductTypeDbo_Brands_BrandsId",
                        column: x => x.BrandsId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BrandDboProductTypeDbo_ProductTypeDbo_ProductTypesId",
                        column: x => x.ProductTypesId,
                        principalTable: "ProductTypeDbo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BrandDboProductTypeDbo_ProductTypesId",
                table: "BrandDboProductTypeDbo",
                column: "ProductTypesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BrandDboProductTypeDbo");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "ProductTypeDbo");
        }
    }
}
