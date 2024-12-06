using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace final_project_final_project_group_9.Migrations.FavoriteFoods
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavoriteFoods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FavBreakfast = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FavLunch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FavSnack = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FavDinner = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteFoods", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FavoriteFoods",
                columns: new[] { "Id", "FavBreakfast", "FavDinner", "FavLunch", "FavSnack" },
                values: new object[,]
                {
                    { 12345678, "Toast", "pasta", "sandwich", "Chips" },
                    { 14969824, "sandwich", "egg", "ham", "pie" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteFoods");
        }
    }
}
