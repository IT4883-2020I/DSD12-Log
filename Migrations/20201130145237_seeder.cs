using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace aspnetcoreapp.Migrations
{
    public partial class seeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WarningLog",
                table: "WarningLog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VideoLog",
                table: "VideoLog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserLog",
                table: "UserLog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UavConnectLog",
                table: "UavConnectLog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StaticalLog",
                table: "StaticalLog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResolveProblemLog",
                table: "ResolveProblemLog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payload",
                table: "Payload");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ObjectObserve",
                table: "ObjectObserve");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MonitorRegionLog",
                table: "MonitorRegionLog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IncidentLog",
                table: "IncidentLog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImageLog",
                table: "ImageLog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DroneLogs",
                table: "DroneLogs");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "WarningLog");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "VideoLog");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserLog");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UavConnectLog");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "StaticalLog");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ResolveProblemLog");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Payload");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ObjectObserve");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MonitorRegionLog");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "IncidentLog");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ImageLog");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "DroneLogs");

            migrationBuilder.AddColumn<int>(
                name: "EntityLogPrimaryKeyId",
                table: "WarningLog",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "EntityLogPrimaryKeyId",
                table: "VideoLog",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "EntityLogPrimaryKeyId",
                table: "UserLog",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "EntityLogPrimaryKeyId",
                table: "UavConnectLog",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "EntityLogPrimaryKeyId",
                table: "StaticalLog",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "EntityLogPrimaryKeyId",
                table: "ResolveProblemLog",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "EntityLogPrimaryKeyId",
                table: "Payload",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "EntityLogPrimaryKeyId",
                table: "ObjectObserve",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "EntityLogPrimaryKeyId",
                table: "MonitorRegionLog",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "EntityLogPrimaryKeyId",
                table: "IncidentLog",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "EntityLogPrimaryKeyId",
                table: "ImageLog",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "EntityLogPrimaryKeyId",
                table: "DroneLogs",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_WarningLog",
                table: "WarningLog",
                column: "EntityLogPrimaryKeyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VideoLog",
                table: "VideoLog",
                column: "EntityLogPrimaryKeyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserLog",
                table: "UserLog",
                column: "EntityLogPrimaryKeyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UavConnectLog",
                table: "UavConnectLog",
                column: "EntityLogPrimaryKeyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StaticalLog",
                table: "StaticalLog",
                column: "EntityLogPrimaryKeyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResolveProblemLog",
                table: "ResolveProblemLog",
                column: "EntityLogPrimaryKeyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payload",
                table: "Payload",
                column: "EntityLogPrimaryKeyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ObjectObserve",
                table: "ObjectObserve",
                column: "EntityLogPrimaryKeyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MonitorRegionLog",
                table: "MonitorRegionLog",
                column: "EntityLogPrimaryKeyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IncidentLog",
                table: "IncidentLog",
                column: "EntityLogPrimaryKeyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImageLog",
                table: "ImageLog",
                column: "EntityLogPrimaryKeyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DroneLogs",
                table: "DroneLogs",
                column: "EntityLogPrimaryKeyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WarningLog",
                table: "WarningLog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VideoLog",
                table: "VideoLog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserLog",
                table: "UserLog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UavConnectLog",
                table: "UavConnectLog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StaticalLog",
                table: "StaticalLog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResolveProblemLog",
                table: "ResolveProblemLog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payload",
                table: "Payload");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ObjectObserve",
                table: "ObjectObserve");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MonitorRegionLog",
                table: "MonitorRegionLog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IncidentLog",
                table: "IncidentLog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImageLog",
                table: "ImageLog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DroneLogs",
                table: "DroneLogs");

            migrationBuilder.DropColumn(
                name: "EntityLogPrimaryKeyId",
                table: "WarningLog");

            migrationBuilder.DropColumn(
                name: "EntityLogPrimaryKeyId",
                table: "VideoLog");

            migrationBuilder.DropColumn(
                name: "EntityLogPrimaryKeyId",
                table: "UserLog");

            migrationBuilder.DropColumn(
                name: "EntityLogPrimaryKeyId",
                table: "UavConnectLog");

            migrationBuilder.DropColumn(
                name: "EntityLogPrimaryKeyId",
                table: "StaticalLog");

            migrationBuilder.DropColumn(
                name: "EntityLogPrimaryKeyId",
                table: "ResolveProblemLog");

            migrationBuilder.DropColumn(
                name: "EntityLogPrimaryKeyId",
                table: "Payload");

            migrationBuilder.DropColumn(
                name: "EntityLogPrimaryKeyId",
                table: "ObjectObserve");

            migrationBuilder.DropColumn(
                name: "EntityLogPrimaryKeyId",
                table: "MonitorRegionLog");

            migrationBuilder.DropColumn(
                name: "EntityLogPrimaryKeyId",
                table: "IncidentLog");

            migrationBuilder.DropColumn(
                name: "EntityLogPrimaryKeyId",
                table: "ImageLog");

            migrationBuilder.DropColumn(
                name: "EntityLogPrimaryKeyId",
                table: "DroneLogs");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "WarningLog",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "VideoLog",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "UserLog",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "UavConnectLog",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "StaticalLog",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ResolveProblemLog",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Payload",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ObjectObserve",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "MonitorRegionLog",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "IncidentLog",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ImageLog",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "DroneLogs",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_WarningLog",
                table: "WarningLog",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VideoLog",
                table: "VideoLog",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserLog",
                table: "UserLog",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UavConnectLog",
                table: "UavConnectLog",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StaticalLog",
                table: "StaticalLog",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResolveProblemLog",
                table: "ResolveProblemLog",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payload",
                table: "Payload",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ObjectObserve",
                table: "ObjectObserve",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MonitorRegionLog",
                table: "MonitorRegionLog",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IncidentLog",
                table: "IncidentLog",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImageLog",
                table: "ImageLog",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DroneLogs",
                table: "DroneLogs",
                column: "Id");
        }
    }
}
