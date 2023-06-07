using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aula08_ap1.Migrations
{
    /// <inheritdoc />
    public partial class ReformuladoMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Valor",
                table: "TransacoesBancarias",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "Gerente",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Senha = table.Column<int>(type: "INTEGER", nullable: false),
                    MyProperty = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gerente", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gerente");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "TransacoesBancarias");
        }
    }
}
