using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace aspnetcoreapp.Migrations
{
    public partial class test : Migration
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
                    RegionId = table.Column<string>(nullable: true)
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
                    { 1, "8", "Drone Add", "3", 46, 21, "Drone 10", "DE_DIEU", "1", "MonitorRegion 1", new DateTime(2020, 12, 1, 17, 23, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 23, "2", "Drone Add", "4", 36, 44, "Drone 2", "DE_DIEU", "3", "MonitorRegion 2", new DateTime(2020, 12, 2, 16, 40, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, "3", "Drone Add", "8", 20, 14, "Drone 7", "CHAY_RUNG", "4", "MonitorRegion 4", new DateTime(2020, 12, 2, 14, 22, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "1", "Drone Edit", "5", 30, 43, "Drone 9", "CHAY_RUNG", "2", "MonitorRegion 3", new DateTime(2020, 12, 2, 14, 21, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, "2", "Drone Delete", "4", 43, 42, "Drone 1", "CHAY_RUNG", "1", "MonitorRegion 4", new DateTime(2020, 12, 1, 3, 48, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "8", "Drone Delete", "4", 12, 21, "Drone 10", "CAY_TRONG", "1", "MonitorRegion 1", new DateTime(2020, 12, 2, 13, 21, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "5", "Drone Add", "7", 38, 38, "Drone 6", "CHAY_RUNG", "1", "MonitorRegion 1", new DateTime(2020, 12, 1, 8, 48, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "9", "Drone Edit", "5", 13, 28, "Drone 7", "LUOI_DIEN", "3", "MonitorRegion 4", new DateTime(2020, 12, 1, 16, 43, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "2", "Drone Edit", "1", 45, 29, "Drone 2", "DE_DIEU", "3", "MonitorRegion 2", new DateTime(2020, 12, 1, 11, 49, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 32, "1", "Drone Edit", "7", 27, 46, "Drone 10", "LUOI_DIEN", "3", "MonitorRegion 3", new DateTime(2020, 12, 1, 10, 6, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 33, "6", "Drone Delete", "5", 21, 43, "Drone 2", "CAY_TRONG", "2", "MonitorRegion 2", new DateTime(2020, 12, 1, 10, 37, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 34, "7", "Drone Edit", "3", 37, 33, "Drone 7", "LUOI_DIEN", "4", "MonitorRegion 2", new DateTime(2020, 12, 1, 4, 5, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "8", "Drone Delete", "1", 17, 15, "Drone 6", "DE_DIEU", "4", "MonitorRegion 3", new DateTime(2020, 12, 2, 14, 3, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 36, "9", "Drone Delete", "4", 48, 27, "Drone 8", "LUOI_DIEN", "3", "MonitorRegion 2", new DateTime(2020, 12, 2, 16, 29, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 37, "2", "Drone Delete", "10", 12, 17, "Drone 5", "DE_DIEU", "1", "MonitorRegion 2", new DateTime(2020, 12, 1, 5, 27, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 38, "2", "Drone Activity Log", "10", 16, 31, "Drone 10", "CHAY_RUNG", "3", "MonitorRegion 4", new DateTime(2020, 12, 2, 3, 25, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 39, "7", "Drone Add", "4", 37, 47, "Drone 2", "LUOI_DIEN", "1", "MonitorRegion 2", new DateTime(2020, 12, 2, 13, 20, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, "2", "Drone Add", "7", 17, 12, "Drone 4", "DE_DIEU", "4", "MonitorRegion 3", new DateTime(2020, 12, 2, 6, 47, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "8", "Drone Activity Log", "10", 34, 26, "Drone 4", "LUOI_DIEN", "1", "MonitorRegion 1", new DateTime(2020, 12, 1, 9, 48, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 21, "1", "Drone Delete", "10", 29, 26, "Drone 9", "CHAY_RUNG", "2", "MonitorRegion 2", new DateTime(2020, 12, 1, 5, 46, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 30, "2", "Drone Activity Log", "7", 15, 38, "Drone 9", "LUOI_DIEN", "1", "MonitorRegion 4", new DateTime(2020, 12, 2, 12, 49, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, "8", "Drone Edit", "1", 36, 47, "Drone 3", "LUOI_DIEN", "4", "MonitorRegion 3", new DateTime(2020, 12, 2, 10, 47, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, "3", "Drone Delete", "6", 20, 21, "Drone 7", "CAY_TRONG", "3", "MonitorRegion 2", new DateTime(2020, 12, 1, 10, 24, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 2, "3", "Drone Add", "4", 14, 17, "Drone 7", "LUOI_DIEN", "4", "MonitorRegion 1", new DateTime(2020, 12, 2, 5, 41, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, "2", "Drone Delete", "1", 44, 34, "Drone 4", "CAY_TRONG", "4", "MonitorRegion 1", new DateTime(2020, 12, 1, 15, 43, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, "2", "Drone Delete", "6", 41, 37, "Drone 6", "DE_DIEU", "3", "MonitorRegion 4", new DateTime(2020, 12, 2, 7, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 5, "1", "Drone Add", "1", 40, 17, "Drone 3", "CAY_TRONG", "3", "MonitorRegion 1", new DateTime(2020, 12, 1, 1, 24, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 6, "10", "Drone Edit", "5", 21, 21, "Drone 7", "LUOI_DIEN", "3", "MonitorRegion 1", new DateTime(2020, 12, 1, 13, 47, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 8, "9", "Drone Add", "8", 19, 17, "Drone 4", "LUOI_DIEN", "1", "MonitorRegion 4", new DateTime(2020, 12, 2, 15, 28, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 9, "9", "Drone Delete", "6", 37, 48, "Drone 10", "LUOI_DIEN", "4", "MonitorRegion 2", new DateTime(2020, 12, 1, 15, 41, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, "3", "Drone Activity Log", "1", 42, 45, "Drone 8", "LUOI_DIEN", "2", "MonitorRegion 3", new DateTime(2020, 12, 2, 11, 10, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 7, "9", "Drone Activity Log", "6", 16, 20, "Drone 2", "CAY_TRONG", "2", "MonitorRegion 1", new DateTime(2020, 12, 2, 11, 24, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "2", "Drone Delete", "6", 41, 24, "Drone 6", "CAY_TRONG", "4", "MonitorRegion 2", new DateTime(2020, 12, 2, 16, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, "4", "Drone Delete", "10", 29, 20, "Drone 6", "CAY_TRONG", "4", "MonitorRegion 4", new DateTime(2020, 12, 1, 11, 29, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, "8", "Drone Edit", "2", 36, 46, "Drone 4", "DE_DIEU", "1", "MonitorRegion 2", new DateTime(2020, 12, 1, 6, 11, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, "8", "Drone Activity Log", "9", 41, 46, "Drone 3", "LUOI_DIEN", "1", "MonitorRegion 4", new DateTime(2020, 12, 1, 15, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 15, "1", "Drone Add", "5", 37, 37, "Drone 10", "LUOI_DIEN", "3", "MonitorRegion 3", new DateTime(2020, 12, 1, 4, 2, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "4", "Drone Activity Log", "9", 24, 46, "Drone 7", "DE_DIEU", "4", "MonitorRegion 4", new DateTime(2020, 12, 1, 2, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, "2", "Drone Add", "10", 12, 35, "Drone 2", "DE_DIEU", "2", "MonitorRegion 2", new DateTime(2020, 12, 2, 5, 17, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "8", "Drone Add", "3", 31, 25, "Drone 7", "CHAY_RUNG", "4", "MonitorRegion 2", new DateTime(2020, 12, 2, 5, 26, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 38, "5", "Image Edit", "1", "6", "3", "Image NU", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 8, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 37, "1", "Image Edit", "6", "10", "13", "Image YC", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 15, 37, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 36, "3", "Image Edit", "3", "33", "14", "Image MI", "DE_DIEU", "0", new DateTime(2020, 12, 1, 15, 23, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 32, "10", "Image Delete", "5", "23", "6", "Image MM", "DE_DIEU", "0", new DateTime(2020, 12, 2, 3, 46, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 34, "2", "Image Delete", "2", "18", "14", "Image TK", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 4, 15, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "5", "Image Activity Log", "2", "4", "7", "Image CA", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 6, 1, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 39, "2", "Image Delete", "6", "11", "1", "Image BX", "DE_DIEU", "1", new DateTime(2020, 12, 1, 16, 29, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 35, "10", "Image Delete", "5", "39", "10", "Image FF", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 11, 25, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, "10", "Image Activity Log", "6", "14", "7", "Image LS", "DE_DIEU", "0", new DateTime(2020, 12, 1, 16, 19, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 49, "6", "Image Delete", "6", "37", "13", "Image XK", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 12, 35, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 42, "2", "Image Delete", "10", "9", "10", "Image EG", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 11, 41, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 43, "8", "Image Edit", "10", "2", "10", "Image DF", "DE_DIEU", "1", new DateTime(2020, 12, 2, 17, 47, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "3", "Image Edit", "9", "11", "14", "Image OU", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 12, 28, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 45, "8", "Image Add", "5", "6", "10", "Image HM", "DE_DIEU", "1", new DateTime(2020, 12, 2, 7, 4, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "7", "Image Edit", "1", "6", "4", "Image UE", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 16, 16, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 47, "5", "Image Delete", "1", "1", "5", "Image DC", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 48, "8", "Image Activity Log", "10", "8", "4", "Image NR", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 10, 22, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 31, "2", "Image Edit", "2", "37", "1", "Image XC", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 3, 42, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 41, "4", "Image Edit", "8", "9", "1", "Image UI", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 9, 37, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "7", "Image Delete", "2", "27", "11", "Image QM", "DE_DIEU", "0", new DateTime(2020, 12, 2, 6, 41, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "1", "Image Delete", "5", "9", "10", "Image ZX", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 11, 29, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "9", "Image Delete", "8", "38", "8", "Image KO", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 16, 24, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, "7", "Image Edit", "3", "31", "5", "Image OC", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 14, 24, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, "5", "Image Edit", "9", "35", "14", "Image CE", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 1, 20, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "8", "Image Add", "2", "8", "8", "Image LM", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 8, 12, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, "1", "Image Add", "1", "34", "7", "Image CS", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 8, 23, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, "2", "Image Activity Log", "7", "20", "2", "Image TG", "DE_DIEU", "0", new DateTime(2020, 12, 2, 8, 13, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 15, "1", "Image Delete", "8", "16", "12", "Image HB", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 3, 39, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "6", "Image Activity Log", "8", "3", "8", "Image JH", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 6, 8, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, "3", "Image Activity Log", "6", "29", "1", "Image JK", "DE_DIEU", "1", new DateTime(2020, 12, 2, 8, 5, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "2", "Image Add", "9", "23", "2", "Image AX", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 10, 26, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "9", "Image Delete", "10", "40", "4", "Image XD", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 16, 1, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 20, "10", "Image Add", "3", "31", "8", "Image ZI", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 11, 26, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, "6", "Image Delete", "6", "3", "2", "Image HI", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 9, 42, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, "4", "Image Add", "6", "34", "3", "Image HQ", "DE_DIEU", "0", new DateTime(2020, 12, 2, 3, 9, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 23, "10", "Image Add", "3", "8", "2", "Image ZV", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 1, 26, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, "8", "Image Edit", "6", "1", "8", "Image EV", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 17, 34, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 25, "9", "Image Edit", "3", "14", "4", "Image RE", "DE_DIEU", "1", new DateTime(2020, 12, 2, 2, 9, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, "1", "Image Edit", "5", "28", "10", "Image XF", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 15, 30, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "9", "Image Edit", "5", "24", "8", "Image FY", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 5, 18, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 32, "9", "Incident Activity Log", "5", "Incident PV", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 1, 17, 9, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 33, "6", "Incident Edit", "13", "Incident OJ", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 2, 16, 2, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "1", "Incident Edit", "9", "Incident OY", "DE_DIEU", "1", "0", new DateTime(2020, 12, 1, 5, 48, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "2", "Incident Activity Log", "1", "Incident GS", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 2, 5, 45, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, "7", "Incident Edit", "3", "Incident XF", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 1, 6, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 37, "3", "Incident Delete", "14", "Incident WV", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 2, 15, 41, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 38, "5", "Incident Delete", "11", "Incident PM", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 1, 16, 31, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, "6", "Incident Edit", "8", "Incident FB", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 2, 2, 34, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "7", "Incident Activity Log", "10", "Incident NP", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 1, 5, 10, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 42, "7", "Incident Edit", "12", "Incident VF", "DE_DIEU", "2", "0", new DateTime(2020, 12, 1, 15, 27, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 43, "7", "Incident Edit", "2", "Incident IP", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 5, 36, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "10", "Incident Activity Log", "12", "Incident DC", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 2, 7, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 45, "3", "Incident Edit", "12", "Incident AJ", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 2, 11, 30, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 46, "2", "Incident Activity Log", "13", "Incident GG", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 8, 14, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 47, "8", "Incident Add", "4", "Incident EX", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 17, 47, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, "3", "Incident Delete", "1", "Incident QR", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 1, 3, 8, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 49, "9", "Incident Edit", "4", "Incident HN", "DE_DIEU", "4", "1", new DateTime(2020, 12, 1, 9, 24, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 41, "9", "Incident Activity Log", "10", "Incident MP", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 2, 9, 5, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 30, "8", "Incident Activity Log", "2", "Incident NI", "DE_DIEU", "3", "0", new DateTime(2020, 12, 1, 1, 45, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 39, "4", "Incident Add", "11", "Incident SS", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 1, 1, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 28, "7", "Incident Add", "1", "Incident MU", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 1, 10, 44, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "5", "Incident Add", "11", "Incident CV", "DE_DIEU", "3", "1", new DateTime(2020, 12, 1, 8, 19, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, "5", "Incident Edit", "7", "Incident HI", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 1, 15, 28, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "6", "Incident Delete", "13", "Incident NX", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 5, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 14, "6", "Incident Delete", "8", "Incident AD", "DE_DIEU", "1", "0", new DateTime(2020, 12, 1, 12, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 15, "9", "Incident Edit", "7", "Incident FF", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 1, 26, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 16, "1", "Incident Activity Log", "14", "Incident BZ", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 2, 2, 5, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, "4", "Incident Activity Log", "9", "Incident CL", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 2, 15, 21, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "4", "Incident Add", "3", "Incident KX", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 2, 6, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 19, "10", "Incident Add", "4", "Incident YO", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 2, 16, 49, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "1", "Incident Delete", "8", "Incident WI", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 1, 13, 24, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 20, "10", "Incident Delete", "3", "Incident LZ", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 2, 9, 7, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "6", "Incident Activity Log", "5", "Incident EN", "DE_DIEU", "3", "1", new DateTime(2020, 12, 1, 9, 27, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 22, "10", "Incident Add", "10", "Incident VN", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 1, 17, 5, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 23, "4", "Incident Delete", "11", "Incident DB", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 2, 9, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, "7", "Incident Edit", "14", "Incident JT", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 1, 16, 18, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 25, "7", "Incident Delete", "7", "Incident EQ", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 1, 12, 21, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "3", "Incident Add", "11", "Incident DB", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 3, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, "7", "Incident Edit", "11", "Incident YV", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 1, 15, 3, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 29, "5", "Incident Activity Log", "7", "Incident US", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 1, 6, 5, 0, 0, DateTimeKind.Unspecified), 20 }
                });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 28, "10", "MonitorRegion Add", "4", "MonitorRegion 4", "DE_DIEU", "1", new DateTime(2020, 12, 2, 8, 4, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, "3", "MonitorRegion Activity Log", "3", "MonitorRegion 3", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 8, 23, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, "8", "MonitorRegion Edit", "2", "MonitorRegion 2", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 5, 29, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 25, "8", "MonitorRegion Delete", "4", "MonitorRegion 4", "DE_DIEU", "0", new DateTime(2020, 12, 2, 4, 3, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, "4", "MonitorRegion Add", "4", "MonitorRegion 4", "DE_DIEU", "1", new DateTime(2020, 12, 2, 14, 42, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "4", "MonitorRegion Delete", "4", "MonitorRegion 4", "DE_DIEU", "0", new DateTime(2020, 12, 1, 14, 43, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "8", "MonitorRegion Add", "1", "MonitorRegion 1", "DE_DIEU", "1", new DateTime(2020, 12, 2, 7, 42, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 30, "9", "MonitorRegion Add", "2", "MonitorRegion 2", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 10, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, "9", "MonitorRegion Delete", "1", "MonitorRegion 1", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 11, 34, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 32, "2", "MonitorRegion Add", "4", "MonitorRegion 4", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 13, 39, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 33, "4", "MonitorRegion Activity Log", "2", "MonitorRegion 2", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 5, 14, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 34, "10", "MonitorRegion Activity Log", "2", "MonitorRegion 2", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 13, 16, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, "6", "MonitorRegion Edit", "1", "MonitorRegion 1", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 5, 44, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 37, "2", "MonitorRegion Edit", "3", "MonitorRegion 3", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 5, 15, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 38, "9", "MonitorRegion Delete", "1", "MonitorRegion 1", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 14, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 39, "10", "MonitorRegion Activity Log", "4", "MonitorRegion 4", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 5, 8, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 22, "5", "MonitorRegion Activity Log", "3", "MonitorRegion 3", "DE_DIEU", "1", new DateTime(2020, 12, 1, 17, 48, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 31, "2", "MonitorRegion Delete", "3", "MonitorRegion 3", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 3, 43, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "9", "MonitorRegion Delete", "1", "MonitorRegion 1", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 10, 49, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, "6", "MonitorRegion Edit", "3", "MonitorRegion 3", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 8, 10, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 19, "10", "MonitorRegion Add", "3", "MonitorRegion 3", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 12, 17, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 1, "10", "MonitorRegion Add", "3", "MonitorRegion 3", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 7, 33, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 2, "2", "MonitorRegion Activity Log", "4", "MonitorRegion 4", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 1, 42, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 3, "8", "MonitorRegion Delete", "2", "MonitorRegion 2", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 9, 24, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, "4", "MonitorRegion Add", "1", "MonitorRegion 1", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 16, 5, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 5, "5", "MonitorRegion Edit", "3", "MonitorRegion 3", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 17, 33, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 6, "1", "MonitorRegion Add", "4", "MonitorRegion 4", "DE_DIEU", "1", new DateTime(2020, 12, 2, 15, 37, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 7, "3", "MonitorRegion Edit", "2", "MonitorRegion 2", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 8, 23, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 8, "1", "MonitorRegion Edit", "2", "MonitorRegion 2", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 2, 34, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 9, "2", "MonitorRegion Delete", "2", "MonitorRegion 2", "DE_DIEU", "0", new DateTime(2020, 12, 1, 1, 42, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 20, "3", "MonitorRegion Activity Log", "4", "MonitorRegion 4", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 2, 49, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 11, "10", "MonitorRegion Add", "2", "MonitorRegion 2", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 17, 9, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, "6", "MonitorRegion Add", "3", "MonitorRegion 3", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 8, 43, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, "8", "MonitorRegion Delete", "1", "MonitorRegion 1", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 17, 2, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 14, "9", "MonitorRegion Delete", "3", "MonitorRegion 3", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 7, 24, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 15, "7", "MonitorRegion Delete", "2", "MonitorRegion 2", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 5, 25, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "5", "MonitorRegion Delete", "4", "MonitorRegion 4", "DE_DIEU", "1", new DateTime(2020, 12, 2, 10, 8, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 17, "4", "MonitorRegion Add", "4", "MonitorRegion 4", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 8, 2, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 18, "5", "MonitorRegion Add", "4", "MonitorRegion 4", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 2, 11, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "7", "MonitorRegion Add", "1", "MonitorRegion 1", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 9, 2, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "1", "ObjectObserve Activity Log", "13", "ObjectObserve VM", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 1, 4, 26, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, "8", "ObjectObserve Delete", "20", "ObjectObserve QC", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 2, 9, 1, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 35, "2", "ObjectObserve Delete", "1", "ObjectObserve UR", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 2, 9, 26, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, "3", "ObjectObserve Add", "11", "ObjectObserve KY", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 2, 2, 33, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 33, "1", "ObjectObserve Add", "12", "ObjectObserve YV", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 1, 15, 27, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, "6", "ObjectObserve Activity Log", "19", "ObjectObserve VX", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 2, 14, 49, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 38, "6", "ObjectObserve Edit", "14", "ObjectObserve OX", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 2, 12, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "10", "ObjectObserve Edit", "11", "ObjectObserve ZK", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 1, 3, 6, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 39, "4", "ObjectObserve Add", "9", "ObjectObserve TP", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 2, 11, 20, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 43, "7", "ObjectObserve Add", "9", "ObjectObserve YT", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 2, 1, 12, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 41, "5", "ObjectObserve Delete", "19", "ObjectObserve YF", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 1, 6, 27, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 42, "6", "ObjectObserve Edit", "18", "ObjectObserve CE", "DE_DIEU", "2", "0", new DateTime(2020, 12, 1, 12, 40, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "3", "ObjectObserve Add", "5", "ObjectObserve GX", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 1, 14, 30, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, "6", "ObjectObserve Delete", "20", "ObjectObserve RI", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 2, 17, 16, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 46, "3", "ObjectObserve Add", "14", "ObjectObserve MR", "DE_DIEU", "3", "0", new DateTime(2020, 12, 2, 1, 34, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 47, "7", "ObjectObserve Activity Log", "9", "ObjectObserve ZZ", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 4, 15, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 48, "5", "ObjectObserve Add", "17", "ObjectObserve KI", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 2, 4, 49, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 30, "9", "ObjectObserve Delete", "9", "ObjectObserve EO", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 2, 3, 11, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, "3", "ObjectObserve Activity Log", "16", "ObjectObserve IB", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 1, 15, 47, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 49, "10", "ObjectObserve Add", "5", "ObjectObserve MV", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 2, 4, 21, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "7", "ObjectObserve Delete", "11", "ObjectObserve QG", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 2, 14, 36, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "5", "ObjectObserve Delete", "19", "ObjectObserve HN", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 1, 8, 43, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "10", "ObjectObserve Activity Log", "17", "ObjectObserve MP", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 2, 3, 19, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 10, "8", "ObjectObserve Edit", "8", "ObjectObserve VW", "DE_DIEU", "1", "0", new DateTime(2020, 12, 1, 14, 49, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, "9", "ObjectObserve Add", "5", "ObjectObserve XI", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 1, 13, 4, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, "6", "ObjectObserve Delete", "2", "ObjectObserve XC", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 4, 18, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, "5", "ObjectObserve Delete", "11", "ObjectObserve EK", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 2, 8, 7, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 15, "7", "ObjectObserve Edit", "15", "ObjectObserve MI", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 6, 6, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 16, "9", "ObjectObserve Add", "4", "ObjectObserve UP", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 1, 15, 5, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, "2", "ObjectObserve Add", "7", "ObjectObserve GM", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 2, 7, 9, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, "5", "ObjectObserve Delete", "12", "ObjectObserve AO", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 10, 35, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "10", "ObjectObserve Add", "19", "ObjectObserve IW", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 18, "5", "ObjectObserve Delete", "13", "ObjectObserve RB", "DE_DIEU", "3", "0", new DateTime(2020, 12, 1, 1, 21, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 25, "2", "ObjectObserve Activity Log", "19", "ObjectObserve OE", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 2, 1, 1, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 24, "7", "ObjectObserve Delete", "14", "ObjectObserve PC", "DE_DIEU", "2", "0", new DateTime(2020, 12, 1, 15, 27, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 23, "6", "ObjectObserve Add", "7", "ObjectObserve JD", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 13, 14, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 26, "1", "ObjectObserve Delete", "14", "ObjectObserve VD", "DE_DIEU", "3", "0", new DateTime(2020, 12, 1, 8, 4, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "6", "ObjectObserve Edit", "3", "ObjectObserve CN", "DE_DIEU", "4", "1", new DateTime(2020, 12, 1, 10, 23, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, "6", "ObjectObserve Activity Log", "5", "ObjectObserve FN", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 2, 14, 23, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 22, "10", "ObjectObserve Edit", "14", "ObjectObserve RQ", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 2, 14, 39, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 38, "1", "Payload Delete", "1", "8", "Payload PE", "DE_DIEU", "0", new DateTime(2020, 12, 1, 11, 45, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 32, "1", "Payload Edit", "3", "8", "Payload MV", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 16, 34, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 33, "4", "Payload Edit", "7", "8", "Payload AI", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 2, 2, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "5", "Payload Edit", "10", "1", "Payload WD", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 12, 46, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "4", "Payload Add", "1", "5", "Payload JQ", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 4, 19, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, "6", "Payload Delete", "1", "2", "Payload NP", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 12, 36, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 37, "4", "Payload Add", "5", "3", "Payload VB", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 17, 39, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 39, "4", "Payload Edit", "2", "1", "Payload JH", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 11, 24, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "2", "Payload Activity Log", "7", "4", "Payload DM", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 10, 42, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 41, "4", "Payload Add", "5", "10", "Payload KZ", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 14, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 42, "8", "Payload Add", "7", "4", "Payload QV", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 13, 4, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 43, "1", "Payload Edit", "9", "10", "Payload GI", "DE_DIEU", "1", new DateTime(2020, 12, 1, 14, 2, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "7", "Payload Activity Log", "9", "7", "Payload TG", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 14, 34, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 45, "7", "Payload Add", "5", "10", "Payload HF", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 11, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "7", "Payload Delete", "2", "8", "Payload YG", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 2, 6, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 47, "10", "Payload Delete", "5", "2", "Payload YU", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 4, 18, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 48, "7", "Payload Add", "5", "9", "Payload NT", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 17, 2, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, "1", "Payload Delete", "10", "8", "Payload WG", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 7, 4, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 30, "4", "Payload Edit", "6", "6", "Payload PB", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 17, 26, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 49, "7", "Payload Add", "1", "6", "Payload IO", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 4, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 28, "1", "Payload Add", "5", "3", "Payload QC", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 6, 20, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "4", "Payload Delete", "8", "5", "Payload SV", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 7, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, "3", "Payload Edit", "3", "1", "Payload DM", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 4, 40, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "5", "Payload Activity Log", "2", "10", "Payload JQ", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 1, 48, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 13, "3", "Payload Edit", "1", "10", "Payload ST", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 13, 22, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, "10", "Payload Activity Log", "8", "7", "Payload TF", "DE_DIEU", "0", new DateTime(2020, 12, 1, 9, 29, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 15, "4", "Payload Add", "9", "4", "Payload WM", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 3, 14, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "10", "Payload Activity Log", "4", "2", "Payload SE", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 11, 49, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, "9", "Payload Activity Log", "8", "6", "Payload PN", "DE_DIEU", "1", new DateTime(2020, 12, 1, 17, 47, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "2", "Payload Delete", "5", "2", "Payload JV", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 11, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, "1", "Payload Delete", "6", "6", "Payload HT", "DE_DIEU", "1", new DateTime(2020, 12, 1, 1, 28, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 20, "7", "Payload Delete", "5", "6", "Payload FD", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 15, 4, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "4", "Payload Delete", "5", "8", "Payload XP", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 14, 13, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, "7", "Payload Add", "6", "5", "Payload NW", "DE_DIEU", "0", new DateTime(2020, 12, 2, 2, 29, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 23, "6", "Payload Add", "5", "8", "Payload PC", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 12, 5, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, "4", "Payload Delete", "9", "4", "Payload ZD", "DE_DIEU", "0", new DateTime(2020, 12, 1, 11, 42, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 25, "4", "Payload Activity Log", "8", "8", "Payload UR", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 16, 22, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, "6", "Payload Delete", "9", "4", "Payload HK", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 13, 11, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "2", "Payload Activity Log", "6", "9", "Payload BL", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 17, 5, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, "10", "Payload Add", "6", "3", "Payload IW", "DE_DIEU", "1", new DateTime(2020, 12, 1, 10, 25, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "7", "ResolveProblem Delete", "1", "ResolveProblem IR", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 5, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 36, "3", "ResolveProblem Delete", "13", "ResolveProblem LR", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 2, 12, 15, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 32, "5", "ResolveProblem Edit", "2", "ResolveProblem IY", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 1, 11, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "10", "ResolveProblem Delete", "10", "ResolveProblem BX", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 1, 9, 2, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "5", "ResolveProblem Delete", "13", "ResolveProblem GE", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 2, 17, 24, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 38, "2", "ResolveProblem Add", "10", "ResolveProblem DA", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 10, 40, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, "10", "ResolveProblem Edit", "5", "ResolveProblem PI", "DE_DIEU", "4", "1", new DateTime(2020, 12, 1, 17, 42, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 39, "3", "ResolveProblem Add", "8", "ResolveProblem EG", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 2, 2, 20, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 44, "1", "ResolveProblem Activity Log", "5", "ResolveProblem ZC", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 2, 3, 49, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 41, "6", "ResolveProblem Edit", "2", "ResolveProblem AS", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 1, 14, 24, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 42, "6", "ResolveProblem Activity Log", "2", "ResolveProblem HP", "DE_DIEU", "4", "0", new DateTime(2020, 12, 2, 2, 33, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 43, "5", "ResolveProblem Add", "14", "ResolveProblem SY", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 1, 9, 26, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, "2", "ResolveProblem Add", "6", "ResolveProblem FP", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 2, 9, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "4", "ResolveProblem Delete", "7", "ResolveProblem PL", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 2, 6, 28, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 47, "1", "ResolveProblem Activity Log", "1", "ResolveProblem MH", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 17, 23, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 48, "1", "ResolveProblem Edit", "2", "ResolveProblem IQ", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 1, 11, 18, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "2", "ResolveProblem Edit", "3", "ResolveProblem DR", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 1, 10, 14, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 40, "7", "ResolveProblem Add", "11", "ResolveProblem YH", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 1, 5, 10, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 30, "8", "ResolveProblem Edit", "4", "ResolveProblem YY", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 1, 11, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 49, "7", "ResolveProblem Delete", "12", "ResolveProblem KZ", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 2, 1, 3, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "7", "ResolveProblem Add", "6", "ResolveProblem AC", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 2, 10, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "7", "ResolveProblem Edit", "13", "ResolveProblem DD", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 2, 8, 29, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, "6", "ResolveProblem Edit", "14", "ResolveProblem FR", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 2, 2, 28, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "5", "ResolveProblem Edit", "2", "ResolveProblem ZG", "DE_DIEU", "1", "0", new DateTime(2020, 12, 2, 4, 46, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "1", "ResolveProblem Activity Log", "1", "ResolveProblem JC", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 2, 14, 11, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 14, "1", "ResolveProblem Activity Log", "12", "ResolveProblem FP", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 1, 5, 20, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 15, "6", "ResolveProblem Add", "6", "ResolveProblem FF", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 2, 14, 5, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "1", "ResolveProblem Edit", "3", "ResolveProblem OL", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 1, 3, 36, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "9", "ResolveProblem Delete", "14", "ResolveProblem BF", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 1, 2, 4, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, "5", "ResolveProblem Activity Log", "10", "ResolveProblem ZB", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 2, 9, 25, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 29, "8", "ResolveProblem Activity Log", "2", "ResolveProblem TG", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 2, 2, 29, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 20, "10", "ResolveProblem Edit", "6", "ResolveProblem RL", "DE_DIEU", "2", "0", new DateTime(2020, 12, 2, 9, 37, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 21, "8", "ResolveProblem Delete", "7", "ResolveProblem GI", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 2, 17, 29, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, "3", "ResolveProblem Activity Log", "1", "ResolveProblem BX", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 2, 6, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, "2", "ResolveProblem Edit", "13", "ResolveProblem RU", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 2, 24, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, "5", "ResolveProblem Activity Log", "13", "ResolveProblem ST", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 1, 5, 28, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, "2", "ResolveProblem Delete", "13", "ResolveProblem HT", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 3, 2, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "5", "ResolveProblem Add", "9", "ResolveProblem IK", "DE_DIEU", "2", "0", new DateTime(2020, 12, 2, 16, 43, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, "9", "ResolveProblem Edit", "14", "ResolveProblem RF", "DE_DIEU", "4", "1", new DateTime(2020, 12, 1, 12, 38, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 19, "7", "ResolveProblem Edit", "14", "ResolveProblem AQ", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 1, 10, 44, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "6", "Statical Edit", "54", "Statical UL", "DE_DIEU", "4", "1", new DateTime(2020, 12, 1, 4, 11, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 36, "6", "Statical Edit", "52", "Statical YO", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 9, 32, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "10", "Statical Edit", "50", "Statical HZ", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 2, 3, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "9", "Statical Delete", "42", "Statical GL", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 1, 2, 23, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "3", "Statical Edit", "46", "Statical QS", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 1, 14, 47, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 32, "3", "Statical Add", "44", "Statical CF", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 2, 2, 15, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 38, "8", "Statical Activity Log", "56", "Statical EZ", "DE_DIEU", "1", "0", new DateTime(2020, 12, 1, 3, 32, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 34, "10", "Statical Delete", "48", "Statical IX", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 2, 17, 48, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 39, "1", "Statical Edit", "58", "Statical MP", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 2, 10, 27, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 43, "8", "Statical Add", "66", "Statical WJ", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 1, 5, 22, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 41, "9", "Statical Add", "62", "Statical AV", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 2, 7, 30, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 42, "8", "Statical Delete", "64", "Statical VR", "DE_DIEU", "3", "0", new DateTime(2020, 12, 1, 14, 47, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 44, "6", "Statical Delete", "68", "Statical QE", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 1, 2, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 45, "9", "Statical Add", "70", "Statical HE", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 1, 9, 17, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "4", "Statical Add", "72", "Statical IE", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 1, 6, 34, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 47, "5", "Statical Add", "74", "Statical BL", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 2, 6, 10, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, "9", "Statical Edit", "76", "Statical QY", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 2, 17, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "6", "Statical Delete", "40", "Statical SB", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 10, 34, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, "1", "Statical Add", "60", "Statical XO", "DE_DIEU", "1", "0", new DateTime(2020, 12, 1, 5, 39, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, "9", "Statical Edit", "78", "Statical QC", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 1, 7, 47, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 29, "9", "Statical Activity Log", "38", "Statical KD", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 2, 12, 17, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 27, "2", "Statical Edit", "34", "Statical MB", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 6, 12, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 28, "8", "Statical Activity Log", "36", "Statical MZ", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 1, 15, 46, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 10, "10", "Statical Add", "0", "Statical WB", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 6, 25, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "8", "Statical Delete", "2", "Statical DP", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 1, 9, 1, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, "1", "Statical Activity Log", "4", "Statical HA", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 14, 36, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 13, "1", "Statical Add", "6", "Statical XS", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 1, 7, 32, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "10", "Statical Delete", "10", "Statical QP", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 7, 29, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "2", "Statical Edit", "12", "Statical LX", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 2, 3, 41, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "5", "Statical Edit", "14", "Statical XH", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 1, 7, 49, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, "3", "Statical Delete", "8", "Statical HS", "DE_DIEU", "4", "0", new DateTime(2020, 12, 2, 12, 34, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "7", "Statical Add", "18", "Statical GO", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 2, 3, 14, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 18, "2", "Statical Activity Log", "16", "Statical AI", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 2, 3, 37, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, "1", "Statical Activity Log", "30", "Statical LS", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 1, 9, 22, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 24, "3", "Statical Delete", "28", "Statical YO", "DE_DIEU", "1", "0", new DateTime(2020, 12, 1, 2, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 23, "4", "Statical Delete", "26", "Statical NJ", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 2, 3, 2, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "3", "Statical Delete", "32", "Statical UT", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 1, 16, 11, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "4", "Statical Delete", "22", "Statical BB", "DE_DIEU", "2", "1", new DateTime(2020, 12, 2, 7, 18, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 20, "6", "Statical Activity Log", "20", "Statical MP", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 16, 38, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 22, "3", "Statical Edit", "24", "Statical YD", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 2, 8, 2, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 38, "6", "UavConnect Activity Log", "6", "UavConnect UY", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 2, 7, 30, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 32, "5", "UavConnect Delete", "8", "UavConnect EZ", "DE_DIEU", "2", "0", new DateTime(2020, 12, 2, 8, 21, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "6", "UavConnect Delete", "5", "UavConnect XI", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 2, 14, 34, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 34, "8", "UavConnect Delete", "10", "UavConnect VQ", "DE_DIEU", "1", "0", new DateTime(2020, 12, 1, 13, 2, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 35, "1", "UavConnect Delete", "5", "UavConnect XU", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 2, 8, 38, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 36, "6", "UavConnect Activity Log", "2", "UavConnect SM", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 1, 8, 10, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 37, "3", "UavConnect Delete", "7", "UavConnect LE", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 1, 2, 47, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 49, "5", "UavConnect Delete", "11", "UavConnect OJ", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 1, 12, 27, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, "10", "UavConnect Delete", "5", "UavConnect DE", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 2, 16, 49, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, "6", "UavConnect Delete", "11", "UavConnect XL", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 2, 16, 43, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 42, "9", "UavConnect Activity Log", "8", "UavConnect DY", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 1, 15, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 43, "9", "UavConnect Edit", "9", "UavConnect SW", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 1, 21, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "9", "UavConnect Add", "11", "UavConnect CZ", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 2, 17, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, "3", "UavConnect Edit", "11", "UavConnect VV", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 2, 14, 8, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 46, "6", "UavConnect Activity Log", "12", "UavConnect RH", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 2, 13, 43, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 47, "7", "UavConnect Edit", "7", "UavConnect TE", "DE_DIEU", "3", "1", new DateTime(2020, 12, 1, 2, 2, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 48, "10", "UavConnect Add", "6", "UavConnect NL", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 15, 6, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, "1", "UavConnect Activity Log", "11", "UavConnect HH", "DE_DIEU", "1", "0", new DateTime(2020, 12, 2, 15, 15, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 30, "8", "UavConnect Activity Log", "2", "UavConnect XP", "DE_DIEU", "1", "0", new DateTime(2020, 12, 1, 4, 6, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 39, "1", "UavConnect Delete", "11", "UavConnect NF", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 2, 2, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "10", "UavConnect Add", "9", "UavConnect FN", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 2, 6, 44, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "2", "UavConnect Edit", "3", "UavConnect KD", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 1, 6, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, "4", "UavConnect Edit", "14", "UavConnect AI", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 2, 7, 41, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "8", "UavConnect Activity Log", "4", "UavConnect QB", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 14, 6, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 13, "5", "UavConnect Add", "6", "UavConnect UH", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 2, 9, 15, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, "10", "UavConnect Edit", "8", "UavConnect JT", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 1, 9, 39, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 15, "2", "UavConnect Edit", "11", "UavConnect MJ", "DE_DIEU", "2", "1", new DateTime(2020, 12, 1, 8, 30, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 16, "5", "UavConnect Edit", "8", "UavConnect ZY", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 2, 2, 3, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "3", "UavConnect Delete", "7", "UavConnect XP", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 2, 8, 25, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, "4", "UavConnect Activity Log", "8", "UavConnect ML", "DE_DIEU", "1", "0", new DateTime(2020, 12, 1, 1, 31, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 29, "4", "UavConnect Edit", "4", "UavConnect WN", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 9, 16, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, "6", "UavConnect Add", "13", "UavConnect PX", "DE_DIEU", "4", "0", new DateTime(2020, 12, 2, 9, 20, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, "3", "UavConnect Edit", "4", "UavConnect KH", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 2, 2, 42, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 22, "9", "UavConnect Activity Log", "2", "UavConnect DY", "DE_DIEU", "3", "0", new DateTime(2020, 12, 1, 14, 9, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, "9", "UavConnect Activity Log", "12", "UavConnect IO", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 2, 12, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 24, "8", "UavConnect Edit", "2", "UavConnect CU", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 1, 12, 3, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 25, "7", "UavConnect Add", "5", "UavConnect AC", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 2, 15, 15, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 26, "2", "UavConnect Edit", "6", "UavConnect WW", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 2, 13, 34, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "4", "UavConnect Delete", "11", "UavConnect RK", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 15, 33, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "4", "UavConnect Activity Log", "10", "UavConnect BR", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 2, 13, 28, 0, 0, DateTimeKind.Unspecified), 20 }
                });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 38, "6", "User Edit", "10", null, "Meta data example 28", "DE_DIEU", "2", "5", new DateTime(2020, 12, 2, 4, 43, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 37, "7", "User Add", "7", null, "Meta data example 27", "DE_DIEU", "1", "7", new DateTime(2020, 12, 2, 1, 11, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, "9", "User Activity Log", "7", null, "Meta data example 26", "LUOI_DIEN", "4", "14", new DateTime(2020, 12, 2, 5, 35, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 32, "7", "User Delete", "2", null, "Meta data example 22", "CAY_TRONG", "1", "12", new DateTime(2020, 12, 1, 10, 45, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 34, "3", "User Activity Log", "2", null, "Meta data example 24", "CAY_TRONG", "2", "5", new DateTime(2020, 12, 1, 16, 38, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 33, "1", "User Add", "2", null, "Meta data example 23", "LUOI_DIEN", "4", "8", new DateTime(2020, 12, 1, 12, 26, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 39, "9", "User Add", "8", null, "Meta data example 29", "CHAY_RUNG", "3", "8", new DateTime(2020, 12, 2, 5, 43, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, "6", "User Add", "8", null, "Meta data example 25", "CAY_TRONG", "2", "11", new DateTime(2020, 12, 1, 3, 11, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, "8", "User Edit", "5", null, "Meta data example 30", "CAY_TRONG", "2", "7", new DateTime(2020, 12, 2, 8, 30, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "3", "User Delete", "3", null, "Meta data example 34", "CAY_TRONG", "4", "2", new DateTime(2020, 12, 2, 11, 9, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 42, "1", "User Add", "6", null, "Meta data example 32", "CHAY_RUNG", "4", "8", new DateTime(2020, 12, 2, 17, 29, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 43, "5", "User Activity Log", "1", null, "Meta data example 33", "DE_DIEU", "2", "5", new DateTime(2020, 12, 1, 4, 1, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 45, "7", "User Activity Log", "4", null, "Meta data example 35", "LUOI_DIEN", "2", "5", new DateTime(2020, 12, 1, 5, 38, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 46, "8", "User Add", "6", null, "Meta data example 36", "CHAY_RUNG", "2", "3", new DateTime(2020, 12, 1, 14, 39, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 47, "2", "User Delete", "7", null, "Meta data example 37", "DE_DIEU", "1", "2", new DateTime(2020, 12, 1, 7, 28, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 48, "5", "User Add", "8", null, "Meta data example 38", "DE_DIEU", "1", "8", new DateTime(2020, 12, 1, 2, 23, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, "7", "User Edit", "7", null, "Meta data example 39", "LUOI_DIEN", "2", "12", new DateTime(2020, 12, 1, 9, 9, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "1", "User Activity Log", "5", null, "Meta data example 21", "CAY_TRONG", "4", "11", new DateTime(2020, 12, 1, 7, 10, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 41, "7", "User Delete", "9", null, "Meta data example 31", "CHAY_RUNG", "4", "13", new DateTime(2020, 12, 2, 11, 41, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 30, "3", "User Delete", "4", null, "Meta data example 20", "CAY_TRONG", "2", "8", new DateTime(2020, 12, 2, 9, 11, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, "6", "User Edit", "9", null, "Meta data example 19", "CHAY_RUNG", "4", "3", new DateTime(2020, 12, 1, 14, 43, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 28, "10", "User Add", "8", null, "Meta data example 18", "DE_DIEU", "4", "10", new DateTime(2020, 12, 2, 17, 25, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "2", "User Edit", "8", null, "Meta data example 0", "CAY_TRONG", "1", "13", new DateTime(2020, 12, 1, 12, 14, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, "8", "User Edit", "2", null, "Meta data example 1", "DE_DIEU", "2", "4", new DateTime(2020, 12, 2, 2, 3, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "5", "User Edit", "1", null, "Meta data example 2", "CHAY_RUNG", "4", "8", new DateTime(2020, 12, 1, 5, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "7", "User Delete", "5", null, "Meta data example 3", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 2, 14, 13, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 14, "8", "User Delete", "9", null, "Meta data example 4", "CAY_TRONG", "3", "6", new DateTime(2020, 12, 2, 13, 16, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "9", "User Add", "5", null, "Meta data example 6", "LUOI_DIEN", "3", "11", new DateTime(2020, 12, 1, 2, 2, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, "3", "User Activity Log", "5", null, "Meta data example 7", "CAY_TRONG", "4", "12", new DateTime(2020, 12, 1, 4, 11, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "1", "User Add", "5", null, "Meta data example 8", "DE_DIEU", "1", "3", new DateTime(2020, 12, 2, 5, 14, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "1", "User Delete", "8", null, "Meta data example 5", "CHAY_RUNG", "1", "3", new DateTime(2020, 12, 1, 17, 34, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 20, "10", "User Activity Log", "3", null, "Meta data example 10", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 2, 10, 38, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, "3", "User Add", "1", null, "Meta data example 9", "CHAY_RUNG", "3", "5", new DateTime(2020, 12, 2, 1, 21, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 26, "4", "User Add", "2", null, "Meta data example 16", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 2, 15, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "4", "User Edit", "6", null, "Meta data example 15", "DE_DIEU", "4", "8", new DateTime(2020, 12, 2, 10, 27, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, "6", "User Activity Log", "10", null, "Meta data example 14", "CHAY_RUNG", "2", "9", new DateTime(2020, 12, 1, 17, 26, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 27, "6", "User Delete", "3", null, "Meta data example 17", "CAY_TRONG", "1", "14", new DateTime(2020, 12, 1, 12, 39, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, "4", "User Activity Log", "9", null, "Meta data example 12", "LUOI_DIEN", "2", "3", new DateTime(2020, 12, 2, 8, 31, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 21, "5", "User Edit", "8", null, "Meta data example 11", "CHAY_RUNG", "1", "14", new DateTime(2020, 12, 1, 14, 15, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "5", "User Add", "9", null, "Meta data example 13", "CHAY_RUNG", "1", "11", new DateTime(2020, 12, 1, 6, 43, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 39, "3", "Video Activity Log", "3", "28", "5", "Video TL", "DE_DIEU", "1", new DateTime(2020, 12, 2, 13, 43, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 32, "9", "Video Activity Log", "7", "32", "10", "Video BL", "DE_DIEU", "0", new DateTime(2020, 12, 1, 17, 23, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 33, "6", "Video Add", "9", "19", "4", "Video KV", "DE_DIEU", "1", new DateTime(2020, 12, 2, 16, 25, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 34, "6", "Video Activity Log", "3", "18", "14", "Video EP", "DE_DIEU", "0", new DateTime(2020, 12, 2, 4, 3, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 35, "5", "Video Activity Log", "6", "20", "3", "Video UL", "DE_DIEU", "1", new DateTime(2020, 12, 2, 14, 27, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, "5", "Video Edit", "10", "23", "12", "Video OZ", "DE_DIEU", "0", new DateTime(2020, 12, 2, 14, 3, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 37, "7", "Video Add", "2", "9", "4", "Video VE", "DE_DIEU", "1", new DateTime(2020, 12, 2, 9, 44, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 38, "6", "Video Activity Log", "4", "8", "5", "Video IV", "DE_DIEU", "0", new DateTime(2020, 12, 2, 7, 6, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 49, "1", "Video Activity Log", "2", "37", "3", "Video XD", "DE_DIEU", "1", new DateTime(2020, 12, 2, 5, 2, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 48, "9", "Video Edit", "6", "23", "12", "Video GX", "DE_DIEU", "0", new DateTime(2020, 12, 1, 2, 20, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 41, "5", "Video Edit", "1", "36", "11", "Video VE", "DE_DIEU", "1", new DateTime(2020, 12, 2, 17, 16, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 42, "9", "Video Delete", "10", "9", "12", "Video WZ", "DE_DIEU", "0", new DateTime(2020, 12, 2, 8, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 43, "6", "Video Edit", "3", "28", "1", "Video KJ", "DE_DIEU", "1", new DateTime(2020, 12, 2, 15, 33, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "6", "Video Activity Log", "7", "39", "10", "Video QF", "DE_DIEU", "0", new DateTime(2020, 12, 2, 15, 12, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 45, "4", "Video Edit", "2", "12", "11", "Video JY", "DE_DIEU", "1", new DateTime(2020, 12, 1, 11, 39, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 46, "3", "Video Activity Log", "4", "2", "1", "Video HF", "DE_DIEU", "0", new DateTime(2020, 12, 1, 17, 20, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 47, "9", "Video Edit", "1", "31", "10", "Video QH", "DE_DIEU", "1", new DateTime(2020, 12, 1, 4, 49, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "10", "Video Edit", "4", "19", "10", "Video LE", "DE_DIEU", "1", new DateTime(2020, 12, 1, 8, 23, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 40, "5", "Video Add", "2", "1", "3", "Video OH", "DE_DIEU", "0", new DateTime(2020, 12, 2, 9, 41, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 30, "4", "Video Delete", "8", "2", "3", "Video SB", "DE_DIEU", "0", new DateTime(2020, 12, 2, 16, 25, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "4", "Video Edit", "4", "1", "11", "Video UH", "DE_DIEU", "1", new DateTime(2020, 12, 1, 1, 36, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 28, "8", "Video Add", "6", "14", "10", "Video ZC", "DE_DIEU", "0", new DateTime(2020, 12, 2, 4, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "10", "Video Add", "7", "34", "8", "Video WT", "DE_DIEU", "1", new DateTime(2020, 12, 2, 14, 8, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "2", "Video Delete", "6", "40", "9", "Video ZL", "DE_DIEU", "0", new DateTime(2020, 12, 2, 3, 34, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, "10", "Video Edit", "3", "29", "1", "Video EQ", "DE_DIEU", "1", new DateTime(2020, 12, 2, 14, 36, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "5", "Video Delete", "10", "31", "6", "Video WY", "DE_DIEU", "0", new DateTime(2020, 12, 1, 10, 47, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, "10", "Video Add", "9", "37", "1", "Video CA", "DE_DIEU", "1", new DateTime(2020, 12, 1, 10, 7, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "2", "Video Add", "2", "18", "4", "Video AJ", "DE_DIEU", "1", new DateTime(2020, 12, 1, 3, 20, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "8", "Video Delete", "1", "30", "13", "Video MG", "DE_DIEU", "0", new DateTime(2020, 12, 1, 5, 8, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 17, "4", "Video Delete", "1", "27", "9", "Video XG", "DE_DIEU", "1", new DateTime(2020, 12, 1, 5, 45, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 14, "9", "Video Activity Log", "7", "30", "10", "Video WI", "DE_DIEU", "0", new DateTime(2020, 12, 2, 10, 32, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 20, "2", "Video Edit", "1", "7", "4", "Video YH", "DE_DIEU", "0", new DateTime(2020, 12, 2, 3, 5, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 21, "3", "Video Activity Log", "2", "29", "2", "Video KD", "DE_DIEU", "1", new DateTime(2020, 12, 2, 2, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 22, "6", "Video Activity Log", "6", "27", "6", "Video EK", "DE_DIEU", "0", new DateTime(2020, 12, 1, 11, 37, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 27, "2", "Video Delete", "4", "16", "14", "Video DK", "DE_DIEU", "1", new DateTime(2020, 12, 1, 1, 23, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 23, "8", "Video Add", "9", "26", "3", "Video WK", "DE_DIEU", "1", new DateTime(2020, 12, 2, 4, 10, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, "5", "Video Edit", "5", "13", "4", "Video LS", "DE_DIEU", "0", new DateTime(2020, 12, 2, 12, 16, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 25, "6", "Video Add", "10", "29", "5", "Video LH", "DE_DIEU", "1", new DateTime(2020, 12, 2, 11, 11, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 26, "9", "Video Activity Log", "6", "17", "14", "Video QN", "DE_DIEU", "0", new DateTime(2020, 12, 2, 3, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "6", "Video Edit", "8", "13", "8", "Video KI", "DE_DIEU", "0", new DateTime(2020, 12, 2, 12, 46, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 36, "7", "Warning Add", "9", "Warning SJ", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 1, 14, 4, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, "7", "Warning Activity Log", "4", "Warning YH", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 4, 37, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 31, "4", "Warning Activity Log", "5", "Warning EN", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 2, 8, 33, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 33, "9", "Warning Activity Log", "6", "Warning LH", "DE_DIEU", "2", "1", new DateTime(2020, 12, 1, 4, 10, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 32, "5", "Warning Delete", "9", "Warning SA", "DE_DIEU", "3", "0", new DateTime(2020, 12, 1, 13, 41, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 37, "2", "Warning Delete", "1", "Warning TB", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 1, 11, 46, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 34, "5", "Warning Add", "5", "Warning WZ", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 1, 3, 11, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 38, "2", "Warning Activity Log", "3", "Warning DL", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 1, 17, 7, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 47, "4", "Warning Activity Log", "1", "Warning LM", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 2, 16, 21, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 40, "5", "Warning Add", "5", "Warning FQ", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 2, 16, 2, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 41, "10", "Warning Edit", "10", "Warning OT", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 5, 1, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 42, "10", "Warning Activity Log", "6", "Warning YX", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 1, 17, 23, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 43, "10", "Warning Edit", "2", "Warning LA", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 1, 7, 25, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "8", "Warning Delete", "5", "Warning NY", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 1, 38, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 45, "9", "Warning Add", "8", "Warning RL", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 1, 10, 48, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "6", "Warning Activity Log", "4", "Warning GR", "DE_DIEU", "2", "0", new DateTime(2020, 12, 1, 13, 28, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 30, "5", "Warning Activity Log", "9", "Warning CY", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 1, 7, 15, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 39, "2", "Warning Delete", "1", "Warning JZ", "DE_DIEU", "3", "1", new DateTime(2020, 12, 2, 13, 24, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, "7", "Warning Delete", "9", "Warning FM", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 2, 4, 44, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 20, "5", "Warning Activity Log", "9", "Warning SF", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 2, 5, 16, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 27, "3", "Warning Activity Log", "2", "Warning HU", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 2, 3, 26, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 48, "4", "Warning Add", "9", "Warning LI", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 2, 17, 39, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "9", "Warning Delete", "10", "Warning OQ", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 2, 1, 3, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, "7", "Warning Edit", "5", "Warning OT", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 2, 4, 29, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "7", "Warning Add", "9", "Warning KH", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 2, 4, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, "7", "Warning Add", "2", "Warning GM", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, "9", "Warning Delete", "7", "Warning QC", "DE_DIEU", "3", "0", new DateTime(2020, 12, 1, 1, 24, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 15, "4", "Warning Add", "5", "Warning EE", "DE_DIEU", "3", "1", new DateTime(2020, 12, 1, 8, 13, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "8", "Warning Delete", "10", "Warning VW", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 2, 11, 27, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 17, "10", "Warning Activity Log", "5", "Warning JD", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 2, 11, 3, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "2", "Warning Delete", "8", "Warning CW", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 1, 6, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "2", "Warning Add", "7", "Warning LK", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 1, 16, 26, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, "7", "Warning Edit", "5", "Warning QH", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 5, 2, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 22, "9", "Warning Edit", "8", "Warning WB", "DE_DIEU", "2", "0", new DateTime(2020, 12, 2, 4, 43, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "3", "Warning Delete", "8", "Warning VX", "DE_DIEU", "2", "1", new DateTime(2020, 12, 1, 8, 29, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, "8", "Warning Activity Log", "10", "Warning CC", "DE_DIEU", "1", "0", new DateTime(2020, 12, 2, 16, 49, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, "9", "Warning Edit", "8", "Warning SK", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 2, 5, 8, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, "6", "Warning Delete", "4", "Warning KL", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 1, 1, 16, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "10", "Warning Add", "2", "Warning QF", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 2, 13, 19, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, "6", "Warning Activity Log", "1", "Warning ZB", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 1, 10, 22, 0, 0, DateTimeKind.Unspecified), 20 }
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
