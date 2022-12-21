using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelAdesso.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class BudgetRemoved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxBudget",
                table: "Guests");

            migrationBuilder.DropColumn(
                name: "MinBudget",
                table: "Guests");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "MaxBudget",
                table: "Guests",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MinBudget",
                table: "Guests",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
