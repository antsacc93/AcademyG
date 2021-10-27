using Microsoft.EntityFrameworkCore.Migrations;

namespace AcademyG.Week8.Amazon.EF.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(maxLength: 5, nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    Type = table.Column<string>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    PurchasePrice = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Code", "Description", "Price", "PurchasePrice", "Type" },
                values: new object[] { 1, "12345", "TV 55 inch Samsung", 23.2m, 1.2m, "Electronic" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
