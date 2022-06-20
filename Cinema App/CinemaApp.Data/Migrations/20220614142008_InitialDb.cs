using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemaApp.Data.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    FilmId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FilmName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Duration = table.Column<int>(type: "INTEGER", nullable: false),
                    Poster = table.Column<string>(type: "TEXT", nullable: true),
                    FilmDescription = table.Column<string>(type: "TEXT", nullable: true),
                    DirectorName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.FilmId);
                });

            migrationBuilder.CreateTable(
                name: "FilmCategories",
                columns: table => new
                {
                    FilmId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmCategories", x => new { x.FilmId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_FilmCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmCategories_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "FilmId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 1, "Komedi" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 2, "Aile" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 3, "Korku" });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmId", "DirectorName", "Duration", "FilmDescription", "FilmName", "Poster" },
                values: new object[] { 1, "Şahan GÖKBAKAR", 120, "Sevgilinizle izlemeyin!!!", "Recep İvedik 1", "url" });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmId", "DirectorName", "Duration", "FilmDescription", "FilmName", "Poster" },
                values: new object[] { 2, "Şahan GÖKBAKAR", 120, "Sevgilinizle izlemeyin!!!", "Recep İvedik 2", "url" });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmId", "DirectorName", "Duration", "FilmDescription", "FilmName", "Poster" },
                values: new object[] { 3, "Şahan GÖKBAKAR", 120, "Sevgilinizle izlemeyin!!!", "Recep İvedik 3", "url" });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmId", "DirectorName", "Duration", "FilmDescription", "FilmName", "Poster" },
                values: new object[] { 4, "Şahan GÖKBAKAR", 120, "Sevgilinizle izlemeyin!!!", "Recep İvedik 4", "url" });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmId", "DirectorName", "Duration", "FilmDescription", "FilmName", "Poster" },
                values: new object[] { 5, "Şahan GÖKBAKAR", 120, "Sevgilinizle izlemeyin!!!", "Recep İvedik 5", "url" });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmId", "DirectorName", "Duration", "FilmDescription", "FilmName", "Poster" },
                values: new object[] { 6, "Şahan GÖKBAKAR", 120, "Sevgilinizle izlemeyin!!!", "Recep İvedik 6", "url" });

            migrationBuilder.InsertData(
                table: "FilmCategories",
                columns: new[] { "CategoryId", "FilmId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "FilmCategories",
                columns: new[] { "CategoryId", "FilmId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "FilmCategories",
                columns: new[] { "CategoryId", "FilmId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "FilmCategories",
                columns: new[] { "CategoryId", "FilmId" },
                values: new object[] { 3, 2 });

            migrationBuilder.InsertData(
                table: "FilmCategories",
                columns: new[] { "CategoryId", "FilmId" },
                values: new object[] { 1, 3 });

            migrationBuilder.InsertData(
                table: "FilmCategories",
                columns: new[] { "CategoryId", "FilmId" },
                values: new object[] { 1, 4 });

            migrationBuilder.InsertData(
                table: "FilmCategories",
                columns: new[] { "CategoryId", "FilmId" },
                values: new object[] { 2, 5 });

            migrationBuilder.InsertData(
                table: "FilmCategories",
                columns: new[] { "CategoryId", "FilmId" },
                values: new object[] { 2, 6 });

            migrationBuilder.CreateIndex(
                name: "IX_FilmCategories_CategoryId",
                table: "FilmCategories",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmCategories");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Films");
        }
    }
}
