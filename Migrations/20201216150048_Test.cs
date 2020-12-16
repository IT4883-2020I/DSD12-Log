using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace aspnetcoreapp.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DroneLogs",
                columns: table => new
                {
                    EntityLogPrimaryKeyId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    EntityId = table.Column<string>(type: "varchar(255)", nullable: true),
                    AuthorId = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    RegionName = table.Column<string>(nullable: true),
                    Longitude = table.Column<int>(nullable: false),
                    Latitude = table.Column<int>(nullable: false),
                    RegionId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DroneLogs", x => x.EntityLogPrimaryKeyId);
                });

            migrationBuilder.CreateTable(
                name: "ImageLogs",
                columns: table => new
                {
                    EntityLogPrimaryKeyId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    EntityId = table.Column<string>(type: "varchar(255)", nullable: true),
                    AuthorId = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Link = table.Column<string>(nullable: true),
                    DroneId = table.Column<string>(nullable: true),
                    IncidentId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageLogs", x => x.EntityLogPrimaryKeyId);
                });

            migrationBuilder.CreateTable(
                name: "IncidentLogs",
                columns: table => new
                {
                    EntityLogPrimaryKeyId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    EntityId = table.Column<string>(type: "varchar(255)", nullable: true),
                    AuthorId = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    RegionId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncidentLogs", x => x.EntityLogPrimaryKeyId);
                });

            migrationBuilder.CreateTable(
                name: "MonitorRegionLogs",
                columns: table => new
                {
                    EntityLogPrimaryKeyId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    EntityId = table.Column<string>(type: "varchar(255)", nullable: true),
                    AuthorId = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonitorRegionLogs", x => x.EntityLogPrimaryKeyId);
                });

            migrationBuilder.CreateTable(
                name: "ObjectObserves",
                columns: table => new
                {
                    EntityLogPrimaryKeyId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    EntityId = table.Column<string>(type: "varchar(255)", nullable: true),
                    AuthorId = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    RegionId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjectObserves", x => x.EntityLogPrimaryKeyId);
                });

            migrationBuilder.CreateTable(
                name: "Payloads",
                columns: table => new
                {
                    EntityLogPrimaryKeyId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    EntityId = table.Column<string>(type: "varchar(255)", nullable: true),
                    AuthorId = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    DroneId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payloads", x => x.EntityLogPrimaryKeyId);
                });

            migrationBuilder.CreateTable(
                name: "ResolveProblemLogs",
                columns: table => new
                {
                    EntityLogPrimaryKeyId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    EntityId = table.Column<string>(type: "varchar(255)", nullable: true),
                    AuthorId = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    RegionId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResolveProblemLogs", x => x.EntityLogPrimaryKeyId);
                });

            migrationBuilder.CreateTable(
                name: "StaticalLogs",
                columns: table => new
                {
                    EntityLogPrimaryKeyId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    EntityId = table.Column<string>(type: "varchar(255)", nullable: true),
                    AuthorId = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    RegionId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaticalLogs", x => x.EntityLogPrimaryKeyId);
                });

            migrationBuilder.CreateTable(
                name: "SystemLogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    Level = table.Column<int>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    WorkName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UavConnectLogs",
                columns: table => new
                {
                    EntityLogPrimaryKeyId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    EntityId = table.Column<string>(type: "varchar(255)", nullable: true),
                    AuthorId = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    DroneId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UavConnectLogs", x => x.EntityLogPrimaryKeyId);
                });

            migrationBuilder.CreateTable(
                name: "UserLog",
                columns: table => new
                {
                    EntityLogPrimaryKeyId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    EntityId = table.Column<string>(type: "varchar(255)", nullable: true),
                    AuthorId = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    Metadata = table.Column<string>(nullable: true),
                    RegionId = table.Column<string>(nullable: true),
                    IncidentId = table.Column<string>(nullable: true),
                    ResolveProblemId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLog", x => x.EntityLogPrimaryKeyId);
                });

            migrationBuilder.CreateTable(
                name: "VideoLogs",
                columns: table => new
                {
                    EntityLogPrimaryKeyId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    EntityId = table.Column<string>(type: "varchar(255)", nullable: true),
                    AuthorId = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    DroneId = table.Column<string>(nullable: true),
                    Link = table.Column<string>(nullable: true),
                    IncidentId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoLogs", x => x.EntityLogPrimaryKeyId);
                });

            migrationBuilder.CreateTable(
                name: "WarningLogs",
                columns: table => new
                {
                    EntityLogPrimaryKeyId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    EntityId = table.Column<string>(type: "varchar(255)", nullable: true),
                    AuthorId = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    RegionId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarningLogs", x => x.EntityLogPrimaryKeyId);
                });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 1, "7", "Drone Activity Log", "2", 26, 23, "Drone 2", "CHAY_RUNG", "4", "MonitorRegion 1", new DateTime(2020, 12, 1, 1, 21, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, "6", "Drone Edit", "3", 14, 10, "Drone 9", "CHAY_RUNG", "3", "MonitorRegion 1", new DateTime(2020, 12, 1, 12, 16, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, "8", "Drone Activity Log", "5", 31, 36, "Drone 7", "CHAY_RUNG", "2", "MonitorRegion 3", new DateTime(2020, 12, 2, 14, 12, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, "7", "Drone Activity Log", "7", 22, 14, "Drone 10", "DE_DIEU", "2", "MonitorRegion 1", new DateTime(2020, 12, 1, 14, 29, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, "2", "Drone Edit", "1", 30, 34, "Drone 2", "CHAY_RUNG", "1", "MonitorRegion 1", new DateTime(2020, 12, 2, 12, 47, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "5", "Drone Edit", "1", 30, 13, "Drone 2", "CHAY_RUNG", "1", "MonitorRegion 4", new DateTime(2020, 12, 2, 11, 9, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 28, "10", "Drone Activity Log", "4", 24, 18, "Drone 1", "CAY_TRONG", "2", "MonitorRegion 1", new DateTime(2020, 12, 1, 11, 17, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 29, "7", "Drone Add", "7", 24, 42, "Drone 6", "CHAY_RUNG", "3", "MonitorRegion 3", new DateTime(2020, 12, 1, 10, 41, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 31, "1", "Drone Add", "10", 29, 41, "Drone 6", "CHAY_RUNG", "2", "MonitorRegion 2", new DateTime(2020, 12, 1, 8, 25, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, "10", "Drone Delete", "10", 10, 29, "Drone 8", "CAY_TRONG", "3", "MonitorRegion 2", new DateTime(2020, 12, 2, 3, 8, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "3", "Drone Activity Log", "3", 15, 46, "Drone 2", "CHAY_RUNG", "2", "MonitorRegion 1", new DateTime(2020, 12, 2, 10, 16, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 34, "8", "Drone Edit", "6", 42, 40, "Drone 4", "CAY_TRONG", "2", "MonitorRegion 2", new DateTime(2020, 12, 1, 5, 21, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "1", "Drone Add", "3", 22, 15, "Drone 2", "DE_DIEU", "4", "MonitorRegion 3", new DateTime(2020, 12, 1, 5, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, "9", "Drone Activity Log", "8", 46, 12, "Drone 6", "CAY_TRONG", "2", "MonitorRegion 1", new DateTime(2020, 12, 1, 17, 8, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 37, "7", "Drone Add", "7", 25, 19, "Drone 6", "CHAY_RUNG", "4", "MonitorRegion 2", new DateTime(2020, 12, 2, 17, 8, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 38, "5", "Drone Edit", "8", 40, 42, "Drone 4", "LUOI_DIEN", "4", "MonitorRegion 4", new DateTime(2020, 12, 1, 8, 27, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 39, "3", "Drone Activity Log", "2", 32, 18, "Drone 3", "LUOI_DIEN", "1", "MonitorRegion 2", new DateTime(2020, 12, 1, 12, 12, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 40, "7", "Drone Activity Log", "2", 18, 19, "Drone 8", "DE_DIEU", "1", "MonitorRegion 4", new DateTime(2020, 12, 1, 15, 31, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 22, "2", "Drone Activity Log", "7", 28, 34, "Drone 4", "DE_DIEU", "3", "MonitorRegion 3", new DateTime(2020, 12, 1, 14, 31, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 21, "5", "Drone Activity Log", "10", 25, 43, "Drone 9", "LUOI_DIEN", "3", "MonitorRegion 3", new DateTime(2020, 12, 2, 12, 27, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 30, "2", "Drone Delete", "9", 29, 33, "Drone 9", "CAY_TRONG", "3", "MonitorRegion 3", new DateTime(2020, 12, 2, 7, 7, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "10", "Drone Activity Log", "7", 45, 28, "Drone 7", "CHAY_RUNG", "2", "MonitorRegion 2", new DateTime(2020, 12, 2, 14, 34, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 20, "9", "Drone Delete", "1", 35, 12, "Drone 1", "CHAY_RUNG", "1", "MonitorRegion 4", new DateTime(2020, 12, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 2, "3", "Drone Delete", "5", 17, 27, "Drone 9", "CHAY_RUNG", "2", "MonitorRegion 3", new DateTime(2020, 12, 1, 15, 45, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 3, "9", "Drone Delete", "5", 23, 11, "Drone 9", "DE_DIEU", "1", "MonitorRegion 3", new DateTime(2020, 12, 1, 13, 18, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, "4", "Drone Add", "4", 46, 24, "Drone 2", "DE_DIEU", "3", "MonitorRegion 1", new DateTime(2020, 12, 1, 7, 39, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 5, "10", "Drone Edit", "5", 11, 30, "Drone 10", "LUOI_DIEN", "2", "MonitorRegion 3", new DateTime(2020, 12, 1, 12, 42, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 6, "4", "Drone Edit", "2", 46, 32, "Drone 5", "CHAY_RUNG", "3", "MonitorRegion 3", new DateTime(2020, 12, 2, 9, 13, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 8, "8", "Drone Delete", "5", 26, 21, "Drone 5", "LUOI_DIEN", "3", "MonitorRegion 3", new DateTime(2020, 12, 2, 8, 10, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 9, "10", "Drone Add", "7", 41, 39, "Drone 5", "CAY_TRONG", "2", "MonitorRegion 4", new DateTime(2020, 12, 1, 6, 38, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "8", "Drone Edit", "7", 12, 38, "Drone 1", "LUOI_DIEN", "3", "MonitorRegion 4", new DateTime(2020, 12, 1, 16, 7, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 7, "3", "Drone Add", "2", 33, 32, "Drone 6", "DE_DIEU", "4", "MonitorRegion 4", new DateTime(2020, 12, 2, 9, 23, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 18, "10", "Drone Edit", "2", 46, 14, "Drone 10", "CAY_TRONG", "3", "MonitorRegion 2", new DateTime(2020, 12, 1, 10, 1, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "6", "Drone Edit", "10", 22, 43, "Drone 9", "CHAY_RUNG", "1", "MonitorRegion 1", new DateTime(2020, 12, 1, 17, 42, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "4", "Drone Delete", "9", 18, 29, "Drone 3", "LUOI_DIEN", "4", "MonitorRegion 2", new DateTime(2020, 12, 2, 12, 38, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 14, "5", "Drone Delete", "10", 32, 38, "Drone 6", "LUOI_DIEN", "3", "MonitorRegion 4", new DateTime(2020, 12, 1, 11, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 15, "1", "Drone Add", "3", 28, 10, "Drone 6", "CAY_TRONG", "4", "MonitorRegion 3", new DateTime(2020, 12, 2, 3, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "4", "Drone Activity Log", "2", 12, 27, "Drone 8", "CHAY_RUNG", "2", "MonitorRegion 3", new DateTime(2020, 12, 1, 8, 21, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, "2", "Drone Edit", "2", 21, 26, "Drone 6", "CAY_TRONG", "3", "MonitorRegion 1", new DateTime(2020, 12, 2, 10, 11, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, "9", "Drone Edit", "1", 18, 38, "Drone 4", "LUOI_DIEN", "1", "MonitorRegion 2", new DateTime(2020, 12, 1, 3, 40, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 38, "9", "Image Delete", "5", "15", "5", "Image ZU", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 9, 49, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 37, "3", "Image Delete", "2", "34", "7", "Image EX", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 1, 34, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 36, "5", "Image Delete", "8", "28", "10", "Image ZV", "DE_DIEU", "0", new DateTime(2020, 12, 1, 5, 36, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 32, "8", "Image Add", "8", "23", "13", "Image AZ", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 17, 47, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 34, "3", "Image Delete", "2", "37", "2", "Image OE", "DE_DIEU", "0", new DateTime(2020, 12, 1, 6, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "6", "Image Delete", "6", "18", "11", "Image ZV", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 16, 3, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 39, "1", "Image Activity Log", "8", "29", "4", "Image PF", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 11, 27, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 35, "5", "Image Activity Log", "8", "8", "13", "Image FZ", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 1, 49, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 40, "4", "Image Delete", "5", "24", "1", "Image KX", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 11, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 49, "8", "Image Delete", "7", "40", "8", "Image WI", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 11, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 42, "6", "Image Edit", "1", "18", "12", "Image DD", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 16, 33, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 43, "8", "Image Activity Log", "1", "22", "6", "Image TO", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 4, 15, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 44, "9", "Image Delete", "1", "2", "10", "Image RD", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 5, 24, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 45, "7", "Image Activity Log", "10", "7", "9", "Image GQ", "DE_DIEU", "1", new DateTime(2020, 12, 2, 9, 44, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 46, "10", "Image Activity Log", "4", "6", "2", "Image GZ", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 3, 36, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 47, "2", "Image Edit", "2", "37", "6", "Image NY", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 6, 49, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 48, "7", "Image Add", "7", "5", "10", "Image KM", "DE_DIEU", "0", new DateTime(2020, 12, 1, 14, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 31, "7", "Image Delete", "9", "18", "9", "Image HK", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 16, 43, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, "3", "Image Delete", "5", "2", "5", "Image ZX", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 12, 16, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 30, "7", "Image Edit", "1", "18", "11", "Image RE", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 1, 28, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 19, "5", "Image Delete", "10", "35", "2", "Image AF", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 2, 24, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "3", "Image Add", "8", "30", "2", "Image FP", "DE_DIEU", "0", new DateTime(2020, 12, 1, 13, 49, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "4", "Image Activity Log", "4", "16", "4", "Image XX", "DE_DIEU", "1", new DateTime(2020, 12, 2, 5, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 11, "1", "Image Edit", "9", "29", "7", "Image IL", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 14, 3, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "4", "Image Activity Log", "4", "40", "7", "Image FO", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 12, 32, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 13, "6", "Image Activity Log", "1", "23", "13", "Image KY", "DE_DIEU", "1", new DateTime(2020, 12, 2, 2, 13, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 14, "5", "Image Activity Log", "9", "23", "7", "Image JM", "DE_DIEU", "0", new DateTime(2020, 12, 2, 5, 18, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 15, "6", "Image Delete", "8", "14", "5", "Image RQ", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 8, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "10", "Image Add", "1", "31", "6", "Image SU", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 8, 14, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, "6", "Image Edit", "1", "40", "6", "Image KV", "DE_DIEU", "1", new DateTime(2020, 12, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 18, "2", "Image Activity Log", "1", "28", "4", "Image KT", "DE_DIEU", "0", new DateTime(2020, 12, 2, 1, 33, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 10, "8", "Image Activity Log", "8", "15", "6", "Image AV", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 10, 4, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 20, "4", "Image Edit", "10", "38", "14", "Image AX", "DE_DIEU", "0", new DateTime(2020, 12, 1, 4, 3, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 21, "1", "Image Activity Log", "10", "11", "1", "Image KC", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 6, 45, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 22, "5", "Image Delete", "1", "30", "7", "Image VH", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 7, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 23, "7", "Image Edit", "2", "25", "8", "Image OW", "DE_DIEU", "1", new DateTime(2020, 12, 1, 7, 21, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, "9", "Image Delete", "3", "8", "6", "Image LJ", "DE_DIEU", "0", new DateTime(2020, 12, 1, 10, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 25, "10", "Image Activity Log", "5", "11", "2", "Image OK", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 5, 2, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, "3", "Image Add", "1", "5", "9", "Image CT", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 8, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, "8", "Image Edit", "5", "20", "2", "Image FB", "DE_DIEU", "1", new DateTime(2020, 12, 2, 4, 45, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 32, "8", "Incident Add", "9", "Incident HP", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 2, 15, 48, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 33, "10", "Incident Activity Log", "5", "Incident IY", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 2, 2, 17, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 34, "3", "Incident Activity Log", "5", "Incident GN", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 15, 37, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 35, "8", "Incident Add", "10", "Incident YA", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 1, 6, 3, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, "3", "Incident Activity Log", "13", "Incident LZ", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 1, 11, 12, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 37, "5", "Incident Delete", "4", "Incident QY", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 2, 8, 13, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 38, "6", "Incident Activity Log", "10", "Incident CW", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 1, 6, 6, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 40, "5", "Incident Edit", "14", "Incident FL", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 2, 17, 36, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "6", "Incident Add", "11", "Incident IL", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 10, 24, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 42, "10", "Incident Activity Log", "2", "Incident JC", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 1, 13, 4, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 43, "4", "Incident Edit", "10", "Incident EA", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 2, 17, 28, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "8", "Incident Delete", "5", "Incident DO", "DE_DIEU", "3", "1", new DateTime(2020, 12, 2, 10, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 45, "8", "Incident Add", "11", "Incident LF", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 2, 12, 39, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "2", "Incident Edit", "10", "Incident ED", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 1, 4, 14, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 47, "3", "Incident Edit", "6", "Incident XZ", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 2, 11, 27, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 48, "8", "Incident Add", "6", "Incident LS", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 1, 7, 26, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, "2", "Incident Delete", "12", "Incident PA", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 2, 8, 13, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, "10", "Incident Delete", "10", "Incident QW", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 2, 7, 37, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 30, "8", "Incident Activity Log", "7", "Incident II", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 1, 17, 48, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 39, "2", "Incident Activity Log", "12", "Incident DK", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 1, 8, 29, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 28, "5", "Incident Add", "1", "Incident BP", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 2, 11, 29, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "4", "Incident Add", "11", "Incident ND", "DE_DIEU", "2", "1", new DateTime(2020, 12, 2, 16, 45, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, "7", "Incident Add", "3", "Incident AK", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 2, 14, 8, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, "8", "Incident Edit", "12", "Incident XC", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 2, 3, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, "6", "Incident Edit", "5", "Incident BD", "DE_DIEU", "3", "0", new DateTime(2020, 12, 2, 3, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 15, "1", "Incident Delete", "2", "Incident VI", "DE_DIEU", "2", "1", new DateTime(2020, 12, 2, 4, 17, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "5", "Incident Activity Log", "1", "Incident TF", "DE_DIEU", "3", "0", new DateTime(2020, 12, 1, 9, 30, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, "7", "Incident Activity Log", "13", "Incident GB", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 2, 12, 20, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "10", "Incident Edit", "13", "Incident HF", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 1, 11, 39, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 19, "6", "Incident Activity Log", "9", "Incident SY", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 2, 15, 18, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 10, "9", "Incident Activity Log", "6", "Incident VV", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 5, 7, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 20, "6", "Incident Delete", "14", "Incident IB", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 1, 13, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "7", "Incident Delete", "2", "Incident LH", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 1, 4, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, "2", "Incident Activity Log", "2", "Incident WL", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 2, 15, 8, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, "6", "Incident Edit", "7", "Incident FF", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 13, 10, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, "6", "Incident Activity Log", "2", "Incident FG", "DE_DIEU", "4", "0", new DateTime(2020, 12, 2, 11, 14, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, "9", "Incident Add", "8", "Incident IT", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 7, 4, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 26, "10", "Incident Add", "5", "Incident TB", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 1, 10, 49, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, "10", "Incident Delete", "6", "Incident LG", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 2, 11, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, "3", "Incident Edit", "14", "Incident LF", "DE_DIEU", "3", "1", new DateTime(2020, 12, 2, 3, 15, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 28, "9", "MonitorRegion Edit", "2", "MonitorRegion 2", "DE_DIEU", "1", new DateTime(2020, 12, 1, 1, 43, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "8", "MonitorRegion Delete", "3", "MonitorRegion 3", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 3, 33, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 23, "2", "MonitorRegion Delete", "3", "MonitorRegion 3", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 10, 24, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 25, "5", "MonitorRegion Add", "1", "MonitorRegion 1", "DE_DIEU", "0", new DateTime(2020, 12, 2, 13, 19, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, "9", "MonitorRegion Edit", "2", "MonitorRegion 2", "DE_DIEU", "1", new DateTime(2020, 12, 2, 12, 48, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 29, "1", "MonitorRegion Delete", "2", "MonitorRegion 2", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 4, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "1", "MonitorRegion Delete", "2", "MonitorRegion 2", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 6, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 30, "7", "MonitorRegion Delete", "3", "MonitorRegion 3", "DE_DIEU", "1", new DateTime(2020, 12, 2, 8, 9, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 35, "9", "MonitorRegion Edit", "1", "MonitorRegion 1", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 3, 19, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 32, "2", "MonitorRegion Delete", "2", "MonitorRegion 2", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 17, 41, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "10", "MonitorRegion Edit", "3", "MonitorRegion 3", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 13, 1, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "9", "MonitorRegion Edit", "4", "MonitorRegion 4", "DE_DIEU", "1", new DateTime(2020, 12, 2, 3, 9, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 36, "3", "MonitorRegion Delete", "2", "MonitorRegion 2", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 7, 37, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 37, "4", "MonitorRegion Edit", "4", "MonitorRegion 4", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 12, 9, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 38, "6", "MonitorRegion Activity Log", "2", "MonitorRegion 2", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 11, 1, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 39, "9", "MonitorRegion Activity Log", "4", "MonitorRegion 4", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 9, 49, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 22, "8", "MonitorRegion Delete", "4", "MonitorRegion 4", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 8, 38, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, "4", "MonitorRegion Add", "2", "MonitorRegion 2", "DE_DIEU", "0", new DateTime(2020, 12, 2, 8, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, "4", "MonitorRegion Edit", "2", "MonitorRegion 2", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 1, 34, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 40, "4", "MonitorRegion Edit", "2", "MonitorRegion 2", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 4, 12, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 19, "9", "MonitorRegion Edit", "1", "MonitorRegion 1", "DE_DIEU", "0", new DateTime(2020, 12, 2, 9, 44, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 1, "3", "MonitorRegion Activity Log", "3", "MonitorRegion 3", "DE_DIEU", "0", new DateTime(2020, 12, 2, 13, 49, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 2, "2", "MonitorRegion Activity Log", "2", "MonitorRegion 2", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 5, 11, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 3, "5", "MonitorRegion Delete", "2", "MonitorRegion 2", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 10, 2, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, "10", "MonitorRegion Delete", "1", "MonitorRegion 1", "DE_DIEU", "1", new DateTime(2020, 12, 2, 6, 9, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 5, "2", "MonitorRegion Edit", "2", "MonitorRegion 2", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 3, 24, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 6, "1", "MonitorRegion Activity Log", "1", "MonitorRegion 1", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 14, 6, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 7, "10", "MonitorRegion Delete", "3", "MonitorRegion 3", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 4, 22, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 8, "9", "MonitorRegion Add", "2", "MonitorRegion 2", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 15, 47, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 9, "2", "MonitorRegion Edit", "4", "MonitorRegion 4", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 8, 14, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, "3", "MonitorRegion Activity Log", "2", "MonitorRegion 2", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 3, 43, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 11, "3", "MonitorRegion Delete", "1", "MonitorRegion 1", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 10, 10, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, "2", "MonitorRegion Activity Log", "4", "MonitorRegion 4", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 12, 29, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 13, "7", "MonitorRegion Add", "1", "MonitorRegion 1", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 15, 25, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, "5", "MonitorRegion Activity Log", "4", "MonitorRegion 4", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 15, 10, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 15, "1", "MonitorRegion Activity Log", "1", "MonitorRegion 1", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 9, 27, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 16, "5", "MonitorRegion Add", "4", "MonitorRegion 4", "DE_DIEU", "1", new DateTime(2020, 12, 1, 13, 41, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, "1", "MonitorRegion Activity Log", "3", "MonitorRegion 3", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 1, 36, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "5", "MonitorRegion Delete", "4", "MonitorRegion 4", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 9, 16, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, "4", "MonitorRegion Delete", "3", "MonitorRegion 3", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 16, 39, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "6", "ObjectObserve Edit", "16", "ObjectObserve UU", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 2, 17, 28, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 36, "2", "ObjectObserve Activity Log", "13", "ObjectObserve TN", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 1, 15, 22, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 35, "8", "ObjectObserve Activity Log", "7", "ObjectObserve BC", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 1, 5, 29, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 31, "6", "ObjectObserve Delete", "15", "ObjectObserve NP", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 1, 3, 25, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "3", "ObjectObserve Delete", "19", "ObjectObserve CI", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 6, 38, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 32, "4", "ObjectObserve Activity Log", "9", "ObjectObserve WD", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 1, 11, 42, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 38, "8", "ObjectObserve Add", "3", "ObjectObserve TR", "DE_DIEU", "2", "0", new DateTime(2020, 12, 2, 14, 30, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 34, "4", "ObjectObserve Add", "7", "ObjectObserve FD", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 1, 4, 29, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 39, "7", "ObjectObserve Activity Log", "18", "ObjectObserve SA", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 1, 13, 42, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 43, "4", "ObjectObserve Delete", "9", "ObjectObserve ST", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 1, 12, 42, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, "8", "ObjectObserve Add", "1", "ObjectObserve NO", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 1, 7, 45, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 42, "3", "ObjectObserve Add", "3", "ObjectObserve FN", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 2, 14, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 44, "10", "ObjectObserve Edit", "13", "ObjectObserve JE", "DE_DIEU", "1", "0", new DateTime(2020, 12, 1, 13, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 45, "5", "ObjectObserve Activity Log", "18", "ObjectObserve FR", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 1, 7, 12, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 46, "4", "ObjectObserve Edit", "15", "ObjectObserve MY", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 1, 2, 26, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 47, "1", "ObjectObserve Add", "14", "ObjectObserve GD", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 2, 1, 15, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, "7", "ObjectObserve Edit", "4", "ObjectObserve GH", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 1, 15, 5, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "7", "ObjectObserve Activity Log", "4", "ObjectObserve BO", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 1, 1, 7, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 40, "2", "ObjectObserve Activity Log", "1", "ObjectObserve SC", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 1, 9, 31, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 49, "6", "ObjectObserve Activity Log", "3", "ObjectObserve IT", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 5, 20, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 29, "4", "ObjectObserve Add", "17", "ObjectObserve WA", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 1, 3, 38, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, "3", "ObjectObserve Delete", "11", "ObjectObserve WW", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 8, 30, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "3", "ObjectObserve Delete", "16", "ObjectObserve AD", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 1, 14, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, "1", "ObjectObserve Edit", "7", "ObjectObserve FD", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 1, 13, 43, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, "1", "ObjectObserve Add", "13", "ObjectObserve EC", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 12, 12, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, "1", "ObjectObserve Edit", "11", "ObjectObserve QP", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 2, 11, 18, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "10", "ObjectObserve Edit", "6", "ObjectObserve DO", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 1, 10, 10, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 15, "6", "ObjectObserve Activity Log", "4", "ObjectObserve HI", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 10, 20, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 16, "7", "ObjectObserve Edit", "16", "ObjectObserve TR", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 1, 10, 9, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "4", "ObjectObserve Edit", "7", "ObjectObserve CZ", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 1, 8, 19, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, "3", "ObjectObserve Activity Log", "10", "ObjectObserve DH", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 2, 9, 40, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, "3", "ObjectObserve Delete", "3", "ObjectObserve BF", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 9, 7, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, "9", "ObjectObserve Delete", "10", "ObjectObserve DI", "DE_DIEU", "2", "0", new DateTime(2020, 12, 2, 16, 38, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 25, "9", "ObjectObserve Edit", "8", "ObjectObserve QT", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 2, 9, 9, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, "8", "ObjectObserve Edit", "18", "ObjectObserve AB", "DE_DIEU", "2", "0", new DateTime(2020, 12, 1, 15, 48, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "7", "ObjectObserve Delete", "9", "ObjectObserve PV", "DE_DIEU", "2", "1", new DateTime(2020, 12, 2, 17, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "10", "ObjectObserve Edit", "11", "ObjectObserve GD", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 2, 17, 9, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 21, "5", "ObjectObserve Add", "20", "ObjectObserve AY", "DE_DIEU", "2", "1", new DateTime(2020, 12, 1, 11, 31, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, "6", "ObjectObserve Add", "5", "ObjectObserve NT", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 1, 1, 5, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "1", "ObjectObserve Activity Log", "1", "ObjectObserve ZD", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 2, 14, 12, 0, 0, DateTimeKind.Unspecified), 20 }
                });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 38, "10", "Payload Add", "8", "1", "Payload WT", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 14, 25, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, "6", "Payload Edit", "10", "7", "Payload LE", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 6, 27, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 33, "4", "Payload Add", "7", "2", "Payload ZS", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 4, 27, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 34, "4", "Payload Edit", "1", "1", "Payload EQ", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 13, 25, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "2", "Payload Activity Log", "5", "1", "Payload QO", "DE_DIEU", "1", new DateTime(2020, 12, 2, 8, 34, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, "7", "Payload Edit", "8", "3", "Payload PP", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 17, 11, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 37, "2", "Payload Add", "1", "5", "Payload GJ", "DE_DIEU", "1", new DateTime(2020, 12, 1, 2, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 39, "2", "Payload Edit", "2", "3", "Payload PN", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 11, 45, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "3", "Payload Activity Log", "1", "3", "Payload WQ", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 8, 14, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 41, "2", "Payload Edit", "5", "3", "Payload QU", "DE_DIEU", "1", new DateTime(2020, 12, 1, 10, 8, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 42, "9", "Payload Delete", "10", "1", "Payload RT", "DE_DIEU", "0", new DateTime(2020, 12, 2, 9, 48, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 43, "8", "Payload Delete", "1", "6", "Payload DF", "DE_DIEU", "1", new DateTime(2020, 12, 2, 8, 13, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 44, "6", "Payload Edit", "9", "10", "Payload PD", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 3, 1, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 45, "2", "Payload Delete", "3", "10", "Payload CB", "DE_DIEU", "1", new DateTime(2020, 12, 2, 3, 45, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 46, "9", "Payload Delete", "3", "3", "Payload TT", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 13, 2, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 47, "4", "Payload Delete", "9", "3", "Payload UO", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 17, 18, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 48, "8", "Payload Delete", "6", "2", "Payload KG", "DE_DIEU", "0", new DateTime(2020, 12, 2, 4, 4, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, "5", "Payload Activity Log", "7", "1", "Payload NV", "DE_DIEU", "0", new DateTime(2020, 12, 2, 11, 29, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 30, "5", "Payload Edit", "6", "3", "Payload MV", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 3, 12, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 49, "6", "Payload Delete", "3", "9", "Payload UZ", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 3, 31, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "1", "Payload Edit", "5", "7", "Payload JY", "DE_DIEU", "0", new DateTime(2020, 12, 1, 9, 45, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, "7", "Payload Edit", "9", "5", "Payload CZ", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 1, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, "6", "Payload Edit", "9", "7", "Payload JO", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 1, 24, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "9", "Payload Delete", "8", "6", "Payload HI", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 3, 49, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, "5", "Payload Edit", "10", "2", "Payload OK", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 7, 21, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, "10", "Payload Edit", "3", "10", "Payload BU", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 16, 49, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 15, "2", "Payload Activity Log", "9", "7", "Payload SI", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 9, 6, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 16, "10", "Payload Delete", "5", "8", "Payload YD", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 14, 18, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 17, "9", "Payload Delete", "4", "10", "Payload EO", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 2, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, "9", "Payload Delete", "3", "1", "Payload HX", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 14, 7, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, "5", "Payload Delete", "6", "8", "Payload DC", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 7, 10, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 20, "9", "Payload Edit", "10", "5", "Payload YR", "DE_DIEU", "0", new DateTime(2020, 12, 2, 3, 44, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 21, "10", "Payload Add", "1", "6", "Payload WS", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 7, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "7", "Payload Activity Log", "8", "5", "Payload ZQ", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 16, 24, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, "9", "Payload Delete", "10", "5", "Payload HH", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 6, 37, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, "10", "Payload Edit", "1", "6", "Payload QX", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 7, 39, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 25, "2", "Payload Activity Log", "4", "9", "Payload RS", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 11, 49, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, "8", "Payload Edit", "5", "2", "Payload CE", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 4, 7, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "4", "Payload Activity Log", "1", "3", "Payload FY", "DE_DIEU", "1", new DateTime(2020, 12, 2, 11, 14, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, "3", "Payload Activity Log", "8", "9", "Payload MJ", "DE_DIEU", "1", new DateTime(2020, 12, 1, 16, 24, 0, 0, DateTimeKind.Unspecified), 20 }
                });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "10", "ResolveProblem Add", "10", "ResolveProblem VH", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 2, 4, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, "6", "ResolveProblem Activity Log", "1", "ResolveProblem XW", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 2, 11, 2, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 32, "8", "ResolveProblem Activity Log", "7", "ResolveProblem ZO", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 1, 14, 8, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 34, "5", "ResolveProblem Delete", "6", "ResolveProblem EQ", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 1, 15, 3, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "7", "ResolveProblem Delete", "3", "ResolveProblem XQ", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 6, 36, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 38, "3", "ResolveProblem Edit", "14", "ResolveProblem VR", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 1, 5, 28, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "10", "ResolveProblem Delete", "9", "ResolveProblem LY", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 1, 16, 27, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 39, "2", "ResolveProblem Add", "7", "ResolveProblem AP", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 2, 16, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 44, "1", "ResolveProblem Edit", "1", "ResolveProblem DC", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 1, 8, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 41, "8", "ResolveProblem Add", "11", "ResolveProblem FI", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 1, 29, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 42, "3", "ResolveProblem Activity Log", "6", "ResolveProblem EB", "DE_DIEU", "1", "0", new DateTime(2020, 12, 1, 13, 42, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 43, "5", "ResolveProblem Add", "3", "ResolveProblem OE", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 17, 15, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, "8", "ResolveProblem Add", "3", "ResolveProblem MJ", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 1, 17, 23, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "7", "ResolveProblem Activity Log", "13", "ResolveProblem SX", "DE_DIEU", "3", "0", new DateTime(2020, 12, 2, 8, 34, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 47, "3", "ResolveProblem Add", "9", "ResolveProblem SZ", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 1, 12, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, "8", "ResolveProblem Delete", "8", "ResolveProblem SM", "DE_DIEU", "1", "0", new DateTime(2020, 12, 1, 4, 47, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, "4", "ResolveProblem Add", "10", "ResolveProblem WA", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 2, 4, 28, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, "2", "ResolveProblem Delete", "7", "ResolveProblem DD", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 6, 22, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 30, "10", "ResolveProblem Activity Log", "7", "ResolveProblem IC", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 2, 3, 49, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 49, "9", "ResolveProblem Activity Log", "12", "ResolveProblem HA", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 6, 46, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 28, "9", "ResolveProblem Add", "3", "ResolveProblem ID", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 2, 10, 28, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "3", "ResolveProblem Activity Log", "11", "ResolveProblem ZR", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 2, 3, 13, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 11, "8", "ResolveProblem Delete", "4", "ResolveProblem FD", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 1, 8, 8, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, "6", "ResolveProblem Edit", "3", "ResolveProblem JM", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 7, 35, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "7", "ResolveProblem Delete", "8", "ResolveProblem FN", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 8, 34, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 14, "9", "ResolveProblem Add", "10", "ResolveProblem LZ", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 1, 8, 21, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "7", "ResolveProblem Edit", "7", "ResolveProblem RT", "DE_DIEU", "2", "1", new DateTime(2020, 12, 2, 2, 36, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 16, "5", "ResolveProblem Add", "13", "ResolveProblem HK", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 2, 14, 19, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, "3", "ResolveProblem Edit", "2", "ResolveProblem VC", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 1, 11, 47, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 18, "8", "ResolveProblem Delete", "5", "ResolveProblem AH", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 1, 3, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, "3", "ResolveProblem Edit", "14", "ResolveProblem XF", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 17, 16, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, "4", "ResolveProblem Edit", "8", "ResolveProblem FO", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 1, 16, 11, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 21, "7", "ResolveProblem Add", "6", "ResolveProblem XN", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 2, 5, 39, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "6", "ResolveProblem Edit", "9", "ResolveProblem AK", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 2, 7, 33, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "7", "ResolveProblem Add", "8", "ResolveProblem QA", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 13, 6, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, "9", "ResolveProblem Add", "14", "ResolveProblem XF", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 1, 2, 15, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "1", "ResolveProblem Edit", "13", "ResolveProblem DC", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 1, 2, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, "3", "ResolveProblem Edit", "6", "ResolveProblem ZT", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 1, 12, 44, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "4", "ResolveProblem Activity Log", "7", "ResolveProblem NN", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 1, 6, 29, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, "10", "ResolveProblem Delete", "6", "ResolveProblem HL", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 1, 8, 7, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "10", "Statical Edit", "54", "Statical WV", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 1, 15, 1, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 36, "4", "Statical Delete", "52", "Statical YI", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 2, 1, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 35, "7", "Statical Delete", "50", "Statical AC", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 1, 16, 4, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, "5", "Statical Delete", "42", "Statical ID", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 2, 4, 3, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "5", "Statical Add", "46", "Statical EM", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 2, 5, 22, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, "10", "Statical Activity Log", "44", "Statical VY", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 2, 15, 10, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 38, "7", "Statical Add", "56", "Statical KI", "DE_DIEU", "1", "0", new DateTime(2020, 12, 2, 15, 13, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 34, "4", "Statical Edit", "48", "Statical VQ", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 1, 12, 27, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 39, "7", "Statical Activity Log", "58", "Statical NQ", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 1, 4, 6, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 43, "4", "Statical Edit", "66", "Statical DQ", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 1, 12, 32, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 41, "6", "Statical Add", "62", "Statical WK", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 2, 5, 4, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 42, "10", "Statical Edit", "64", "Statical QU", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 11, 43, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "3", "Statical Activity Log", "68", "Statical XO", "DE_DIEU", "1", "0", new DateTime(2020, 12, 2, 7, 31, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 45, "10", "Statical Activity Log", "70", "Statical HH", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 2, 17, 41, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 46, "7", "Statical Delete", "72", "Statical WW", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 2, 15, 23, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 47, "5", "Statical Edit", "74", "Statical OD", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 6, 46, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 48, "7", "Statical Delete", "76", "Statical HJ", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 2, 17, 34, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 30, "9", "Statical Activity Log", "40", "Statical FM", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 1, 10, 47, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 40, "4", "Statical Add", "60", "Statical RK", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 2, 17, 6, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, "10", "Statical Edit", "78", "Statical JX", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 2, 1, 20, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 29, "5", "Statical Activity Log", "38", "Statical CT", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 17, 23, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 27, "4", "Statical Activity Log", "34", "Statical DC", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 1, 9, 22, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 28, "7", "Statical Add", "36", "Statical XT", "DE_DIEU", "1", "0", new DateTime(2020, 12, 1, 7, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "2", "Statical Activity Log", "0", "Statical YE", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 11, "3", "Statical Add", "2", "Statical NJ", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 1, 11, 15, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, "6", "Statical Add", "4", "Statical BR", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 1, 15, 42, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, "9", "Statical Edit", "6", "Statical PV", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 1, 14, 16, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 15, "3", "Statical Activity Log", "10", "Statical YK", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 1, 9, 34, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 16, "9", "Statical Edit", "12", "Statical GN", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 1, 3, 18, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "6", "Statical Add", "14", "Statical EG", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 1, 3, 19, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, "4", "Statical Edit", "8", "Statical MA", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 1, 12, 44, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 19, "6", "Statical Activity Log", "18", "Statical PH", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 2, 16, 4, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "1", "Statical Add", "16", "Statical UL", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 3, 3, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "10", "Statical Add", "30", "Statical MU", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 1, 9, 37, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, "6", "Statical Activity Log", "28", "Statical CW", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 1, 2, 23, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, "7", "Statical Activity Log", "26", "Statical QE", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 2, 11, 10, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, "8", "Statical Add", "32", "Statical TH", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 16, 17, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, "2", "Statical Edit", "22", "Statical NU", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 1, 8, 12, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, "8", "Statical Delete", "20", "Statical MW", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 13, 37, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, "7", "Statical Edit", "24", "Statical MV", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 2, 12, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 38, "5", "UavConnect Delete", "7", "10", "UavConnect BN", "DE_DIEU", "0", new DateTime(2020, 12, 2, 10, 18, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 32, "5", "UavConnect Delete", "1", "11", "UavConnect WV", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 3, 18, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "6", "UavConnect Activity Log", "9", "10", "UavConnect MZ", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 8, 48, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 34, "6", "UavConnect Edit", "2", "2", "UavConnect XA", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 3, 12, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "7", "UavConnect Activity Log", "4", "4", "UavConnect XO", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 10, 13, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, "5", "UavConnect Add", "2", "9", "UavConnect BW", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 7, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 37, "4", "UavConnect Delete", "6", "8", "UavConnect OF", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 4, 44, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 49, "5", "UavConnect Add", "6", "14", "UavConnect AK", "DE_DIEU", "1", new DateTime(2020, 12, 1, 2, 40, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 31, "10", "UavConnect Delete", "6", "10", "UavConnect MJ", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 7, 44, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, "3", "UavConnect Add", "5", "7", "UavConnect ZG", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 16, 14, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 42, "9", "UavConnect Add", "2", "12", "UavConnect YC", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 2, 44, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 43, "7", "UavConnect Activity Log", "7", "5", "UavConnect FL", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 16, 19, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 44, "9", "UavConnect Add", "3", "6", "UavConnect VE", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 3, 13, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, "4", "UavConnect Add", "5", "2", "UavConnect DR", "DE_DIEU", "1", new DateTime(2020, 12, 2, 12, 7, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "4", "UavConnect Edit", "7", "8", "UavConnect SE", "DE_DIEU", "0", new DateTime(2020, 12, 2, 12, 15, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 47, "9", "UavConnect Delete", "1", "2", "UavConnect QF", "DE_DIEU", "1", new DateTime(2020, 12, 2, 15, 12, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 48, "3", "UavConnect Add", "7", "3", "UavConnect XU", "DE_DIEU", "0", new DateTime(2020, 12, 2, 3, 49, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, "9", "UavConnect Activity Log", "2", "9", "UavConnect NJ", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 11, 29, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 30, "8", "UavConnect Delete", "5", "6", "UavConnect IF", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 4, 9, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 39, "7", "UavConnect Add", "2", "1", "UavConnect JU", "DE_DIEU", "1", new DateTime(2020, 12, 1, 6, 4, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 28, "3", "UavConnect Edit", "5", "8", "UavConnect BV", "DE_DIEU", "0", new DateTime(2020, 12, 1, 15, 12, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, "6", "UavConnect Delete", "4", "2", "UavConnect YY", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 13, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, "10", "UavConnect Activity Log", "1", "3", "UavConnect CT", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 2, 45, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 12, "10", "UavConnect Edit", "3", "3", "UavConnect CY", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 13, 10, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "5", "UavConnect Delete", "6", "7", "UavConnect MG", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 10, 33, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 14, "4", "UavConnect Activity Log", "3", "13", "UavConnect RJ", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 5, 42, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 15, "6", "UavConnect Edit", "1", "13", "UavConnect PS", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 3, 2, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 16, "1", "UavConnect Add", "9", "3", "UavConnect QI", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 13, 26, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, "9", "UavConnect Delete", "6", "13", "UavConnect DH", "DE_DIEU", "1", new DateTime(2020, 12, 1, 9, 2, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, "7", "UavConnect Edit", "7", "7", "UavConnect EL", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 15, 18, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 29, "10", "UavConnect Edit", "10", "5", "UavConnect GX", "DE_DIEU", "1", new DateTime(2020, 12, 1, 11, 13, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, "6", "UavConnect Activity Log", "7", "1", "UavConnect CW", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 12, 13, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 21, "2", "UavConnect Add", "10", "10", "UavConnect WP", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 16, 19, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "4", "UavConnect Add", "5", "4", "UavConnect QB", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 4, 12, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 23, "8", "UavConnect Delete", "9", "14", "UavConnect PJ", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 9, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, "4", "UavConnect Delete", "7", "6", "UavConnect OG", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 5, 25, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 25, "9", "UavConnect Edit", "5", "1", "UavConnect IA", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 9, 47, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, "10", "UavConnect Edit", "3", "2", "UavConnect RC", "DE_DIEU", "0", new DateTime(2020, 12, 2, 12, 35, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "6", "UavConnect Activity Log", "7", "2", "UavConnect PR", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 6, 4, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, "5", "UavConnect Add", "1", "8", "UavConnect WN", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 10, 21, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 38, "10", "User Delete", "8", null, "Meta data example 28", "CHAY_RUNG", "2", "4", new DateTime(2020, 12, 1, 8, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 37, "6", "User Activity Log", "6", null, "Meta data example 27", "CHAY_RUNG", "2", "11", new DateTime(2020, 12, 2, 8, 29, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, "10", "User Delete", "7", null, "Meta data example 26", "CAY_TRONG", "3", "14", new DateTime(2020, 12, 1, 9, 28, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 32, "5", "User Activity Log", "10", null, "Meta data example 22", "CAY_TRONG", "4", "3", new DateTime(2020, 12, 1, 2, 48, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 34, "5", "User Edit", "10", null, "Meta data example 24", "CAY_TRONG", "4", "13", new DateTime(2020, 12, 2, 13, 43, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 33, "5", "User Edit", "4", null, "Meta data example 23", "DE_DIEU", "3", "10", new DateTime(2020, 12, 1, 14, 13, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 39, "3", "User Activity Log", "7", null, "Meta data example 29", "DE_DIEU", "3", "5", new DateTime(2020, 12, 2, 17, 21, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 35, "2", "User Activity Log", "10", null, "Meta data example 25", "LUOI_DIEN", "4", "8", new DateTime(2020, 12, 1, 10, 49, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 40, "3", "User Add", "2", null, "Meta data example 30", "LUOI_DIEN", "1", "10", new DateTime(2020, 12, 1, 16, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 44, "5", "User Delete", "5", null, "Meta data example 34", "CAY_TRONG", "3", "11", new DateTime(2020, 12, 1, 3, 6, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 42, "9", "User Activity Log", "3", null, "Meta data example 32", "CHAY_RUNG", "2", "7", new DateTime(2020, 12, 2, 1, 32, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 43, "3", "User Edit", "7", null, "Meta data example 33", "CHAY_RUNG", "4", "5", new DateTime(2020, 12, 2, 6, 30, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 45, "10", "User Add", "7", null, "Meta data example 35", "CHAY_RUNG", "4", "7", new DateTime(2020, 12, 1, 12, 6, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "7", "User Activity Log", "5", null, "Meta data example 36", "LUOI_DIEN", "4", "5", new DateTime(2020, 12, 1, 8, 23, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 47, "10", "User Edit", "2", null, "Meta data example 37", "DE_DIEU", "1", "2", new DateTime(2020, 12, 1, 14, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 48, "1", "User Edit", "8", null, "Meta data example 38", "DE_DIEU", "2", "12", new DateTime(2020, 12, 1, 12, 49, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 49, "3", "User Edit", "7", null, "Meta data example 39", "LUOI_DIEN", "4", "6", new DateTime(2020, 12, 1, 17, 44, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "8", "User Delete", "7", null, "Meta data example 21", "LUOI_DIEN", "3", "2", new DateTime(2020, 12, 1, 6, 48, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, "6", "User Activity Log", "7", null, "Meta data example 31", "CHAY_RUNG", "1", "4", new DateTime(2020, 12, 2, 1, 3, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 30, "7", "User Add", "4", null, "Meta data example 20", "CHAY_RUNG", "2", "6", new DateTime(2020, 12, 1, 8, 2, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "3", "User Activity Log", "10", null, "Meta data example 19", "CHAY_RUNG", "3", "5", new DateTime(2020, 12, 1, 2, 37, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 28, "8", "User Add", "5", null, "Meta data example 18", "DE_DIEU", "4", "9", new DateTime(2020, 12, 2, 1, 7, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "10", "User Delete", "2", null, "Meta data example 0", "CHAY_RUNG", "1", "9", new DateTime(2020, 12, 2, 3, 47, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, "6", "User Delete", "6", null, "Meta data example 1", "LUOI_DIEN", "3", "9", new DateTime(2020, 12, 1, 1, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, "3", "User Add", "3", null, "Meta data example 2", "CHAY_RUNG", "3", "7", new DateTime(2020, 12, 1, 9, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, "5", "User Edit", "10", null, "Meta data example 3", "CAY_TRONG", "1", "2", new DateTime(2020, 12, 1, 8, 5, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, "2", "User Delete", "6", null, "Meta data example 4", "CAY_TRONG", "4", "14", new DateTime(2020, 12, 2, 7, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "4", "User Activity Log", "6", null, "Meta data example 6", "LUOI_DIEN", "3", "7", new DateTime(2020, 12, 1, 7, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, "8", "User Activity Log", "4", null, "Meta data example 7", "LUOI_DIEN", "4", "2", new DateTime(2020, 12, 2, 17, 40, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "1", "User Activity Log", "9", null, "Meta data example 8", "CAY_TRONG", "4", "6", new DateTime(2020, 12, 1, 5, 4, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 15, "4", "User Delete", "2", null, "Meta data example 5", "CHAY_RUNG", "2", "10", new DateTime(2020, 12, 2, 2, 48, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 20, "6", "User Edit", "10", null, "Meta data example 10", "CHAY_RUNG", "4", "10", new DateTime(2020, 12, 2, 8, 40, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 19, "4", "User Add", "2", null, "Meta data example 9", "LUOI_DIEN", "1", "12", new DateTime(2020, 12, 2, 9, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 26, "3", "User Activity Log", "6", null, "Meta data example 16", "DE_DIEU", "4", "12", new DateTime(2020, 12, 1, 16, 19, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, "6", "User Add", "2", null, "Meta data example 15", "CAY_TRONG", "4", "13", new DateTime(2020, 12, 2, 13, 20, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, "1", "User Edit", "1", null, "Meta data example 14", "DE_DIEU", "2", "8", new DateTime(2020, 12, 1, 17, 24, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "5", "User Delete", "8", null, "Meta data example 17", "CHAY_RUNG", "1", "12", new DateTime(2020, 12, 1, 15, 6, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, "7", "User Edit", "9", null, "Meta data example 12", "DE_DIEU", "2", "8", new DateTime(2020, 12, 1, 14, 21, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 21, "7", "User Delete", "8", null, "Meta data example 11", "CAY_TRONG", "2", "10", new DateTime(2020, 12, 1, 8, 8, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 23, "6", "User Edit", "7", null, "Meta data example 13", "LUOI_DIEN", "4", "6", new DateTime(2020, 12, 1, 9, 35, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 39, "3", "Video Activity Log", "10", "24", "8", "Video FZ", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 9, 34, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 32, "4", "Video Activity Log", "10", "14", "11", "Video AC", "DE_DIEU", "0", new DateTime(2020, 12, 1, 9, 45, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 33, "6", "Video Edit", "9", "37", "2", "Video DF", "DE_DIEU", "1", new DateTime(2020, 12, 1, 3, 7, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "4", "Video Edit", "5", "17", "12", "Video GP", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 8, 26, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "4", "Video Delete", "3", "20", "13", "Video DJ", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 17, 2, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 36, "7", "Video Delete", "7", "35", "7", "Video HB", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 1, 43, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 37, "5", "Video Activity Log", "5", "33", "6", "Video HL", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 3, 11, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 38, "6", "Video Add", "4", "2", "1", "Video LZ", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 6, 48, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, "7", "Video Add", "3", "31", "6", "Video ZK", "DE_DIEU", "1", new DateTime(2020, 12, 1, 5, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, "8", "Video Add", "2", "31", "7", "Video XQ", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 8, 48, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 41, "1", "Video Edit", "10", "15", "11", "Video VB", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 8, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 42, "9", "Video Edit", "3", "26", "1", "Video AT", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 13, 6, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 43, "3", "Video Delete", "10", "23", "7", "Video DU", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 11, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 44, "5", "Video Activity Log", "1", "9", "5", "Video YR", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 1, 21, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 45, "1", "Video Delete", "6", "5", "4", "Video GF", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 3, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 46, "5", "Video Edit", "8", "29", "1", "Video DH", "DE_DIEU", "0", new DateTime(2020, 12, 1, 5, 14, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 47, "5", "Video Activity Log", "6", "35", "4", "Video UH", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 3, 38, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 31, "6", "Video Add", "9", "33", "4", "Video WU", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 12, 41, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, "9", "Video Add", "5", "36", "11", "Video AC", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 2, 4, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 30, "8", "Video Edit", "6", "20", "14", "Video YR", "DE_DIEU", "0", new DateTime(2020, 12, 2, 2, 23, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 19, "4", "Video Activity Log", "1", "16", "1", "Video HO", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 14, 18, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 28, "9", "Video Edit", "7", "24", "13", "Video KH", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 5, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 29, "1", "Video Add", "3", "12", "1", "Video PB", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 14, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "4", "Video Edit", "8", "19", "3", "Video FL", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 3, 18, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, "5", "Video Activity Log", "5", "18", "8", "Video XP", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 14, 9, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 12, "4", "Video Activity Log", "5", "40", "1", "Video ZP", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 5, 41, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 13, "2", "Video Delete", "9", "39", "5", "Video FB", "DE_DIEU", "1", new DateTime(2020, 12, 2, 11, 13, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 15, "9", "Video Delete", "2", "13", "1", "Video WN", "DE_DIEU", "1", new DateTime(2020, 12, 1, 17, 25, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "9", "Video Activity Log", "10", "35", "6", "Video OT", "DE_DIEU", "0", new DateTime(2020, 12, 1, 5, 24, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, "3", "Video Add", "8", "27", "1", "Video YI", "DE_DIEU", "1", new DateTime(2020, 12, 1, 14, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, "1", "Video Activity Log", "7", "11", "2", "Video MG", "DE_DIEU", "0", new DateTime(2020, 12, 1, 15, 9, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 20, "5", "Video Delete", "3", "37", "1", "Video LG", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 14, 3, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "9", "Video Activity Log", "4", "4", "12", "Video KN", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 16, 4, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 22, "9", "Video Add", "3", "5", "1", "Video RU", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 15, 48, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, "7", "Video Activity Log", "3", "23", "9", "Video MI", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 14, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, "3", "Video Edit", "4", "13", "9", "Video ZG", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 13, 24, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, "2", "Video Add", "4", "26", "12", "Video PA", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 14, 26, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "2", "Video Activity Log", "10", "8", "7", "Video UB", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 16, 28, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, "2", "Video Edit", "5", "2", "13", "Video VN", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 10, 8, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 18, "5", "Video Add", "4", "25", "12", "Video WW", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 14, 32, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 36, "2", "Warning Delete", "3", "Warning GB", "DE_DIEU", "3", "0", new DateTime(2020, 12, 2, 1, 39, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 35, "1", "Warning Delete", "10", "Warning TC", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 2, 8, 26, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, "6", "Warning Delete", "8", "Warning EQ", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 2, 9, 31, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "2", "Warning Activity Log", "9", "Warning KG", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 2, 17, 9, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 32, "1", "Warning Add", "1", "Warning LR", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 2, 17, 8, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 37, "4", "Warning Add", "1", "Warning XZ", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 1, 1, 14, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 34, "8", "Warning Add", "1", "Warning EK", "DE_DIEU", "1", "0", new DateTime(2020, 12, 1, 9, 17, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 38, "9", "Warning Add", "9", "Warning RQ", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 2, 8, 30, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 47, "3", "Warning Edit", "5", "Warning GI", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 2, 14, 10, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 40, "10", "Warning Add", "9", "Warning PZ", "DE_DIEU", "3", "0", new DateTime(2020, 12, 2, 10, 10, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 41, "8", "Warning Add", "3", "Warning QY", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 1, 12, 29, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 42, "6", "Warning Add", "5", "Warning XC", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 1, 1, 38, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 43, "8", "Warning Edit", "2", "Warning KX", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 1, 10, 28, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "10", "Warning Add", "9", "Warning NI", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 1, 10, 5, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, "3", "Warning Add", "5", "Warning EG", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 1, 4, 32, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "5", "Warning Activity Log", "6", "Warning MZ", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 1, 14, 27, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 30, "5", "Warning Delete", "9", "Warning VT", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 2, 11, 30, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 39, "4", "Warning Add", "6", "Warning CF", "DE_DIEU", "3", "1", new DateTime(2020, 12, 1, 11, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "9", "Warning Edit", "1", "Warning OS", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 2, 5, 40, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, "10", "Warning Add", "7", "Warning BH", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 2, 14, 39, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, "1", "Warning Delete", "9", "Warning KE", "DE_DIEU", "3", "1", new DateTime(2020, 12, 1, 3, 30, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 48, "5", "Warning Edit", "6", "Warning FX", "DE_DIEU", "2", "0", new DateTime(2020, 12, 1, 13, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, "9", "Warning Activity Log", "3", "Warning EI", "DE_DIEU", "2", "0", new DateTime(2020, 12, 1, 15, 9, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 11, "2", "Warning Delete", "10", "Warning DN", "DE_DIEU", "2", "1", new DateTime(2020, 12, 2, 3, 31, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, "8", "Warning Add", "5", "Warning MZ", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 1, 16, 24, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, "5", "Warning Add", "9", "Warning RK", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 1, 7, 33, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, "2", "Warning Delete", "10", "Warning QU", "DE_DIEU", "2", "0", new DateTime(2020, 12, 1, 3, 33, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 15, "9", "Warning Edit", "8", "Warning UZ", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 1, 11, 26, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 16, "7", "Warning Add", "10", "Warning ED", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 1, 10, 26, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, "10", "Warning Add", "3", "Warning IQ", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 1, 14, 29, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 18, "1", "Warning Edit", "10", "Warning KD", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 7, 32, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 19, "8", "Warning Delete", "9", "Warning SO", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 6, 45, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "7", "Warning Activity Log", "5", "Warning YZ", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 1, 1, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 22, "7", "Warning Delete", "10", "Warning OT", "DE_DIEU", "3", "0", new DateTime(2020, 12, 1, 8, 12, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 23, "1", "Warning Add", "10", "Warning TV", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 2, 4, 38, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, "9", "Warning Delete", "3", "Warning GF", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 2, 5, 39, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 25, "4", "Warning Delete", "6", "Warning IX", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 1, 10, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "5", "Warning Delete", "4", "Warning SM", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 1, 2, 15, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "8", "Warning Activity Log", "5", "Warning TV", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 2, 1, 3, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 49, "6", "Warning Activity Log", "10", "Warning IM", "DE_DIEU", "2", "1", new DateTime(2020, 12, 1, 17, 4, 0, 0, DateTimeKind.Unspecified), 20 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DroneLogs");

            migrationBuilder.DropTable(
                name: "ImageLogs");

            migrationBuilder.DropTable(
                name: "IncidentLogs");

            migrationBuilder.DropTable(
                name: "MonitorRegionLogs");

            migrationBuilder.DropTable(
                name: "ObjectObserves");

            migrationBuilder.DropTable(
                name: "Payloads");

            migrationBuilder.DropTable(
                name: "ResolveProblemLogs");

            migrationBuilder.DropTable(
                name: "StaticalLogs");

            migrationBuilder.DropTable(
                name: "SystemLogs");

            migrationBuilder.DropTable(
                name: "UavConnectLogs");

            migrationBuilder.DropTable(
                name: "UserLog");

            migrationBuilder.DropTable(
                name: "VideoLogs");

            migrationBuilder.DropTable(
                name: "WarningLogs");
        }
    }
}
