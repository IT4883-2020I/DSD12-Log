using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace aspnetcoreapp.Migrations
{
    public partial class _6groups2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DroneLogs_DescriptionForm_DescriptionId",
                table: "DroneLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_ImageLog_DescriptionForm_DescriptionId",
                table: "ImageLog");

            migrationBuilder.DropForeignKey(
                name: "FK_IncidentLog_DescriptionForm_DescriptionId",
                table: "IncidentLog");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectObserve_DescriptionForm_DescriptionId",
                table: "ObjectObserve");

            migrationBuilder.DropForeignKey(
                name: "FK_Payload_DescriptionForm_DescriptionId",
                table: "Payload");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLog_DescriptionForm_DescriptionId",
                table: "UserLog");

            migrationBuilder.DropForeignKey(
                name: "FK_VideoLog_DescriptionForm_DescriptionId",
                table: "VideoLog");

            migrationBuilder.DropTable(
                name: "DescriptionForm");

            migrationBuilder.DropIndex(
                name: "IX_VideoLog_DescriptionId",
                table: "VideoLog");

            migrationBuilder.DropIndex(
                name: "IX_UserLog_DescriptionId",
                table: "UserLog");

            migrationBuilder.DropIndex(
                name: "IX_Payload_DescriptionId",
                table: "Payload");

            migrationBuilder.DropIndex(
                name: "IX_ObjectObserve_DescriptionId",
                table: "ObjectObserve");

            migrationBuilder.DropIndex(
                name: "IX_IncidentLog_DescriptionId",
                table: "IncidentLog");

            migrationBuilder.DropIndex(
                name: "IX_ImageLog_DescriptionId",
                table: "ImageLog");

            migrationBuilder.DropIndex(
                name: "IX_DroneLogs_DescriptionId",
                table: "DroneLogs");

            migrationBuilder.DropColumn(
                name: "DescriptionId",
                table: "VideoLog");

            migrationBuilder.DropColumn(
                name: "DescriptionId",
                table: "UserLog");

            migrationBuilder.DropColumn(
                name: "DescriptionId",
                table: "Payload");

            migrationBuilder.DropColumn(
                name: "DescriptionId",
                table: "ObjectObserve");

            migrationBuilder.DropColumn(
                name: "DescriptionId",
                table: "IncidentLog");

            migrationBuilder.DropColumn(
                name: "DescriptionId",
                table: "ImageLog");

            migrationBuilder.DropColumn(
                name: "DescriptionId",
                table: "DroneLogs");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "VideoLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "UserLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Payload",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ObjectObserve",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "IncidentLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ImageLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "DroneLogs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "VideoLog");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "UserLog");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Payload");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ObjectObserve");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "IncidentLog");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ImageLog");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "DroneLogs");

            migrationBuilder.AddColumn<int>(
                name: "DescriptionId",
                table: "VideoLog",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DescriptionId",
                table: "UserLog",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DescriptionId",
                table: "Payload",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DescriptionId",
                table: "ObjectObserve",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DescriptionId",
                table: "IncidentLog",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DescriptionId",
                table: "ImageLog",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DescriptionId",
                table: "DroneLogs",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DescriptionForm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DescriptionForm", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VideoLog_DescriptionId",
                table: "VideoLog",
                column: "DescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLog_DescriptionId",
                table: "UserLog",
                column: "DescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Payload_DescriptionId",
                table: "Payload",
                column: "DescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_ObjectObserve_DescriptionId",
                table: "ObjectObserve",
                column: "DescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentLog_DescriptionId",
                table: "IncidentLog",
                column: "DescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageLog_DescriptionId",
                table: "ImageLog",
                column: "DescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_DroneLogs_DescriptionId",
                table: "DroneLogs",
                column: "DescriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_DroneLogs_DescriptionForm_DescriptionId",
                table: "DroneLogs",
                column: "DescriptionId",
                principalTable: "DescriptionForm",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ImageLog_DescriptionForm_DescriptionId",
                table: "ImageLog",
                column: "DescriptionId",
                principalTable: "DescriptionForm",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IncidentLog_DescriptionForm_DescriptionId",
                table: "IncidentLog",
                column: "DescriptionId",
                principalTable: "DescriptionForm",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectObserve_DescriptionForm_DescriptionId",
                table: "ObjectObserve",
                column: "DescriptionId",
                principalTable: "DescriptionForm",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payload_DescriptionForm_DescriptionId",
                table: "Payload",
                column: "DescriptionId",
                principalTable: "DescriptionForm",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserLog_DescriptionForm_DescriptionId",
                table: "UserLog",
                column: "DescriptionId",
                principalTable: "DescriptionForm",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VideoLog_DescriptionForm_DescriptionId",
                table: "VideoLog",
                column: "DescriptionId",
                principalTable: "DescriptionForm",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
