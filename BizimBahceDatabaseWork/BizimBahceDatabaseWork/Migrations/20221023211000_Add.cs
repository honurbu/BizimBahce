using Microsoft.EntityFrameworkCore.Migrations;

namespace BizimBahceDatabaseWork.Migrations
{
    public partial class Add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OliveOils",
                columns: table => new
                {
                    OliveOilsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OliveOilTypeID = table.Column<int>(type: "int", nullable: false),
                    OliveOilPropertyID = table.Column<int>(type: "int", nullable: false),
                    OliveOilBenefitID = table.Column<int>(type: "int", nullable: false),
                    OliveOilPriceID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OliveOils", x => x.OliveOilsID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OliveOils");
        }
    }
}
