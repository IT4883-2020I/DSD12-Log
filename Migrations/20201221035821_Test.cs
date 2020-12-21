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
                    RegionId = table.Column<string>(nullable: true),
                    ProjectId = table.Column<string>(nullable: true)
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
                    ProjectId = table.Column<string>(nullable: true),
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
                    Name = table.Column<string>(nullable: true),
                    ProjectId = table.Column<string>(nullable: true)
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
                    DroneId = table.Column<string>(nullable: true),
                    ProjectId = table.Column<string>(nullable: true)
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
                    DroneId = table.Column<string>(nullable: true),
                    ProjectId = table.Column<string>(nullable: true)
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
                    ProjectId = table.Column<string>(nullable: true),
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
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectId", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 1, "3", "Drone Activity Log", "9", 21, 18, "Drone 3", "4", "CAY_TRONG", "2", "MonitorRegion 4", new DateTime(2020, 12, 1, 4, 3, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, "8", "Drone Add", "7", 43, 21, "Drone 5", "8", "LUOI_DIEN", "1", "MonitorRegion 1", new DateTime(2020, 12, 2, 4, 19, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, "8", "Drone Delete", "9", 27, 44, "Drone 8", "3", "CAY_TRONG", "4", "MonitorRegion 2", new DateTime(2020, 12, 1, 16, 9, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 25, "6", "Drone Activity Log", "4", 33, 43, "Drone 6", "6", "CHAY_RUNG", "3", "MonitorRegion 3", new DateTime(2020, 12, 2, 2, 22, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, "10", "Drone Activity Log", "8", 29, 15, "Drone 10", "3", "CAY_TRONG", "2", "MonitorRegion 2", new DateTime(2020, 12, 2, 12, 49, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 27, "2", "Drone Activity Log", "5", 25, 40, "Drone 4", "8", "LUOI_DIEN", "2", "MonitorRegion 4", new DateTime(2020, 12, 1, 16, 7, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 28, "2", "Drone Add", "10", 32, 49, "Drone 8", "1", "DE_DIEU", "4", "MonitorRegion 4", new DateTime(2020, 12, 2, 12, 8, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "4", "Drone Edit", "1", 13, 39, "Drone 2", "3", "CAY_TRONG", "3", "MonitorRegion 4", new DateTime(2020, 12, 1, 9, 38, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "4", "Drone Edit", "9", 13, 39, "Drone 3", "2", "CAY_TRONG", "2", "MonitorRegion 1", new DateTime(2020, 12, 2, 12, 25, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 32, "2", "Drone Delete", "5", 13, 46, "Drone 3", "3", "CAY_TRONG", "3", "MonitorRegion 1", new DateTime(2020, 12, 1, 13, 37, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "8", "Drone Delete", "6", 19, 40, "Drone 5", "3", "CAY_TRONG", "1", "MonitorRegion 2", new DateTime(2020, 12, 1, 16, 25, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 34, "2", "Drone Activity Log", "1", 20, 13, "Drone 5", "2", "DE_DIEU", "2", "MonitorRegion 4", new DateTime(2020, 12, 2, 1, 28, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 35, "7", "Drone Edit", "5", 20, 25, "Drone 3", "2", "DE_DIEU", "3", "MonitorRegion 4", new DateTime(2020, 12, 1, 10, 30, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 36, "3", "Drone Edit", "8", 31, 39, "Drone 5", "3", "CAY_TRONG", "2", "MonitorRegion 2", new DateTime(2020, 12, 1, 5, 18, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 37, "5", "Drone Edit", "4", 29, 42, "Drone 5", "5", "CHAY_RUNG", "2", "MonitorRegion 2", new DateTime(2020, 12, 1, 5, 28, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 38, "7", "Drone Activity Log", "8", 11, 15, "Drone 9", "1", "DE_DIEU", "1", "MonitorRegion 2", new DateTime(2020, 12, 1, 2, 21, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 39, "10", "Drone Add", "7", 26, 31, "Drone 2", "2", "DE_DIEU", "3", "MonitorRegion 4", new DateTime(2020, 12, 1, 6, 43, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, "7", "Drone Activity Log", "3", 17, 31, "Drone 5", "6", "CHAY_RUNG", "1", "MonitorRegion 2", new DateTime(2020, 12, 1, 7, 20, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 22, "10", "Drone Activity Log", "2", 26, 18, "Drone 9", "4", "CAY_TRONG", "4", "MonitorRegion 2", new DateTime(2020, 12, 1, 2, 6, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 21, "4", "Drone Edit", "7", 42, 20, "Drone 4", "4", "CAY_TRONG", "2", "MonitorRegion 1", new DateTime(2020, 12, 2, 7, 48, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "1", "Drone Add", "7", 33, 38, "Drone 2", "7", "LUOI_DIEN", "2", "MonitorRegion 1", new DateTime(2020, 12, 2, 2, 47, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 19, "6", "Drone Edit", "9", 18, 37, "Drone 3", "1", "DE_DIEU", "1", "MonitorRegion 2", new DateTime(2020, 12, 1, 10, 47, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, "4", "Drone Edit", "9", 35, 45, "Drone 4", "6", "CHAY_RUNG", "1", "MonitorRegion 4", new DateTime(2020, 12, 2, 11, 23, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 2, "3", "Drone Edit", "7", 49, 35, "Drone 4", "5", "CHAY_RUNG", "3", "MonitorRegion 2", new DateTime(2020, 12, 1, 13, 47, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 3, "10", "Drone Delete", "9", 25, 46, "Drone 4", "2", "CAY_TRONG", "3", "MonitorRegion 1", new DateTime(2020, 12, 2, 11, 24, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, "2", "Drone Add", "7", 24, 20, "Drone 7", "2", "CAY_TRONG", "4", "MonitorRegion 2", new DateTime(2020, 12, 2, 15, 37, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 5, "2", "Drone Edit", "1", 27, 40, "Drone 4", "3", "CAY_TRONG", "4", "MonitorRegion 2", new DateTime(2020, 12, 2, 9, 24, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 6, "6", "Drone Edit", "4", 31, 20, "Drone 5", "6", "CHAY_RUNG", "1", "MonitorRegion 4", new DateTime(2020, 12, 1, 12, 18, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 8, "2", "Drone Add", "6", 38, 24, "Drone 8", "2", "DE_DIEU", "3", "MonitorRegion 3", new DateTime(2020, 12, 2, 14, 34, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 9, "3", "Drone Edit", "7", 18, 28, "Drone 5", "4", "CHAY_RUNG", "1", "MonitorRegion 1", new DateTime(2020, 12, 1, 10, 10, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, "3", "Drone Delete", "1", 32, 40, "Drone 8", "5", "CHAY_RUNG", "4", "MonitorRegion 4", new DateTime(2020, 12, 1, 14, 43, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 7, "8", "Drone Activity Log", "9", 44, 21, "Drone 2", "4", "CAY_TRONG", "1", "MonitorRegion 1", new DateTime(2020, 12, 1, 15, 15, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "6", "Drone Delete", "5", 43, 36, "Drone 7", "6", "LUOI_DIEN", "3", "MonitorRegion 3", new DateTime(2020, 12, 1, 17, 31, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, "8", "Drone Edit", "5", 47, 31, "Drone 3", "6", "LUOI_DIEN", "3", "MonitorRegion 4", new DateTime(2020, 12, 1, 7, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "3", "Drone Delete", "7", 44, 33, "Drone 5", "8", "LUOI_DIEN", "2", "MonitorRegion 1", new DateTime(2020, 12, 2, 10, 49, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 14, "1", "Drone Edit", "9", 19, 46, "Drone 2", "4", "CHAY_RUNG", "4", "MonitorRegion 1", new DateTime(2020, 12, 2, 15, 40, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 15, "1", "Drone Delete", "7", 26, 38, "Drone 9", "6", "CHAY_RUNG", "1", "MonitorRegion 4", new DateTime(2020, 12, 2, 1, 22, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "8", "Drone Edit", "3", 27, 17, "Drone 6", "4", "CAY_TRONG", "4", "MonitorRegion 2", new DateTime(2020, 12, 1, 12, 15, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "1", "Drone Delete", "1", 30, 23, "Drone 4", "0", "DE_DIEU", "1", "MonitorRegion 4", new DateTime(2020, 12, 1, 11, 43, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, "9", "Drone Add", "9", 46, 22, "Drone 2", "4", "CHAY_RUNG", "2", "MonitorRegion 1", new DateTime(2020, 12, 2, 12, 13, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectId", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 38, "8", "Image Edit", "6", "18", "5", "Image HJ", "5", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 11, 36, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 37, "8", "Image Add", "10", "22", "1", "Image IM", "5", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 12, 43, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, "1", "Image Add", "8", "15", "7", "Image FB", "8", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 8, 4, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, "7", "Image Add", "1", "16", "2", "Image EL", "1", "DE_DIEU", "0", new DateTime(2020, 12, 1, 13, 11, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 34, "10", "Image Add", "7", "18", "10", "Image NR", "4", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 5, 2, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 33, "10", "Image Activity Log", "8", "27", "12", "Image QX", "3", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 13, 17, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 39, "5", "Image Activity Log", "4", "29", "5", "Image VX", "4", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 10, 48, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 35, "3", "Image Activity Log", "10", "30", "14", "Image KQ", "4", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 1, 36, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 40, "9", "Image Edit", "5", "5", "9", "Image GE", "4", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 9, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 49, "3", "Image Delete", "9", "18", "6", "Image SC", "4", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 4, 21, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 42, "7", "Image Add", "9", "39", "2", "Image QL", "2", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 10, 37, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 43, "8", "Image Edit", "2", "28", "14", "Image NV", "4", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 5, 49, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "1", "Image Activity Log", "2", "17", "9", "Image HS", "2", "DE_DIEU", "0", new DateTime(2020, 12, 1, 2, 7, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 45, "7", "Image Add", "8", "9", "4", "Image VK", "2", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 14, 31, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "9", "Image Delete", "7", "22", "9", "Image LH", "0", "DE_DIEU", "0", new DateTime(2020, 12, 2, 12, 8, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 47, "9", "Image Delete", "8", "23", "1", "Image EI", "0", "DE_DIEU", "1", new DateTime(2020, 12, 1, 16, 23, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 48, "1", "Image Edit", "4", "17", "13", "Image TN", "3", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 10, 9, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "4", "Image Delete", "2", "19", "11", "Image KA", "2", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 1, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, "9", "Image Add", "2", "24", "7", "Image EW", "7", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 17, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 30, "3", "Image Activity Log", "2", "17", "7", "Image VU", "7", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 15, 15, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, "5", "Image Edit", "1", "23", "4", "Image VN", "2", "DE_DIEU", "1", new DateTime(2020, 12, 2, 13, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 28, "5", "Image Add", "1", "39", "4", "Image SC", "0", "DE_DIEU", "0", new DateTime(2020, 12, 1, 3, 37, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "9", "Image Delete", "5", "37", "8", "Image OP", "3", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 16, 37, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, "2", "Image Delete", "10", "40", "5", "Image RA", "4", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 9, 35, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, "10", "Image Delete", "7", "29", "2", "Image PU", "6", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 1, 9, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, "5", "Image Edit", "9", "17", "14", "Image IZ", "6", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 17, 13, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, "1", "Image Add", "4", "17", "5", "Image BR", "8", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 6, 47, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "2", "Image Add", "7", "20", "12", "Image QW", "5", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 15, 25, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "10", "Image Edit", "6", "36", "6", "Image KT", "7", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 11, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "8", "Image Delete", "1", "16", "12", "Image MV", "2", "DE_DIEU", "1", new DateTime(2020, 12, 1, 9, 44, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, "9", "Image Activity Log", "4", "32", "13", "Image BG", "4", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 14, 45, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 10, "6", "Image Add", "9", "11", "9", "Image OE", "2", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 4, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, "10", "Image Delete", "5", "37", "3", "Image HY", "3", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 11, 7, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "9", "Image Add", "6", "7", "12", "Image QS", "8", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 3, 45, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "10", "Image Edit", "8", "25", "3", "Image SS", "0", "DE_DIEU", "0", new DateTime(2020, 12, 1, 9, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "3", "Image Activity Log", "4", "38", "3", "Image SA", "6", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 10, 46, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 24, "3", "Image Activity Log", "4", "23", "10", "Image VQ", "0", "DE_DIEU", "0", new DateTime(2020, 12, 1, 14, 49, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, "4", "Image Edit", "4", "8", "4", "Image AF", "0", "DE_DIEU", "1", new DateTime(2020, 12, 1, 13, 34, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, "3", "Image Delete", "10", "33", "9", "Image IZ", "7", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 15, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "2", "Image Activity Log", "7", "19", "8", "Image YB", "6", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 15, 45, 0, 0, DateTimeKind.Unspecified), 20 }
                });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectId", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 32, "9", "Incident Edit", "9", "Incident IU", "7", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 7, 39, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 33, "6", "Incident Add", "9", "Incident HW", "4", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 1, 16, 42, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 34, "9", "Incident Delete", "11", "Incident RT", "5", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 2, 2, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 35, "4", "Incident Delete", "12", "Incident PC", "4", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 1, 15, 9, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 36, "4", "Incident Add", "10", "Incident KZ", "8", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 15, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 37, "1", "Incident Delete", "14", "Incident HS", "2", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 1, 12, 9, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 38, "2", "Incident Add", "5", "Incident HY", "8", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 2, 15, 29, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, "4", "Incident Edit", "14", "Incident TU", "8", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 10, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "9", "Incident Edit", "5", "Incident EM", "2", "DE_DIEU", "2", "0", new DateTime(2020, 12, 1, 17, 38, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 42, "8", "Incident Add", "6", "Incident UT", "4", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 2, 9, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 43, "3", "Incident Edit", "14", "Incident LP", "8", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 2, 9, 49, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "9", "Incident Activity Log", "1", "Incident SB", "4", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 1, 9, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 45, "6", "Incident Delete", "5", "Incident FQ", "1", "DE_DIEU", "2", "1", new DateTime(2020, 12, 1, 8, 22, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 46, "7", "Incident Edit", "5", "Incident PD", "6", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 1, 8, 44, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 47, "8", "Incident Edit", "1", "Incident LL", "4", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 1, 9, 48, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 48, "2", "Incident Activity Log", "12", "Incident CX", "4", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 1, 11, 11, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 49, "10", "Incident Add", "5", "Incident UL", "1", "DE_DIEU", "4", "1", new DateTime(2020, 12, 1, 10, 33, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 41, "10", "Incident Activity Log", "12", "Incident RO", "3", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 1, 15, 17, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 30, "7", "Incident Delete", "14", "Incident EV", "2", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 1, 15, 27, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 39, "3", "Incident Edit", "6", "Incident MN", "6", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 2, 5, 18, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 28, "10", "Incident Add", "8", "Incident TQ", "6", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 2, 14, 26, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "5", "Incident Delete", "10", "Incident SJ", "4", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 1, 6, 34, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, "4", "Incident Edit", "5", "Incident II", "1", "DE_DIEU", "4", "0", new DateTime(2020, 12, 2, 7, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "10", "Incident Edit", "11", "Incident IT", "6", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 2, 15, 5, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, "5", "Incident Activity Log", "13", "Incident BN", "6", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 1, 16, 41, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 15, "9", "Incident Edit", "10", "Incident NZ", "4", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 1, 13, 3, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 16, "4", "Incident Activity Log", "9", "Incident MN", "6", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 2, 11, 20, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, "6", "Incident Delete", "2", "Incident OS", "7", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 2, 17, 9, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, "1", "Incident Delete", "11", "Incident XW", "2", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 1, 5, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "6", "Incident Edit", "9", "Incident MJ", "3", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 2, 15, 2, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, "4", "Incident Add", "10", "Incident FE", "6", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 1, 9, 7, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, "9", "Incident Activity Log", "2", "Incident GD", "4", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 1, 2, 3, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 21, "4", "Incident Edit", "14", "Incident GK", "5", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 2, 3, 41, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 22, "7", "Incident Add", "8", "Incident RO", "5", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 2, 16, 7, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 23, "4", "Incident Add", "10", "Incident SB", "3", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 2, 4, 10, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, "8", "Incident Activity Log", "14", "Incident MR", "2", "DE_DIEU", "4", "0", new DateTime(2020, 12, 2, 14, 36, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, "1", "Incident Add", "8", "Incident XN", "7", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 2, 7, 12, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 26, "7", "Incident Delete", "13", "Incident UF", "6", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 2, 12, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "7", "Incident Edit", "7", "Incident HN", "2", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 9, 27, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 29, "7", "Incident Delete", "12", "Incident WU", "5", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 2, 15, 2, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 28, "1", "MonitorRegion Edit", "4", "MonitorRegion 4", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 5, 13, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "4", "MonitorRegion Edit", "4", "MonitorRegion 4", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 1, 1, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "3", "MonitorRegion Edit", "2", "MonitorRegion 2", "DE_DIEU", "0", new DateTime(2020, 12, 2, 8, 5, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 25, "5", "MonitorRegion Edit", "3", "MonitorRegion 3", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 11, 40, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, "5", "MonitorRegion Edit", "3", "MonitorRegion 3", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 6, 33, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 29, "4", "MonitorRegion Add", "4", "MonitorRegion 4", "DE_DIEU", "0", new DateTime(2020, 12, 2, 2, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 26, "3", "MonitorRegion Delete", "4", "MonitorRegion 4", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 16, 9, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 30, "4", "MonitorRegion Edit", "1", "MonitorRegion 1", "DE_DIEU", "1", new DateTime(2020, 12, 2, 10, 23, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "7", "MonitorRegion Edit", "4", "MonitorRegion 4", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 9, 1, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 32, "2", "MonitorRegion Add", "4", "MonitorRegion 4", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 11, 3, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 33, "5", "MonitorRegion Activity Log", "4", "MonitorRegion 4", "DE_DIEU", "0", new DateTime(2020, 12, 2, 16, 6, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 34, "10", "MonitorRegion Delete", "3", "MonitorRegion 3", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 13, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 36, "8", "MonitorRegion Activity Log", "3", "MonitorRegion 3", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 7, 32, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 37, "8", "MonitorRegion Add", "4", "MonitorRegion 4", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 16, 21, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 38, "2", "MonitorRegion Activity Log", "1", "MonitorRegion 1", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 6, 3, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 39, "1", "MonitorRegion Edit", "2", "MonitorRegion 2", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 4, 36, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 22, "9", "MonitorRegion Edit", "3", "MonitorRegion 3", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 3, 10, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "4", "MonitorRegion Delete", "4", "MonitorRegion 4", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 17, 24, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "8", "MonitorRegion Activity Log", "1", "MonitorRegion 1", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 17, 27, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 40, "4", "MonitorRegion Add", "2", "MonitorRegion 2", "DE_DIEU", "1", new DateTime(2020, 12, 1, 8, 5, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 19, "3", "MonitorRegion Edit", "4", "MonitorRegion 4", "DE_DIEU", "0", new DateTime(2020, 12, 2, 6, 8, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 1, "10", "MonitorRegion Activity Log", "2", "MonitorRegion 2", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 11, 43, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 2, "9", "MonitorRegion Activity Log", "4", "MonitorRegion 4", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 14, 45, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 3, "6", "MonitorRegion Activity Log", "4", "MonitorRegion 4", "DE_DIEU", "0", new DateTime(2020, 12, 2, 3, 33, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 4, "9", "MonitorRegion Delete", "2", "MonitorRegion 2", "DE_DIEU", "1", new DateTime(2020, 12, 2, 8, 1, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 5, "10", "MonitorRegion Delete", "1", "MonitorRegion 1", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 15, 1, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 6, "6", "MonitorRegion Add", "3", "MonitorRegion 3", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 4, 41, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 7, "3", "MonitorRegion Delete", "1", "MonitorRegion 1", "DE_DIEU", "0", new DateTime(2020, 12, 2, 15, 1, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 8, "5", "MonitorRegion Activity Log", "4", "MonitorRegion 4", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 8, 36, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 9, "4", "MonitorRegion Activity Log", "2", "MonitorRegion 2", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 10, 19, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 20, "3", "MonitorRegion Delete", "2", "MonitorRegion 2", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 2, 12, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, "10", "MonitorRegion Edit", "1", "MonitorRegion 1", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 5, 15, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "7", "MonitorRegion Edit", "2", "MonitorRegion 2", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 14, 40, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "3", "MonitorRegion Add", "4", "MonitorRegion 4", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 10, 33, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, "3", "MonitorRegion Add", "2", "MonitorRegion 2", "DE_DIEU", "1", new DateTime(2020, 12, 1, 1, 11, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "4", "MonitorRegion Activity Log", "2", "MonitorRegion 2", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 5, 46, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 16, "4", "MonitorRegion Add", "3", "MonitorRegion 3", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 10, 3, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, "7", "MonitorRegion Activity Log", "3", "MonitorRegion 3", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 6, 48, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "5", "MonitorRegion Add", "3", "MonitorRegion 3", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 5, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "4", "MonitorRegion Activity Log", "4", "MonitorRegion 4", "DE_DIEU", "1", new DateTime(2020, 12, 2, 11, 31, 0, 0, DateTimeKind.Unspecified), 20 }
                });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "1", "ObjectObserve Delete", "9", "ObjectObserve WN", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 1, 8, 7, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 36, "4", "ObjectObserve Edit", "12", "ObjectObserve AY", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 16, 47, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "6", "ObjectObserve Delete", "10", "ObjectObserve SJ", "DE_DIEU", "3", "1", new DateTime(2020, 12, 1, 1, 34, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, "6", "ObjectObserve Delete", "2", "ObjectObserve PD", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 1, 5, 35, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "3", "ObjectObserve Edit", "3", "ObjectObserve QF", "DE_DIEU", "4", "1", new DateTime(2020, 12, 1, 5, 40, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 32, "2", "ObjectObserve Activity Log", "3", "ObjectObserve AY", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 2, 2, 10, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 38, "10", "ObjectObserve Add", "12", "ObjectObserve WF", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 2, 6, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 34, "6", "ObjectObserve Delete", "17", "ObjectObserve GO", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 1, 3, 6, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 39, "2", "ObjectObserve Add", "5", "ObjectObserve XS", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 7, 39, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 43, "6", "ObjectObserve Add", "3", "ObjectObserve OF", "DE_DIEU", "2", "1", new DateTime(2020, 12, 1, 9, 34, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 41, "10", "ObjectObserve Edit", "3", "ObjectObserve UO", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 1, 2, 38, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 42, "5", "ObjectObserve Activity Log", "19", "ObjectObserve EY", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 2, 14, 10, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 44, "9", "ObjectObserve Add", "1", "ObjectObserve ZU", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 2, 15, 17, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, "4", "ObjectObserve Add", "9", "ObjectObserve MR", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 1, 7, 47, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "10", "ObjectObserve Delete", "8", "ObjectObserve YC", "DE_DIEU", "4", "0", new DateTime(2020, 12, 2, 12, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 47, "8", "ObjectObserve Edit", "5", "ObjectObserve MW", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 1, 8, 26, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 48, "10", "ObjectObserve Add", "5", "ObjectObserve XW", "DE_DIEU", "2", "0", new DateTime(2020, 12, 1, 2, 49, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 30, "6", "ObjectObserve Add", "16", "ObjectObserve SS", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 1, 8, 45, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, "8", "ObjectObserve Delete", "8", "ObjectObserve TN", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 1, 12, 7, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 49, "2", "ObjectObserve Add", "15", "ObjectObserve IT", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 2, 5, 11, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "10", "ObjectObserve Activity Log", "3", "ObjectObserve XE", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 1, 8, 11, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 27, "10", "ObjectObserve Activity Log", "4", "ObjectObserve XY", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 2, 34, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 28, "3", "ObjectObserve Delete", "8", "ObjectObserve UC", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 2, 6, 35, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, "2", "ObjectObserve Add", "16", "ObjectObserve ZW", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 2, 15, 26, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "7", "ObjectObserve Delete", "19", "ObjectObserve JN", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 1, 16, 41, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, "10", "ObjectObserve Add", "17", "ObjectObserve QZ", "DE_DIEU", "2", "0", new DateTime(2020, 12, 2, 12, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, "8", "ObjectObserve Add", "14", "ObjectObserve GU", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 1, 16, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "7", "ObjectObserve Delete", "13", "ObjectObserve RD", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 1, 7, 42, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "9", "ObjectObserve Add", "19", "ObjectObserve VB", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 2, 6, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, "2", "ObjectObserve Delete", "10", "ObjectObserve XW", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 1, 3, 4, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 14, "1", "ObjectObserve Delete", "18", "ObjectObserve LZ", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 1, 6, 39, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "5", "ObjectObserve Delete", "12", "ObjectObserve YO", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 1, 13, 48, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, "5", "ObjectObserve Delete", "13", "ObjectObserve EI", "DE_DIEU", "3", "0", new DateTime(2020, 12, 2, 13, 21, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 25, "10", "ObjectObserve Delete", "17", "ObjectObserve GA", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 14, 6, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, "4", "ObjectObserve Edit", "11", "ObjectObserve NJ", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 1, 9, 3, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "3", "ObjectObserve Activity Log", "13", "ObjectObserve HP", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 1, 4, 24, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, "4", "ObjectObserve Delete", "5", "ObjectObserve LL", "DE_DIEU", "2", "0", new DateTime(2020, 12, 2, 11, 43, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "9", "ObjectObserve Delete", "7", "ObjectObserve ML", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 3, 38, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 20, "8", "ObjectObserve Edit", "2", "ObjectObserve CA", "DE_DIEU", "1", "0", new DateTime(2020, 12, 2, 4, 39, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 22, "1", "ObjectObserve Edit", "10", "ObjectObserve LU", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 1, 11, 29, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectId", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 38, "8", "Payload Edit", "2", "10", "Payload JZ", "6", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 3, 9, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 32, "10", "Payload Edit", "2", "7", "Payload YP", "4", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 12, 21, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 33, "8", "Payload Activity Log", "2", "2", "Payload OB", "3", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 15, 49, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 34, "9", "Payload Activity Log", "3", "9", "Payload XT", "1", "DE_DIEU", "0", new DateTime(2020, 12, 1, 5, 40, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 35, "9", "Payload Add", "10", "6", "Payload IF", "0", "DE_DIEU", "1", new DateTime(2020, 12, 1, 7, 26, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, "5", "Payload Edit", "6", "10", "Payload YA", "3", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 11, 44, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 37, "5", "Payload Edit", "1", "6", "Payload GN", "3", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 8, 28, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 39, "3", "Payload Activity Log", "6", "7", "Payload UH", "4", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 5, 5, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 31, "10", "Payload Add", "2", "3", "Payload IA", "0", "DE_DIEU", "1", new DateTime(2020, 12, 2, 15, 22, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 41, "6", "Payload Delete", "5", "10", "Payload DC", "3", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 2, 18, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 42, "7", "Payload Activity Log", "3", "1", "Payload JZ", "7", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 5, 31, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 43, "1", "Payload Edit", "10", "10", "Payload GU", "4", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 12, 15, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "9", "Payload Add", "4", "5", "Payload JA", "1", "DE_DIEU", "0", new DateTime(2020, 12, 1, 17, 27, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, "9", "Payload Add", "1", "9", "Payload PR", "7", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 1, 42, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "7", "Payload Edit", "10", "1", "Payload YN", "3", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 1, 39, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 47, "2", "Payload Add", "10", "9", "Payload HY", "4", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 9, 44, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, "8", "Payload Edit", "9", "7", "Payload PV", "5", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 16, 40, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 40, "9", "Payload Delete", "8", "4", "Payload NP", "4", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 1, 11, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 30, "2", "Payload Delete", "6", "1", "Payload BZ", "8", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 4, 31, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 49, "1", "Payload Delete", "8", "1", "Payload LZ", "2", "DE_DIEU", "1", new DateTime(2020, 12, 1, 16, 34, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "3", "Payload Add", "4", "9", "Payload WK", "8", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 3, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "5", "Payload Edit", "6", "3", "Payload YH", "4", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 6, 32, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, "1", "Payload Edit", "10", "5", "Payload JO", "2", "DE_DIEU", "1", new DateTime(2020, 12, 2, 9, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "6", "Payload Edit", "8", "4", "Payload CT", "5", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 10, 23, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "3", "Payload Delete", "6", "10", "Payload PU", "6", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 13, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 14, "1", "Payload Activity Log", "3", "9", "Payload SQ", "6", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 11, 15, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 15, "1", "Payload Add", "7", "3", "Payload NZ", "6", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 12, 7, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "8", "Payload Delete", "3", "8", "Payload YV", "6", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 7, 10, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 17, "6", "Payload Edit", "6", "3", "Payload NI", "4", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 17, 12, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 18, "7", "Payload Activity Log", "7", "8", "Payload TH", "4", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 15, 10, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 29, "7", "Payload Activity Log", "3", "5", "Payload XP", "5", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 9, 33, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 20, "3", "Payload Activity Log", "5", "4", "Payload PG", "2", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 5, 22, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 21, "2", "Payload Activity Log", "4", "10", "Payload DS", "6", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 4, 36, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 22, "1", "Payload Delete", "5", "2", "Payload MZ", "2", "DE_DIEU", "0", new DateTime(2020, 12, 1, 13, 44, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 23, "7", "Payload Delete", "8", "4", "Payload ET", "1", "DE_DIEU", "1", new DateTime(2020, 12, 1, 11, 38, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, "9", "Payload Delete", "1", "1", "Payload IQ", "6", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 8, 15, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 25, "1", "Payload Activity Log", "3", "10", "Payload TQ", "8", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 17, 35, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, "7", "Payload Delete", "5", "10", "Payload OF", "0", "DE_DIEU", "0", new DateTime(2020, 12, 2, 8, 3, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "2", "Payload Edit", "7", "2", "Payload PG", "7", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 3, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 19, "1", "Payload Edit", "2", "10", "Payload CT", "6", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 17, 39, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "10", "ResolveProblem Activity Log", "7", "ResolveProblem VY", "DE_DIEU", "2", "1", new DateTime(2020, 12, 2, 14, 16, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, "9", "ResolveProblem Delete", "6", "ResolveProblem HX", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 1, 8, 33, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 32, "8", "ResolveProblem Edit", "4", "ResolveProblem CB", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 2, 10, 8, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "10", "ResolveProblem Activity Log", "5", "ResolveProblem KK", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 2, 7, 42, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 33, "10", "ResolveProblem Delete", "14", "ResolveProblem IR", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 2, 29, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 38, "9", "ResolveProblem Edit", "8", "ResolveProblem WP", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 1, 3, 9, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "2", "ResolveProblem Edit", "2", "ResolveProblem DZ", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 1, 5, 23, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 39, "3", "ResolveProblem Add", "12", "ResolveProblem ST", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 8, 10, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 44, "5", "ResolveProblem Add", "4", "ResolveProblem LF", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 1, 9, 27, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 41, "2", "ResolveProblem Edit", "7", "ResolveProblem NX", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 13, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 42, "5", "ResolveProblem Activity Log", "4", "ResolveProblem BX", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 2, 7, 14, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 43, "1", "ResolveProblem Delete", "10", "ResolveProblem QP", "DE_DIEU", "2", "1", new DateTime(2020, 12, 1, 14, 15, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 45, "2", "ResolveProblem Activity Log", "6", "ResolveProblem GX", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 17, 4, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 46, "10", "ResolveProblem Add", "5", "ResolveProblem BT", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 1, 6, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 47, "4", "ResolveProblem Add", "3", "ResolveProblem GE", "DE_DIEU", "4", "1", new DateTime(2020, 12, 1, 12, 47, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, "3", "ResolveProblem Activity Log", "2", "ResolveProblem UB", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 2, 11, 5, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 31, "2", "ResolveProblem Edit", "5", "ResolveProblem SQ", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 7, 2, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 40, "2", "ResolveProblem Add", "9", "ResolveProblem EE", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 1, 11, 33, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 30, "3", "ResolveProblem Edit", "12", "ResolveProblem WC", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 2, 15, 8, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 49, "4", "ResolveProblem Add", "14", "ResolveProblem FW", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 15, 10, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 28, "6", "ResolveProblem Edit", "2", "ResolveProblem XF", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 2, 5, 39, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, "7", "ResolveProblem Activity Log", "14", "ResolveProblem TX", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 16, 29, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 11, "1", "ResolveProblem Activity Log", "12", "ResolveProblem IO", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 1, 1, 1, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 12, "7", "ResolveProblem Edit", "2", "ResolveProblem QT", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 2, 2, 19, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "2", "ResolveProblem Edit", "14", "ResolveProblem OD", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 1, 11, 47, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, "2", "ResolveProblem Delete", "2", "ResolveProblem SQ", "DE_DIEU", "2", "0", new DateTime(2020, 12, 2, 11, 24, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 15, "1", "ResolveProblem Add", "3", "ResolveProblem IE", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 2, 11, 32, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "10", "ResolveProblem Edit", "7", "ResolveProblem EP", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 2, 14, 10, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "7", "ResolveProblem Activity Log", "12", "ResolveProblem OI", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 3, 24, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "3", "ResolveProblem Edit", "11", "ResolveProblem PX", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 2, 9, 23, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 29, "3", "ResolveProblem Edit", "4", "ResolveProblem LS", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 1, 7, 27, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, "5", "ResolveProblem Activity Log", "3", "ResolveProblem XN", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 2, 11, 9, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 21, "7", "ResolveProblem Delete", "1", "ResolveProblem RF", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 8, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, "2", "ResolveProblem Activity Log", "7", "ResolveProblem QK", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 2, 1, 43, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, "7", "ResolveProblem Add", "14", "ResolveProblem TA", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 1, 17, 38, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, "5", "ResolveProblem Activity Log", "14", "ResolveProblem PZ", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 2, 12, 3, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, "7", "ResolveProblem Delete", "14", "ResolveProblem RC", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 2, 15, 27, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "5", "ResolveProblem Activity Log", "3", "ResolveProblem OM", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 1, 11, 36, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 27, "4", "ResolveProblem Add", "3", "ResolveProblem HL", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 2, 8, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 19, "10", "ResolveProblem Edit", "12", "ResolveProblem NA", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 2, 16, 6, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "9", "Statical Add", "54", "Statical HW", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 2, 12, 39, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, "10", "Statical Edit", "52", "Statical BI", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 1, 11, 43, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "4", "Statical Edit", "50", "Statical IG", "DE_DIEU", "3", "1", new DateTime(2020, 12, 2, 1, 42, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "1", "Statical Edit", "42", "Statical HW", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 1, 16, 47, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 33, "1", "Statical Edit", "46", "Statical QJ", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 2, 16, 38, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 32, "3", "Statical Edit", "44", "Statical GY", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 1, 7, 47, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 38, "9", "Statical Add", "56", "Statical SG", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 1, 11, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 34, "1", "Statical Add", "48", "Statical WJ", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 1, 17, 49, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 39, "7", "Statical Delete", "58", "Statical WY", "DE_DIEU", "2", "1", new DateTime(2020, 12, 2, 8, 34, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 43, "6", "Statical Delete", "66", "Statical YB", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 2, 14, 35, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, "9", "Statical Add", "62", "Statical GM", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 6, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 42, "5", "Statical Delete", "64", "Statical PD", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 1, 6, 30, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 44, "4", "Statical Delete", "68", "Statical TX", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 2, 9, 37, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 45, "5", "Statical Delete", "70", "Statical XP", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 9, 44, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 46, "7", "Statical Add", "72", "Statical TB", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 1, 15, 28, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 47, "3", "Statical Activity Log", "74", "Statical OO", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 2, 3, 8, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 48, "8", "Statical Delete", "76", "Statical PT", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 2, 9, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 30, "8", "Statical Edit", "40", "Statical AI", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 1, 8, 29, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 40, "10", "Statical Activity Log", "60", "Statical YF", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 1, 16, 17, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 49, "1", "Statical Delete", "78", "Statical LP", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 2, 3, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, "7", "Statical Add", "38", "Statical QO", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 1, 14, 34, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, "10", "Statical Activity Log", "34", "Statical LL", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 2, 15, 19, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 28, "5", "Statical Delete", "36", "Statical JB", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 1, 10, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, "3", "Statical Activity Log", "0", "Statical SD", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 1, 1, 13, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 11, "8", "Statical Add", "2", "Statical EX", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 2, 11, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, "9", "Statical Edit", "4", "Statical SL", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 1, 17, 35, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "6", "Statical Activity Log", "6", "Statical PN", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 1, 13, 33, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 15, "8", "Statical Edit", "10", "Statical FW", "DE_DIEU", "3", "1", new DateTime(2020, 12, 1, 15, 22, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 16, "2", "Statical Edit", "12", "Statical XJ", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 2, 3, 23, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "6", "Statical Edit", "14", "Statical RZ", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 2, 6, 2, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, "6", "Statical Delete", "8", "Statical HM", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 1, 4, 38, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "10", "Statical Edit", "18", "Statical JW", "DE_DIEU", "2", "1", new DateTime(2020, 12, 2, 8, 16, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 18, "8", "Statical Edit", "16", "Statical PG", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 2, 16, 21, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 25, "10", "Statical Edit", "30", "Statical HF", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 1, 1, 32, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, "1", "Statical Add", "28", "Statical KJ", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 2, 9, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 23, "3", "Statical Activity Log", "26", "Statical NU", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 2, 4, 47, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, "1", "Statical Delete", "32", "Statical NS", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 1, 11, 4, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "8", "Statical Add", "22", "Statical IV", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 2, 5, 47, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, "10", "Statical Edit", "20", "Statical SW", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 1, 14, 10, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 22, "3", "Statical Add", "24", "Statical VU", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 1, 2, 19, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectId", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 38, "6", "UavConnect Edit", "6", "8", "UavConnect EI", "3", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 9, 16, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 32, "3", "UavConnect Delete", "3", "1", "UavConnect BS", "0", "DE_DIEU", "0", new DateTime(2020, 12, 1, 15, 27, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "10", "UavConnect Edit", "4", "6", "UavConnect BB", "6", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 8, 24, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "9", "UavConnect Delete", "2", "11", "UavConnect SJ", "1", "DE_DIEU", "0", new DateTime(2020, 12, 1, 13, 16, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 35, "3", "UavConnect Delete", "9", "12", "UavConnect RN", "6", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 14, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 36, "6", "UavConnect Delete", "4", "12", "UavConnect JQ", "4", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 2, 41, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 37, "8", "UavConnect Edit", "1", "4", "UavConnect MG", "3", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 14, 37, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 49, "8", "UavConnect Add", "10", "14", "UavConnect KM", "4", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 10, 9, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 31, "10", "UavConnect Add", "1", "6", "UavConnect RY", "5", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 12, 42, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 41, "9", "UavConnect Delete", "10", "3", "UavConnect TW", "1", "DE_DIEU", "1", new DateTime(2020, 12, 1, 8, 6, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 42, "4", "UavConnect Activity Log", "7", "12", "UavConnect WW", "5", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 17, 9, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 43, "5", "UavConnect Delete", "10", "4", "UavConnect JC", "4", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 4, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 44, "4", "UavConnect Edit", "8", "5", "UavConnect AN", "5", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 13, 34, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 45, "7", "UavConnect Activity Log", "5", "14", "UavConnect IR", "2", "DE_DIEU", "1", new DateTime(2020, 12, 2, 10, 44, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 46, "8", "UavConnect Add", "9", "1", "UavConnect UR", "8", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 1, 26, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 47, "3", "UavConnect Activity Log", "3", "1", "UavConnect LW", "6", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 16, 32, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 48, "10", "UavConnect Activity Log", "4", "3", "UavConnect PA", "4", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 8, 44, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 40, "6", "UavConnect Edit", "1", "9", "UavConnect NM", "4", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 16, 40, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "10", "UavConnect Delete", "9", "5", "UavConnect MH", "3", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 12, 43, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 39, "6", "UavConnect Delete", "8", "3", "UavConnect UY", "8", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 15, 42, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "8", "UavConnect Delete", "4", "11", "UavConnect JM", "2", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 6, 43, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, "10", "UavConnect Add", "6", "11", "UavConnect NJ", "4", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 2, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "9", "UavConnect Delete", "2", "12", "UavConnect KE", "4", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 6, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, "2", "UavConnect Delete", "3", "2", "UavConnect DW", "0", "DE_DIEU", "0", new DateTime(2020, 12, 1, 14, 7, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, "6", "UavConnect Edit", "6", "4", "UavConnect RC", "7", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 14, 23, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, "9", "UavConnect Add", "5", "1", "UavConnect AQ", "3", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 13, 21, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "2", "UavConnect Delete", "1", "5", "UavConnect UK", "4", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 1, 26, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "9", "UavConnect Edit", "2", "2", "UavConnect SP", "5", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 2, 43, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "2", "UavConnect Edit", "1", "2", "UavConnect BR", "2", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 5, 23, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 18, "8", "UavConnect Add", "4", "3", "UavConnect UX", "6", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 5, 44, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "9", "UavConnect Edit", "4", "13", "UavConnect GP", "7", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 13, 3, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, "2", "UavConnect Activity Log", "6", "2", "UavConnect TV", "1", "DE_DIEU", "0", new DateTime(2020, 12, 1, 16, 5, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 21, "1", "UavConnect Add", "7", "10", "UavConnect HC", "5", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 4, 29, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "1", "UavConnect Add", "7", "6", "UavConnect TB", "2", "DE_DIEU", "0", new DateTime(2020, 12, 2, 10, 13, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 23, "6", "UavConnect Add", "6", "1", "UavConnect ID", "5", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 13, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, "5", "UavConnect Add", "3", "12", "UavConnect NJ", "2", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 15, 24, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "4", "UavConnect Edit", "1", "14", "UavConnect DG", "6", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 8, 22, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, "8", "UavConnect Edit", "10", "7", "UavConnect OA", "6", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 3, 12, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "10", "UavConnect Edit", "4", "11", "UavConnect KN", "6", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 11, 12, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 19, "7", "UavConnect Add", "8", "2", "UavConnect VS", "4", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 16, 20, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 38, "9", "User Add", "3", null, "Meta data example 28", "CAY_TRONG", "3", "9", new DateTime(2020, 12, 1, 17, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 37, "3", "User Activity Log", "8", null, "Meta data example 27", "DE_DIEU", "3", "11", new DateTime(2020, 12, 1, 7, 7, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, "2", "User Add", "4", null, "Meta data example 26", "DE_DIEU", "2", "7", new DateTime(2020, 12, 1, 15, 7, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, "3", "User Add", "10", null, "Meta data example 22", "LUOI_DIEN", "3", "6", new DateTime(2020, 12, 1, 3, 15, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 34, "7", "User Edit", "5", null, "Meta data example 24", "LUOI_DIEN", "1", "5", new DateTime(2020, 12, 2, 5, 8, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 33, "3", "User Activity Log", "4", null, "Meta data example 23", "DE_DIEU", "3", "11", new DateTime(2020, 12, 1, 6, 7, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 39, "3", "User Edit", "3", null, "Meta data example 29", "CHAY_RUNG", "1", "14", new DateTime(2020, 12, 2, 9, 14, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "10", "User Delete", "1", null, "Meta data example 25", "LUOI_DIEN", "1", "2", new DateTime(2020, 12, 2, 6, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, "10", "User Add", "3", null, "Meta data example 30", "LUOI_DIEN", "4", "12", new DateTime(2020, 12, 1, 7, 9, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 44, "3", "User Activity Log", "9", null, "Meta data example 34", "CAY_TRONG", "3", "2", new DateTime(2020, 12, 2, 1, 24, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 42, "4", "User Activity Log", "3", null, "Meta data example 32", "CHAY_RUNG", "4", "9", new DateTime(2020, 12, 2, 11, 29, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 43, "6", "User Delete", "5", null, "Meta data example 33", "DE_DIEU", "4", "2", new DateTime(2020, 12, 1, 8, 15, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 45, "8", "User Add", "4", null, "Meta data example 35", "LUOI_DIEN", "3", "4", new DateTime(2020, 12, 1, 16, 19, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "8", "User Add", "6", null, "Meta data example 36", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 2, 13, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 47, "1", "User Delete", "1", null, "Meta data example 37", "LUOI_DIEN", "4", "2", new DateTime(2020, 12, 2, 14, 29, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 48, "6", "User Delete", "5", null, "Meta data example 38", "CAY_TRONG", "4", "12", new DateTime(2020, 12, 1, 13, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 49, "10", "User Delete", "6", null, "Meta data example 39", "CAY_TRONG", "1", "3", new DateTime(2020, 12, 2, 1, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, "8", "User Activity Log", "6", null, "Meta data example 21", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 5, 37, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 41, "10", "User Add", "5", null, "Meta data example 31", "DE_DIEU", "2", "7", new DateTime(2020, 12, 1, 13, 40, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 30, "6", "User Delete", "5", null, "Meta data example 20", "CAY_TRONG", "1", "9", new DateTime(2020, 12, 2, 1, 34, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, "10", "User Delete", "8", null, "Meta data example 19", "CHAY_RUNG", "3", "14", new DateTime(2020, 12, 1, 8, 22, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "10", "User Add", "9", null, "Meta data example 18", "CHAY_RUNG", "2", "7", new DateTime(2020, 12, 2, 12, 49, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "7", "User Delete", "4", null, "Meta data example 0", "DE_DIEU", "3", "3", new DateTime(2020, 12, 2, 4, 4, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, "7", "User Edit", "8", null, "Meta data example 1", "LUOI_DIEN", "2", "14", new DateTime(2020, 12, 2, 1, 14, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "7", "User Delete", "9", null, "Meta data example 2", "DE_DIEU", "2", "11", new DateTime(2020, 12, 2, 11, 12, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, "4", "User Delete", "9", null, "Meta data example 3", "LUOI_DIEN", "2", "10", new DateTime(2020, 12, 1, 2, 35, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 14, "5", "User Add", "10", null, "Meta data example 4", "LUOI_DIEN", "2", "9", new DateTime(2020, 12, 1, 4, 27, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "7", "User Edit", "6", null, "Meta data example 6", "LUOI_DIEN", "1", "10", new DateTime(2020, 12, 2, 1, 14, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "3", "User Add", "9", null, "Meta data example 7", "CAY_TRONG", "1", "6", new DateTime(2020, 12, 1, 4, 2, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 18, "2", "User Activity Log", "6", null, "Meta data example 8", "CAY_TRONG", "3", "12", new DateTime(2020, 12, 1, 10, 18, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 15, "8", "User Activity Log", "8", null, "Meta data example 5", "LUOI_DIEN", "4", "12", new DateTime(2020, 12, 2, 13, 32, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 20, "1", "User Activity Log", "5", null, "Meta data example 10", "CHAY_RUNG", "3", "4", new DateTime(2020, 12, 2, 6, 28, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, "10", "User Add", "4", null, "Meta data example 9", "DE_DIEU", "1", "5", new DateTime(2020, 12, 2, 17, 43, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 26, "2", "User Activity Log", "6", null, "Meta data example 16", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 1, 14, 25, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, "4", "User Activity Log", "6", null, "Meta data example 15", "DE_DIEU", "2", "3", new DateTime(2020, 12, 2, 8, 10, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 24, "8", "User Delete", "3", null, "Meta data example 14", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 1, 15, 39, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "2", "User Activity Log", "3", null, "Meta data example 17", "LUOI_DIEN", "2", "11", new DateTime(2020, 12, 2, 11, 36, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 22, "6", "User Delete", "8", null, "Meta data example 12", "CHAY_RUNG", "2", "12", new DateTime(2020, 12, 1, 11, 34, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "8", "User Edit", "6", null, "Meta data example 11", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 1, 16, 8, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "7", "User Edit", "9", null, "Meta data example 13", "CHAY_RUNG", "3", "3", new DateTime(2020, 12, 2, 15, 14, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectId", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 39, "8", "Video Edit", "6", "12", "6", "Video RH", "6", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 14, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 32, "7", "Video Activity Log", "3", "28", "1", "Video WP", "4", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 7, 25, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 33, "9", "Video Delete", "8", "25", "13", "Video UB", "4", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 9, 41, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 34, "8", "Video Add", "6", "36", "4", "Video LD", "4", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 6, 15, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, "5", "Video Edit", "10", "18", "10", "Video XY", "4", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 11, 38, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 36, "6", "Video Delete", "9", "25", "12", "Video DX", "5", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 9, 22, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 37, "9", "Video Edit", "2", "24", "12", "Video GI", "6", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 13, 10, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 38, "7", "Video Activity Log", "1", "11", "2", "Video XL", "4", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 8, 40, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 49, "7", "Video Add", "3", "14", "10", "Video ZO", "5", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 17, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, "1", "Video Delete", "8", "10", "8", "Video SP", "6", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 14, 43, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, "1", "Video Activity Log", "7", "24", "1", "Video CN", "6", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 16, 44, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 42, "6", "Video Delete", "7", "29", "10", "Video DC", "4", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 13, 36, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 43, "9", "Video Delete", "4", "25", "5", "Video QK", "6", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 13, 43, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 44, "10", "Video Activity Log", "6", "21", "13", "Video GM", "4", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 17, 41, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 45, "2", "Video Delete", "7", "22", "14", "Video JC", "5", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 2, 43, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 46, "9", "Video Add", "10", "30", "10", "Video ZV", "5", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 14, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 47, "5", "Video Activity Log", "3", "22", "7", "Video OU", "5", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 6, 8, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 31, "3", "Video Activity Log", "4", "26", "2", "Video MO", "4", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 14, 28, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 40, "4", "Video Edit", "5", "35", "12", "Video LI", "4", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 4, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "3", "Video Delete", "7", "5", "9", "Video WL", "4", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 11, 48, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "3", "Video Activity Log", "5", "20", "13", "Video PK", "5", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 10, 3, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 28, "7", "Video Edit", "5", "23", "13", "Video SR", "6", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 17, 5, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 29, "3", "Video Add", "6", "1", "6", "Video XE", "6", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 11, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "9", "Video Edit", "7", "12", "14", "Video EJ", "5", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 7, 41, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, "5", "Video Edit", "6", "20", "5", "Video JJ", "4", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 7, 7, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "2", "Video Edit", "2", "34", "9", "Video AJ", "4", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 9, 5, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "1", "Video Activity Log", "2", "2", "2", "Video NU", "6", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 10, 27, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 15, "1", "Video Add", "2", "23", "1", "Video HA", "5", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 2, 25, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "4", "Video Activity Log", "9", "11", "12", "Video MM", "4", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 14, 22, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, "10", "Video Activity Log", "1", "19", "3", "Video MJ", "4", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 5, 37, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 14, "10", "Video Add", "4", "15", "14", "Video OS", "4", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 14, 21, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, "1", "Video Delete", "10", "23", "6", "Video YX", "6", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 17, 12, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "3", "Video Delete", "5", "2", "9", "Video ZI", "4", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 5, 35, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, "6", "Video Delete", "3", "9", "8", "Video FY", "4", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 5, 26, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "6", "Video Delete", "6", "25", "9", "Video NG", "5", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 4, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 23, "6", "Video Delete", "5", "32", "2", "Video JU", "4", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 9, 34, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, "3", "Video Add", "10", "24", "9", "Video OY", "4", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 9, 49, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "9", "Video Edit", "4", "12", "1", "Video GP", "4", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 5, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, "3", "Video Edit", "6", "18", "5", "Video HM", "5", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 6, 48, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 18, "7", "Video Edit", "5", "32", "12", "Video EC", "5", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 12, 35, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 36, "9", "Warning Edit", "8", "Warning PF", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 2, 15, 3, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "1", "Warning Activity Log", "1", "Warning RE", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 1, 14, 19, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 31, "2", "Warning Activity Log", "4", "Warning DF", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 1, 8, 33, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 33, "3", "Warning Delete", "4", "Warning PO", "DE_DIEU", "2", "1", new DateTime(2020, 12, 1, 15, 2, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 32, "2", "Warning Edit", "3", "Warning PG", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 1, 15, 32, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 37, "1", "Warning Activity Log", "7", "Warning FY", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 2, 10, 30, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 34, "8", "Warning Edit", "2", "Warning TQ", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 1, 5, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 38, "2", "Warning Activity Log", "1", "Warning NL", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 2, 8, 48, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 47, "1", "Warning Edit", "10", "Warning TO", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 2, 14, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 40, "3", "Warning Activity Log", "5", "Warning JC", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 1, 11, 49, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 41, "10", "Warning Activity Log", "9", "Warning XS", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 1, 11, 12, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 42, "3", "Warning Add", "8", "Warning ZB", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 2, 11, 13, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 43, "10", "Warning Delete", "4", "Warning TC", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 6, 25, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 44, "10", "Warning Add", "1", "Warning BK", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 2, 9, 13, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, "4", "Warning Delete", "7", "Warning NU", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 2, 16, 13, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 46, "10", "Warning Activity Log", "5", "Warning AG", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 2, 17, 33, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 30, "9", "Warning Delete", "5", "Warning MY", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 2, 10, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 39, "7", "Warning Edit", "5", "Warning SY", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 17, 49, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 29, "8", "Warning Delete", "8", "Warning DY", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 1, 9, 28, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 20, "10", "Warning Edit", "6", "Warning ZE", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 2, 9, 47, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "8", "Warning Add", "9", "Warning NP", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 1, 9, 8, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, "6", "Warning Edit", "6", "Warning JH", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 2, 2, 1, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, "9", "Warning Edit", "3", "Warning EK", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 1, 7, 39, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, "2", "Warning Add", "7", "Warning WS", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 2, 17, 38, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, "6", "Warning Add", "7", "Warning WP", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 2, 2, 4, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, "3", "Warning Activity Log", "9", "Warning ES", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 3, 1, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 14, "10", "Warning Add", "3", "Warning DD", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 2, 2, 37, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "1", "Warning Delete", "8", "Warning UO", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 2, 9, 39, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "9", "Warning Activity Log", "6", "Warning VU", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 2, 8, 47, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, "6", "Warning Edit", "10", "Warning JC", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 2, 2, 23, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 18, "1", "Warning Activity Log", "2", "Warning YK", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 1, 8, 2, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, "6", "Warning Edit", "7", "Warning YQ", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 1, 13, 41, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 21, "7", "Warning Edit", "5", "Warning WT", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 2, 8, 22, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 22, "6", "Warning Edit", "2", "Warning FW", "DE_DIEU", "4", "0", new DateTime(2020, 12, 2, 8, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "4", "Warning Add", "10", "Warning EA", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 1, 14, 47, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, "9", "Warning Activity Log", "2", "Warning FP", "DE_DIEU", "1", "0", new DateTime(2020, 12, 2, 12, 45, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, "4", "Warning Delete", "9", "Warning SK", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 1, 7, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "8", "Warning Delete", "4", "Warning AV", "DE_DIEU", "4", "0", new DateTime(2020, 12, 2, 3, 42, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "6", "Warning Activity Log", "4", "Warning YV", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 1, 9, 15, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 49, "4", "Warning Activity Log", "2", "Warning FP", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 2, 5, 49, 0, 0, DateTimeKind.Unspecified), 20 }
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
