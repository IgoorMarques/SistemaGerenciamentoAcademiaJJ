using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class RemoçãoColumnProfessorID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turma_Professor_ProfessorID",
                table: "Turma");

            migrationBuilder.DropIndex(
                name: "IX_Turma_ProfessorID",
                table: "Turma");

            migrationBuilder.DropColumn(
                name: "ProfessorID",
                table: "Turma");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfessorID",
                table: "Turma",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Turma_ProfessorID",
                table: "Turma",
                column: "ProfessorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Turma_Professor_ProfessorID",
                table: "Turma",
                column: "ProfessorID",
                principalTable: "Professor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
