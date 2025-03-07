using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PRACT2CRUD.Migrations
{
    /// <inheritdoc />
    public partial class AgregarGeneroEstudiante : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "Estudiantes",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Estudiantes");
        }
    }
}
