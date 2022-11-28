using Microsoft.EntityFrameworkCore.Migrations;

namespace BizimBahceDatabaseWork.Migrations
{
    public partial class Oil_Type_Relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_OliveOils_OliveOilTypeID",
                table: "OliveOils",
                column: "OliveOilTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_OliveOils_OliveOilTypes_OliveOilTypeID",
                table: "OliveOils",
                column: "OliveOilTypeID",
                principalTable: "OliveOilTypes",
                principalColumn: "OliveOilTypeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OliveOils_OliveOilTypes_OliveOilTypeID",
                table: "OliveOils");

            migrationBuilder.DropIndex(
                name: "IX_OliveOils_OliveOilTypeID",
                table: "OliveOils");
        }
    }
}
