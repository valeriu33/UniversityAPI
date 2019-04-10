using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityAPI.Migrations
{
    public partial class AddNameTOLessons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Lessons",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Lessons");
        }
    }
}
