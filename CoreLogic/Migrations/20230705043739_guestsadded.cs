using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreLogic.Migrations
{
    /// <inheritdoc />
    public partial class guestsadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Noof_Guests",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Noof_Guests",
                table: "Events");
        }
    }
}
