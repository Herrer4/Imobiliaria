using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraestrutura.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "imoveis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "Text", nullable: false),
                    QuantidadeDeQuartos = table.Column<byte>(type: "tinyint", nullable: false),
                    ValorAluguel = table.Column<double>(type: "float", nullable: false),
                    TipoImovel = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_imoveis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "enderencos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImovelId = table.Column<int>(type: "int", nullable: false),
                    Cidade = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Bairro = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enderencos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_enderencos_imoveis_ImovelId",
                        column: x => x.ImovelId,
                        principalTable: "imoveis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_enderencos_ImovelId",
                table: "enderencos",
                column: "ImovelId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "enderencos");

            migrationBuilder.DropTable(
                name: "imoveis");
        }
    }
}
