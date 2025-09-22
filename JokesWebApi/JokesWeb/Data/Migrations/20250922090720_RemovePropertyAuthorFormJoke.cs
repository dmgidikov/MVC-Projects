using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JokesWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemovePropertyAuthorFormJoke : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Joke");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Joke",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
