using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aula12_entity_frework.Migrations
{
    /// <inheritdoc />
    public partial class newMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "People",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "People",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Product",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_PersonId",
                table: "Product",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_People_PersonId",
                table: "Product",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_People_PersonId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_PersonId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "People",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "People",
                newName: "Nome");
        }
    }
}
