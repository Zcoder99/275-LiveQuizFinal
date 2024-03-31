using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SqlServerLibrary.Migrations
{
    /// <inheritdoc />
    public partial class addQuizPropertys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMultipleChoice",
                table: "Questions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsTrueFalse",
                table: "Questions",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMultipleChoice",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "IsTrueFalse",
                table: "Questions");
        }
    }
}
