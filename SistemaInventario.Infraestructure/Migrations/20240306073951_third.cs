using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaInventario.Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sexo",
                table: "AspNetUsers",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "Rol",
                table: "AspNetUsers",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "Edad",
                table: "AspNetUsers",
                newName: "Age");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Role",
                table: "AspNetUsers",
                newName: "Sexo");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "AspNetUsers",
                newName: "Rol");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "AspNetUsers",
                newName: "Edad");
        }
    }
}
