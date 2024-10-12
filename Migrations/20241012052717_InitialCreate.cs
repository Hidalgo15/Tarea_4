using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tarea_4.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SeriePeliculasLibros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Pais = table.Column<string>(type: "TEXT", nullable: false),
                    Lenguage = table.Column<string>(type: "TEXT", nullable: false),
                    Tipo = table.Column<int>(type: "INTEGER", nullable: false),
                    PhotoUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Resumen = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriePeliculasLibros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personaje",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Apodo = table.Column<string>(type: "TEXT", nullable: false),
                    Raza = table.Column<string>(type: "TEXT", nullable: false),
                    Foto = table.Column<string>(type: "TEXT", nullable: true),
                    Edad = table.Column<int>(type: "INTEGER", nullable: false),
                    Poder_caracteristico = table.Column<string>(type: "TEXT", nullable: false),
                    Serie_Libro_Pelicula_Id = table.Column<int>(type: "INTEGER", nullable: false),
                    SeriesPeliculasLibrosId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personaje", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personaje_SeriePeliculasLibros_SeriesPeliculasLibrosId",
                        column: x => x.SeriesPeliculasLibrosId,
                        principalTable: "SeriePeliculasLibros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personaje_SeriesPeliculasLibrosId",
                table: "Personaje",
                column: "SeriesPeliculasLibrosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personaje");

            migrationBuilder.DropTable(
                name: "SeriePeliculasLibros");
        }
    }
}
