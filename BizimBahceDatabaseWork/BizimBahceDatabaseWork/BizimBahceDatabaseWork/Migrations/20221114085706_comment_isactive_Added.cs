using Microsoft.EntityFrameworkCore.Migrations;

namespace BizimBahceDatabaseWork.Migrations
{
    public partial class comment_isactive_Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Comments",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Comments");
        }
    }
}
