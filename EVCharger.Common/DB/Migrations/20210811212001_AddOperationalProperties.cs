using Microsoft.EntityFrameworkCore.Migrations;

namespace EVCharger.DB.Migrations
{
    public partial class AddOperationalProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "DefaultTariff",
                table: "Constellations",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MinBalanceToInitiateCharging",
                table: "Constellations",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "OperationMode",
                table: "Constellations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "OverdraftIstAllowed",
                table: "Constellations",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DefaultTariff",
                table: "Constellations");

            migrationBuilder.DropColumn(
                name: "MinBalanceToInitiateCharging",
                table: "Constellations");

            migrationBuilder.DropColumn(
                name: "OperationMode",
                table: "Constellations");

            migrationBuilder.DropColumn(
                name: "OverdraftIstAllowed",
                table: "Constellations");
        }
    }
}
