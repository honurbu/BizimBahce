using Microsoft.EntityFrameworkCore.Migrations;

namespace BizimBahceDatabaseWork.Migrations
{
    public partial class Message_Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MsgOwner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MsgMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MsgTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MsgContent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");
        }
    }
}
