using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PttAppAPI.Persistence.Migrations
{
    public partial class mig_10_CreatingNewColumnSubOfSub : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdSub",
                table: "SubCategories",
                newName: "SubId");

            migrationBuilder.AddColumn<int>(
                name: "SubOfSubId",
                table: "SubOfSubCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubOfSubId",
                table: "SubOfSubCategories");

            migrationBuilder.RenameColumn(
                name: "SubId",
                table: "SubCategories",
                newName: "IdSub");
        }
    }
}
