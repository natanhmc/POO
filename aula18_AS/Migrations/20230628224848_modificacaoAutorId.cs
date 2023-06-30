using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aula18_AS.Migrations
{
    /// <inheritdoc />
    public partial class modificacaoAutorId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutorLivro");

            migrationBuilder.RenameColumn(
                name: "AutorId",
                table: "DbSetAutorLivro",
                newName: "AutoresId");

            migrationBuilder.AddColumn<int>(
                name: "AutorId",
                table: "DbSetLivro",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DbSetLivro_AutorId",
                table: "DbSetLivro",
                column: "AutorId");

            migrationBuilder.CreateIndex(
                name: "IX_DbSetAutorLivro_LivroId",
                table: "DbSetAutorLivro",
                column: "LivroId");

            migrationBuilder.AddForeignKey(
                name: "FK_DbSetAutorLivro_DbSetLivro_LivroId",
                table: "DbSetAutorLivro",
                column: "LivroId",
                principalTable: "DbSetLivro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DbSetLivro_DbSetAutor_AutorId",
                table: "DbSetLivro",
                column: "AutorId",
                principalTable: "DbSetAutor",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DbSetAutorLivro_DbSetLivro_LivroId",
                table: "DbSetAutorLivro");

            migrationBuilder.DropForeignKey(
                name: "FK_DbSetLivro_DbSetAutor_AutorId",
                table: "DbSetLivro");

            migrationBuilder.DropIndex(
                name: "IX_DbSetLivro_AutorId",
                table: "DbSetLivro");

            migrationBuilder.DropIndex(
                name: "IX_DbSetAutorLivro_LivroId",
                table: "DbSetAutorLivro");

            migrationBuilder.DropColumn(
                name: "AutorId",
                table: "DbSetLivro");

            migrationBuilder.RenameColumn(
                name: "AutoresId",
                table: "DbSetAutorLivro",
                newName: "AutorId");

            migrationBuilder.CreateTable(
                name: "AutorLivro",
                columns: table => new
                {
                    AutoresId = table.Column<int>(type: "INTEGER", nullable: false),
                    LivrosId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutorLivro", x => new { x.AutoresId, x.LivrosId });
                    table.ForeignKey(
                        name: "FK_AutorLivro_DbSetAutor_AutoresId",
                        column: x => x.AutoresId,
                        principalTable: "DbSetAutor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutorLivro_DbSetLivro_LivrosId",
                        column: x => x.LivrosId,
                        principalTable: "DbSetLivro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutorLivro_LivrosId",
                table: "AutorLivro",
                column: "LivrosId");
        }
    }
}
