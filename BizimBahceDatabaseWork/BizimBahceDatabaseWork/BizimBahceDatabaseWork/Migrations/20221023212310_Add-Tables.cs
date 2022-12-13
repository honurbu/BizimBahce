using Microsoft.EntityFrameworkCore.Migrations;

namespace BizimBahceDatabaseWork.Migrations
{
    public partial class AddTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentSubject = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentID);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerProvince = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "OliveOilBenefits",
                columns: table => new
                {
                    OliveOilBenefitID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OliveOilBenefitDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OliveOilBenefits", x => x.OliveOilBenefitID);
                });

            migrationBuilder.CreateTable(
                name: "OliveOilPrices",
                columns: table => new
                {
                    OliveOilPriceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OliveOilPriceLiter = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OliveOilPrices", x => x.OliveOilPriceID);
                });

            migrationBuilder.CreateTable(
                name: "OliveOilProperties",
                columns: table => new
                {
                    OliveOilPropertyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OliveOilDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OliveOilAsidic = table.Column<float>(type: "real", nullable: false),
                    OliveOilLiter = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OliveOilProperties", x => x.OliveOilPropertyID);
                });

            migrationBuilder.CreateTable(
                name: "OliveOilTypes",
                columns: table => new
                {
                    OliveOilTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OliveOilDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OliveOilTypes", x => x.OliveOilTypeID);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    SocialMediaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SocialMediaInstagram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialMediaFace = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.SocialMediaID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "OliveOilBenefits");

            migrationBuilder.DropTable(
                name: "OliveOilPrices");

            migrationBuilder.DropTable(
                name: "OliveOilProperties");

            migrationBuilder.DropTable(
                name: "OliveOilTypes");

            migrationBuilder.DropTable(
                name: "SocialMedias");
        }
    }
}
