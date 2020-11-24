using Microsoft.EntityFrameworkCore.Migrations;

namespace aspnetcoreapp.Migrations
{
    public partial class newLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "X",
                table: "DroneLogs");

            migrationBuilder.DropColumn(
                name: "Y",
                table: "DroneLogs");

            migrationBuilder.AddColumn<int>(
                name: "Latitude",
                table: "DroneLogs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Longitude",
                table: "DroneLogs",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "DroneLogs");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "DroneLogs");

            migrationBuilder.AddColumn<int>(
                name: "X",
                table: "DroneLogs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Y",
                table: "DroneLogs",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
