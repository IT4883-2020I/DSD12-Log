using Microsoft.EntityFrameworkCore.Migrations;

namespace aspnetcoreapp.Migrations
{
    public partial class netEntityLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "WarningLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "VideoLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "UserLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "UavConnectLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "StaticalLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ResolveProblemLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Payload",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ObjectObserve",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "MonitorRegionLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "IncidentLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ImageLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "DroneLogs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "WarningLog");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "VideoLog");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "UserLog");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "UavConnectLog");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "StaticalLog");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ResolveProblemLog");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Payload");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ObjectObserve");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "MonitorRegionLog");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "IncidentLog");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ImageLog");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "DroneLogs");
        }
    }
}
