using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace aspnetcoreapp.Migrations
{
    public partial class _6groups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DroneLogs",
                table: "DroneLogs");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "DroneLogs");

            migrationBuilder.RenameTable(
                name: "DroneLogs",
                newName: "DroneLog");

            migrationBuilder.AddColumn<int>(
                name: "DescriptionId",
                table: "DroneLog",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EntityId",
                table: "DroneLog",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Timestamp",
                table: "DroneLog",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_DroneLog",
                table: "DroneLog",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "DescriptionForm",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DescriptionForm", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DroneLog_DescriptionId",
                table: "DroneLog",
                column: "DescriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_DroneLog_DescriptionForm_DescriptionId",
                table: "DroneLog",
                column: "DescriptionId",
                principalTable: "DescriptionForm",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DroneLog_DescriptionForm_DescriptionId",
                table: "DroneLog");

            migrationBuilder.DropTable(
                name: "DescriptionForm");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DroneLog",
                table: "DroneLog");

            migrationBuilder.DropIndex(
                name: "IX_DroneLog_DescriptionId",
                table: "DroneLog");

            migrationBuilder.DropColumn(
                name: "DescriptionId",
                table: "DroneLog");

            migrationBuilder.DropColumn(
                name: "EntityId",
                table: "DroneLog");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "DroneLog");

            migrationBuilder.RenameTable(
                name: "DroneLog",
                newName: "DroneLogs");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "DroneLogs",
                type: "text",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DroneLogs",
                table: "DroneLogs",
                column: "Id");
        }
    }
}
