using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aula18_AS.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DbSetAutor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    CPF = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbSetAutor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DbSetLivro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(type: "TEXT", nullable: true),
                    NumeroPag = table.Column<int>(type: "INTEGER", nullable: false),
                    CodBarras = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbSetLivro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    senha = table.Column<string>(type: "varchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.id);
                });

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

            migrationBuilder.CreateTable(
                name: "DbSerEmprestimo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false),
                    EmprestimosId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbSerEmprestimo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DbSerEmprestimo_DbSetLivro_EmprestimosId",
                        column: x => x.EmprestimosId,
                        principalTable: "DbSetLivro",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DbSerEmprestimo_usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutorLivro_LivrosId",
                table: "AutorLivro",
                column: "LivrosId");

            migrationBuilder.CreateIndex(
                name: "IX_DbSerEmprestimo_EmprestimosId",
                table: "DbSerEmprestimo",
                column: "EmprestimosId");

            migrationBuilder.CreateIndex(
                name: "IX_DbSerEmprestimo_UsuarioId",
                table: "DbSerEmprestimo",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutorLivro");

            migrationBuilder.DropTable(
                name: "DbSerEmprestimo");

            migrationBuilder.DropTable(
                name: "DbSetAutor");

            migrationBuilder.DropTable(
                name: "DbSetLivro");

            migrationBuilder.DropTable(
                name: "usuario");
        }
    }
}
