﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aula12_entity_frework.Migrations
{
    /// <inheritdoc />
    public partial class AddPhoneNumberPerson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "phoneNumber",
                table: "People",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "phoneNumber",
                table: "People");
        }
    }
}
