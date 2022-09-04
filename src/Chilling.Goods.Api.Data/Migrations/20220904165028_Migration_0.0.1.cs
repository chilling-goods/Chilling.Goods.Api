using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chilling.Goods.Api.Data.Migrations
{
    public partial class Migration_001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BrandDboProductTypeDbo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductTypeDbo",
                table: "ProductTypeDbo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Brands",
                table: "Brands");

            migrationBuilder.RenameTable(
                name: "ProductTypeDbo",
                newName: "ProductType");

            migrationBuilder.RenameTable(
                name: "Brands",
                newName: "Brand");

            migrationBuilder.AddColumn<Guid>(
                name: "CatalogId",
                table: "ProductType",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductType",
                table: "ProductType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Brand",
                table: "Brand",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProducTypeBrands",
                columns: table => new
                {
                    BrandId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProducTypeBrands", x => new { x.ProductTypeId, x.BrandId });
                    table.ForeignKey(
                        name: "FK_ProducTypeBrands_Brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProducTypeBrands_ProductType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductType_CatalogId",
                table: "ProductType",
                column: "CatalogId");

            migrationBuilder.CreateIndex(
                name: "IX_ProducTypeBrands_BrandId",
                table: "ProducTypeBrands",
                column: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductType_Catalog_CatalogId",
                table: "ProductType",
                column: "CatalogId",
                principalTable: "Catalog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductType_Catalog_CatalogId",
                table: "ProductType");

            migrationBuilder.DropTable(
                name: "Catalog");

            migrationBuilder.DropTable(
                name: "ProducTypeBrands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductType",
                table: "ProductType");

            migrationBuilder.DropIndex(
                name: "IX_ProductType_CatalogId",
                table: "ProductType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Brand",
                table: "Brand");

            migrationBuilder.DropColumn(
                name: "CatalogId",
                table: "ProductType");

            migrationBuilder.RenameTable(
                name: "ProductType",
                newName: "ProductTypeDbo");

            migrationBuilder.RenameTable(
                name: "Brand",
                newName: "Brands");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductTypeDbo",
                table: "ProductTypeDbo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Brands",
                table: "Brands",
                column: "Id");

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
    }
}
