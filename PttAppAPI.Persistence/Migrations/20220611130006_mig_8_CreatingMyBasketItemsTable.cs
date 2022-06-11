using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PttAppAPI.Persistence.Migrations;

public partial class mig_8_CreatingMyBasketItemsTable : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "MyBasketItems",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                ProductId = table.Column<int>(type: "int", nullable: false),
                ProductTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                MainCategoryId = table.Column<int>(type: "int", nullable: false),
                SubCategoryId = table.Column<int>(type: "int", nullable: false),
                SubOfSubCategoryId = table.Column<int>(type: "int", nullable: false),
                ProductCount = table.Column<int>(type: "int", nullable: false),
                ProductPrice = table.Column<float>(type: "real", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_MyBasketItems", x => x.Id);
            });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "MyBasketItems");
    }
}
