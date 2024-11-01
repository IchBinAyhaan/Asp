using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Asp_task2.Migrations
{
    /// <inheritdoc />
    public partial class PricingCardAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PricingCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeaderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parag1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parag2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parag3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parag4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModofiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PricingCards", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PricingCards");
        }
    }
}
