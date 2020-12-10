using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace aspnetcoreapp.Migrations
{
    public partial class First : Migration
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
                    EntityId = table.Column<int>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    RegionName = table.Column<string>(nullable: true),
                    Longitude = table.Column<int>(nullable: false),
                    Latitude = table.Column<int>(nullable: false),
                    RegionId = table.Column<int>(nullable: false)
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
                    EntityId = table.Column<int>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Link = table.Column<string>(nullable: true),
                    DroneId = table.Column<int>(nullable: false)
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
                    EntityId = table.Column<int>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    RegionId = table.Column<int>(nullable: false),
                    ImageId = table.Column<int>(nullable: false),
                    VideoId = table.Column<int>(nullable: false),
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
                    EntityId = table.Column<int>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
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
                    EntityId = table.Column<int>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    RegionId = table.Column<int>(nullable: false)
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
                    EntityId = table.Column<int>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    DroneId = table.Column<int>(nullable: false)
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
                    EntityId = table.Column<int>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    RegionId = table.Column<int>(nullable: false),
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
                    EntityId = table.Column<int>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    RegionId = table.Column<int>(nullable: false),
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
                    EntityId = table.Column<int>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    DroneId = table.Column<int>(nullable: false)
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
                    EntityId = table.Column<int>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    Metadata = table.Column<string>(nullable: true),
                    RegionId = table.Column<int>(nullable: false),
                    IncidentId = table.Column<int>(nullable: false),
                    ResolveProblemId = table.Column<int>(nullable: false)
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
                    EntityId = table.Column<int>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    DroneId = table.Column<int>(nullable: false),
                    Link = table.Column<string>(nullable: true)
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
                    EntityId = table.Column<int>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    RegionId = table.Column<int>(nullable: false)
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
                    { 1, 8, "Drone Delete", 3, 17, 19, "Drone 10", "DE_DIEU", 2, "MonitorRegion 4", new DateTime(2020, 12, 1, 14, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 23, 1, "Drone Edit", 3, 16, 14, "Drone 6", "CAY_TRONG", 2, "MonitorRegion 4", new DateTime(2020, 12, 2, 7, 36, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, 9, "Drone Edit", 3, 25, 48, "Drone 8", "DE_DIEU", 2, "MonitorRegion 1", new DateTime(2020, 12, 2, 11, 33, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 25, 7, "Drone Edit", 10, 16, 31, "Drone 1", "CHAY_RUNG", 3, "MonitorRegion 1", new DateTime(2020, 12, 2, 13, 10, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, 5, "Drone Activity Log", 6, 10, 18, "Drone 9", "LUOI_DIEN", 2, "MonitorRegion 1", new DateTime(2020, 12, 1, 16, 41, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 27, 5, "Drone Activity Log", 9, 20, 29, "Drone 9", "CAY_TRONG", 2, "MonitorRegion 3", new DateTime(2020, 12, 1, 15, 28, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 28, 2, "Drone Add", 6, 34, 44, "Drone 5", "CHAY_RUNG", 4, "MonitorRegion 1", new DateTime(2020, 12, 1, 2, 27, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, 3, "Drone Add", 5, 40, 12, "Drone 9", "LUOI_DIEN", 1, "MonitorRegion 3", new DateTime(2020, 12, 2, 16, 2, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 31, 5, "Drone Edit", 2, 33, 17, "Drone 8", "CAY_TRONG", 3, "MonitorRegion 2", new DateTime(2020, 12, 1, 8, 7, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 32, 7, "Drone Delete", 6, 28, 20, "Drone 6", "CHAY_RUNG", 3, "MonitorRegion 2", new DateTime(2020, 12, 2, 17, 18, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, 2, "Drone Delete", 7, 33, 21, "Drone 2", "CHAY_RUNG", 3, "MonitorRegion 2", new DateTime(2020, 12, 2, 2, 17, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 34, 6, "Drone Delete", 5, 17, 20, "Drone 4", "CHAY_RUNG", 2, "MonitorRegion 3", new DateTime(2020, 12, 1, 4, 6, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 35, 9, "Drone Delete", 10, 25, 16, "Drone 8", "CHAY_RUNG", 3, "MonitorRegion 3", new DateTime(2020, 12, 2, 8, 8, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 36, 5, "Drone Delete", 5, 29, 43, "Drone 10", "CHAY_RUNG", 4, "MonitorRegion 1", new DateTime(2020, 12, 2, 6, 8, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 37, 5, "Drone Activity Log", 3, 37, 34, "Drone 4", "DE_DIEU", 2, "MonitorRegion 1", new DateTime(2020, 12, 1, 8, 26, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 38, 8, "Drone Add", 2, 20, 36, "Drone 8", "LUOI_DIEN", 4, "MonitorRegion 3", new DateTime(2020, 12, 1, 6, 22, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 39, 3, "Drone Edit", 7, 23, 29, "Drone 1", "DE_DIEU", 1, "MonitorRegion 1", new DateTime(2020, 12, 2, 6, 13, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 40, 3, "Drone Edit", 10, 18, 15, "Drone 9", "CAY_TRONG", 1, "MonitorRegion 4", new DateTime(2020, 12, 1, 2, 12, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 22, 5, "Drone Activity Log", 4, 13, 32, "Drone 9", "DE_DIEU", 2, "MonitorRegion 1", new DateTime(2020, 12, 1, 6, 14, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 21, 6, "Drone Edit", 5, 22, 33, "Drone 4", "LUOI_DIEN", 4, "MonitorRegion 1", new DateTime(2020, 12, 2, 13, 36, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, 1, "Drone Add", 9, 38, 33, "Drone 8", "CHAY_RUNG", 3, "MonitorRegion 3", new DateTime(2020, 12, 1, 15, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 19, 8, "Drone Activity Log", 3, 19, 31, "Drone 5", "CHAY_RUNG", 1, "MonitorRegion 1", new DateTime(2020, 12, 2, 11, 49, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 20, 8, "Drone Add", 3, 36, 15, "Drone 8", "LUOI_DIEN", 1, "MonitorRegion 1", new DateTime(2020, 12, 1, 3, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 2, 1, "Drone Activity Log", 7, 26, 34, "Drone 7", "LUOI_DIEN", 4, "MonitorRegion 2", new DateTime(2020, 12, 1, 2, 43, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 3, 5, "Drone Add", 9, 39, 18, "Drone 7", "CHAY_RUNG", 3, "MonitorRegion 2", new DateTime(2020, 12, 1, 12, 3, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 4, 5, "Drone Delete", 5, 28, 26, "Drone 5", "DE_DIEU", 4, "MonitorRegion 1", new DateTime(2020, 12, 1, 5, 27, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 5, 10, "Drone Activity Log", 5, 46, 47, "Drone 4", "CAY_TRONG", 4, "MonitorRegion 1", new DateTime(2020, 12, 2, 8, 33, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 6, 5, "Drone Delete", 7, 35, 31, "Drone 10", "CHAY_RUNG", 4, "MonitorRegion 2", new DateTime(2020, 12, 1, 11, 24, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 8, 7, "Drone Delete", 6, 14, 20, "Drone 1", "CHAY_RUNG", 3, "MonitorRegion 3", new DateTime(2020, 12, 1, 11, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 9, 3, "Drone Add", 8, 27, 13, "Drone 7", "DE_DIEU", 2, "MonitorRegion 2", new DateTime(2020, 12, 1, 8, 33, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, 10, "Drone Delete", 1, 18, 39, "Drone 3", "LUOI_DIEN", 1, "MonitorRegion 2", new DateTime(2020, 12, 1, 1, 17, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 7, 8, "Drone Add", 5, 15, 42, "Drone 3", "LUOI_DIEN", 1, "MonitorRegion 1", new DateTime(2020, 12, 2, 13, 17, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 18, 6, "Drone Edit", 1, 41, 27, "Drone 7", "CAY_TRONG", 3, "MonitorRegion 2", new DateTime(2020, 12, 1, 15, 23, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, 1, "Drone Add", 1, 10, 48, "Drone 6", "CHAY_RUNG", 3, "MonitorRegion 3", new DateTime(2020, 12, 1, 6, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, 2, "Drone Edit", 10, 11, 45, "Drone 8", "DE_DIEU", 1, "MonitorRegion 1", new DateTime(2020, 12, 2, 17, 5, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, 4, "Drone Delete", 9, 49, 27, "Drone 5", "DE_DIEU", 4, "MonitorRegion 3", new DateTime(2020, 12, 2, 12, 16, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 15, 5, "Drone Delete", 6, 34, 35, "Drone 4", "CAY_TRONG", 4, "MonitorRegion 3", new DateTime(2020, 12, 1, 8, 10, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, 6, "Drone Activity Log", 10, 38, 18, "Drone 6", "CHAY_RUNG", 4, "MonitorRegion 4", new DateTime(2020, 12, 1, 8, 27, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, 4, "Drone Add", 4, 48, 41, "Drone 7", "DE_DIEU", 3, "MonitorRegion 4", new DateTime(2020, 12, 2, 9, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, 2, "Drone Add", 2, 33, 41, "Drone 10", "LUOI_DIEN", 2, "MonitorRegion 2", new DateTime(2020, 12, 2, 16, 9, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 38, 3, "Image Edit", 5, 29, "Image IT", "DE_DIEU", "0", new DateTime(2020, 12, 2, 17, 40, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 37, 8, "Image Edit", 6, 33, "Image GO", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 12, 48, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 36, 8, "Image Add", 1, 32, "Image OA", "DE_DIEU", "0", new DateTime(2020, 12, 2, 6, 22, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, 4, "Image Add", 8, 6, "Image EP", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 11, 22, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 34, 8, "Image Activity Log", 4, 34, "Image WK", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 15, 13, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 33, 10, "Image Add", 6, 32, "Image GS", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 11, 8, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 39, 3, "Image Edit", 5, 13, "Image UZ", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 8, 30, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, 5, "Image Add", 8, 35, "Image VY", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 10, 4, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, 9, "Image Edit", 4, 26, "Image QO", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 8, 40, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 49, 7, "Image Edit", 2, 37, "Image PW", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 12, 44, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 42, 5, "Image Add", 5, 40, "Image GW", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 10, 39, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 43, 3, "Image Activity Log", 4, 26, "Image YO", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 3, 28, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 44, 1, "Image Delete", 1, 35, "Image LU", "DE_DIEU", "0", new DateTime(2020, 12, 1, 10, 33, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 45, 4, "Image Add", 6, 21, "Image YQ", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 13, 30, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, 7, "Image Add", 6, 18, "Image HH", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 16, 43, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 47, 9, "Image Edit", 4, 29, "Image GA", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 13, 32, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 48, 2, "Image Activity Log", 8, 11, "Image ID", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 15, 24, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 31, 1, "Image Delete", 2, 28, "Image EK", "DE_DIEU", "1", new DateTime(2020, 12, 1, 7, 38, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, 8, "Image Edit", 2, 40, "Image BN", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 12, 43, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, 8, "Image Activity Log", 5, 11, "Image KE", "DE_DIEU", "0", new DateTime(2020, 12, 2, 4, 16, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, 6, "Image Activity Log", 8, 4, "Image PN", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 5, 19, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 28, 5, "Image Delete", 6, 31, "Image DN", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 15, 7, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, 7, "Image Delete", 8, 37, "Image OX", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 16, 26, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, 6, "Image Add", 7, 26, "Image QK", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 16, 28, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, 10, "Image Delete", 6, 3, "Image TV", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 6, 18, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, 10, "Image Delete", 7, 14, "Image RG", "DE_DIEU", "1", new DateTime(2020, 12, 1, 17, 10, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 14, 5, "Image Add", 10, 37, "Image RJ", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 3, 32, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, 4, "Image Add", 7, 13, "Image VM", "DE_DIEU", "1", new DateTime(2020, 12, 1, 4, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, 10, "Image Activity Log", 4, 16, "Image HG", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 9, 14, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, 1, "Image Delete", 7, 8, "Image ZH", "DE_DIEU", "1", new DateTime(2020, 12, 2, 2, 28, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, 7, "Image Edit", 10, 28, "Image TM", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 7, 48, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, 3, "Image Edit", 5, 35, "Image MO", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 7, 3, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, 5, "Image Delete", 1, 39, "Image GC", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 12, 41, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, 7, "Image Add", 1, 13, "Image CE", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 15, 29, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, 2, "Image Activity Log", 3, 2, "Image DM", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 5, 37, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, 4, "Image Activity Log", 4, 13, "Image XG", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 13, 11, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 24, 9, "Image Edit", 8, 18, "Image BG", "DE_DIEU", "0", new DateTime(2020, 12, 1, 8, 37, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 25, 4, "Image Add", 10, 27, "Image SX", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 5, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 26, 4, "Image Edit", 10, 5, "Image AU", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 12, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, 10, "Image Activity Log", 5, 18, "Image ML", "DE_DIEU", "1", new DateTime(2020, 12, 1, 5, 22, 0, 0, DateTimeKind.Unspecified), 20 }
                });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "ImageId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type", "VideoId" },
                values: new object[,]
                {
                    { 32, 5, "Incident Add", 7, 5, "Incident RF", "DE_DIEU", 2, "0", new DateTime(2020, 12, 2, 2, 1, 0, 0, DateTimeKind.Unspecified), 2, 6 },
                    { 33, 2, "Incident Activity Log", 13, 10, "Incident KS", "CHAY_RUNG", 3, "1", new DateTime(2020, 12, 1, 14, 46, 0, 0, DateTimeKind.Unspecified), 20, 16 },
                    { 34, 7, "Incident Edit", 3, 3, "Incident XQ", "LUOI_DIEN", 1, "0", new DateTime(2020, 12, 1, 17, 43, 0, 0, DateTimeKind.Unspecified), 4, 15 },
                    { 35, 9, "Incident Add", 1, 28, "Incident UG", "LUOI_DIEN", 2, "1", new DateTime(2020, 12, 2, 3, 27, 0, 0, DateTimeKind.Unspecified), 2, 27 },
                    { 36, 10, "Incident Add", 4, 31, "Incident XE", "CAY_TRONG", 1, "0", new DateTime(2020, 12, 2, 1, 39, 0, 0, DateTimeKind.Unspecified), 2, 27 },
                    { 37, 6, "Incident Add", 3, 13, "Incident AH", "DE_DIEU", 1, "1", new DateTime(2020, 12, 1, 2, 39, 0, 0, DateTimeKind.Unspecified), 2, 38 },
                    { 38, 5, "Incident Edit", 6, 13, "Incident JZ", "CAY_TRONG", 2, "0", new DateTime(2020, 12, 1, 2, 42, 0, 0, DateTimeKind.Unspecified), 4, 40 },
                    { 40, 10, "Incident Delete", 9, 30, "Incident CU", "DE_DIEU", 4, "0", new DateTime(2020, 12, 1, 2, 33, 0, 0, DateTimeKind.Unspecified), 3, 25 },
                    { 44, 8, "Incident Add", 2, 5, "Incident YC", "CAY_TRONG", 1, "0", new DateTime(2020, 12, 1, 7, 40, 0, 0, DateTimeKind.Unspecified), 2, 27 },
                    { 42, 10, "Incident Activity Log", 11, 39, "Incident DR", "CAY_TRONG", 1, "0", new DateTime(2020, 12, 2, 16, 12, 0, 0, DateTimeKind.Unspecified), 20, 1 },
                    { 43, 10, "Incident Activity Log", 6, 29, "Incident KB", "CAY_TRONG", 1, "1", new DateTime(2020, 12, 2, 5, 27, 0, 0, DateTimeKind.Unspecified), 20, 26 },
                    { 31, 3, "Incident Delete", 9, 4, "Incident KR", "LUOI_DIEN", 3, "1", new DateTime(2020, 12, 2, 12, 9, 0, 0, DateTimeKind.Unspecified), 3, 3 },
                    { 45, 8, "Incident Activity Log", 9, 33, "Incident YM", "CHAY_RUNG", 4, "1", new DateTime(2020, 12, 1, 7, 35, 0, 0, DateTimeKind.Unspecified), 20, 29 },
                    { 46, 3, "Incident Edit", 4, 17, "Incident YQ", "CHAY_RUNG", 3, "0", new DateTime(2020, 12, 1, 14, 38, 0, 0, DateTimeKind.Unspecified), 4, 30 },
                    { 47, 9, "Incident Edit", 7, 38, "Incident NZ", "DE_DIEU", 3, "1", new DateTime(2020, 12, 2, 11, 21, 0, 0, DateTimeKind.Unspecified), 4, 12 },
                    { 48, 1, "Incident Edit", 2, 21, "Incident DB", "CHAY_RUNG", 4, "0", new DateTime(2020, 12, 1, 5, 37, 0, 0, DateTimeKind.Unspecified), 4, 12 },
                    { 49, 7, "Incident Add", 10, 11, "Incident WA", "CHAY_RUNG", 4, "1", new DateTime(2020, 12, 1, 10, 29, 0, 0, DateTimeKind.Unspecified), 2, 13 },
                    { 41, 5, "Incident Edit", 4, 25, "Incident WN", "LUOI_DIEN", 2, "1", new DateTime(2020, 12, 2, 4, 28, 0, 0, DateTimeKind.Unspecified), 4, 12 },
                    { 30, 5, "Incident Delete", 12, 39, "Incident BL", "DE_DIEU", 1, "0", new DateTime(2020, 12, 2, 15, 9, 0, 0, DateTimeKind.Unspecified), 3, 10 },
                    { 39, 2, "Incident Add", 4, 33, "Incident AQ", "DE_DIEU", 4, "1", new DateTime(2020, 12, 1, 16, 31, 0, 0, DateTimeKind.Unspecified), 2, 9 },
                    { 28, 4, "Incident Add", 13, 39, "Incident KZ", "DE_DIEU", 1, "0", new DateTime(2020, 12, 1, 16, 21, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 11, 5, "Incident Delete", 3, 15, "Incident UY", "DE_DIEU", 1, "1", new DateTime(2020, 12, 2, 8, 3, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 12, 4, "Incident Activity Log", 6, 21, "Incident GQ", "LUOI_DIEN", 4, "0", new DateTime(2020, 12, 2, 10, 37, 0, 0, DateTimeKind.Unspecified), 20, 13 },
                    { 13, 5, "Incident Delete", 3, 11, "Incident AO", "CHAY_RUNG", 4, "1", new DateTime(2020, 12, 1, 13, 34, 0, 0, DateTimeKind.Unspecified), 3, 39 },
                    { 14, 3, "Incident Activity Log", 9, 11, "Incident HG", "LUOI_DIEN", 4, "0", new DateTime(2020, 12, 1, 10, 44, 0, 0, DateTimeKind.Unspecified), 20, 26 },
                    { 15, 3, "Incident Add", 4, 39, "Incident IY", "CAY_TRONG", 4, "1", new DateTime(2020, 12, 1, 1, 15, 0, 0, DateTimeKind.Unspecified), 2, 12 },
                    { 16, 7, "Incident Add", 6, 8, "Incident GL", "LUOI_DIEN", 4, "0", new DateTime(2020, 12, 2, 5, 23, 0, 0, DateTimeKind.Unspecified), 2, 4 },
                    { 17, 1, "Incident Delete", 14, 35, "Incident IW", "LUOI_DIEN", 4, "1", new DateTime(2020, 12, 2, 9, 16, 0, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 18, 9, "Incident Delete", 11, 9, "Incident XQ", "DE_DIEU", 2, "0", new DateTime(2020, 12, 1, 8, 23, 0, 0, DateTimeKind.Unspecified), 3, 40 },
                    { 19, 2, "Incident Activity Log", 9, 27, "Incident VD", "CAY_TRONG", 1, "1", new DateTime(2020, 12, 2, 7, 39, 0, 0, DateTimeKind.Unspecified), 20, 30 },
                    { 10, 8, "Incident Activity Log", 5, 32, "Incident HP", "DE_DIEU", 3, "0", new DateTime(2020, 12, 2, 16, 29, 0, 0, DateTimeKind.Unspecified), 20, 22 },
                    { 20, 3, "Incident Activity Log", 14, 22, "Incident IJ", "LUOI_DIEN", 4, "0", new DateTime(2020, 12, 2, 10, 34, 0, 0, DateTimeKind.Unspecified), 20, 7 },
                    { 21, 9, "Incident Add", 2, 26, "Incident BL", "CHAY_RUNG", 1, "1", new DateTime(2020, 12, 1, 10, 25, 0, 0, DateTimeKind.Unspecified), 2, 8 },
                    { 22, 9, "Incident Activity Log", 11, 29, "Incident QJ", "LUOI_DIEN", 1, "0", new DateTime(2020, 12, 1, 3, 48, 0, 0, DateTimeKind.Unspecified), 20, 39 },
                    { 23, 4, "Incident Add", 8, 26, "Incident PH", "DE_DIEU", 1, "1", new DateTime(2020, 12, 2, 7, 43, 0, 0, DateTimeKind.Unspecified), 2, 35 },
                    { 24, 10, "Incident Edit", 1, 16, "Incident BQ", "CHAY_RUNG", 4, "0", new DateTime(2020, 12, 2, 16, 35, 0, 0, DateTimeKind.Unspecified), 4, 15 },
                    { 25, 4, "Incident Edit", 14, 35, "Incident TL", "CHAY_RUNG", 3, "1", new DateTime(2020, 12, 1, 11, 7, 0, 0, DateTimeKind.Unspecified), 4, 9 },
                    { 26, 6, "Incident Edit", 9, 25, "Incident NN", "CHAY_RUNG", 1, "0", new DateTime(2020, 12, 2, 10, 21, 0, 0, DateTimeKind.Unspecified), 4, 32 },
                    { 27, 3, "Incident Edit", 7, 39, "Incident JD", "DE_DIEU", 4, "1", new DateTime(2020, 12, 2, 12, 12, 0, 0, DateTimeKind.Unspecified), 4, 26 },
                    { 29, 9, "Incident Edit", 13, 35, "Incident WW", "CAY_TRONG", 2, "1", new DateTime(2020, 12, 1, 8, 2, 0, 0, DateTimeKind.Unspecified), 4, 21 }
                });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 28, 2, "MonitorRegion Delete", 2, "MonitorRegion 2", "DE_DIEU", "1", new DateTime(2020, 12, 2, 8, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, 2, "MonitorRegion Edit", 3, "MonitorRegion 3", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 7, 9, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, 6, "MonitorRegion Add", 1, "MonitorRegion 1", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 9, 33, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, 2, "MonitorRegion Add", 4, "MonitorRegion 4", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 17, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, 10, "MonitorRegion Edit", 3, "MonitorRegion 3", "DE_DIEU", "1", new DateTime(2020, 12, 2, 11, 40, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 29, 3, "MonitorRegion Activity Log", 4, "MonitorRegion 4", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 5, 44, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, 10, "MonitorRegion Add", 3, "MonitorRegion 3", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 8, 45, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 30, 1, "MonitorRegion Add", 2, "MonitorRegion 2", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 8, 9, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, 9, "MonitorRegion Add", 2, "MonitorRegion 2", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 12, 34, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, 7, "MonitorRegion Activity Log", 2, "MonitorRegion 2", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 3, 41, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 33, 1, "MonitorRegion Edit", 4, "MonitorRegion 4", "DE_DIEU", "0", new DateTime(2020, 12, 1, 16, 36, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, 1, "MonitorRegion Delete", 3, "MonitorRegion 3", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 5, 12, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 36, 10, "MonitorRegion Edit", 1, "MonitorRegion 1", "DE_DIEU", "1", new DateTime(2020, 12, 2, 5, 5, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 37, 9, "MonitorRegion Add", 4, "MonitorRegion 4", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 15, 43, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 38, 8, "MonitorRegion Delete", 3, "MonitorRegion 3", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 4, 44, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 39, 7, "MonitorRegion Edit", 3, "MonitorRegion 3", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 15, 3, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 22, 5, "MonitorRegion Activity Log", 4, "MonitorRegion 4", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 6, 35, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 31, 8, "MonitorRegion Edit", 3, "MonitorRegion 3", "DE_DIEU", "0", new DateTime(2020, 12, 1, 8, 47, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 21, 8, "MonitorRegion Delete", 1, "MonitorRegion 1", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 9, 28, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, 9, "MonitorRegion Activity Log", 2, "MonitorRegion 2", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 9, 6, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, 2, "MonitorRegion Edit", 3, "MonitorRegion 3", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 5, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 1, 5, "MonitorRegion Edit", 4, "MonitorRegion 4", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 2, 35, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 2, 7, "MonitorRegion Activity Log", 4, "MonitorRegion 4", "DE_DIEU", "1", new DateTime(2020, 12, 1, 3, 8, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 3, 4, "MonitorRegion Activity Log", 1, "MonitorRegion 1", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 12, 47, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 4, 3, "MonitorRegion Delete", 2, "MonitorRegion 2", "DE_DIEU", "1", new DateTime(2020, 12, 1, 12, 36, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 5, 1, "MonitorRegion Edit", 4, "MonitorRegion 4", "DE_DIEU", "0", new DateTime(2020, 12, 2, 2, 6, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 6, 4, "MonitorRegion Delete", 4, "MonitorRegion 4", "DE_DIEU", "1", new DateTime(2020, 12, 1, 1, 35, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 7, 9, "MonitorRegion Delete", 3, "MonitorRegion 3", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 1, 47, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 8, 8, "MonitorRegion Activity Log", 3, "MonitorRegion 3", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 17, 34, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 9, 1, "MonitorRegion Delete", 4, "MonitorRegion 4", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 16, 18, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 20, 8, "MonitorRegion Edit", 3, "MonitorRegion 3", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 5, 12, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, 7, "MonitorRegion Add", 4, "MonitorRegion 4", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 17, 23, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, 3, "MonitorRegion Delete", 4, "MonitorRegion 4", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 8, 7, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, 1, "MonitorRegion Delete", 3, "MonitorRegion 3", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 4, 26, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 14, 8, "MonitorRegion Edit", 1, "MonitorRegion 1", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 6, 2, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 15, 10, "MonitorRegion Edit", 2, "MonitorRegion 2", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 2, 43, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 16, 2, "MonitorRegion Activity Log", 3, "MonitorRegion 3", "DE_DIEU", "1", new DateTime(2020, 12, 1, 13, 22, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, 1, "MonitorRegion Add", 3, "MonitorRegion 3", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 6, 22, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 18, 6, "MonitorRegion Activity Log", 1, "MonitorRegion 1", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 1, 12, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 10, 4, "MonitorRegion Delete", 1, "MonitorRegion 1", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 3, 46, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, 1, "ObjectObserve Delete", 10, "ObjectObserve IF", "CAY_TRONG", 1, "1", new DateTime(2020, 12, 1, 14, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 36, 10, "ObjectObserve Delete", 13, "ObjectObserve AQ", "CAY_TRONG", 4, "0", new DateTime(2020, 12, 2, 11, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 35, 6, "ObjectObserve Edit", 9, "ObjectObserve AG", "DE_DIEU", 2, "1", new DateTime(2020, 12, 1, 6, 28, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, 10, "ObjectObserve Delete", 17, "ObjectObserve PO", "CHAY_RUNG", 4, "1", new DateTime(2020, 12, 2, 13, 48, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, 7, "ObjectObserve Add", 4, "ObjectObserve RI", "LUOI_DIEN", 4, "1", new DateTime(2020, 12, 2, 16, 43, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, 10, "ObjectObserve Delete", 16, "ObjectObserve YA", "CAY_TRONG", 2, "0", new DateTime(2020, 12, 2, 15, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 38, 2, "ObjectObserve Edit", 9, "ObjectObserve NT", "CAY_TRONG", 4, "0", new DateTime(2020, 12, 2, 13, 43, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, 6, "ObjectObserve Delete", 13, "ObjectObserve KX", "CHAY_RUNG", 4, "0", new DateTime(2020, 12, 2, 12, 7, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 39, 5, "ObjectObserve Add", 10, "ObjectObserve BA", "CAY_TRONG", 2, "1", new DateTime(2020, 12, 1, 1, 45, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 43, 8, "ObjectObserve Add", 15, "ObjectObserve OE", "DE_DIEU", 2, "1", new DateTime(2020, 12, 1, 1, 6, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 41, 2, "ObjectObserve Add", 15, "ObjectObserve AV", "LUOI_DIEN", 3, "1", new DateTime(2020, 12, 2, 14, 32, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 42, 6, "ObjectObserve Edit", 7, "ObjectObserve DW", "CHAY_RUNG", 4, "0", new DateTime(2020, 12, 2, 10, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, 9, "ObjectObserve Add", 17, "ObjectObserve LX", "DE_DIEU", 4, "0", new DateTime(2020, 12, 1, 14, 8, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, 2, "ObjectObserve Activity Log", 9, "ObjectObserve NO", "CHAY_RUNG", 3, "1", new DateTime(2020, 12, 2, 10, 33, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 46, 3, "ObjectObserve Add", 5, "ObjectObserve AF", "DE_DIEU", 2, "0", new DateTime(2020, 12, 1, 14, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 47, 3, "ObjectObserve Add", 20, "ObjectObserve FN", "DE_DIEU", 3, "1", new DateTime(2020, 12, 2, 14, 8, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, 1, "ObjectObserve Activity Log", 17, "ObjectObserve KU", "DE_DIEU", 4, "0", new DateTime(2020, 12, 1, 10, 26, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 30, 3, "ObjectObserve Activity Log", 15, "ObjectObserve CG", "DE_DIEU", 4, "0", new DateTime(2020, 12, 2, 6, 9, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 40, 7, "ObjectObserve Add", 20, "ObjectObserve UC", "DE_DIEU", 1, "0", new DateTime(2020, 12, 2, 8, 5, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, 4, "ObjectObserve Add", 4, "ObjectObserve UB", "LUOI_DIEN", 3, "1", new DateTime(2020, 12, 1, 8, 48, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, 6, "ObjectObserve Edit", 6, "ObjectObserve OO", "CAY_TRONG", 2, "1", new DateTime(2020, 12, 2, 14, 16, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, 4, "ObjectObserve Activity Log", 16, "ObjectObserve ZB", "DE_DIEU", 1, "1", new DateTime(2020, 12, 1, 6, 7, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 28, 5, "ObjectObserve Edit", 19, "ObjectObserve GH", "CHAY_RUNG", 2, "0", new DateTime(2020, 12, 2, 12, 18, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, 10, "ObjectObserve Edit", 2, "ObjectObserve ZR", "CAY_TRONG", 2, "0", new DateTime(2020, 12, 2, 5, 34, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, 8, "ObjectObserve Edit", 15, "ObjectObserve II", "LUOI_DIEN", 3, "1", new DateTime(2020, 12, 1, 10, 39, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, 5, "ObjectObserve Activity Log", 10, "ObjectObserve BA", "CHAY_RUNG", 2, "0", new DateTime(2020, 12, 2, 6, 13, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 13, 3, "ObjectObserve Add", 6, "ObjectObserve HR", "LUOI_DIEN", 2, "1", new DateTime(2020, 12, 2, 3, 6, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, 9, "ObjectObserve Add", 6, "ObjectObserve ZB", "DE_DIEU", 4, "1", new DateTime(2020, 12, 2, 13, 37, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, 1, "ObjectObserve Add", 20, "ObjectObserve VL", "CHAY_RUNG", 1, "0", new DateTime(2020, 12, 2, 2, 45, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, 7, "ObjectObserve Delete", 6, "ObjectObserve RB", "CHAY_RUNG", 4, "1", new DateTime(2020, 12, 2, 16, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 14, 6, "ObjectObserve Edit", 9, "ObjectObserve HM", "CHAY_RUNG", 3, "0", new DateTime(2020, 12, 2, 12, 46, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 19, 8, "ObjectObserve Activity Log", 3, "ObjectObserve VS", "CAY_TRONG", 2, "1", new DateTime(2020, 12, 2, 3, 16, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, 9, "ObjectObserve Add", 19, "ObjectObserve TP", "DE_DIEU", 3, "0", new DateTime(2020, 12, 1, 5, 12, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, 8, "ObjectObserve Activity Log", 16, "ObjectObserve DG", "CHAY_RUNG", 2, "1", new DateTime(2020, 12, 2, 17, 11, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 24, 1, "ObjectObserve Delete", 13, "ObjectObserve LR", "CAY_TRONG", 4, "0", new DateTime(2020, 12, 2, 7, 16, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 23, 4, "ObjectObserve Activity Log", 17, "ObjectObserve XW", "LUOI_DIEN", 2, "1", new DateTime(2020, 12, 1, 17, 40, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, 8, "ObjectObserve Delete", 9, "ObjectObserve PE", "DE_DIEU", 2, "0", new DateTime(2020, 12, 2, 2, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, 9, "ObjectObserve Edit", 8, "ObjectObserve GK", "DE_DIEU", 1, "1", new DateTime(2020, 12, 2, 10, 49, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, 6, "ObjectObserve Delete", 19, "ObjectObserve SG", "CAY_TRONG", 4, "0", new DateTime(2020, 12, 2, 4, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, 2, "ObjectObserve Delete", 11, "ObjectObserve QQ", "CHAY_RUNG", 1, "0", new DateTime(2020, 12, 1, 15, 8, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 38, 10, "Payload Delete", 10, 1, "Payload GS", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 12, 10, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 32, 3, "Payload Activity Log", 3, 4, "Payload SG", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 12, 47, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 33, 3, "Payload Delete", 9, 5, "Payload ME", "DE_DIEU", "1", new DateTime(2020, 12, 1, 15, 37, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 34, 3, "Payload Edit", 9, 1, "Payload YD", "DE_DIEU", "0", new DateTime(2020, 12, 1, 13, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, 1, "Payload Delete", 6, 2, "Payload CW", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 14, 17, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 36, 9, "Payload Delete", 6, 2, "Payload AS", "DE_DIEU", "0", new DateTime(2020, 12, 1, 11, 16, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 37, 3, "Payload Add", 4, 9, "Payload QG", "DE_DIEU", "1", new DateTime(2020, 12, 2, 16, 28, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 39, 3, "Payload Delete", 6, 6, "Payload EA", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 9, 7, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, 9, "Payload Add", 6, 10, "Payload UF", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 15, 11, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 41, 4, "Payload Activity Log", 6, 10, "Payload DR", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 5, 23, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 42, 10, "Payload Edit", 8, 8, "Payload VQ", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 9, 35, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 43, 9, "Payload Edit", 5, 7, "Payload RN", "DE_DIEU", "1", new DateTime(2020, 12, 2, 9, 44, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, 3, "Payload Delete", 10, 4, "Payload DK", "DE_DIEU", "0", new DateTime(2020, 12, 2, 7, 35, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 45, 7, "Payload Add", 9, 4, "Payload AI", "DE_DIEU", "1", new DateTime(2020, 12, 1, 17, 47, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, 8, "Payload Edit", 8, 9, "Payload XJ", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 5, 5, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 47, 4, "Payload Activity Log", 3, 5, "Payload PA", "DE_DIEU", "1", new DateTime(2020, 12, 2, 11, 47, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 48, 3, "Payload Add", 5, 5, "Payload QK", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 7, 23, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, 7, "Payload Edit", 6, 3, "Payload BX", "DE_DIEU", "0", new DateTime(2020, 12, 1, 9, 42, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, 2, "Payload Activity Log", 6, 4, "Payload BO", "DE_DIEU", "0", new DateTime(2020, 12, 2, 7, 19, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 49, 7, "Payload Delete", 3, 8, "Payload TO", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 13, 8, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, 2, "Payload Add", 6, 3, "Payload LV", "DE_DIEU", "0", new DateTime(2020, 12, 1, 16, 4, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, 8, "Payload Edit", 1, 3, "Payload DZ", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 17, 13, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, 5, "Payload Edit", 5, 10, "Payload WQ", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 17, 46, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, 9, "Payload Add", 1, 1, "Payload RB", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 10, 45, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, 2, "Payload Edit", 3, 9, "Payload FC", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 2, 2, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, 3, "Payload Add", 8, 3, "Payload SX", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 17, 6, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, 7, "Payload Delete", 5, 5, "Payload DJ", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 3, 44, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, 6, "Payload Activity Log", 6, 5, "Payload XL", "DE_DIEU", "0", new DateTime(2020, 12, 2, 3, 2, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, 10, "Payload Add", 3, 7, "Payload HC", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 16, 19, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 18, 10, "Payload Edit", 5, 9, "Payload YU", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 16, 2, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 29, 10, "Payload Activity Log", 8, 10, "Payload BY", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 10, 6, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 20, 5, "Payload Activity Log", 5, 1, "Payload ZD", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 16, 43, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 21, 7, "Payload Delete", 1, 8, "Payload LO", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 1, 4, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, 9, "Payload Activity Log", 9, 10, "Payload YT", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 8, 31, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, 3, "Payload Activity Log", 8, 9, "Payload TE", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 15, 40, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 24, 10, "Payload Add", 4, 3, "Payload LV", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 10, 6, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, 9, "Payload Edit", 2, 10, "Payload GP", "DE_DIEU", "1", new DateTime(2020, 12, 2, 10, 26, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, 10, "Payload Delete", 9, 7, "Payload WJ", "DE_DIEU", "0", new DateTime(2020, 12, 1, 10, 3, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, 2, "Payload Edit", 7, 1, "Payload HQ", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 12, 43, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 19, 5, "Payload Add", 5, 1, "Payload CV", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 3, 6, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, 8, "ResolveProblem Add", 11, "ResolveProblem QE", "CHAY_RUNG", 2, "1", new DateTime(2020, 12, 2, 14, 39, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, 9, "ResolveProblem Add", 1, "ResolveProblem WW", "CHAY_RUNG", 4, "0", new DateTime(2020, 12, 2, 15, 39, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, 10, "ResolveProblem Delete", 4, "ResolveProblem WP", "CHAY_RUNG", 1, "0", new DateTime(2020, 12, 2, 14, 21, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 34, 2, "ResolveProblem Edit", 2, "ResolveProblem JE", "CAY_TRONG", 2, "0", new DateTime(2020, 12, 2, 17, 26, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 33, 3, "ResolveProblem Delete", 10, "ResolveProblem VZ", "LUOI_DIEN", 2, "1", new DateTime(2020, 12, 2, 6, 49, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 38, 6, "ResolveProblem Delete", 8, "ResolveProblem SS", "DE_DIEU", 4, "0", new DateTime(2020, 12, 2, 8, 7, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 35, 1, "ResolveProblem Edit", 8, "ResolveProblem XP", "CHAY_RUNG", 1, "1", new DateTime(2020, 12, 2, 8, 24, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 39, 3, "ResolveProblem Delete", 6, "ResolveProblem HH", "CAY_TRONG", 1, "1", new DateTime(2020, 12, 2, 15, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 44, 6, "ResolveProblem Activity Log", 13, "ResolveProblem YO", "CAY_TRONG", 3, "0", new DateTime(2020, 12, 1, 6, 36, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 41, 10, "ResolveProblem Activity Log", 1, "ResolveProblem TD", "LUOI_DIEN", 3, "1", new DateTime(2020, 12, 2, 6, 31, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 42, 8, "ResolveProblem Activity Log", 12, "ResolveProblem ND", "DE_DIEU", 3, "0", new DateTime(2020, 12, 2, 9, 24, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 43, 9, "ResolveProblem Edit", 9, "ResolveProblem IO", "DE_DIEU", 2, "1", new DateTime(2020, 12, 1, 16, 1, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 45, 6, "ResolveProblem Edit", 5, "ResolveProblem JQ", "CAY_TRONG", 1, "1", new DateTime(2020, 12, 2, 1, 5, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 46, 10, "ResolveProblem Activity Log", 3, "ResolveProblem SI", "CAY_TRONG", 4, "0", new DateTime(2020, 12, 1, 15, 34, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 47, 8, "ResolveProblem Add", 14, "ResolveProblem LU", "LUOI_DIEN", 3, "1", new DateTime(2020, 12, 2, 7, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, 1, "ResolveProblem Activity Log", 7, "ResolveProblem CL", "CHAY_RUNG", 2, "0", new DateTime(2020, 12, 2, 11, 42, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 31, 2, "ResolveProblem Delete", 11, "ResolveProblem BL", "CHAY_RUNG", 2, "1", new DateTime(2020, 12, 1, 14, 4, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, 10, "ResolveProblem Activity Log", 6, "ResolveProblem GD", "LUOI_DIEN", 1, "0", new DateTime(2020, 12, 2, 8, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 30, 9, "ResolveProblem Delete", 11, "ResolveProblem BB", "LUOI_DIEN", 3, "0", new DateTime(2020, 12, 1, 11, 16, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 49, 4, "ResolveProblem Activity Log", 1, "ResolveProblem BJ", "LUOI_DIEN", 3, "1", new DateTime(2020, 12, 2, 8, 19, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 28, 10, "ResolveProblem Delete", 3, "ResolveProblem FW", "CAY_TRONG", 3, "0", new DateTime(2020, 12, 2, 3, 18, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, 3, "ResolveProblem Add", 8, "ResolveProblem RX", "CAY_TRONG", 3, "0", new DateTime(2020, 12, 1, 3, 5, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, 8, "ResolveProblem Delete", 14, "ResolveProblem AA", "CAY_TRONG", 2, "1", new DateTime(2020, 12, 1, 6, 31, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, 3, "ResolveProblem Activity Log", 12, "ResolveProblem PN", "CHAY_RUNG", 1, "0", new DateTime(2020, 12, 2, 3, 48, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 13, 9, "ResolveProblem Edit", 11, "ResolveProblem DW", "LUOI_DIEN", 3, "1", new DateTime(2020, 12, 1, 5, 44, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, 10, "ResolveProblem Delete", 1, "ResolveProblem DE", "CAY_TRONG", 1, "0", new DateTime(2020, 12, 1, 11, 44, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 15, 3, "ResolveProblem Edit", 6, "ResolveProblem UG", "LUOI_DIEN", 3, "1", new DateTime(2020, 12, 2, 10, 15, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 16, 7, "ResolveProblem Delete", 9, "ResolveProblem JQ", "CAY_TRONG", 3, "0", new DateTime(2020, 12, 2, 14, 35, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 17, 1, "ResolveProblem Activity Log", 11, "ResolveProblem VG", "CAY_TRONG", 1, "1", new DateTime(2020, 12, 1, 14, 46, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, 2, "ResolveProblem Edit", 2, "ResolveProblem HS", "DE_DIEU", 4, "0", new DateTime(2020, 12, 1, 11, 13, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 29, 4, "ResolveProblem Edit", 3, "ResolveProblem RT", "CAY_TRONG", 4, "1", new DateTime(2020, 12, 1, 14, 34, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, 6, "ResolveProblem Edit", 5, "ResolveProblem SL", "LUOI_DIEN", 2, "0", new DateTime(2020, 12, 1, 4, 12, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 21, 4, "ResolveProblem Edit", 14, "ResolveProblem NV", "CHAY_RUNG", 2, "1", new DateTime(2020, 12, 2, 4, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 22, 8, "ResolveProblem Activity Log", 5, "ResolveProblem US", "DE_DIEU", 1, "0", new DateTime(2020, 12, 2, 10, 28, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, 6, "ResolveProblem Add", 2, "ResolveProblem EA", "CHAY_RUNG", 4, "1", new DateTime(2020, 12, 2, 5, 43, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, 4, "ResolveProblem Activity Log", 1, "ResolveProblem FA", "LUOI_DIEN", 1, "0", new DateTime(2020, 12, 2, 6, 6, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, 7, "ResolveProblem Activity Log", 1, "ResolveProblem KM", "DE_DIEU", 2, "1", new DateTime(2020, 12, 2, 15, 25, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, 4, "ResolveProblem Delete", 8, "ResolveProblem JT", "CHAY_RUNG", 2, "0", new DateTime(2020, 12, 1, 1, 46, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, 9, "ResolveProblem Activity Log", 5, "ResolveProblem ZE", "CHAY_RUNG", 4, "1", new DateTime(2020, 12, 2, 1, 31, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, 9, "ResolveProblem Activity Log", 12, "ResolveProblem NC", "CHAY_RUNG", 1, "1", new DateTime(2020, 12, 2, 14, 37, 0, 0, DateTimeKind.Unspecified), 20 }
                });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, 1, "Statical Edit", 54, "Statical MR", "LUOI_DIEN", 4, "1", new DateTime(2020, 12, 1, 7, 27, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 36, 7, "Statical Activity Log", 52, "Statical LJ", "CAY_TRONG", 3, "0", new DateTime(2020, 12, 1, 12, 46, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 35, 1, "Statical Activity Log", 50, "Statical AA", "DE_DIEU", 4, "1", new DateTime(2020, 12, 2, 13, 34, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 31, 2, "Statical Activity Log", 42, "Statical BI", "CHAY_RUNG", 3, "1", new DateTime(2020, 12, 2, 9, 43, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 33, 2, "Statical Add", 46, "Statical EY", "LUOI_DIEN", 4, "1", new DateTime(2020, 12, 1, 17, 8, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, 6, "Statical Edit", 44, "Statical PY", "CAY_TRONG", 3, "0", new DateTime(2020, 12, 1, 5, 6, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 38, 7, "Statical Delete", 56, "Statical EX", "CHAY_RUNG", 4, "0", new DateTime(2020, 12, 1, 14, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 34, 4, "Statical Delete", 48, "Statical HD", "CAY_TRONG", 3, "0", new DateTime(2020, 12, 2, 11, 45, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 39, 9, "Statical Delete", 58, "Statical SR", "LUOI_DIEN", 4, "1", new DateTime(2020, 12, 1, 13, 9, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 43, 9, "Statical Activity Log", 66, "Statical UC", "CHAY_RUNG", 3, "1", new DateTime(2020, 12, 2, 12, 2, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 41, 9, "Statical Edit", 62, "Statical SW", "DE_DIEU", 4, "1", new DateTime(2020, 12, 1, 8, 11, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 42, 5, "Statical Activity Log", 64, "Statical KA", "CAY_TRONG", 3, "0", new DateTime(2020, 12, 2, 2, 7, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 44, 2, "Statical Add", 68, "Statical ZH", "LUOI_DIEN", 4, "0", new DateTime(2020, 12, 1, 5, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, 4, "Statical Delete", 70, "Statical ML", "LUOI_DIEN", 2, "1", new DateTime(2020, 12, 1, 12, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 46, 5, "Statical Activity Log", 72, "Statical FP", "LUOI_DIEN", 1, "0", new DateTime(2020, 12, 1, 9, 45, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 47, 8, "Statical Add", 74, "Statical WU", "CHAY_RUNG", 3, "1", new DateTime(2020, 12, 1, 7, 44, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, 8, "Statical Edit", 76, "Statical SF", "CHAY_RUNG", 4, "0", new DateTime(2020, 12, 1, 1, 9, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, 1, "Statical Delete", 40, "Statical SG", "DE_DIEU", 3, "0", new DateTime(2020, 12, 2, 10, 1, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, 9, "Statical Delete", 60, "Statical LY", "CHAY_RUNG", 1, "0", new DateTime(2020, 12, 2, 2, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 49, 7, "Statical Edit", 78, "Statical KX", "DE_DIEU", 3, "1", new DateTime(2020, 12, 1, 11, 34, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 29, 5, "Statical Activity Log", 38, "Statical GX", "DE_DIEU", 3, "1", new DateTime(2020, 12, 2, 11, 1, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 27, 5, "Statical Activity Log", 34, "Statical SC", "DE_DIEU", 2, "1", new DateTime(2020, 12, 1, 1, 19, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 28, 3, "Statical Add", 36, "Statical QD", "CAY_TRONG", 1, "0", new DateTime(2020, 12, 1, 11, 40, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, 8, "Statical Activity Log", 0, "Statical EW", "DE_DIEU", 3, "0", new DateTime(2020, 12, 1, 3, 45, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 11, 7, "Statical Add", 2, "Statical YW", "CAY_TRONG", 3, "1", new DateTime(2020, 12, 1, 4, 27, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, 9, "Statical Delete", 4, "Statical JJ", "CAY_TRONG", 4, "0", new DateTime(2020, 12, 1, 15, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, 3, "Statical Add", 6, "Statical YW", "DE_DIEU", 2, "1", new DateTime(2020, 12, 2, 5, 48, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, 6, "Statical Delete", 10, "Statical DX", "LUOI_DIEN", 2, "1", new DateTime(2020, 12, 2, 1, 38, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, 1, "Statical Delete", 12, "Statical SZ", "DE_DIEU", 3, "0", new DateTime(2020, 12, 2, 12, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 17, 10, "Statical Add", 14, "Statical BB", "CHAY_RUNG", 4, "1", new DateTime(2020, 12, 2, 6, 9, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, 3, "Statical Delete", 8, "Statical GL", "CHAY_RUNG", 3, "0", new DateTime(2020, 12, 1, 16, 38, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, 5, "Statical Edit", 18, "Statical DQ", "CAY_TRONG", 2, "1", new DateTime(2020, 12, 2, 15, 27, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 18, 2, "Statical Activity Log", 16, "Statical BO", "CAY_TRONG", 2, "0", new DateTime(2020, 12, 2, 4, 1, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, 5, "Statical Delete", 30, "Statical RZ", "CAY_TRONG", 1, "1", new DateTime(2020, 12, 2, 5, 26, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, 7, "Statical Add", 28, "Statical BC", "CAY_TRONG", 4, "0", new DateTime(2020, 12, 2, 11, 40, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 23, 4, "Statical Add", 26, "Statical PD", "DE_DIEU", 2, "1", new DateTime(2020, 12, 2, 14, 27, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 26, 3, "Statical Add", 32, "Statical LG", "CAY_TRONG", 2, "0", new DateTime(2020, 12, 1, 6, 17, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, 5, "Statical Activity Log", 22, "Statical HK", "CHAY_RUNG", 1, "1", new DateTime(2020, 12, 1, 14, 33, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 20, 4, "Statical Add", 20, "Statical PJ", "DE_DIEU", 3, "0", new DateTime(2020, 12, 1, 7, 33, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, 4, "Statical Delete", 24, "Statical EM", "CHAY_RUNG", 4, "0", new DateTime(2020, 12, 2, 15, 6, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 38, 5, "UavConnect Activity Log", 6, 7, "UavConnect YU", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 4, 28, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 32, 10, "UavConnect Activity Log", 6, 8, "UavConnect SU", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 13, 47, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 33, 5, "UavConnect Delete", 3, 11, "UavConnect HT", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 9, 42, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 34, 4, "UavConnect Add", 4, 6, "UavConnect QT", "DE_DIEU", "0", new DateTime(2020, 12, 1, 10, 44, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, 10, "UavConnect Edit", 1, 13, "UavConnect CK", "DE_DIEU", "1", new DateTime(2020, 12, 1, 14, 32, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 36, 2, "UavConnect Delete", 10, 7, "UavConnect CY", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 9, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 37, 7, "UavConnect Add", 5, 10, "UavConnect CM", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 9, 14, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, 6, "UavConnect Add", 3, 5, "UavConnect CL", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 2, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 31, 10, "UavConnect Activity Log", 9, 4, "UavConnect JO", "DE_DIEU", "1", new DateTime(2020, 12, 1, 9, 29, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 41, 1, "UavConnect Activity Log", 4, 1, "UavConnect GJ", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 17, 46, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 42, 2, "UavConnect Add", 4, 1, "UavConnect AO", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 13, 19, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 43, 9, "UavConnect Edit", 4, 6, "UavConnect YB", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 3, 22, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, 7, "UavConnect Activity Log", 8, 12, "UavConnect VH", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 3, 18, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 45, 1, "UavConnect Add", 7, 3, "UavConnect QR", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 11, 11, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, 8, "UavConnect Edit", 4, 1, "UavConnect LN", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 9, 14, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 47, 9, "UavConnect Delete", 8, 12, "UavConnect OG", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 5, 1, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 48, 5, "UavConnect Edit", 8, 10, "UavConnect RK", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 1, 37, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 40, 7, "UavConnect Delete", 6, 6, "UavConnect ZH", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 9, 34, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 30, 3, "UavConnect Edit", 7, 6, "UavConnect NO", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 6, 12, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 39, 3, "UavConnect Add", 9, 14, "UavConnect TF", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 10, 40, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 28, 6, "UavConnect Add", 7, 13, "UavConnect QW", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 7, 48, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, 8, "UavConnect Edit", 4, 11, "UavConnect EO", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 14, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, 5, "UavConnect Delete", 7, 8, "UavConnect KO", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 3, 24, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, 4, "UavConnect Activity Log", 9, 3, "UavConnect PQ", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 11, 4, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 13, 7, "UavConnect Add", 9, 9, "UavConnect QK", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 5, 9, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, 6, "UavConnect Delete", 7, 9, "UavConnect QO", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 3, 7, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 15, 7, "UavConnect Delete", 9, 5, "UavConnect IR", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 9, 16, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, 9, "UavConnect Edit", 1, 5, "UavConnect QI", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 14, 15, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, 8, "UavConnect Add", 10, 12, "UavConnect HO", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 4, 11, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 18, 4, "UavConnect Activity Log", 5, 1, "UavConnect SV", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 5, 45, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 29, 3, "UavConnect Add", 8, 10, "UavConnect IS", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 1, 22, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, 5, "UavConnect Edit", 3, 6, "UavConnect CL", "DE_DIEU", "0", new DateTime(2020, 12, 2, 8, 30, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 21, 6, "UavConnect Activity Log", 10, 6, "UavConnect VD", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 12, 31, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 22, 4, "UavConnect Add", 7, 9, "UavConnect PN", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 14, 48, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 23, 5, "UavConnect Activity Log", 2, 10, "UavConnect WT", "DE_DIEU", "1", new DateTime(2020, 12, 1, 11, 7, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 24, 9, "UavConnect Activity Log", 8, 10, "UavConnect XC", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 13, 46, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, 2, "UavConnect Activity Log", 1, 10, "UavConnect TU", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 9, 9, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, 5, "UavConnect Add", 9, 10, "UavConnect PT", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 3, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, 2, "UavConnect Activity Log", 5, 10, "UavConnect HL", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 13, 27, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, 1, "UavConnect Delete", 8, 9, "UavConnect BQ", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 9, 14, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 38, 2, "User Add", 7, 0, "Meta data example 28", "CAY_TRONG", 4, 3, new DateTime(2020, 12, 1, 7, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 37, 8, "User Add", 5, 0, "Meta data example 27", "DE_DIEU", 4, 5, new DateTime(2020, 12, 1, 12, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, 6, "User Edit", 1, 0, "Meta data example 26", "LUOI_DIEN", 2, 1, new DateTime(2020, 12, 1, 5, 41, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 32, 4, "User Edit", 10, 0, "Meta data example 22", "CAY_TRONG", 3, 5, new DateTime(2020, 12, 1, 9, 49, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, 7, "User Activity Log", 9, 0, "Meta data example 24", "LUOI_DIEN", 1, 13, new DateTime(2020, 12, 2, 8, 43, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 33, 8, "User Delete", 8, 0, "Meta data example 23", "CHAY_RUNG", 3, 12, new DateTime(2020, 12, 2, 7, 34, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 39, 10, "User Add", 6, 0, "Meta data example 29", "DE_DIEU", 4, 1, new DateTime(2020, 12, 2, 16, 31, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, 3, "User Activity Log", 9, 0, "Meta data example 25", "LUOI_DIEN", 4, 4, new DateTime(2020, 12, 2, 12, 11, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 40, 7, "User Edit", 10, 0, "Meta data example 30", "DE_DIEU", 4, 13, new DateTime(2020, 12, 2, 2, 41, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, 2, "User Delete", 8, 0, "Meta data example 34", "CHAY_RUNG", 4, 4, new DateTime(2020, 12, 1, 10, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 42, 6, "User Add", 7, 0, "Meta data example 32", "CHAY_RUNG", 3, 4, new DateTime(2020, 12, 1, 17, 33, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 43, 1, "User Delete", 2, 0, "Meta data example 33", "CHAY_RUNG", 2, 1, new DateTime(2020, 12, 1, 10, 47, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 45, 3, "User Delete", 4, 0, "Meta data example 35", "CHAY_RUNG", 1, 9, new DateTime(2020, 12, 1, 2, 1, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 46, 10, "User Activity Log", 6, 0, "Meta data example 36", "LUOI_DIEN", 1, 13, new DateTime(2020, 12, 2, 13, 3, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 47, 5, "User Activity Log", 2, 0, "Meta data example 37", "CHAY_RUNG", 1, 12, new DateTime(2020, 12, 1, 10, 31, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 48, 9, "User Edit", 8, 0, "Meta data example 38", "CAY_TRONG", 1, 6, new DateTime(2020, 12, 2, 12, 7, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 49, 7, "User Edit", 9, 0, "Meta data example 39", "CAY_TRONG", 4, 4, new DateTime(2020, 12, 1, 1, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, 1, "User Activity Log", 3, 0, "Meta data example 21", "LUOI_DIEN", 4, 7, new DateTime(2020, 12, 1, 13, 21, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 41, 4, "User Edit", 4, 0, "Meta data example 31", "LUOI_DIEN", 2, 10, new DateTime(2020, 12, 1, 17, 34, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, 6, "User Delete", 3, 0, "Meta data example 20", "CAY_TRONG", 2, 12, new DateTime(2020, 12, 2, 14, 37, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, 8, "User Edit", 10, 0, "Meta data example 19", "DE_DIEU", 4, 1, new DateTime(2020, 12, 2, 15, 41, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 28, 6, "User Add", 3, 0, "Meta data example 18", "LUOI_DIEN", 1, 14, new DateTime(2020, 12, 2, 13, 34, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, 5, "User Activity Log", 5, 0, "Meta data example 0", "CAY_TRONG", 4, 8, new DateTime(2020, 12, 2, 5, 18, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 11, 1, "User Activity Log", 7, 0, "Meta data example 1", "CAY_TRONG", 4, 1, new DateTime(2020, 12, 2, 2, 42, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 12, 6, "User Add", 3, 0, "Meta data example 2", "CHAY_RUNG", 4, 6, new DateTime(2020, 12, 2, 16, 22, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, 3, "User Activity Log", 3, 0, "Meta data example 3", "LUOI_DIEN", 2, 6, new DateTime(2020, 12, 2, 16, 18, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 14, 1, "User Activity Log", 8, 0, "Meta data example 4", "CHAY_RUNG", 4, 13, new DateTime(2020, 12, 1, 6, 49, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 16, 1, "User Add", 3, 0, "Meta data example 6", "CAY_TRONG", 3, 7, new DateTime(2020, 12, 1, 6, 39, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, 3, "User Edit", 8, 0, "Meta data example 7", "DE_DIEU", 2, 8, new DateTime(2020, 12, 2, 11, 36, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 18, 5, "User Edit", 8, 0, "Meta data example 8", "CHAY_RUNG", 1, 13, new DateTime(2020, 12, 2, 5, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 15, 5, "User Add", 5, 0, "Meta data example 5", "LUOI_DIEN", 4, 5, new DateTime(2020, 12, 1, 7, 34, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, 10, "User Edit", 10, 0, "Meta data example 10", "CHAY_RUNG", 3, 13, new DateTime(2020, 12, 1, 9, 18, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 19, 10, "User Delete", 4, 0, "Meta data example 9", "DE_DIEU", 3, 4, new DateTime(2020, 12, 2, 3, 9, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, 10, "User Add", 3, 0, "Meta data example 16", "LUOI_DIEN", 2, 7, new DateTime(2020, 12, 1, 14, 47, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, 9, "User Delete", 1, 0, "Meta data example 15", "DE_DIEU", 3, 9, new DateTime(2020, 12, 2, 8, 49, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, 5, "User Delete", 8, 0, "Meta data example 14", "DE_DIEU", 2, 9, new DateTime(2020, 12, 1, 7, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, 9, "User Add", 1, 0, "Meta data example 17", "CAY_TRONG", 2, 12, new DateTime(2020, 12, 2, 8, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, 5, "User Delete", 10, 0, "Meta data example 12", "CAY_TRONG", 1, 6, new DateTime(2020, 12, 2, 12, 4, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, 3, "User Activity Log", 2, 0, "Meta data example 11", "CAY_TRONG", 4, 6, new DateTime(2020, 12, 2, 6, 15, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, 8, "User Edit", 10, 0, "Meta data example 13", "CHAY_RUNG", 2, 2, new DateTime(2020, 12, 2, 9, 43, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 39, 8, "Video Edit", 6, 37, "Video NR", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 13, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 32, 4, "Video Activity Log", 10, 39, "Video CA", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 1, 36, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 33, 2, "Video Add", 10, 5, "Video HP", "DE_DIEU", "1", new DateTime(2020, 12, 1, 16, 8, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 34, 3, "Video Activity Log", 9, 29, "Video PQ", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 16, 45, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 35, 9, "Video Activity Log", 9, 34, "Video IK", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 16, 17, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, 2, "Video Add", 9, 8, "Video ZQ", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 10, 32, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 37, 10, "Video Delete", 8, 12, "Video DG", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 14, 38, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 38, 1, "Video Edit", 5, 15, "Video ZQ", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 15, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 49, 1, "Video Delete", 6, 28, "Video JN", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 10, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 48, 10, "Video Activity Log", 2, 18, "Video WM", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 6, 46, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 41, 9, "Video Edit", 1, 40, "Video ZJ", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 17, 32, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 42, 6, "Video Activity Log", 7, 9, "Video TQ", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 10, 49, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 43, 5, "Video Activity Log", 8, 24, "Video TK", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 13, 4, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 44, 4, "Video Add", 10, 20, "Video EE", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 1, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, 6, "Video Delete", 4, 25, "Video OG", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 16, 9, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 46, 5, "Video Delete", 3, 15, "Video QE", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 17, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 47, 5, "Video Edit", 5, 22, "Video SZ", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 12, 13, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, 1, "Video Add", 5, 22, "Video NM", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 5, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, 4, "Video Delete", 9, 3, "Video IT", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 1, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 30, 7, "Video Add", 8, 34, "Video PS", "DE_DIEU", "0", new DateTime(2020, 12, 2, 13, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 19, 5, "Video Edit", 4, 14, "Video RT", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 4, 9, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 28, 5, "Video Delete", 2, 27, "Video NY", "DE_DIEU", "0", new DateTime(2020, 12, 2, 5, 26, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, 10, "Video Activity Log", 3, 37, "Video YK", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 12, 28, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 10, 6, "Video Edit", 1, 31, "Video NJ", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 15, 18, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, 9, "Video Edit", 7, 35, "Video NP", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 3, 21, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, 6, "Video Add", 8, 30, "Video KU", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 13, 17, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, 7, "Video Activity Log", 3, 29, "Video YP", "DE_DIEU", "1", new DateTime(2020, 12, 2, 4, 5, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 15, 7, "Video Delete", 10, 16, "Video HU", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 7, 23, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, 10, "Video Activity Log", 8, 26, "Video PJ", "DE_DIEU", "0", new DateTime(2020, 12, 2, 2, 46, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, 7, "Video Add", 8, 16, "Video PN", "DE_DIEU", "1", new DateTime(2020, 12, 1, 13, 41, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, 9, "Video Add", 2, 9, "Video FQ", "DE_DIEU", "0", new DateTime(2020, 12, 2, 2, 29, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, 8, "Video Delete", 8, 21, "Video MQ", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 12, 38, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, 7, "Video Activity Log", 2, 18, "Video EK", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 12, 22, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 22, 3, "Video Add", 6, 37, "Video RY", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 7, 13, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, 2, "Video Delete", 8, 20, "Video VZ", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 17, 44, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 23, 10, "Video Add", 4, 20, "Video ZO", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 14, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, 5, "Video Activity Log", 3, 30, "Video EJ", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 7, 5, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, 2, "Video Edit", 9, 30, "Video MB", "DE_DIEU", "1", new DateTime(2020, 12, 1, 12, 25, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, 9, "Video Delete", 5, 9, "Video LB", "DE_DIEU", "0", new DateTime(2020, 12, 2, 10, 25, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, 7, "Video Edit", 2, 29, "Video DK", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 2, 19, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 36, 4, "Warning Add", 5, "Warning BB", "CHAY_RUNG", 3, "0", new DateTime(2020, 12, 1, 1, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, 2, "Warning Add", 4, "Warning PO", "LUOI_DIEN", 2, "1", new DateTime(2020, 12, 2, 16, 45, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 31, 5, "Warning Edit", 5, "Warning PQ", "CHAY_RUNG", 3, "1", new DateTime(2020, 12, 1, 3, 25, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 33, 1, "Warning Add", 1, "Warning BV", "CAY_TRONG", 2, "1", new DateTime(2020, 12, 1, 14, 8, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, 4, "Warning Edit", 7, "Warning XW", "LUOI_DIEN", 3, "0", new DateTime(2020, 12, 2, 13, 34, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 37, 9, "Warning Activity Log", 4, "Warning AU", "LUOI_DIEN", 2, "1", new DateTime(2020, 12, 1, 4, 10, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 34, 9, "Warning Delete", 5, "Warning WT", "LUOI_DIEN", 2, "0", new DateTime(2020, 12, 2, 3, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 38, 5, "Warning Activity Log", 6, "Warning XD", "LUOI_DIEN", 1, "0", new DateTime(2020, 12, 2, 3, 15, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 47, 10, "Warning Delete", 7, "Warning ED", "CHAY_RUNG", 4, "1", new DateTime(2020, 12, 2, 6, 24, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, 4, "Warning Edit", 5, "Warning UO", "CAY_TRONG", 4, "0", new DateTime(2020, 12, 2, 5, 26, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 41, 5, "Warning Edit", 3, "Warning KM", "CAY_TRONG", 3, "1", new DateTime(2020, 12, 1, 13, 8, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 42, 6, "Warning Activity Log", 4, "Warning HD", "CHAY_RUNG", 1, "0", new DateTime(2020, 12, 1, 15, 32, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 43, 1, "Warning Edit", 6, "Warning LF", "CAY_TRONG", 4, "1", new DateTime(2020, 12, 2, 4, 47, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, 9, "Warning Activity Log", 5, "Warning BF", "CHAY_RUNG", 1, "0", new DateTime(2020, 12, 1, 13, 42, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 45, 3, "Warning Delete", 1, "Warning LI", "CHAY_RUNG", 1, "1", new DateTime(2020, 12, 1, 3, 38, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 46, 6, "Warning Edit", 6, "Warning EI", "LUOI_DIEN", 1, "0", new DateTime(2020, 12, 1, 14, 37, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, 10, "Warning Add", 3, "Warning VU", "CHAY_RUNG", 4, "0", new DateTime(2020, 12, 1, 15, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 39, 8, "Warning Edit", 6, "Warning XK", "LUOI_DIEN", 4, "1", new DateTime(2020, 12, 1, 13, 8, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 29, 2, "Warning Delete", 2, "Warning FQ", "CAY_TRONG", 3, "1", new DateTime(2020, 12, 2, 10, 26, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 20, 4, "Warning Edit", 9, "Warning IA", "CAY_TRONG", 3, "0", new DateTime(2020, 12, 2, 4, 45, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, 1, "Warning Edit", 4, "Warning EI", "CAY_TRONG", 4, "1", new DateTime(2020, 12, 2, 16, 43, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 48, 3, "Warning Edit", 5, "Warning FV", "DE_DIEU", 1, "0", new DateTime(2020, 12, 1, 2, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, 1, "Warning Delete", 3, "Warning GX", "CAY_TRONG", 2, "0", new DateTime(2020, 12, 2, 3, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, 2, "Warning Delete", 5, "Warning VS", "DE_DIEU", 1, "1", new DateTime(2020, 12, 2, 9, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, 1, "Warning Activity Log", 4, "Warning VO", "CHAY_RUNG", 2, "0", new DateTime(2020, 12, 2, 10, 11, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 13, 7, "Warning Add", 5, "Warning ZP", "CHAY_RUNG", 3, "1", new DateTime(2020, 12, 1, 13, 37, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, 5, "Warning Add", 6, "Warning EQ", "LUOI_DIEN", 1, "0", new DateTime(2020, 12, 2, 9, 21, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, 4, "Warning Delete", 1, "Warning PM", "CAY_TRONG", 3, "1", new DateTime(2020, 12, 2, 4, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, 9, "Warning Delete", 8, "Warning BR", "LUOI_DIEN", 2, "0", new DateTime(2020, 12, 1, 14, 37, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 17, 8, "Warning Delete", 7, "Warning HM", "DE_DIEU", 3, "1", new DateTime(2020, 12, 2, 12, 29, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, 2, "Warning Add", 1, "Warning EP", "CHAY_RUNG", 4, "0", new DateTime(2020, 12, 1, 17, 7, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 19, 6, "Warning Add", 6, "Warning BA", "CAY_TRONG", 3, "1", new DateTime(2020, 12, 1, 15, 11, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, 8, "Warning Add", 4, "Warning IN", "CAY_TRONG", 4, "1", new DateTime(2020, 12, 1, 15, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, 8, "Warning Add", 9, "Warning TE", "CHAY_RUNG", 4, "0", new DateTime(2020, 12, 2, 2, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 23, 1, "Warning Edit", 10, "Warning HR", "LUOI_DIEN", 4, "1", new DateTime(2020, 12, 2, 17, 9, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, 2, "Warning Activity Log", 9, "Warning SG", "DE_DIEU", 4, "0", new DateTime(2020, 12, 2, 14, 19, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, 8, "Warning Add", 1, "Warning CR", "LUOI_DIEN", 4, "1", new DateTime(2020, 12, 1, 12, 47, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 26, 2, "Warning Add", 4, "Warning HD", "CHAY_RUNG", 1, "0", new DateTime(2020, 12, 2, 12, 19, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 28, 3, "Warning Add", 3, "Warning YZ", "LUOI_DIEN", 4, "0", new DateTime(2020, 12, 1, 12, 22, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, 1, "Warning Add", 7, "Warning RR", "DE_DIEU", 2, "1", new DateTime(2020, 12, 2, 4, 48, 0, 0, DateTimeKind.Unspecified), 2 }
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
