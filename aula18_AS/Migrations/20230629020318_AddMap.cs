using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aula18_AS.Migrations
{
    /// <inheritdoc />
    public partial class AddMap : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DbSetAutorLivro_DbSetAutor_AutorId",
                table: "DbSetAutorLivro");

            migrationBuilder.DropForeignKey(
                name: "FK_DbSetEmprestimo_DbSetLivro_EmprestimosId",
                table: "DbSetEmprestimo");

            migrationBuilder.DropIndex(
                name: "IX_DbSetEmprestimo_EmprestimosId",
                table: "DbSetEmprestimo");

            migrationBuilder.DropColumn(
                name: "EmprestimosId",
                table: "DbSetEmprestimo");

            migrationBuilder.DropColumn(
                name: "AutoresId",
                table: "DbSetAutorLivro");

            migrationBuilder.AddColumn<int>(
                name: "LivroId",
                table: "DbSetEmprestimo",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "AutorId",
                table: "DbSetAutorLivro",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DbSetEmprestimo_LivroId",
                table: "DbSetEmprestimo",
                column: "LivroId");

            migrationBuilder.AddForeignKey(
                name: "FK_DbSetAutorLivro_DbSetAutor_AutorId",
                table: "DbSetAutorLivro",
                column: "AutorId",
                principalTable: "DbSetAutor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DbSetEmprestimo_DbSetLivro_LivroId",
                table: "DbSetEmprestimo",
                column: "LivroId",
                principalTable: "DbSetLivro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DbSetAutorLivro_DbSetAutor_AutorId",
                table: "DbSetAutorLivro");

            migrationBuilder.DropForeignKey(
                name: "FK_DbSetEmprestimo_DbSetLivro_LivroId",
                table: "DbSetEmprestimo");

            migrationBuilder.DropIndex(
                name: "IX_DbSetEmprestimo_LivroId",
                table: "DbSetEmprestimo");

            migrationBuilder.DropColumn(
                name: "LivroId",
                table: "DbSetEmprestimo");

            migrationBuilder.AddColumn<int>(
                name: "EmprestimosId",
                table: "DbSetEmprestimo",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AutorId",
                table: "DbSetAutorLivro",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "AutoresId",
                table: "DbSetAutorLivro",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DbSetEmprestimo_EmprestimosId",
                table: "DbSetEmprestimo",
                column: "EmprestimosId");

            migrationBuilder.AddForeignKey(
                name: "FK_DbSetAutorLivro_DbSetAutor_AutorId",
                table: "DbSetAutorLivro",
                column: "AutorId",
                principalTable: "DbSetAutor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DbSetEmprestimo_DbSetLivro_EmprestimosId",
                table: "DbSetEmprestimo",
                column: "EmprestimosId",
                principalTable: "DbSetLivro",
                principalColumn: "Id");
        }
    }
}
