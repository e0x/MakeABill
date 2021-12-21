using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MakeABill.Infraestructure.Migrations
{
    public partial class Fix_Article_entity_21_12_2021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArticleCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    LastModifyBy = table.Column<string>(nullable: true),
                    CreateBy = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastModifyDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Commentary = table.Column<string>(nullable: true),
                    Description = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    LastModifyBy = table.Column<string>(nullable: true),
                    CreateBy = table.Column<string>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastModifyDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Commentary = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 50, nullable: true),
                    Unit = table.Column<string>(nullable: true),
                    PriceUnit = table.Column<double>(nullable: false),
                    PriceUnitTaxed = table.Column<double>(nullable: false),
                    PerfomanceObs = table.Column<string>(maxLength: 50, nullable: true),
                    RecomendSupplierId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Article_ArticleCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ArticleCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Article_CategoryId",
                table: "Article",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Article");

            migrationBuilder.DropTable(
                name: "ArticleCategory");
        }
    }
}
