using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FestfullApi.Migrations
{
    /// <inheritdoc />
    public partial class modelingdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "companions",
                columns: table => new
                {
                    companion_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    dog_checker = table.Column<bool>(type: "boolean", nullable: false),
                    f_name = table.Column<string>(type: "text", nullable: false),
                    s_name = table.Column<string>(type: "text", nullable: true),
                    f_last_name = table.Column<string>(type: "text", nullable: true),
                    s_last_name = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companions", x => x.companion_id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    event_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    event_name = table.Column<string>(type: "text", nullable: false),
                    tables = table.Column<long>(type: "bigint", nullable: false),
                    chairs_per_table = table.Column<long>(type: "bigint", nullable: false),
                    event_Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Event_stamp = table.Column<DateOnly>(type: "date", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.event_id);
                });

            migrationBuilder.CreateTable(
                name: "guests",
                columns: table => new
                {
                    guest_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    phone = table.Column<string>(type: "text", nullable: false),
                    b_day = table.Column<DateOnly>(type: "date", nullable: false),
                    alcohol_checker = table.Column<bool>(type: "boolean", nullable: false),
                    alergies = table.Column<List<string>>(type: "text[]", nullable: false),
                    pass_word = table.Column<string>(type: "text", nullable: false),
                    evetn_id = table.Column<long>(type: "bigint", nullable: false),
                    f_name = table.Column<string>(type: "text", nullable: false),
                    s_name = table.Column<string>(type: "text", nullable: true),
                    f_last_name = table.Column<string>(type: "text", nullable: true),
                    s_last_name = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_guests", x => x.guest_id);
                    table.ForeignKey(
                        name: "FK_guests_Events_evetn_id",
                        column: x => x.evetn_id,
                        principalTable: "Events",
                        principalColumn: "event_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_guests_evetn_id",
                table: "guests",
                column: "evetn_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "companions");

            migrationBuilder.DropTable(
                name: "guests");

            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
