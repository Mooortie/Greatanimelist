using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Greatanimelist.Server.Migrations
{
    /// <inheritdoc />
    public partial class addingseenEpisodes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SeenEpisodes",
                table: "Anime",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeenEpisodes",
                table: "Anime");
        }
    }
}
