using Microsoft.EntityFrameworkCore.Migrations;

namespace BusReservation.Data.Migrations
{
    public partial class mig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_ChooseSeat_ChooseSeatId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Directions_DirectionId",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "ChooseSeat");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_ChooseSeatId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_DirectionId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "ChooseSeatId",
                table: "Tickets");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ChooseSeatId",
                table: "Tickets",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ChooseSeat",
                columns: table => new
                {
                    ChooseSeatId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DirectionId = table.Column<int>(type: "INTEGER", nullable: false),
                    IsEmpty = table.Column<bool>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChooseSeat", x => x.ChooseSeatId);
                    table.ForeignKey(
                        name: "FK_ChooseSeat_Directions_DirectionId",
                        column: x => x.DirectionId,
                        principalTable: "Directions",
                        principalColumn: "DirectionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ChooseSeatId",
                table: "Tickets",
                column: "ChooseSeatId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_DirectionId",
                table: "Tickets",
                column: "DirectionId");

            migrationBuilder.CreateIndex(
                name: "IX_ChooseSeat_DirectionId",
                table: "ChooseSeat",
                column: "DirectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_ChooseSeat_ChooseSeatId",
                table: "Tickets",
                column: "ChooseSeatId",
                principalTable: "ChooseSeat",
                principalColumn: "ChooseSeatId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Directions_DirectionId",
                table: "Tickets",
                column: "DirectionId",
                principalTable: "Directions",
                principalColumn: "DirectionId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
