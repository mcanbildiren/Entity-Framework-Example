using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBExample2.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductFeatureId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeatures", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductFeatureId",
                table: "Products",
                column: "ProductFeatureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductFeatures_ProductFeatureId",
                table: "Products",
                column: "ProductFeatureId",
                principalTable: "ProductFeatures",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductFeatures_ProductFeatureId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProductFeatures");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductFeatureId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductFeatureId",
                table: "Products");
        }
    }
}
