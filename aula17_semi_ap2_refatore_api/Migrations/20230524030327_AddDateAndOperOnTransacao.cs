using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aula08_ap1.Migrations
{
    /// <inheritdoc />
    public partial class AddDateAndOperOnTransacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Valor",
                table: "TransacoesBancarias",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "Operacao",
                table: "TransacoesBancarias",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Operacao",
                table: "TransacoesBancarias");

            migrationBuilder.AlterColumn<decimal>(
                name: "Valor",
                table: "TransacoesBancarias",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");
        }
    }
}
