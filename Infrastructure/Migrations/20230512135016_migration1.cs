using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cinemas",
                columns: table => new
                {
                    CinemaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Localisation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinemas", x => x.CinemaId);
                });

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    FilmId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Duree = table.Column<double>(type: "float", nullable: false),
                    DateRealisation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Prix = table.Column<double>(type: "float", nullable: false),
                    typeFilm = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.FilmId);
                });

            migrationBuilder.CreateTable(
                name: "Salles",
                columns: table => new
                {
                    IdSalle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    NbPlaces = table.Column<int>(type: "int", nullable: false),
                    CinemaId = table.Column<int>(type: "int", nullable: false),
                    CinemaFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salles", x => x.IdSalle);
                    table.ForeignKey(
                        name: "FK_Salles_Cinemas_CinemaId",
                        column: x => x.CinemaId,
                        principalTable: "Cinemas",
                        principalColumn: "CinemaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projections",
                columns: table => new
                {
                    DateProjection = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TypeProjection = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SalleFK = table.Column<int>(type: "int", nullable: false),
                    FilmFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projections", x => x.DateProjection);
                    table.ForeignKey(
                        name: "FK_Projections_Films_FilmFK",
                        column: x => x.FilmFK,
                        principalTable: "Films",
                        principalColumn: "FilmId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projections_Salles_SalleFK",
                        column: x => x.SalleFK,
                        principalTable: "Salles",
                        principalColumn: "IdSalle",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projections_FilmFK",
                table: "Projections",
                column: "FilmFK");

            migrationBuilder.CreateIndex(
                name: "IX_Projections_SalleFK",
                table: "Projections",
                column: "SalleFK");

            migrationBuilder.CreateIndex(
                name: "IX_Salles_CinemaId",
                table: "Salles",
                column: "CinemaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projections");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "Salles");

            migrationBuilder.DropTable(
                name: "Cinemas");
        }
    }
}
