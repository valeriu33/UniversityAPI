using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityAPI.Migrations
{
    public partial class RestrictFieldsLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IDNP",
                table: "Students",
                maxLength: 13,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IDNP",
                table: "Students");
        }
    }
}
