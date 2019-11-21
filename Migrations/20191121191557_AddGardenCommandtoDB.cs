using Microsoft.EntityFrameworkCore.Migrations;

namespace GardensApi.Migrations
{
    public partial class AddGardenCommandtoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GardenItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantName = table.Column<string>(nullable: true),
                    PlantDescription = table.Column<string>(nullable: true),
                    Alive = table.Column<bool>(nullable: false),
                    Indoor = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GardenItems", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GardenItems");
        }
    }
}
