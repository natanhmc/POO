using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aula18_AS.Migrations
{
    /// <inheritdoc />
    public partial class RemodeladoOutraVez : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DbSerEmprestimo_DbSetLivro_EmprestimosId",
                table: "DbSerEmprestimo");

            migrationBuilder.DropForeignKey(
                name: "FK_DbSerEmprestimo_usuario_UsuarioId",
                table: "DbSerEmprestimo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_usuario",
                table: "usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DbSerEmprestimo",
                table: "DbSerEmprestimo");

            migrationBuilder.RenameTable(
                name: "usuario",
                newName: "DbSetUsuario");

            migrationBuilder.RenameTable(
                name: "DbSerEmprestimo",
                newName: "DbSetEmprestimo");

            migrationBuilder.RenameColumn(
                name: "senha",
                table: "DbSetUsuario",
                newName: "Senha");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "DbSetUsuario",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "DbSetUsuario",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_DbSerEmprestimo_UsuarioId",
                table: "DbSetEmprestimo",
                newName: "IX_DbSetEmprestimo_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_DbSerEmprestimo_EmprestimosId",
                table: "DbSetEmprestimo",
                newName: "IX_DbSetEmprestimo_EmprestimosId");

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "DbSetUsuario",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "DbSetUsuario",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DbSetUsuario",
                table: "DbSetUsuario",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DbSetEmprestimo",
                table: "DbSetEmprestimo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DbSetEmprestimo_DbSetLivro_EmprestimosId",
                table: "DbSetEmprestimo",
                column: "EmprestimosId",
                principalTable: "DbSetLivro",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DbSetEmprestimo_DbSetUsuario_UsuarioId",
                table: "DbSetEmprestimo",
                column: "UsuarioId",
                principalTable: "DbSetUsuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DbSetEmprestimo_DbSetLivro_EmprestimosId",
                table: "DbSetEmprestimo");

            migrationBuilder.DropForeignKey(
                name: "FK_DbSetEmprestimo_DbSetUsuario_UsuarioId",
                table: "DbSetEmprestimo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DbSetUsuario",
                table: "DbSetUsuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DbSetEmprestimo",
                table: "DbSetEmprestimo");

            migrationBuilder.RenameTable(
                name: "DbSetUsuario",
                newName: "usuario");

            migrationBuilder.RenameTable(
                name: "DbSetEmprestimo",
                newName: "DbSerEmprestimo");

            migrationBuilder.RenameColumn(
                name: "Senha",
                table: "usuario",
                newName: "senha");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "usuario",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "usuario",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_DbSetEmprestimo_UsuarioId",
                table: "DbSerEmprestimo",
                newName: "IX_DbSerEmprestimo_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_DbSetEmprestimo_EmprestimosId",
                table: "DbSerEmprestimo",
                newName: "IX_DbSerEmprestimo_EmprestimosId");

            migrationBuilder.AlterColumn<string>(
                name: "senha",
                table: "usuario",
                type: "varchar(30)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "usuario",
                type: "varchar(200)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_usuario",
                table: "usuario",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DbSerEmprestimo",
                table: "DbSerEmprestimo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DbSerEmprestimo_DbSetLivro_EmprestimosId",
                table: "DbSerEmprestimo",
                column: "EmprestimosId",
                principalTable: "DbSetLivro",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DbSerEmprestimo_usuario_UsuarioId",
                table: "DbSerEmprestimo",
                column: "UsuarioId",
                principalTable: "usuario",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
