using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JokesWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCreatedByUsernamePropertyInJokes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedByUsername",
                table: "Joke",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByUsername",
                table: "Joke");
        }
    }
}
