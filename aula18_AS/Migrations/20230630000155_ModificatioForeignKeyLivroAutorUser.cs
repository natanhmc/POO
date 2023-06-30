using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aula18_AS.Migrations
{
    /// <inheritdoc />
    public partial class ModificatioForeignKeyLivroAutorUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DbSetAutorLivro_DbSetAutor_AutorId",
                table: "DbSetAutorLivro");

            migrationBuilder.DropForeignKey(
                name: "FK_DbSetAutorLivro_DbSetLivro_LivroId",
                table: "DbSetAutorLivro");

            migrationBuilder.DropForeignKey(
                name: "FK_DbSetEmprestimo_DbSetLivro_LivroId",
                table: "DbSetEmprestimo");

            migrationBuilder.DropForeignKey(
                name: "FK_DbSetEmprestimo_DbSetUsuario_UsuarioId",
                table: "DbSetEmprestimo");

            migrationBuilder.DropIndex(
                name: "IX_DbSetAutorLivro_AutorId",
                table: "DbSetAutorLivro");

            migrationBuilder.DropIndex(
                name: "IX_DbSetAutorLivro_LivroId",
                table: "DbSetAutorLivro");

            migrationBuilder.RenameColumn(
                name: "LivroId",
                table: "DbSetAutorLivro",
                newName: "LivroCodBarras");

            migrationBuilder.RenameColumn(
                name: "AutorId",
                table: "DbSetAutorLivro",
                newName: "AutorCpf");

            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "DbSetUsuario",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "DbSetEmprestimo",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "LivroId",
                table: "DbSetEmprestimo",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "LivroCodBarras",
                table: "DbSetEmprestimo",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioCpf",
                table: "DbSetEmprestimo",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AutoresId",
                table: "DbSetAutorLivro",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LivrosId",
                table: "DbSetAutorLivro",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DbSetAutorLivro_AutoresId",
                table: "DbSetAutorLivro",
                column: "AutoresId");

            migrationBuilder.CreateIndex(
                name: "IX_DbSetAutorLivro_LivrosId",
                table: "DbSetAutorLivro",
                column: "LivrosId");

            migrationBuilder.AddForeignKey(
                name: "FK_DbSetAutorLivro_DbSetAutor_AutoresId",
                table: "DbSetAutorLivro",
                column: "AutoresId",
                principalTable: "DbSetAutor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DbSetAutorLivro_DbSetLivro_LivrosId",
                table: "DbSetAutorLivro",
                column: "LivrosId",
                principalTable: "DbSetLivro",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DbSetEmprestimo_DbSetLivro_LivroId",
                table: "DbSetEmprestimo",
                column: "LivroId",
                principalTable: "DbSetLivro",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DbSetEmprestimo_DbSetUsuario_UsuarioId",
                table: "DbSetEmprestimo",
                column: "UsuarioId",
                principalTable: "DbSetUsuario",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DbSetAutorLivro_DbSetAutor_AutoresId",
                table: "DbSetAutorLivro");

            migrationBuilder.DropForeignKey(
                name: "FK_DbSetAutorLivro_DbSetLivro_LivrosId",
                table: "DbSetAutorLivro");

            migrationBuilder.DropForeignKey(
                name: "FK_DbSetEmprestimo_DbSetLivro_LivroId",
                table: "DbSetEmprestimo");

            migrationBuilder.DropForeignKey(
                name: "FK_DbSetEmprestimo_DbSetUsuario_UsuarioId",
                table: "DbSetEmprestimo");

            migrationBuilder.DropIndex(
                name: "IX_DbSetAutorLivro_AutoresId",
                table: "DbSetAutorLivro");

            migrationBuilder.DropIndex(
                name: "IX_DbSetAutorLivro_LivrosId",
                table: "DbSetAutorLivro");

            migrationBuilder.DropColumn(
                name: "CPF",
                table: "DbSetUsuario");

            migrationBuilder.DropColumn(
                name: "LivroCodBarras",
                table: "DbSetEmprestimo");

            migrationBuilder.DropColumn(
                name: "UsuarioCpf",
                table: "DbSetEmprestimo");

            migrationBuilder.DropColumn(
                name: "AutoresId",
                table: "DbSetAutorLivro");

            migrationBuilder.DropColumn(
                name: "LivrosId",
                table: "DbSetAutorLivro");

            migrationBuilder.RenameColumn(
                name: "LivroCodBarras",
                table: "DbSetAutorLivro",
                newName: "LivroId");

            migrationBuilder.RenameColumn(
                name: "AutorCpf",
                table: "DbSetAutorLivro",
                newName: "AutorId");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "DbSetEmprestimo",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LivroId",
                table: "DbSetEmprestimo",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DbSetAutorLivro_AutorId",
                table: "DbSetAutorLivro",
                column: "AutorId");

            migrationBuilder.CreateIndex(
                name: "IX_DbSetAutorLivro_LivroId",
                table: "DbSetAutorLivro",
                column: "LivroId");

            migrationBuilder.AddForeignKey(
                name: "FK_DbSetAutorLivro_DbSetAutor_AutorId",
                table: "DbSetAutorLivro",
                column: "AutorId",
                principalTable: "DbSetAutor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DbSetAutorLivro_DbSetLivro_LivroId",
                table: "DbSetAutorLivro",
                column: "LivroId",
                principalTable: "DbSetLivro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DbSetEmprestimo_DbSetLivro_LivroId",
                table: "DbSetEmprestimo",
                column: "LivroId",
                principalTable: "DbSetLivro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DbSetEmprestimo_DbSetUsuario_UsuarioId",
                table: "DbSetEmprestimo",
                column: "UsuarioId",
                principalTable: "DbSetUsuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
