using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace aspnetcoreapp.Migrations
{
    public partial class _6groups1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DroneLog_DescriptionForm_DescriptionId",
                table: "DroneLog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DroneLog",
                table: "DroneLog");

            migrationBuilder.RenameTable(
                name: "DroneLog",
                newName: "DroneLogs");

            migrationBuilder.RenameIndex(
                name: "IX_DroneLog_DescriptionId",
                table: "DroneLogs",
                newName: "IX_DroneLogs_DescriptionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DroneLogs",
                table: "DroneLogs",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ImageLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EntityId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    DescriptionId = table.Column<int>(nullable: true),
                    Timestamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageLog_DescriptionForm_DescriptionId",
                        column: x => x.DescriptionId,
                        principalTable: "DescriptionForm",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IncidentLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EntityId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    DescriptionId = table.Column<int>(nullable: true),
                    Timestamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncidentLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IncidentLog_DescriptionForm_DescriptionId",
                        column: x => x.DescriptionId,
                        principalTable: "DescriptionForm",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ObjectObserve",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EntityId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    DescriptionId = table.Column<int>(nullable: true),
                    Timestamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjectObserve", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ObjectObserve_DescriptionForm_DescriptionId",
                        column: x => x.DescriptionId,
                        principalTable: "DescriptionForm",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payload",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EntityId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    DescriptionId = table.Column<int>(nullable: true),
                    Timestamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payload", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payload_DescriptionForm_DescriptionId",
                        column: x => x.DescriptionId,
                        principalTable: "DescriptionForm",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EntityId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    DescriptionId = table.Column<int>(nullable: true),
                    Timestamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserLog_DescriptionForm_DescriptionId",
                        column: x => x.DescriptionId,
                        principalTable: "DescriptionForm",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VideoLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EntityId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    DescriptionId = table.Column<int>(nullable: true),
                    Timestamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VideoLog_DescriptionForm_DescriptionId",
                        column: x => x.DescriptionId,
                        principalTable: "DescriptionForm",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImageLog_DescriptionId",
                table: "ImageLog",
                column: "DescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentLog_DescriptionId",
                table: "IncidentLog",
                column: "DescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_ObjectObserve_DescriptionId",
                table: "ObjectObserve",
                column: "DescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Payload_DescriptionId",
                table: "Payload",
                column: "DescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLog_DescriptionId",
                table: "UserLog",
                column: "DescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoLog_DescriptionId",
                table: "VideoLog",
                column: "DescriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_DroneLogs_DescriptionForm_DescriptionId",
                table: "DroneLogs",
                column: "DescriptionId",
                principalTable: "DescriptionForm",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DroneLogs_DescriptionForm_DescriptionId",
                table: "DroneLogs");

            migrationBuilder.DropTable(
                name: "ImageLog");

            migrationBuilder.DropTable(
                name: "IncidentLog");

            migrationBuilder.DropTable(
                name: "ObjectObserve");

            migrationBuilder.DropTable(
                name: "Payload");

            migrationBuilder.DropTable(
                name: "UserLog");

            migrationBuilder.DropTable(
                name: "VideoLog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DroneLogs",
                table: "DroneLogs");

            migrationBuilder.RenameTable(
                name: "DroneLogs",
                newName: "DroneLog");

            migrationBuilder.RenameIndex(
                name: "IX_DroneLogs_DescriptionId",
                table: "DroneLog",
                newName: "IX_DroneLog_DescriptionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DroneLog",
                table: "DroneLog",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DroneLog_DescriptionForm_DescriptionId",
                table: "DroneLog",
                column: "DescriptionId",
                principalTable: "DescriptionForm",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
