using Microsoft.EntityFrameworkCore.Migrations;

namespace BizimBahceDatabaseWork.Migrations
{
    public partial class Add_Relation_Oils : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_OliveOils_OliveOilBenefitID",
                table: "OliveOils",
                column: "OliveOilBenefitID");

            migrationBuilder.CreateIndex(
                name: "IX_OliveOils_OliveOilPriceID",
                table: "OliveOils",
                column: "OliveOilPriceID");

            migrationBuilder.CreateIndex(
                name: "IX_OliveOils_OliveOilPropertyID",
                table: "OliveOils",
                column: "OliveOilPropertyID");

            migrationBuilder.AddForeignKey(
                name: "FK_OliveOils_OliveOilBenefits_OliveOilBenefitID",
                table: "OliveOils",
                column: "OliveOilBenefitID",
                principalTable: "OliveOilBenefits",
                principalColumn: "OliveOilBenefitID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OliveOils_OliveOilPrices_OliveOilPriceID",
                table: "OliveOils",
                column: "OliveOilPriceID",
                principalTable: "OliveOilPrices",
                principalColumn: "OliveOilPriceID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OliveOils_OliveOilProperties_OliveOilPropertyID",
                table: "OliveOils",
                column: "OliveOilPropertyID",
                principalTable: "OliveOilProperties",
                principalColumn: "OliveOilPropertyID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OliveOils_OliveOilBenefits_OliveOilBenefitID",
                table: "OliveOils");

            migrationBuilder.DropForeignKey(
                name: "FK_OliveOils_OliveOilPrices_OliveOilPriceID",
                table: "OliveOils");

            migrationBuilder.DropForeignKey(
                name: "FK_OliveOils_OliveOilProperties_OliveOilPropertyID",
                table: "OliveOils");

            migrationBuilder.DropIndex(
                name: "IX_OliveOils_OliveOilBenefitID",
                table: "OliveOils");

            migrationBuilder.DropIndex(
                name: "IX_OliveOils_OliveOilPriceID",
                table: "OliveOils");

            migrationBuilder.DropIndex(
                name: "IX_OliveOils_OliveOilPropertyID",
                table: "OliveOils");
        }
    }
}
