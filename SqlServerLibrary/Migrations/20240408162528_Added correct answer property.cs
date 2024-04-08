using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SqlServerLibrary.Migrations
{
    /// <inheritdoc />
    public partial class Addedcorrectanswerproperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CorrectAnswer",
                table: "Answers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CorrectAnswer",
                table: "Answers");
        }
    }
}
