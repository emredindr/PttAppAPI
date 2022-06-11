using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PttAppAPI.Persistence.Migrations;

public partial class mig_6_CreatingAccountPageItemLoginedTable : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "AccountPageItemsLogined",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                ImageSource = table.Column<string>(type: "nvarchar(max)", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AccountPageItemsLogined", x => x.Id);
            });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "AccountPageItemsLogined");
    }
}
