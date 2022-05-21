using Microsoft.EntityFrameworkCore.Migrations;

namespace BusReservation.Data.Migrations
{
    public partial class mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TicketArrivalCity",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "TicketDepartureCity",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Finish",
                table: "Directions");

            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Directions",
                newName: "StartCity");

            migrationBuilder.RenameColumn(
                name: "Start",
                table: "Directions",
                newName: "FinishCity");

            migrationBuilder.AddColumn<int>(
                name: "ChooseSeatId",
                table: "Tickets",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SeatTotalNumber",
                table: "Directions",
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
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    IsEmpty = table.Column<bool>(type: "INTEGER", nullable: false)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_ChooseSeat_ChooseSeatId",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "ChooseSeat");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_ChooseSeatId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "ChooseSeatId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "SeatTotalNumber",
                table: "Directions");

            migrationBuilder.RenameColumn(
                name: "StartCity",
                table: "Directions",
                newName: "Time");

            migrationBuilder.RenameColumn(
                name: "FinishCity",
                table: "Directions",
                newName: "Start");

            migrationBuilder.AddColumn<string>(
                name: "TicketArrivalCity",
                table: "Tickets",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TicketDepartureCity",
                table: "Tickets",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Finish",
                table: "Directions",
                type: "TEXT",
                nullable: true);
        }
    }
}
