using Microsoft.EntityFrameworkCore.Migrations;

namespace aspnetcoreapp.Migrations
{
    public partial class AddPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "WarningLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkName",
                table: "UserLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "UavConnectLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "ResolveProblemLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "ObjectObserve",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "MonitorRegionLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "IncidentLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RegionName",
                table: "DroneLogs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "X",
                table: "DroneLogs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Y",
                table: "DroneLogs",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "WarningLog");

            migrationBuilder.DropColumn(
                name: "WorkName",
                table: "UserLog");

            migrationBuilder.DropColumn(
                name: "State",
                table: "UavConnectLog");

            migrationBuilder.DropColumn(
                name: "State",
                table: "ResolveProblemLog");

            migrationBuilder.DropColumn(
                name: "State",
                table: "ObjectObserve");

            migrationBuilder.DropColumn(
                name: "State",
                table: "MonitorRegionLog");

            migrationBuilder.DropColumn(
                name: "State",
                table: "IncidentLog");

            migrationBuilder.DropColumn(
                name: "RegionName",
                table: "DroneLogs");

            migrationBuilder.DropColumn(
                name: "X",
                table: "DroneLogs");

            migrationBuilder.DropColumn(
                name: "Y",
                table: "DroneLogs");
        }
    }
}
