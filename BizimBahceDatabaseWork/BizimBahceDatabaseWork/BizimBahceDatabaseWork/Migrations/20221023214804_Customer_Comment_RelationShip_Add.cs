using Microsoft.EntityFrameworkCore.Migrations;

namespace BizimBahceDatabaseWork.Migrations
{
    public partial class Customer_Comment_RelationShip_Add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CustomerID",
                table: "Comments",
                column: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Customers_CustomerID",
                table: "Comments",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Customers_CustomerID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_CustomerID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "Comments");
        }
    }
}
