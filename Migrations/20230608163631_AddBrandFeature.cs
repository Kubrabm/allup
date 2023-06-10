using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Allup.Migrations
{
    public partial class AddBrandFeature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BrandLists_Brands_BrandId",
                table: "BrandLists");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropIndex(
                name: "IX_BrandLists_BrandId",
                table: "BrandLists");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "BrandLists");

            migrationBuilder.AddColumn<int>(
                name: "BrandAndFeatureId",
                table: "BrandLists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "brandAndFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brandAndFeatures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandAndFeatureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Features_brandAndFeatures_BrandAndFeatureId",
                        column: x => x.BrandAndFeatureId,
                        principalTable: "brandAndFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BrandLists_BrandAndFeatureId",
                table: "BrandLists",
                column: "BrandAndFeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_Features_BrandAndFeatureId",
                table: "Features",
                column: "BrandAndFeatureId");

            migrationBuilder.AddForeignKey(
                name: "FK_BrandLists_brandAndFeatures_BrandAndFeatureId",
                table: "BrandLists",
                column: "BrandAndFeatureId",
                principalTable: "brandAndFeatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BrandLists_brandAndFeatures_BrandAndFeatureId",
                table: "BrandLists");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "brandAndFeatures");

            migrationBuilder.DropIndex(
                name: "IX_BrandLists_BrandAndFeatureId",
                table: "BrandLists");

            migrationBuilder.DropColumn(
                name: "BrandAndFeatureId",
                table: "BrandLists");

            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "BrandLists",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BrandLists_BrandId",
                table: "BrandLists",
                column: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_BrandLists_Brands_BrandId",
                table: "BrandLists",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id");
        }
    }
}
