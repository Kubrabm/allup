using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Allup.Migrations
{
    public partial class AddProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BrandLists_brandAndFeatures_BrandAndFeatureId",
                table: "BrandLists");

            migrationBuilder.DropForeignKey(
                name: "FK_Features_brandAndFeatures_BrandAndFeatureId",
                table: "Features");

            migrationBuilder.DropPrimaryKey(
                name: "PK_brandAndFeatures",
                table: "brandAndFeatures");

            migrationBuilder.RenameTable(
                name: "brandAndFeatures",
                newName: "BrandAndFeatures");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BrandAndFeatures",
                table: "BrandAndFeatures",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dexcription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OLdPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discount = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BrandLists_BrandAndFeatures_BrandAndFeatureId",
                table: "BrandLists",
                column: "BrandAndFeatureId",
                principalTable: "BrandAndFeatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Features_BrandAndFeatures_BrandAndFeatureId",
                table: "Features",
                column: "BrandAndFeatureId",
                principalTable: "BrandAndFeatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BrandLists_BrandAndFeatures_BrandAndFeatureId",
                table: "BrandLists");

            migrationBuilder.DropForeignKey(
                name: "FK_Features_BrandAndFeatures_BrandAndFeatureId",
                table: "Features");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BrandAndFeatures",
                table: "BrandAndFeatures");

            migrationBuilder.RenameTable(
                name: "BrandAndFeatures",
                newName: "brandAndFeatures");

            migrationBuilder.AddPrimaryKey(
                name: "PK_brandAndFeatures",
                table: "brandAndFeatures",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BrandLists_brandAndFeatures_BrandAndFeatureId",
                table: "BrandLists",
                column: "BrandAndFeatureId",
                principalTable: "brandAndFeatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Features_brandAndFeatures_BrandAndFeatureId",
                table: "Features",
                column: "BrandAndFeatureId",
                principalTable: "brandAndFeatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
