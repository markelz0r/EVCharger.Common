using Microsoft.EntityFrameworkCore.Migrations;

namespace EVCharger.DB.Migrations
{
    public partial class AddConstellations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Constellations_Users_AdministratorsId",
                table: "Constellations");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Constellations_ConstellationId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ConstellationId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Constellations_AdministratorsId",
                table: "Constellations");

            migrationBuilder.DropColumn(
                name: "ConstellationId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AdministratorsId",
                table: "Constellations");

            migrationBuilder.CreateTable(
                name: "ConstellationUser",
                columns: table => new
                {
                    ConstellationsId = table.Column<string>(type: "text", nullable: false),
                    UsersId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConstellationUser", x => new { x.ConstellationsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ConstellationUser_Constellations_ConstellationsId",
                        column: x => x.ConstellationsId,
                        principalTable: "Constellations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConstellationUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConstellationUser_UsersId",
                table: "ConstellationUser",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConstellationUser");

            migrationBuilder.AddColumn<string>(
                name: "ConstellationId",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdministratorsId",
                table: "Constellations",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_ConstellationId",
                table: "Users",
                column: "ConstellationId");

            migrationBuilder.CreateIndex(
                name: "IX_Constellations_AdministratorsId",
                table: "Constellations",
                column: "AdministratorsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Constellations_Users_AdministratorsId",
                table: "Constellations",
                column: "AdministratorsId",
                principalTable: "Users",
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
    }
}
