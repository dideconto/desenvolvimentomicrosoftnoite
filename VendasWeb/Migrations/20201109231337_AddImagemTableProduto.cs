using Microsoft.EntityFrameworkCore.Migrations;

namespace VendasWeb.Migrations
{
    public partial class AddImagemTableProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Imagem",
                table: "Produtos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagem",
                table: "Produtos");
        }
    }
}
