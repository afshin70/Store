using Microsoft.EntityFrameworkCore.Migrations;

namespace Store.Migrations
{
    public partial class updatetbls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Features_Json",
                table: "Products",
                newName: "Features");

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "SubCategories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "SubCategories");

            migrationBuilder.RenameColumn(
                name: "Features",
                table: "Products",
                newName: "Features_Json");
        }
    }
}
