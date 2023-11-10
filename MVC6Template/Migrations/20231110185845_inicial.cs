using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC6Template.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonagensDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuperNome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentidadeSecreta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Poder = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonagensDb", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonagensDb");
        }
    }
}
