using Microsoft.EntityFrameworkCore.Migrations;

namespace DadJokesWebApp.Data.Migrations
{
    public partial class addusers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JokeUser",
                table: "Joke",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JokeUser",
                table: "Joke");
        }
    }
}
