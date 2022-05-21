using Microsoft.EntityFrameworkCore.Migrations;

namespace BusReservation.Data.Migrations
{
    public partial class mig8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Tickets_DirectionId",
                table: "Tickets",
                column: "DirectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Directions_DirectionId",
                table: "Tickets",
                column: "DirectionId",
                principalTable: "Directions",
                principalColumn: "DirectionId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Directions_DirectionId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_DirectionId",
                table: "Tickets");
        }
    }
}
