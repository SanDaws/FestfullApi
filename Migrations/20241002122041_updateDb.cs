using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FestfullApi.Migrations
{
    /// <inheritdoc />
    public partial class updateDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "guest_id",
                table: "companions",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_companions_guest_id",
                table: "companions",
                column: "guest_id");

            migrationBuilder.AddForeignKey(
                name: "FK_companions_guests_guest_id",
                table: "companions",
                column: "guest_id",
                principalTable: "guests",
                principalColumn: "guest_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_companions_guests_guest_id",
                table: "companions");

            migrationBuilder.DropIndex(
                name: "IX_companions_guest_id",
                table: "companions");

            migrationBuilder.DropColumn(
                name: "guest_id",
                table: "companions");
        }
    }
}
