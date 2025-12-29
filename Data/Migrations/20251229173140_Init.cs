using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotKeyHeros.Data.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Collections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UtcStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UtcEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumKeyStrokes = table.Column<int>(type: "int", nullable: false),
                    NumMouseClicks = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collections", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Collections");
        }
    }
}
