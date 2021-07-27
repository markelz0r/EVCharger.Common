using Microsoft.EntityFrameworkCore.Migrations;

namespace EVCharger.DB.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chargers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    ChargerStatus = table.Column<int>(type: "integer", nullable: false),
                    ConstellationId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chargers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    Balance = table.Column<double>(type: "double precision", nullable: false),
                    AccountType = table.Column<int>(type: "integer", nullable: false),
                    ConstellationId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Constellations",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    AdministratorsId = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Constellations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Constellations_Users_AdministratorsId",
                        column: x => x.AdministratorsId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chargers_ConstellationId",
                table: "Chargers",
                column: "ConstellationId");

            migrationBuilder.CreateIndex(
                name: "IX_Constellations_AdministratorsId",
                table: "Constellations",
                column: "AdministratorsId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ConstellationId",
                table: "Users",
                column: "ConstellationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chargers_Constellations_ConstellationId",
                table: "Chargers",
                column: "ConstellationId",
                principalTable: "Constellations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Constellations_ConstellationId",
                table: "Users",
                column: "ConstellationId",
                principalTable: "Constellations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Constellations_ConstellationId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Chargers");

            migrationBuilder.DropTable(
                name: "Constellations");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
