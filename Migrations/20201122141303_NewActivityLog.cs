using Microsoft.EntityFrameworkCore.Migrations;

namespace aspnetcoreapp.Migrations
{
    public partial class NewActivityLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "VideoLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "StaticalLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Payload",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "ImageLog",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "VideoLog");

            migrationBuilder.DropColumn(
                name: "State",
                table: "StaticalLog");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Payload");

            migrationBuilder.DropColumn(
                name: "State",
                table: "ImageLog");
        }
    }
}
