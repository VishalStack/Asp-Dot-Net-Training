#nullable disable

using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiApplication.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Ekta" },
                    { 2, "Aarti" },
                    { 3, "Dhwani" },
                    { 4, "Shreya" },
                    { 5, "Manali" },
                    { 6, "Yukta" },
                    { 7, "Disha" },
                    { 8, "Naxi" },
                    { 9, "Vaishali" },
                    { 10, "Chetna" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
