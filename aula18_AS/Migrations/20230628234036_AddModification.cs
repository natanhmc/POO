using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aula18_AS.Migrations
{
    /// <inheritdoc />
    public partial class AddModification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DbSetLivro_DbSetAutor_AutorId",
                table: "DbSetLivro");

            migrationBuilder.DropIndex(
                name: "IX_DbSetLivro_AutorId",
                table: "DbSetLivro");

            migrationBuilder.DropColumn(
                name: "AutorId",
                table: "DbSetLivro");

            migrationBuilder.AddColumn<int>(
                name: "AutorId",
                table: "DbSetAutorLivro",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DbSetAutorLivro_AutorId",
                table: "DbSetAutorLivro",
                column: "AutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_DbSetAutorLivro_DbSetAutor_AutorId",
                table: "DbSetAutorLivro",
                column: "AutorId",
                principalTable: "DbSetAutor",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DbSetAutorLivro_DbSetAutor_AutorId",
                table: "DbSetAutorLivro");

            migrationBuilder.DropIndex(
                name: "IX_DbSetAutorLivro_AutorId",
                table: "DbSetAutorLivro");

            migrationBuilder.DropColumn(
                name: "AutorId",
                table: "DbSetAutorLivro");

            migrationBuilder.AddColumn<int>(
                name: "AutorId",
                table: "DbSetLivro",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DbSetLivro_AutorId",
                table: "DbSetLivro",
                column: "AutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_DbSetLivro_DbSetAutor_AutorId",
                table: "DbSetLivro",
                column: "AutorId",
                principalTable: "DbSetAutor",
                principalColumn: "Id");
        }
    }
}
